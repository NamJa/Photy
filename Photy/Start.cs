using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using System.Media;
using WMPLib;

namespace Photy
{

    public partial class Start : Form
    {
        int curImgIndex = 0;
        int pageNum = 0;
        int isAnim = 0;
        string[] dirName = new string[50];
        public static List<string> movePath = new List<string>();
        PictureBox pb;

        WindowsMediaPlayer WMP;
        IWMPMedia Media;
        IWMPPlaylist PlayList;

        public Start()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TransparencyKey = BackColor;
            for (int i = 0; i < 48; i++)
            {
                dirName[i] = "분류" + (i + 1);
            }
            dirName[48] = "기타";

            WMP = new WindowsMediaPlayer();
            Media = WMP.newMedia("bbyong.mp3");
            PlayList = WMP.newPlaylist("MusicPlayer", "");

            WMP.currentPlaylist = PlayList;
            PlayList.appendItem(Media);
        }

        private void Start_Load(object sender, EventArgs e)
        {
            Load_Next_Image(); Load_Dir_Name();
        }

        private void Load_Next_Image()
        {
            try
            {
                var fs = new FileStream(Main.imageList[curImgIndex], FileMode.Open);
                var loadedImage = new Bitmap(fs);
                pictureBox.BackgroundImage = (Bitmap)loadedImage.Clone();
                fs.Close();
            }
            catch
            {
                /* 예외 처리 */
            }
        }

        private void Load_Dir_Name()
        {
            upDir.Text = dirName[pageNum * 4];
            rightDir.Text = dirName[pageNum * 4 + 1];
            downDir.Text = dirName[pageNum * 4 + 2];
            leftDir.Text = dirName[pageNum * 4 + 3];
        }

        private void goToMain()
        {
            Main.main.Visible = true;
            Main.main.listReset();
            movePath.Clear();
            Process.Start("explorer.exe", Main.dirDialog.SelectedPath);
            this.Close();
        }

        private void dirNameChange(int index)
        {
            string promptValue = Prompt.ShowDialog(dirName[index], "폴더명 변경");
            if (promptValue != dirName[index])
            {
                if (Directory.Exists(Main.dirDialog.SelectedPath + "\\" + dirName[index]))
                {
                    Directory.Move(Main.dirDialog.SelectedPath + "\\" + dirName[index], Main.dirDialog.SelectedPath + "\\" + promptValue);
                }
                movePath = movePath.Select(x => x.Replace(dirName[index], promptValue)).ToList();
                dirName[index] = promptValue;
                Load_Dir_Name();
            }
        }

