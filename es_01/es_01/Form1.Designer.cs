namespace es_01
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.txt_daPassare = new System.Windows.Forms.TextBox();
            this.bnt_3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(57, 49);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(87, 59);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "apri form f2";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(57, 129);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(87, 59);
            this.btn_2.TabIndex = 1;
            this.btn_2.Text = "apri f2";
            this.btn_2.UseVisualStyleBackColor = true;
            // 
            // txt_daPassare
            // 
            this.txt_daPassare.Location = new System.Drawing.Point(57, 210);
            this.txt_daPassare.Name = "txt_daPassare";
            this.txt_daPassare.Size = new System.Drawing.Size(100, 20);
            this.txt_daPassare.TabIndex = 2;
            // 
            // bnt_3
            // 
            this.bnt_3.Location = new System.Drawing.Point(57, 236);
            this.bnt_3.Name = "bnt_3";
            this.bnt_3.Size = new System.Drawing.Size(87, 59);
            this.bnt_3.TabIndex = 3;
            this.bnt_3.Text = "pasa text box a f2";
            this.bnt_3.UseVisualStyleBackColor = true;
            this.bnt_3.Click += new System.EventHandler(this.bnt_3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 350);
            this.Controls.Add(this.bnt_3);
            this.Controls.Add(this.txt_daPassare);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.TextBox txt_daPassare;
        private System.Windows.Forms.Button bnt_3;
    }
}

