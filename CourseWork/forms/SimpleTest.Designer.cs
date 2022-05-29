using System.ComponentModel;

namespace CourseWork
{
    partial class SimpleTest
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
            this.QuestionTextLabel = new System.Windows.Forms.Label();
            this.NextQuestionButton = new System.Windows.Forms.Button();
            this.FirstAnswerButton = new System.Windows.Forms.RadioButton();
            this.SecondAnswerButton = new System.Windows.Forms.RadioButton();
            this.ThirdAnswerButton = new System.Windows.Forms.RadioButton();
            this.PastQuestionButton = new System.Windows.Forms.Button();
            this.QuestionNumberLabel = new System.Windows.Forms.Label();
            this.EndTestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionTextLabel
            // 
            this.QuestionTextLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.QuestionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionTextLabel.Location = new System.Drawing.Point(12, 59);
            this.QuestionTextLabel.Name = "QuestionTextLabel";
            this.QuestionTextLabel.Size = new System.Drawing.Size(460, 169);
            this.QuestionTextLabel.TabIndex = 0;
            this.QuestionTextLabel.Text = "Текст вопроса";
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.Location = new System.Drawing.Point(252, 399);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(220, 50);
            this.NextQuestionButton.TabIndex = 4;
            this.NextQuestionButton.Text = "Далее";
            this.NextQuestionButton.UseVisualStyleBackColor = true;
            this.NextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // FirstAnswerButton
            // 
            this.FirstAnswerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstAnswerButton.Location = new System.Drawing.Point(12, 231);
            this.FirstAnswerButton.Name = "FirstAnswerButton";
            this.FirstAnswerButton.Size = new System.Drawing.Size(460, 50);
            this.FirstAnswerButton.TabIndex = 1;
            this.FirstAnswerButton.TabStop = true;
            this.FirstAnswerButton.Text = "Ответ 1";
            this.FirstAnswerButton.UseVisualStyleBackColor = true;
            this.FirstAnswerButton.CheckedChanged += new System.EventHandler(this.AnswerButton_CheckedChanged);
            // 
            // SecondAnswerButton
            // 
            this.SecondAnswerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondAnswerButton.Location = new System.Drawing.Point(12, 287);
            this.SecondAnswerButton.Name = "SecondAnswerButton";
            this.SecondAnswerButton.Size = new System.Drawing.Size(460, 50);
            this.SecondAnswerButton.TabIndex = 2;
            this.SecondAnswerButton.TabStop = true;
            this.SecondAnswerButton.Text = "Ответ 2";
            this.SecondAnswerButton.UseVisualStyleBackColor = true;
            this.SecondAnswerButton.CheckedChanged += new System.EventHandler(this.AnswerButton_CheckedChanged);
            // 
            // ThirdAnswerButton
            // 
            this.ThirdAnswerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThirdAnswerButton.Location = new System.Drawing.Point(12, 343);
            this.ThirdAnswerButton.Name = "ThirdAnswerButton";
            this.ThirdAnswerButton.Size = new System.Drawing.Size(460, 50);
            this.ThirdAnswerButton.TabIndex = 3;
            this.ThirdAnswerButton.TabStop = true;
            this.ThirdAnswerButton.Text = "Ответ 3";
            this.ThirdAnswerButton.UseVisualStyleBackColor = true;
            this.ThirdAnswerButton.CheckedChanged += new System.EventHandler(this.AnswerButton_CheckedChanged);
            // 
            // PastQuestionButton
            // 
            this.PastQuestionButton.Location = new System.Drawing.Point(12, 399);
            this.PastQuestionButton.Name = "PastQuestionButton";
            this.PastQuestionButton.Size = new System.Drawing.Size(220, 50);
            this.PastQuestionButton.TabIndex = 5;
            this.PastQuestionButton.Text = "Назад";
            this.PastQuestionButton.UseVisualStyleBackColor = true;
            this.PastQuestionButton.Click += new System.EventHandler(this.PastQuestionButton_Click);
            // 
            // QuestionNumberLabel
            // 
            this.QuestionNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionNumberLabel.Location = new System.Drawing.Point(12, 9);
            this.QuestionNumberLabel.Name = "QuestionNumberLabel";
            this.QuestionNumberLabel.Size = new System.Drawing.Size(460, 40);
            this.QuestionNumberLabel.TabIndex = 6;
            this.QuestionNumberLabel.Text = "Вопрос 1/n";
            this.QuestionNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndTestButton
            // 
            this.EndTestButton.Location = new System.Drawing.Point(12, 455);
            this.EndTestButton.Name = "EndTestButton";
            this.EndTestButton.Size = new System.Drawing.Size(460, 50);
            this.EndTestButton.TabIndex = 7;
            this.EndTestButton.Text = "Закончить тест";
            this.EndTestButton.UseVisualStyleBackColor = true;
            this.EndTestButton.Click += new System.EventHandler(this.EndTestButton_Click);
            // 
            // SimpleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 516);
            this.Controls.Add(this.EndTestButton);
            this.Controls.Add(this.QuestionNumberLabel);
            this.Controls.Add(this.PastQuestionButton);
            this.Controls.Add(this.ThirdAnswerButton);
            this.Controls.Add(this.SecondAnswerButton);
            this.Controls.Add(this.FirstAnswerButton);
            this.Controls.Add(this.NextQuestionButton);
            this.Controls.Add(this.QuestionTextLabel);
            this.Name = "SimpleTest";
            this.Text = "Простой тест";
            this.Load += new System.EventHandler(this.SimpleTest_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button EndTestButton;

        private System.Windows.Forms.Label QuestionNumberLabel;

        private System.Windows.Forms.Button PastQuestionButton;

        private System.Windows.Forms.RadioButton ThirdAnswerButton;

        private System.Windows.Forms.RadioButton FirstAnswerButton;
        private System.Windows.Forms.RadioButton SecondAnswerButton;

        private System.Windows.Forms.Button NextQuestionButton;

        private System.Windows.Forms.Label QuestionTextLabel;

        #endregion
    }
}