using System.ComponentModel;

namespace CourseWork
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.ExitBox = new System.Windows.Forms.PictureBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.SimpleTestButton = new System.Windows.Forms.Button();
            this.HardTestButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SimpleTestLabel = new System.Windows.Forms.Label();
            this.HardTestLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBox
            // 
            this.ExitBox.Image = ((System.Drawing.Image)(resources.GetObject("ExitBox.Image")));
            this.ExitBox.Location = new System.Drawing.Point(264, 12);
            this.ExitBox.Name = "ExitBox";
            this.ExitBox.Size = new System.Drawing.Size(50, 50);
            this.ExitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitBox.TabIndex = 0;
            this.ExitBox.TabStop = false;
            this.ExitBox.Click += new System.EventHandler(this.ExitBox_Click);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameLabel.Location = new System.Drawing.Point(12, 12);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(246, 50);
            this.UserNameLabel.TabIndex = 1;
            // 
            // SimpleTestButton
            // 
            this.SimpleTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SimpleTestButton.Location = new System.Drawing.Point(12, 131);
            this.SimpleTestButton.Name = "SimpleTestButton";
            this.SimpleTestButton.Size = new System.Drawing.Size(150, 50);
            this.SimpleTestButton.TabIndex = 2;
            this.SimpleTestButton.Text = "Простой тест";
            this.SimpleTestButton.UseVisualStyleBackColor = true;
            this.SimpleTestButton.Click += new System.EventHandler(this.SimpleTestButton_Click);
            // 
            // HardTestButton
            // 
            this.HardTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HardTestButton.Location = new System.Drawing.Point(12, 209);
            this.HardTestButton.Name = "HardTestButton";
            this.HardTestButton.Size = new System.Drawing.Size(150, 50);
            this.HardTestButton.TabIndex = 3;
            this.HardTestButton.Text = "Сложный тест";
            this.HardTestButton.UseVisualStyleBackColor = true;
            this.HardTestButton.Click += new System.EventHandler(this.HardTestButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сбросить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SimpleTestLabel
            // 
            this.SimpleTestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SimpleTestLabel.Location = new System.Drawing.Point(168, 131);
            this.SimpleTestLabel.Name = "SimpleTestLabel";
            this.SimpleTestLabel.Size = new System.Drawing.Size(90, 50);
            this.SimpleTestLabel.TabIndex = 5;
            this.SimpleTestLabel.Text = "10/10";
            this.SimpleTestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HardTestLabel
            // 
            this.HardTestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HardTestLabel.Location = new System.Drawing.Point(168, 209);
            this.HardTestLabel.Name = "HardTestLabel";
            this.HardTestLabel.Size = new System.Drawing.Size(90, 50);
            this.HardTestLabel.TabIndex = 6;
            this.HardTestLabel.Text = "10/10";
            this.HardTestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.HardTestLabel);
            this.Controls.Add(this.SimpleTestLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HardTestButton);
            this.Controls.Add(this.SimpleTestButton);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.ExitBox);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label HardTestLabel;

        private System.Windows.Forms.Label SimpleTestLabel;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button SimpleTestButton;
        private System.Windows.Forms.Button HardTestButton;

        private System.Windows.Forms.Label UserNameLabel;

        private System.Windows.Forms.PictureBox ExitBox;

        #endregion
    }
}