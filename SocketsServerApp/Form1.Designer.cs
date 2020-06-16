namespace SocketsServerApp
{
    partial class Form1
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
            this.startServerBtn = new System.Windows.Forms.Button();
            this.piPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.piPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startServerBtn
            // 
            this.startServerBtn.Location = new System.Drawing.Point(12, 415);
            this.startServerBtn.Name = "startServerBtn";
            this.startServerBtn.Size = new System.Drawing.Size(75, 23);
            this.startServerBtn.TabIndex = 0;
            this.startServerBtn.Text = "Start Server";
            this.startServerBtn.UseVisualStyleBackColor = true;
            this.startServerBtn.Click += new System.EventHandler(this.startServerBtn_Click);
            // 
            // piPictureBox
            // 
            this.piPictureBox.Location = new System.Drawing.Point(93, 12);
            this.piPictureBox.Name = "piPictureBox";
            this.piPictureBox.Size = new System.Drawing.Size(695, 426);
            this.piPictureBox.TabIndex = 1;
            this.piPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.piPictureBox);
            this.Controls.Add(this.startServerBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.piPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startServerBtn;
        private System.Windows.Forms.PictureBox piPictureBox;
    }
}

