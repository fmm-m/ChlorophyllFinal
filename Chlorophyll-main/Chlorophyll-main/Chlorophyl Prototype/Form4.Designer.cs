namespace Chlorophyl_Prototype
{
    partial class Form4
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
            this.lessonTitle = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lessonTitle
            // 
            this.lessonTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lessonTitle.Location = new System.Drawing.Point(47, 9);
            this.lessonTitle.Name = "lessonTitle";
            this.lessonTitle.Size = new System.Drawing.Size(368, 128);
            this.lessonTitle.TabIndex = 1;
            this.lessonTitle.Text = "Lesson #1. What is programming?";
            this.lessonTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // Menu
            // 
            this.Menu.Location = new System.Drawing.Point(12, 989);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(121, 40);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = true;
            this.Menu.Click += new System.EventHandler(this.button1_Click);
            // 
            // content
            // 
            this.content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content.Location = new System.Drawing.Point(50, 123);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(342, 849);
            this.content.TabIndex = 3;
            this.content.Text = " ";
            this.content.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(531, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1300, 897);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.content);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.lessonTitle);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lessonTitle;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Label content;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}