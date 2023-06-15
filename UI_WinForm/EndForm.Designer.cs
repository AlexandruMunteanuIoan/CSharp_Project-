namespace UI_WinForm
{
    partial class EndForm
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
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblScor = new System.Windows.Forms.Label();
            this.btEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(345, 43);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(0, 16);
            this.lblEnd.TabIndex = 0;
            this.lblEnd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblScor
            // 
            this.lblScor.AutoSize = true;
            this.lblScor.Location = new System.Drawing.Point(242, 166);
            this.lblScor.Name = "lblScor";
            this.lblScor.Size = new System.Drawing.Size(0, 16);
            this.lblScor.TabIndex = 1;
            this.lblScor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btEnd
            // 
            this.btEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEnd.Location = new System.Drawing.Point(531, 188);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(75, 23);
            this.btEnd.TabIndex = 2;
            this.btEnd.Text = "END";
            this.btEnd.UseVisualStyleBackColor = false;
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click);
            // 
            // EndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.lblScor);
            this.Controls.Add(this.lblEnd);
            this.Name = "EndForm";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblScor;
        private System.Windows.Forms.Button btEnd;
    }
}