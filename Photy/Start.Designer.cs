namespace Photy
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.upDir = new System.Windows.Forms.Button();
            this.rightDir = new System.Windows.Forms.Button();
            this.downDir = new System.Windows.Forms.Button();
            this.leftDir = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.spaceDestination = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // upDir
            // 
            this.upDir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.upDir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.upDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upDir.Font = new System.Drawing.Font("맑은 고딕", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.upDir.Image = global::Photy.Properties.Resources.folder;
            this.upDir.Location = new System.Drawing.Point(220, 12);
            this.upDir.Name = "upDir";
            this.upDir.Size = new System.Drawing.Size(172, 158);
            this.upDir.TabIndex = 0;
            this.upDir.TabStop = false;
            this.upDir.Text = "위쪽";
            this.upDir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.upDir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.upDir.UseVisualStyleBackColor = false;
            this.upDir.Click += new System.EventHandler(this.dirClick);
            this.upDir.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Start_PreviewKeyDown);
            // 
            // rightDir
            // 
            this.rightDir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rightDir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rightDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightDir.Font = new System.Drawing.Font("맑은 고딕", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rightDir.Image = global::Photy.Properties.Resources.folder;
            this.rightDir.Location = new System.Drawing.Point(431, 177);
            this.rightDir.Name = "rightDir";
            this.rightDir.Size = new System.Drawing.Size(172, 158);
            this.rightDir.TabIndex = 1;
            this.rightDir.TabStop = false;
            this.rightDir.Text = "오른쪽";
            this.rightDir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rightDir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rightDir.UseVisualStyleBackColor = false;
            this.rightDir.Click += new System.EventHandler(this.dirClick);
            this.rightDir.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Start_PreviewKeyDown);
            // 
            // downDir
            // 
            this.downDir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.downDir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.downDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downDir.Font = new System.Drawing.Font("맑은 고딕", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.downDir.Image = global::Photy.Properties.Resources.folder;
            this.downDir.Location = new System.Drawing.Point(220, 354);
            this.downDir.Name = "downDir";
            this.downDir.Size = new System.Drawing.Size(172, 158);
            this.downDir.TabIndex = 2;
            this.downDir.TabStop = false;
            this.downDir.Text = "아래쪽";
            this.downDir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.downDir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.downDir.UseVisualStyleBackColor = false;
            this.downDir.Click += new System.EventHandler(this.dirClick);
            this.downDir.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Start_PreviewKeyDown);
            // 
            // leftDir
            // 
            this.leftDir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.leftDir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.leftDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftDir.Font = new System.Drawing.Font("맑은 고딕", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.leftDir.Image = global::Photy.Properties.Resources.folder;
            this.leftDir.Location = new System.Drawing.Point(12, 177);
            this.leftDir.Name = "leftDir";
            this.leftDir.Size = new System.Drawing.Size(172, 158);
            this.leftDir.TabIndex = 3;
            this.leftDir.TabStop = false;
            this.leftDir.Text = "왼쪽";
            this.leftDir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.leftDir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.leftDir.UseVisualStyleBackColor = false;
            this.leftDir.Click += new System.EventHandler(this.dirClick);
            this.leftDir.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Start_PreviewKeyDown);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Location = new System.Drawing.Point(219, 192);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(176, 139);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // spaceDestination
            // 
            this.spaceDestination.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spaceDestination.BackColor = System.Drawing.Color.Transparent;
            this.spaceDestination.Location = new System.Drawing.Point(302, 258);
            this.spaceDestination.Name = "spaceDestination";
            this.spaceDestination.Size = new System.Drawing.Size(10, 10);
            this.spaceDestination.TabIndex = 5;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 524);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.spaceDestination);
            this.Controls.Add(this.leftDir);
            this.Controls.Add(this.downDir);
            this.Controls.Add(this.rightDir);
            this.Controls.Add(this.upDir);
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Start_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button upDir;
        private System.Windows.Forms.Button rightDir;
        private System.Windows.Forms.Button downDir;
        private System.Windows.Forms.Button leftDir;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel spaceDestination;
    }
}