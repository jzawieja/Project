﻿namespace Snake
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
            this.playingfield = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.realscore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playingfield)).BeginInit();
            this.SuspendLayout();
            // 
            // playingfield
            // 
            this.playingfield.Location = new System.Drawing.Point(12, 12);
            this.playingfield.Name = "playingfield";
            this.playingfield.Size = new System.Drawing.Size(336, 336);
            this.playingfield.TabIndex = 0;
            this.playingfield.TabStop = false;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score.Location = new System.Drawing.Point(365, 21);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(89, 29);
            this.score.TabIndex = 1;
            this.score.Text = "Score:";
            // 
            // realscore
            // 
            this.realscore.AutoSize = true;
            this.realscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.realscore.Location = new System.Drawing.Point(467, 19);
            this.realscore.Name = "realscore";
            this.realscore.Size = new System.Drawing.Size(0, 29);
            this.realscore.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 360);
            this.Controls.Add(this.realscore);
            this.Controls.Add(this.score);
            this.Controls.Add(this.playingfield);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.playingfield)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playingfield;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label realscore;
    }
}
