namespace Autodesk_File_Removal_Tool
{
    partial class frm_frontPage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_flexnet = new System.Windows.Forms.CheckBox();
            this.chk_installer = new System.Windows.Forms.CheckBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.br_progress = new System.Windows.Forms.ProgressBar();
            this.lbl_status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Autodesk_File_Removal_Tool.Properties.Resources.autodesk_logo_color_text_black_rgb_large;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 85);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(90, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Removal Tool";
            // 
            // chk_flexnet
            // 
            this.chk_flexnet.AutoSize = true;
            this.chk_flexnet.Location = new System.Drawing.Point(127, 178);
            this.chk_flexnet.Name = "chk_flexnet";
            this.chk_flexnet.Size = new System.Drawing.Size(137, 17);
            this.chk_flexnet.TabIndex = 2;
            this.chk_flexnet.Text = "Remove FlexNet Folder";
            this.chk_flexnet.UseVisualStyleBackColor = true;
            // 
            // chk_installer
            // 
            this.chk_installer.AutoSize = true;
            this.chk_installer.Location = new System.Drawing.Point(127, 229);
            this.chk_installer.Name = "chk_installer";
            this.chk_installer.Size = new System.Drawing.Size(158, 17);
            this.chk_installer.TabIndex = 3;
            this.chk_installer.Text = "Remove Autodesk Installers";
            this.chk_installer.UseVisualStyleBackColor = true;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(154, 326);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(104, 23);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // br_progress
            // 
            this.br_progress.Location = new System.Drawing.Point(12, 384);
            this.br_progress.Name = "br_progress";
            this.br_progress.Size = new System.Drawing.Size(389, 23);
            this.br_progress.TabIndex = 5;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(12, 365);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 13);
            this.lbl_status.TabIndex = 6;
            // 
            // frm_frontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 419);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.br_progress);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.chk_installer);
            this.Controls.Add(this.chk_flexnet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_frontPage";
            this.Text = "Autodesk File Removal Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_flexnet;
        private System.Windows.Forms.CheckBox chk_installer;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.ProgressBar br_progress;
        private System.Windows.Forms.Label lbl_status;
    }
}