        private void dirClick(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "upDir":
                    dirNameChange(pageNum * 4); break;
                case "rightDir":
                    dirNameChange(pageNum * 4 + 1); break;
                case "downDir":
                    dirNameChange(pageNum * 4 + 2); break;
                case "leftDir":
                    dirNameChange(pageNum * 4 + 3); break;
            }
        }

        private void PicturBoxAnimation_Remove()
        {
            this.Invoke((Action)delegate ()
            {
                Controls.Remove(pb);
            });
        }

        private void Start_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            WMP.controls.play();
            Control destination = null;
            int dirIndex = 0;
            e.IsInputKey = true;

            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.Up:
                    dirIndex = pageNum * 4; destination = upDir; break;
                case Keys.D:
                case Keys.Right:
                    dirIndex = pageNum * 4 + 1; destination = rightDir; break;
                case Keys.S:
                case Keys.Down:
                    dirIndex = pageNum * 4 + 2; destination = downDir; break;
                case Keys.A:
                case Keys.Left:
                    dirIndex = pageNum * 4 + 3; destination = leftDir; break;
                case Keys.Space:
                    dirIndex = 48; destination = spaceDestination; break;
                case Keys.Escape:
                    goToMain(); break;
            }
            if (e.KeyCode == Keys.T) //T누르면 꺼짐
                isAnim++;
            
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.D || e.KeyCode == Keys.S || e.KeyCode == Keys.A || e.KeyCode == Keys.Up || e.KeyCode == Keys.Right || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Space)
            {
                if (!Directory.Exists(Main.dirDialog.SelectedPath + "\\" + dirName[dirIndex]))
                {
                    Directory.CreateDirectory(Main.dirDialog.SelectedPath + "\\" + dirName[dirIndex]);
                }

                try
                {
                    var fs = new FileStream(Main.imageList[curImgIndex], FileMode.Open);
                    var loadedImage = new Bitmap(fs);
                    pb = new PictureBox { BackgroundImage = (Bitmap)loadedImage.Clone(), BackgroundImageLayout = ImageLayout.Zoom, BackColor = Color.Transparent, Width = pictureBox.Width, Height = pictureBox.Height, Left = pictureBox.Left, Top = pictureBox.Top };
                    fs.Close();
                    this.Controls.Add(pb);
                    pb.BringToFront();

                    FileInfo file = new FileInfo(Main.imageList[curImgIndex]);

                    string path = Main.dirDialog.SelectedPath + "\\" + dirName[dirIndex] + "\\" + file.Name;
                    movePath.Add(path);
                    if (File.Exists(file.FullName))
                    {
                        File.Move(file.FullName, path);
                    }
                    curImgIndex++;
                    if (curImgIndex >= Main.imageList.Count)
                    {
                        slideToDestination(destination, pb, 100, null);
                        goToMain();
                        return;
                    }
                    Load_Next_Image();
                    if (isAnim%2 == 0) // 기능 켜졌는지 확인
                        slideToDestination(destination, pb, 1, PicturBoxAnimation_Remove); 

                }
                catch
                {
                    /* 예외 처리 */
                }
            }
            else if (e.KeyCode >= Keys.F1 && e.KeyCode <= Keys.F12)
            {
                pageNum = e.KeyCode - Keys.F1;
                Load_Dir_Name();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                Process.Start("mspaint.exe", Main.imageList[curImgIndex]);
            }
            else if (e.Control && e.KeyCode == Keys.Z && curImgIndex != 0)
            {
                curImgIndex--;
                File.Move(movePath[curImgIndex], Main.imageList[curImgIndex]);
                movePath.RemoveAt(curImgIndex);
                Load_Next_Image();
            }
        }

        private void slideToDestination(Control destination, Control control, int delay, Action onFinish)
        {
            new Task(() =>
            {
                int xdestCenter = (destination.Right + destination.Left) / 2;
                int ydestCenter = (destination.Top + destination.Bottom) / 2;
                int xcontCenter = (control.Right + control.Left) / 2;
                int ycontCenter = (control.Top + control.Bottom) / 2;
                int speed = 1;
                int xShrink = control.Width / 40;
                int yShrink = control.Height / 40;

                while (control.Width > 0  || control.Height  > 0|| xcontCenter < xdestCenter - speed || xcontCenter > xdestCenter + speed || ycontCenter < ydestCenter - speed || ycontCenter > ydestCenter + speed)
                {
                    try
                    {
                        xcontCenter = (control.Right + control.Left) / 2;
                        ycontCenter = (control.Top + control.Bottom) / 2;

                        if (xcontCenter < xdestCenter - speed)
                        {
                            this.Invoke((Action)delegate ()
                            {
                                control.Left += speed * ((xShrink / speed) + 1);
                                control.Width -= xShrink;
                            });
                        }
                        else if (xcontCenter > xdestCenter + speed)
                        {
                            this.Invoke((Action)delegate ()
                            {
                                control.Left -= speed;
                                control.Width -= xShrink;
                            });
                        }
                        else if(control.Width > 0)
                        {
                            this.Invoke((Action)delegate ()
                            {
                                control.Width -= yShrink;
                            });
                        }
                        if (ycontCenter < ydestCenter - speed)
                        {
                            this.Invoke((Action)delegate ()
                            {
                                control.Top += speed * ((yShrink / speed) + 1);
                                control.Height -= yShrink;
                            });
                        }
                        else if(ycontCenter > ydestCenter + speed)
                        {
                            this.Invoke((Action)delegate ()
                            {
                                control.Top -= speed;
                                control.Height -= yShrink;
                            });
                        }
                        else if (control.Height > 0)
                        {
                            this.Invoke((Action)delegate ()
                            {
                                control.Height -= yShrink;
                            });
                        }
                        Thread.Sleep(delay);
                    }
                    catch
                    {
                        // form could be disposed
                        break;
                    }
                }

                if (onFinish != null) onFinish();

            }).Start();
        }
    }

    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 260,
                Height = 80,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            TextBox textBox = new TextBox() { Left = 10, Top = 10, Width = 160, Text = text };
            Button confirmation = new Button() { Text = "확인", Left = 180, Top = 10, Width = 55, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : text;
        }
    }

    public static class Util
    {
        public enum Effect { Roll, Slide, Center, Blend }

        public static void Animate(Control ctl, Effect effect, int msec, int angle)
        {
            int flags = effmap[(int)effect];
            if (ctl.Visible) { flags |= 0x10000; angle += 180; }
            else
            {
                if (ctl.TopLevelControl == ctl) flags |= 0x20000;
                else if (effect == Effect.Blend) throw new ArgumentException();
            }
            flags |= dirmap[(angle % 360) / 45];
            bool ok = AnimateWindow(ctl.Handle, msec, flags);
            if (!ok) throw new Exception("Animation failed");
            ctl.Visible = !ctl.Visible;
        }

        private static int[] dirmap = { 1, 5, 4, 6, 2, 10, 8, 9 };
        private static int[] effmap = { 0, 0x40000, 0x10, 0x80000 };

        [DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr handle, int msec, int flags);
    }
}
