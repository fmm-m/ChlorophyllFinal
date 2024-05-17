namespace Chlorophyl_Prototype
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLessons = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnSandbox = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label1.Location = new System.Drawing.Point(1370, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chlorophyll";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLessons
            // 
            this.btnLessons.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLessons.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnLessons.Location = new System.Drawing.Point(228, 468);
            this.btnLessons.Name = "btnLessons";
            this.btnLessons.Size = new System.Drawing.Size(164, 66);
            this.btnLessons.TabIndex = 1;
            this.btnLessons.Text = "Lessons";
            this.btnLessons.UseVisualStyleBackColor = false;
            this.btnLessons.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnResume
            // 
            this.btnResume.BackColor = System.Drawing.Color.ForestGreen;
            this.btnResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnResume.Location = new System.Drawing.Point(228, 544);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(227, 63);
            this.btnResume.TabIndex = 2;
            this.btnResume.Text = "Resume Lesson";
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnSandbox
            // 
            this.btnSandbox.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSandbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnSandbox.Location = new System.Drawing.Point(228, 762);
            this.btnSandbox.Name = "btnSandbox";
            this.btnSandbox.Size = new System.Drawing.Size(98, 63);
            this.btnSandbox.TabIndex = 3;
            this.btnSandbox.Text = "Quit";
            this.btnSandbox.UseVisualStyleBackColor = false;
            this.btnSandbox.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnAbout.Location = new System.Drawing.Point(228, 621);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(149, 63);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Chlorophyl_Prototype.Properties.Resources.green_leafed_plant_4k_hd_green_3840x2160;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-29, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1950, 1098);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSandbox);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnLessons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLessons;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnSandbox;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

