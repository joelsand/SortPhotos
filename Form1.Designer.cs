namespace SortPhotos
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
            this.txtSourceDir = new System.Windows.Forms.TextBox();
            this.txtDestPhotos = new System.Windows.Forms.TextBox();
            this.btnSortNow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestPhotosRaw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestinationVideos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkMakeCopies = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtSourceDir
            // 
            this.txtSourceDir.Location = new System.Drawing.Point(12, 31);
            this.txtSourceDir.Name = "txtSourceDir";
            this.txtSourceDir.Size = new System.Drawing.Size(339, 20);
            this.txtSourceDir.TabIndex = 1;
            // 
            // txtDestPhotos
            // 
            this.txtDestPhotos.Location = new System.Drawing.Point(12, 74);
            this.txtDestPhotos.Name = "txtDestPhotos";
            this.txtDestPhotos.Size = new System.Drawing.Size(339, 20);
            this.txtDestPhotos.TabIndex = 3;
            // 
            // btnSortNow
            // 
            this.btnSortNow.Location = new System.Drawing.Point(12, 216);
            this.btnSortNow.Name = "btnSortNow";
            this.btnSortNow.Size = new System.Drawing.Size(75, 23);
            this.btnSortNow.TabIndex = 9;
            this.btnSortNow.Text = "Sort now!";
            this.btnSortNow.UseVisualStyleBackColor = true;
            this.btnSortNow.Click += new System.EventHandler(this.btnSortNow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination Photos:";
            // 
            // txtDestPhotosRaw
            // 
            this.txtDestPhotosRaw.Location = new System.Drawing.Point(12, 115);
            this.txtDestPhotosRaw.Name = "txtDestPhotosRaw";
            this.txtDestPhotosRaw.Size = new System.Drawing.Size(339, 20);
            this.txtDestPhotosRaw.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Destination Photos (Raw):";
            // 
            // txtDestinationVideos
            // 
            this.txtDestinationVideos.Location = new System.Drawing.Point(12, 155);
            this.txtDestinationVideos.Name = "txtDestinationVideos";
            this.txtDestinationVideos.Size = new System.Drawing.Size(339, 20);
            this.txtDestinationVideos.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Destination Videos:";
            // 
            // chkMakeCopies
            // 
            this.chkMakeCopies.AutoSize = true;
            this.chkMakeCopies.Location = new System.Drawing.Point(14, 182);
            this.chkMakeCopies.Name = "chkMakeCopies";
            this.chkMakeCopies.Size = new System.Drawing.Size(120, 17);
            this.chkMakeCopies.TabIndex = 8;
            this.chkMakeCopies.Text = "Make copies of files";
            this.chkMakeCopies.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 262);
            this.Controls.Add(this.chkMakeCopies);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSortNow);
            this.Controls.Add(this.txtDestinationVideos);
            this.Controls.Add(this.txtDestPhotosRaw);
            this.Controls.Add(this.txtDestPhotos);
            this.Controls.Add(this.txtSourceDir);
            this.Name = "Form1";
            this.Text = "Sort Photos and Videos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSourceDir;
        private System.Windows.Forms.TextBox txtDestPhotos;
        private System.Windows.Forms.Button btnSortNow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestPhotosRaw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDestinationVideos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkMakeCopies;
    }
}

