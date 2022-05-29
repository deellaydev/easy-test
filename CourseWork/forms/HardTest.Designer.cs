using System.ComponentModel;

namespace CourseWork
{
    partial class HardTest
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
            this.EndTestButton = new System.Windows.Forms.Button();
            this.QuestionNumberLabel = new System.Windows.Forms.Label();
            this.PastQuestionButton = new System.Windows.Forms.Button();
            this.NextQuestionButton = new System.Windows.Forms.Button();
            this.QuestionTextLabel = new System.Windows.Forms.Label();
            this.AnswerInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EndTestButton
            // 
            this.EndTestButton.Location = new System.Drawing.Point(15, 323);
            this.EndTestButton.Name = "EndTestButton";
            this.EndTestButton.Size = new System.Drawing.Size(460, 50);
            this.EndTestButton.TabIndex = 15;
            this.EndTestButton.Text = "Закончить тест";
            this.EndTestButton.UseVisualStyleBackColor = true;
            this.EndTestButton.Click += new System.EventHandler(this.EndTestButton_Click);
            // 
            // QuestionNumberLabel
            // 
            this.QuestionNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionNumberLabel.Location = new System.Drawing.Point(12, 10);
            this.QuestionNumberLabel.Name = "QuestionNumberLabel";
            this.QuestionNumberLabel.Size = new System.Drawing.Size(460, 40);
            this.QuestionNumberLabel.TabIndex = 14;
            this.QuestionNumberLabel.Text = "Вопрос 1/n";
            this.QuestionNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PastQuestionButton
            // 
            this.PastQuestionButton.Location = new System.Drawing.Point(15, 267);
            this.PastQuestionButton.Name = "PastQuestionButton";
            this.PastQuestionButton.Size = new System.Drawing.Size(220, 50);
            this.PastQuestionButton.TabIndex = 13;
            this.PastQuestionButton.Text = "Назад";
            this.PastQuestionButton.UseVisualStyleBackColor = true;
            this.PastQuestionButton.Click += new System.EventHandler(this.PastQuestionButton_Click);
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.Location = new System.Drawing.Point(255, 267);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(220, 50);
            this.NextQuestionButton.TabIndex = 12;
            this.NextQuestionButton.Text = "Далее";
            this.NextQuestionButton.UseVisualStyleBackColor = true;
            this.NextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // QuestionTextLabel
            // 
            this.QuestionTextLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.QuestionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionTextLabel.Location = new System.Drawing.Point(12, 60);
            this.QuestionTextLabel.Name = "QuestionTextLabel";
            this.QuestionTextLabel.Size = new System.Drawing.Size(460, 169);
            this.QuestionTextLabel.TabIndex = 8;
            this.QuestionTextLabel.Text = "Текст вопроса";
            // 
            // AnswerInput
            // 
            this.AnswerInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerInput.Location = new System.Drawing.Point(15, 232);
            this.AnswerInput.Name = "AnswerInput";
            this.AnswerInput.Size = new System.Drawing.Size(460, 29);
            this.AnswerInput.TabIndex = 16;
            this.AnswerInput.TextChanged += new System.EventHandler(this.AnswerInput_TextChanged);
            // 
            // HardTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 381);
            this.Controls.Add(this.AnswerInput);
            this.Controls.Add(this.EndTestButton);
            this.Controls.Add(this.QuestionNumberLabel);
            this.Controls.Add(this.PastQuestionButton);
            this.Controls.Add(this.NextQuestionButton);
            this.Controls.Add(this.QuestionTextLabel);
            this.Name = "HardTest";
            this.Text = "HardTest";
            this.Load += new System.EventHandler(this.HardTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button EndTestButton;
        private System.Windows.Forms.Label QuestionNumberLabel;
        private System.Windows.Forms.Button PastQuestionButton;
        private System.Windows.Forms.Button NextQuestionButton;
        private System.Windows.Forms.Label QuestionTextLabel;
        private System.Windows.Forms.TextBox AnswerInput;

        #endregion
    }
}