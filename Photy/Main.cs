using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photy
{
    public partial class Main : Form
    {
        public static Main main;
        public static List<string> imageList = new List<string>();
        public static FolderBrowserDialog dirDialog = new FolderBrowserDialog();

        public Main()
        {
            InitializeComponent();
        }

        public void listReset()
        {
            imageList.Clear();
            flowLayoutPanel1.Controls.Clear();
        }

        private void addImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            dialog.Multiselect = true;
            dialog.Title = "사진 추가";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in dialog.FileNames)
                {
                    try
                    {
                        imageList.Add(file);
                        PictureBox pb = new PictureBox();
                        var fs = new FileStream(file, FileMode.Open);
                        var loadedImage = new Bitmap(fs);
                        loadedImage = new Bitmap(loadedImage, new Size(30, 30));
                        pb.Image = (Bitmap)loadedImage.Clone();
                        fs.Close();

                        pb.Height = loadedImage.Height;
                        pb.Width = loadedImage.Width;
                        pb.Image = loadedImage;

                        var p = new FlowLayoutPanel();
                        p.Height = 35;
                        p.Width = flowLayoutPanel1.Width - 25;
                        p.Controls.Add(pb);
                        var fileinfo = new FileInfo(file);
                        Label fileName = new Label { Text = fileinfo.Name };
                        fileName.AutoSize = true;
                        Label fileSize = new Label { Text = fileinfo.Length.ToString() + " Bytes" };
                        fileSize.AutoSize = true;
                        p.Controls.Add(fileName);
                        p.Controls.Add(fileSize);
                        flowLayoutPanel1.Controls.Add(p);

                        Label label = new Label();
                        label.AutoSize = false;
                        label.Height = 2;
                        label.Width = flowLayoutPanel1.Width - 25;
                        label.BorderStyle = BorderStyle.Fixed3D;
                        flowLayoutPanel1.Controls.Add(label);
                    }
                    catch (SecurityException ex)
                    {
                        // The user lacks appropriate permissions to read files, discover paths, etc.
                        MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                            "Error message: " + ex.Message + "\n\n" +
                            "Details (send to Support):\n\n" + ex.StackTrace
                        );
                    }
                    catch (Exception ex)
                    {
                        // Could not load the image - probably related to Windows file system permissions.
                        MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\'))
                            + ". You may not have permission to read the file, or " +
                            "it may be corrupt.\n\nReported error: " + ex.Message);
                    }
                }
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            main = this;
            this.Visible = false;
            Start start = new Start();
            start.Owner = this;
            start.Show();
        }

        private void dirSelectBtn_Click(object sender, EventArgs e)
        {
            if (dirDialog.ShowDialog() == DialogResult.OK)
            {
                dirPath.Text = dirDialog.SelectedPath;
            }
        }
    }
}
