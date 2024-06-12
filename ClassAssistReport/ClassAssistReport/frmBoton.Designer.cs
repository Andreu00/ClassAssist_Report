namespace ClassAssistReport
{
    partial class frmBoton
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
            this.btnGInforme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGInforme
            // 
            this.btnGInforme.Location = new System.Drawing.Point(357, 193);
            this.btnGInforme.Name = "btnGInforme";
            this.btnGInforme.Size = new System.Drawing.Size(75, 23);
            this.btnGInforme.TabIndex = 0;
            this.btnGInforme.Text = "button1";
            this.btnGInforme.UseVisualStyleBackColor = true;
            this.btnGInforme.Click += new System.EventHandler(this.btnGInforme_Click);
            // 
            // frmBoton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGInforme);
            this.Name = "frmBoton";
            this.Text = "frmBoton";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGInforme;
    }
}