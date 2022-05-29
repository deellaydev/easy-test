using System.ComponentModel;

namespace CourseWork
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.label1 = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.Eye = new System.Windows.Forms.PictureBox();
            this.ClosedEye = new System.Windows.Forms.PictureBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.LoginInput = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordInput = new System.Windows.Forms.TextBox();
            this.EyeConfirm = new System.Windows.Forms.PictureBox();
            this.ClosedEyeConfirm = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ExitBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Eye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosedEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EyeConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosedEyeConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(83, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(96, 187);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(165, 28);
            this.SignUpButton.TabIndex = 12;
            this.SignUpButton.Text = "Регистрация";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // Eye
            // 
            this.Eye.Image = ((System.Drawing.Image)(resources.GetObject("Eye.Image")));
            this.Eye.Location = new System.Drawing.Point(270, 123);
            this.Eye.Name = "Eye";
            this.Eye.Size = new System.Drawing.Size(26, 26);
            this.Eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Eye.TabIndex = 11;
            this.Eye.TabStop = false;
            this.Eye.Click += new System.EventHandler(this.Eye_Click);
            // 
            // ClosedEye
            // 
            this.ClosedEye.Image = ((System.Drawing.Image)(resources.GetObject("ClosedEye.Image")));
            this.ClosedEye.Location = new System.Drawing.Point(270, 123);
            this.ClosedEye.Name = "ClosedEye";
            this.ClosedEye.Size = new System.Drawing.Size(26, 26);
            this.ClosedEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClosedEye.TabIndex = 10;
            this.ClosedEye.TabStop = false;
            this.ClosedEye.Click += new System.EventHandler(this.ClosedEye_Click);
            // 
            // PasswordInput
            // 
            this.PasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordInput.Location = new System.Drawing.Point(96, 123);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(168, 26);
            this.PasswordInput.TabIndex = 9;
            // 
            // LoginInput
            // 
            this.LoginInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginInput.Location = new System.Drawing.Point(96, 91);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(168, 26);
            this.LoginInput.TabIndex = 8;
            // 
            // ConfirmPasswordInput
            // 
            this.ConfirmPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmPasswordInput.Location = new System.Drawing.Point(96, 155);
            this.ConfirmPasswordInput.Name = "ConfirmPasswordInput";
            this.ConfirmPasswordInput.Size = new System.Drawing.Size(168, 26);
            this.ConfirmPasswordInput.TabIndex = 14;
            // 
            // EyeConfirm
            // 
            this.EyeConfirm.Image = ((System.Drawing.Image)(resources.GetObject("EyeConfirm.Image")));
            this.EyeConfirm.Location = new System.Drawing.Point(270, 155);
            this.EyeConfirm.Name = "EyeConfirm";
            this.EyeConfirm.Size = new System.Drawing.Size(26, 26);
            this.EyeConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EyeConfirm.TabIndex = 15;
            this.EyeConfirm.TabStop = false;
            this.EyeConfirm.Click += new System.EventHandler(this.EyeConfirm_Click);
            // 
            // ClosedEyeConfirm
            // 
            this.ClosedEyeConfirm.Image = ((System.Drawing.Image)(resources.GetObject("ClosedEyeConfirm.Image")));
            this.ClosedEyeConfirm.Location = new System.Drawing.Point(270, 155);
            this.ClosedEyeConfirm.Name = "ClosedEyeConfirm";
            this.ClosedEyeConfirm.Size = new System.Drawing.Size(26, 26);
            this.ClosedEyeConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClosedEyeConfirm.TabIndex = 16;
            this.ClosedEyeConfirm.TabStop = false;
            this.ClosedEyeConfirm.Click += new System.EventHandler(this.ClosedEyeConfirm_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(154, 218);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 27);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Войти";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ExitBox
            // 
            this.ExitBox.Image = ((System.Drawing.Image)(resources.GetObject("ExitBox.Image")));
            this.ExitBox.Location = new System.Drawing.Point(322, 12);
            this.ExitBox.Name = "ExitBox";
            this.ExitBox.Size = new System.Drawing.Size(50, 50);
            this.ExitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitBox.TabIndex = 18;
            this.ExitBox.TabStop = false;
            this.ExitBox.Click += new System.EventHandler(this.ExitBox_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.ExitBox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ClosedEyeConfirm);
            this.Controls.Add(this.EyeConfirm);
            this.Controls.Add(this.ConfirmPasswordInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.Eye);
            this.Controls.Add(this.ClosedEye);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.LoginInput);
            this.Name = "SignUp";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Eye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosedEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EyeConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosedEyeConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox ExitBox;

        private System.Windows.Forms.LinkLabel linkLabel1;

        private System.Windows.Forms.TextBox ConfirmPasswordInput;
        private System.Windows.Forms.PictureBox EyeConfirm;
        private System.Windows.Forms.PictureBox ClosedEyeConfirm;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.PictureBox Eye;
        private System.Windows.Forms.PictureBox ClosedEye;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.TextBox LoginInput;

        #endregion
    }
}