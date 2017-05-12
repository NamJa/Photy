namespace Photy
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.startBtn = new System.Windows.Forms.Button();
            this.addImageBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addImageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dirPathLabel = new System.Windows.Forms.Label();
            this.dirPath = new System.Windows.Forms.TextBox();
            this.dirSelectBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.BackgroundImage = global::Photy.Properties.Resources.playBtn;
            this.startBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.startBtn.Location = new System.Drawing.Point(124, 14);
            this.startBtn.Margin = new System.Windows.Forms.Padding(5);
            this.startBtn.Name = "startBtn";
            this.startBtn.Padding = new System.Windows.Forms.Padding(5);
            this.startBtn.Size = new System.Drawing.Size(100, 100);
            this.startBtn.TabIndex = 1;
            this.startBtn.TabStop = false;
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // addImageBtn
            // 
            this.addImageBtn.BackgroundImage = global::Photy.Properties.Resources.addImageBtn;
            this.addImageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addImageBtn.Location = new System.Drawing.Point(14, 14);
            this.addImageBtn.Margin = new System.Windows.Forms.Padding(5);
            this.addImageBtn.Name = "addImageBtn";
            this.addImageBtn.Padding = new System.Windows.Forms.Padding(5);
            this.addImageBtn.Size = new System.Drawing.Size(100, 100);
            this.addImageBtn.TabIndex = 0;
            this.addImageBtn.TabStop = false;
            this.addImageBtn.UseVisualStyleBackColor = true;
            this.addImageBtn.Click += new System.EventHandler(this.addImageBtn_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(118, 12);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // addImageLabel
            // 
            this.addImageLabel.AutoSize = true;
            this.addImageLabel.Font = new System.Drawing.Font("맑은 고딕", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addImageLabel.Location = new System.Drawing.Point(12, 116);
            this.addImageLabel.Name = "addImageLabel";
            this.addImageLabel.Size = new System.Drawing.Size(104, 30);
            this.addImageLabel.TabIndex = 2;
            this.addImageLabel.Text = "사진 추가";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(123, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "정리 시작";
            // 
            // dirPathLabel
            // 
            this.dirPathLabel.AutoSize = true;
            this.dirPathLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dirPathLabel.Location = new System.Drawing.Point(245, 21);
            this.dirPathLabel.Name = "dirPathLabel";
            this.dirPathLabel.Size = new System.Drawing.Size(119, 32);
            this.dirPathLabel.TabIndex = 4;
            this.dirPathLabel.Text = "이동 폴더";
            // 
            // dirPath
            // 
            this.dirPath.Location = new System.Drawing.Point(248, 57);
            this.dirPath.Name = "dirPath";
            this.dirPath.ReadOnly = true;
            this.dirPath.Size = new System.Drawing.Size(497, 35);
            this.dirPath.TabIndex = 5;
            this.dirPath.TabStop = false;
            // 
            // dirSelectBtn
            // 
            this.dirSelectBtn.Font = new System.Drawing.Font("맑은 고딕", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dirSelectBtn.Location = new System.Drawing.Point(751, 54);
            this.dirSelectBtn.Name = "dirSelectBtn";
            this.dirSelectBtn.Size = new System.Drawing.Size(100, 46);
            this.dirSelectBtn.TabIndex = 6;
            this.dirSelectBtn.TabStop = false;
            this.dirSelectBtn.Text = "선택";
            this.dirSelectBtn.UseVisualStyleBackColor = true;
            this.dirSelectBtn.Click += new System.EventHandler(this.dirSelectBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 157);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(837, 429);
            this.flowLayoutPanel1.TabIndex = 8;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(867, 598);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dirSelectBtn);
            this.Controls.Add(this.dirPath);
            this.Controls.Add(this.dirPathLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addImageLabel);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.addImageBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Photy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addImageBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label addImageLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dirPathLabel;
        private System.Windows.Forms.TextBox dirPath;
        private System.Windows.Forms.Button dirSelectBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

