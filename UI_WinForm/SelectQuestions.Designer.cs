namespace UI_WinForm
{
    partial class SelectQuestions
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
            this.lblSelectQuestions = new System.Windows.Forms.Label();
            this.txtBoxNrQuestions = new System.Windows.Forms.TextBox();
            this.btStartQuiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectQuestions
            // 
            this.lblSelectQuestions.AutoSize = true;
            this.lblSelectQuestions.ForeColor = System.Drawing.Color.White;
            this.lblSelectQuestions.Location = new System.Drawing.Point(321, 104);
            this.lblSelectQuestions.Name = "lblSelectQuestions";
            this.lblSelectQuestions.Size = new System.Drawing.Size(0, 16);
            this.lblSelectQuestions.TabIndex = 0;
            // 
            // txtBoxNrQuestions
            // 
            this.txtBoxNrQuestions.BackColor = System.Drawing.Color.White;
            this.txtBoxNrQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNrQuestions.ForeColor = System.Drawing.Color.Black;
            this.txtBoxNrQuestions.Location = new System.Drawing.Point(318, 134);
            this.txtBoxNrQuestions.Name = "txtBoxNrQuestions";
            this.txtBoxNrQuestions.Size = new System.Drawing.Size(66, 15);
            this.txtBoxNrQuestions.TabIndex = 1;
            this.txtBoxNrQuestions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btStartQuiz
            // 
            this.btStartQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btStartQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStartQuiz.Location = new System.Drawing.Point(302, 173);
            this.btStartQuiz.Name = "btStartQuiz";
            this.btStartQuiz.Size = new System.Drawing.Size(81, 46);
            this.btStartQuiz.TabIndex = 2;
            this.btStartQuiz.Text = "Start Quiz";
            this.btStartQuiz.UseVisualStyleBackColor = false;
            this.btStartQuiz.Click += new System.EventHandler(this.btStartQuiz_Click);
            // 
            // SelectQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btStartQuiz);
            this.Controls.Add(this.txtBoxNrQuestions);
            this.Controls.Add(this.lblSelectQuestions);
            this.Name = "SelectQuestions";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectQuestions;
        private System.Windows.Forms.TextBox txtBoxNrQuestions;
        private System.Windows.Forms.Button btStartQuiz;
    }
}