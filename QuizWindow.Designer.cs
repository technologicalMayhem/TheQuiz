namespace TheQuiz
{
    partial class QuizWindow
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
            this.qustionCount = new System.Windows.Forms.Label();
            this.questionCountCorrect = new System.Windows.Forms.Label();
            this.questionCountWrong = new System.Windows.Forms.Label();
            this.questionCountSkipped = new System.Windows.Forms.Label();
            this.buttonSkipQuestion = new System.Windows.Forms.Button();
            this.questionCurrentQuestion = new System.Windows.Forms.Label();
            this.questionAnswerA = new System.Windows.Forms.Button();
            this.questionAnswerB = new System.Windows.Forms.Button();
            this.questionAnswerD = new System.Windows.Forms.Button();
            this.questionAnswerC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // qustionCount
            // 
            this.qustionCount.AutoSize = true;
            this.qustionCount.Location = new System.Drawing.Point(13, 13);
            this.qustionCount.Name = "qustionCount";
            this.qustionCount.Size = new System.Drawing.Size(88, 13);
            this.qustionCount.TabIndex = 0;
            this.qustionCount.Text = "Frage Nummer: 0";
            // 
            // questionCountCorrect
            // 
            this.questionCountCorrect.AutoSize = true;
            this.questionCountCorrect.Location = new System.Drawing.Point(137, 13);
            this.questionCountCorrect.Name = "questionCountCorrect";
            this.questionCountCorrect.Size = new System.Drawing.Size(88, 13);
            this.questionCountCorrect.TabIndex = 1;
            this.questionCountCorrect.Text = "Fragen Richtig: 0";
            // 
            // questionCountWrong
            // 
            this.questionCountWrong.AutoSize = true;
            this.questionCountWrong.Location = new System.Drawing.Point(231, 13);
            this.questionCountWrong.Name = "questionCountWrong";
            this.questionCountWrong.Size = new System.Drawing.Size(86, 13);
            this.questionCountWrong.TabIndex = 2;
            this.questionCountWrong.Text = "Fragen Falsch: 0";
            // 
            // questionCountSkipped
            // 
            this.questionCountSkipped.AutoSize = true;
            this.questionCountSkipped.Location = new System.Drawing.Point(323, 13);
            this.questionCountSkipped.Name = "questionCountSkipped";
            this.questionCountSkipped.Size = new System.Drawing.Size(120, 13);
            this.questionCountSkipped.TabIndex = 3;
            this.questionCountSkipped.Text = "Fragen übersprungen: 0";
            // 
            // buttonSkipQuestion
            // 
            this.buttonSkipQuestion.Location = new System.Drawing.Point(457, 8);
            this.buttonSkipQuestion.Name = "buttonSkipQuestion";
            this.buttonSkipQuestion.Size = new System.Drawing.Size(149, 23);
            this.buttonSkipQuestion.TabIndex = 4;
            this.buttonSkipQuestion.Text = "Frage überspringen";
            this.buttonSkipQuestion.UseVisualStyleBackColor = true;
            this.buttonSkipQuestion.Click += new System.EventHandler(this.buttonSkipQuestion_Click);
            // 
            // questionCurrentQuestion
            // 
            this.questionCurrentQuestion.AutoSize = true;
            this.questionCurrentQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionCurrentQuestion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionCurrentQuestion.Location = new System.Drawing.Point(16, 54);
            this.questionCurrentQuestion.MaximumSize = new System.Drawing.Size(590, 70);
            this.questionCurrentQuestion.MinimumSize = new System.Drawing.Size(590, 70);
            this.questionCurrentQuestion.Name = "questionCurrentQuestion";
            this.questionCurrentQuestion.Size = new System.Drawing.Size(590, 70);
            this.questionCurrentQuestion.TabIndex = 5;
            this.questionCurrentQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.questionCurrentQuestion.Click += new System.EventHandler(this.label1_Click);
            // 
            // questionAnswerA
            // 
            this.questionAnswerA.Location = new System.Drawing.Point(16, 136);
            this.questionAnswerA.MaximumSize = new System.Drawing.Size(285, 48);
            this.questionAnswerA.MinimumSize = new System.Drawing.Size(285, 48);
            this.questionAnswerA.Name = "questionAnswerA";
            this.questionAnswerA.Size = new System.Drawing.Size(285, 48);
            this.questionAnswerA.TabIndex = 6;
            this.questionAnswerA.UseVisualStyleBackColor = true;
            // 
            // questionAnswerB
            // 
            this.questionAnswerB.Location = new System.Drawing.Point(321, 136);
            this.questionAnswerB.MaximumSize = new System.Drawing.Size(285, 48);
            this.questionAnswerB.MinimumSize = new System.Drawing.Size(285, 48);
            this.questionAnswerB.Name = "questionAnswerB";
            this.questionAnswerB.Size = new System.Drawing.Size(285, 48);
            this.questionAnswerB.TabIndex = 7;
            this.questionAnswerB.UseVisualStyleBackColor = true;
            // 
            // questionAnswerD
            // 
            this.questionAnswerD.Location = new System.Drawing.Point(321, 190);
            this.questionAnswerD.MaximumSize = new System.Drawing.Size(285, 48);
            this.questionAnswerD.MinimumSize = new System.Drawing.Size(285, 48);
            this.questionAnswerD.Name = "questionAnswerD";
            this.questionAnswerD.Size = new System.Drawing.Size(285, 48);
            this.questionAnswerD.TabIndex = 9;
            this.questionAnswerD.UseVisualStyleBackColor = true;
            // 
            // questionAnswerC
            // 
            this.questionAnswerC.Location = new System.Drawing.Point(16, 190);
            this.questionAnswerC.MaximumSize = new System.Drawing.Size(285, 48);
            this.questionAnswerC.MinimumSize = new System.Drawing.Size(285, 48);
            this.questionAnswerC.Name = "questionAnswerC";
            this.questionAnswerC.Size = new System.Drawing.Size(285, 48);
            this.questionAnswerC.TabIndex = 8;
            this.questionAnswerC.UseVisualStyleBackColor = true;
            // 
            // QuizWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 254);
            this.Controls.Add(this.questionAnswerD);
            this.Controls.Add(this.questionAnswerC);
            this.Controls.Add(this.questionAnswerB);
            this.Controls.Add(this.questionAnswerA);
            this.Controls.Add(this.questionCurrentQuestion);
            this.Controls.Add(this.buttonSkipQuestion);
            this.Controls.Add(this.questionCountSkipped);
            this.Controls.Add(this.questionCountWrong);
            this.Controls.Add(this.questionCountCorrect);
            this.Controls.Add(this.qustionCount);
            this.Name = "QuizWindow";
            this.Text = "QuizWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label qustionCount;
        private System.Windows.Forms.Label questionCountCorrect;
        private System.Windows.Forms.Label questionCountWrong;
        private System.Windows.Forms.Label questionCountSkipped;
        private System.Windows.Forms.Button buttonSkipQuestion;
        private System.Windows.Forms.Label questionCurrentQuestion;
        private System.Windows.Forms.Button questionAnswerA;
        private System.Windows.Forms.Button questionAnswerB;
        private System.Windows.Forms.Button questionAnswerD;
        private System.Windows.Forms.Button questionAnswerC;
    }
}