namespace Ковалёв_Н.ДЗ_Урок_7
{
    partial class Form2
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
            this.textBoxGuess = new System.Windows.Forms.TextBox();
            this.lblGuess = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxGuess
            // 
            this.textBoxGuess.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxGuess.Location = new System.Drawing.Point(102, 130);
            this.textBoxGuess.Name = "textBoxGuess";
            this.textBoxGuess.Size = new System.Drawing.Size(79, 20);
            this.textBoxGuess.TabIndex = 0;
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGuess.Location = new System.Drawing.Point(69, 59);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(136, 24);
            this.lblGuess.TabIndex = 1;
            this.lblGuess.Text = "Угадай число!";
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGuess.Location = new System.Drawing.Point(102, 156);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(79, 44);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Угадать";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCounter.Location = new System.Drawing.Point(69, 93);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(145, 20);
            this.lblCounter.TabIndex = 3;
            this.lblCounter.Text = "Счётчик попыток:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 231);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.textBoxGuess);
            this.Name = "Form2";
            this.Text = "Угадай число";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGuess;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblCounter;
    }
}