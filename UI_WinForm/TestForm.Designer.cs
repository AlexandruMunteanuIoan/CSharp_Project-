namespace UI_WinForm
{
    partial class TestForm
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btAnswer1 = new System.Windows.Forms.Button();
            this.btAnswer2 = new System.Windows.Forms.Button();
            this.btAnswer3 = new System.Windows.Forms.Button();
            this.btAnswer4 = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(360, 68);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(44, 16);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "label1";;
            // 
            // btAnswer1
            // 
            this.btAnswer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btAnswer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnswer1.Location = new System.Drawing.Point(175, 119);
            this.btAnswer1.Name = "btAnswer1";
            this.btAnswer1.Size = new System.Drawing.Size(75, 23);
            this.btAnswer1.TabIndex = 1;
            this.btAnswer1.Text = "button1";
            this.btAnswer1.UseVisualStyleBackColor = false;
            this.btAnswer1.Click += new System.EventHandler(this.btAnswer1_Click);
            // 
            // btAnswer2
            // 
            this.btAnswer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btAnswer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnswer2.Location = new System.Drawing.Point(548, 137);
            this.btAnswer2.Name = "btAnswer2";
            this.btAnswer2.Size = new System.Drawing.Size(75, 23);
            this.btAnswer2.TabIndex = 2;
            this.btAnswer2.Text = "button2";
            this.btAnswer2.UseVisualStyleBackColor = false;
            this.btAnswer2.Click += new System.EventHandler(this.btAnswer2_Click);
            // 
            // btAnswer3
            // 
            this.btAnswer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btAnswer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnswer3.Location = new System.Drawing.Point(72, 224);
            this.btAnswer3.Name = "btAnswer3";
            this.btAnswer3.Size = new System.Drawing.Size(112, 52);
            this.btAnswer3.TabIndex = 3;
            this.btAnswer3.Text = "button3";
            this.btAnswer3.UseVisualStyleBackColor = false;
            this.btAnswer3.Click += new System.EventHandler(this.btAnswer3_Click);
            // 
            // btAnswer4
            // 
            this.btAnswer4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btAnswer4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnswer4.Location = new System.Drawing.Point(582, 224);
            this.btAnswer4.Name = "btAnswer4";
            this.btAnswer4.Size = new System.Drawing.Size(75, 23);
            this.btAnswer4.TabIndex = 4;
            this.btAnswer4.Text = "button4";
            this.btAnswer4.UseVisualStyleBackColor = false;
            this.btAnswer4.Click += new System.EventHandler(this.btAnswer4_Click);
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNext.Location = new System.Drawing.Point(598, 320);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(117, 46);
            this.btNext.TabIndex = 5;
            this.btNext.Text = "button5";
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext5_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btAnswer4);
            this.Controls.Add(this.btAnswer3);
            this.Controls.Add(this.btAnswer2);
            this.Controls.Add(this.btAnswer1);
            this.Controls.Add(this.lblQuestion);
            this.Name = "TestForm";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btAnswer1;
        private System.Windows.Forms.Button btAnswer2;
        private System.Windows.Forms.Button btAnswer3;
        private System.Windows.Forms.Button btAnswer4;
        private System.Windows.Forms.Button btNext;
    }
}