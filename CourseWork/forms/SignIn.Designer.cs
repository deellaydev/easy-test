using System.ComponentModel;

namespace CourseWork
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.LoginInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.ClosedEye = new System.Windows.Forms.PictureBox();
            this.Eye = new System.Windows.Forms.PictureBox();
            this.SignInButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ExitBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClosedEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Eye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginInput
            // 
            this.LoginInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginInput.Location = new System.Drawing.Point(100, 90);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(168, 26);
            this.LoginInput.TabIndex = 0;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordInput.Location = new System.Drawing.Point(100, 122);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(168, 26);
            this.PasswordInput.TabIndex = 1;
            // 
            // ClosedEye
            // 
            this.ClosedEye.Image = ((System.Drawing.Image)(resources.GetObject("ClosedEye.Image")));
            this.ClosedEye.Location = new System.Drawing.Point(274, 122);
            this.ClosedEye.Name = "ClosedEye";
            this.ClosedEye.Size = new System.Drawing.Size(26, 26);
            this.ClosedEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClosedEye.TabIndex = 4;
            this.ClosedEye.TabStop = false;
            this.ClosedEye.Click += new System.EventHandler(this.ClosedEye_Click);
            // 
            // Eye
            // 
            this.Eye.Image = ((System.Drawing.Image)(resources.GetObject("Eye.Image")));
            this.Eye.Location = new System.Drawing.Point(274, 122);
            this.Eye.Name = "Eye";
            this.Eye.Size = new System.Drawing.Size(26, 26);
            this.Eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Eye.TabIndex = 5;
            this.Eye.TabStop = false;
            this.Eye.Click += new System.EventHandler(this.Eye_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(100, 154);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(165, 28);
            this.SignInButton.TabIndex = 6;
            this.SignInButton.Text = "Войти";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(87, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(134, 185);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(108, 27);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Регистрация";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ExitBox
            // 
            this.ExitBox.Image = ((System.Drawing.Image)(resources.GetObject("ExitBox.Image")));
            this.ExitBox.Location = new System.Drawing.Point(322, 12);
            this.ExitBox.Name = "ExitBox";
            this.ExitBox.Size = new System.Drawing.Size(50, 50);
            this.ExitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitBox.TabIndex = 9;
            this.ExitBox.TabStop = false;
            this.ExitBox.Click += new System.EventHandler(this.ExitBox_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.ExitBox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.Eye);
            this.Controls.Add(this.ClosedEye);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.LoginInput);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "SignIn";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.SignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClosedEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Eye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox ExitBox;

        private System.Windows.Forms.LinkLabel linkLabel1;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button SignInButton;

        private System.Windows.Forms.PictureBox Eye;

        private System.Windows.Forms.PictureBox ClosedEye;

        private System.Windows.Forms.TextBox LoginInput;
        private System.Windows.Forms.TextBox PasswordInput;

        #endregion
    }
}