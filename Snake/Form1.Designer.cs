namespace Snake
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Playing_field = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.RScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Playing_field)).BeginInit();
            this.SuspendLayout();
            // 
            // Playing_field
            // 
            this.Playing_field.Location = new System.Drawing.Point(12, 12);
            this.Playing_field.Name = "Playing_field";
            this.Playing_field.Size = new System.Drawing.Size(337, 312);
            this.Playing_field.TabIndex = 0;
            this.Playing_field.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Score.Location = new System.Drawing.Point(378, 20);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(82, 29);
            this.Score.TabIndex = 1;
            this.Score.Text = "Score";
            // 
            // RScore
            // 
            this.RScore.AutoSize = true;
            this.RScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RScore.Location = new System.Drawing.Point(466, 17);
            this.RScore.Name = "RScore";
            this.RScore.Size = new System.Drawing.Size(86, 31);
            this.RScore.TabIndex = 2;
            this.RScore.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 336);
            this.Controls.Add(this.RScore);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Playing_field);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Playing_field)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Playing_field;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label RScore;
    }
}

