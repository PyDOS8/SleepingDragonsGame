namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dungeonImg = new PictureBox();
            playerImg = new PictureBox();
            dragonImg = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dungeonImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dragonImg).BeginInit();
            SuspendLayout();
            // 
            // dungeonImg
            // 
            dungeonImg.Image = (Image)resources.GetObject("dungeonImg.Image");
            dungeonImg.Location = new Point(-3, 1);
            dungeonImg.Name = "dungeonImg";
            dungeonImg.Size = new Size(806, 449);
            dungeonImg.TabIndex = 0;
            dungeonImg.TabStop = false;
            dungeonImg.Click += dungeonImg_Click;
            // 
            // playerImg
            // 
            playerImg.BackgroundImage = (Image)resources.GetObject("playerImg.BackgroundImage");
            playerImg.Image = (Image)resources.GetObject("playerImg.Image");
            playerImg.Location = new Point(-3, 392);
            playerImg.Name = "playerImg";
            playerImg.Size = new Size(50, 58);
            playerImg.TabIndex = 1;
            playerImg.TabStop = false;
            // 
            // dragonImg
            // 
            dragonImg.BackgroundImage = (Image)resources.GetObject("dragonImg.BackgroundImage");
            dragonImg.Image = (Image)resources.GetObject("dragonImg.Image");
            dragonImg.Location = new Point(598, 359);
            dragonImg.Name = "dragonImg";
            dragonImg.Size = new Size(205, 91);
            dragonImg.TabIndex = 2;
            dragonImg.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dragonImg);
            Controls.Add(playerImg);
            Controls.Add(dungeonImg);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dungeonImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)dragonImg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox dungeonImg;
        private PictureBox playerImg;
        private PictureBox dragonImg;
    }
}