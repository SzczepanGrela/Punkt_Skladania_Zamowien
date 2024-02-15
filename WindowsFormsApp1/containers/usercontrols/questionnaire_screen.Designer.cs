namespace WindowsFormsApp1.controls.usercontrols
{
    partial class Questionnaire_screen
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.AnswerPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QuestionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.QuestionLabel.Location = new System.Drawing.Point(0, 0);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(596, 108);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Text = "What category are you interested in?";
            this.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnswerPanel
            // 
            this.AnswerPanel.AutoScroll = true;
            this.AnswerPanel.BackColor = System.Drawing.Color.Olive;
            this.AnswerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnswerPanel.Location = new System.Drawing.Point(0, 108);
            this.AnswerPanel.Name = "AnswerPanel";
            this.AnswerPanel.Size = new System.Drawing.Size(596, 625);
            this.AnswerPanel.TabIndex = 1;
            // 
            // Questionnaire_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Controls.Add(this.AnswerPanel);
            this.Controls.Add(this.QuestionLabel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Questionnaire_screen";
            this.Size = new System.Drawing.Size(596, 733);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Panel AnswerPanel;
    }
}
