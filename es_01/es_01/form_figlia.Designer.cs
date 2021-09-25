namespace es_01
{
    partial class form_figlia
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
            this.btnF3_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnF3_1
            // 
            this.btnF3_1.Location = new System.Drawing.Point(21, 75);
            this.btnF3_1.Name = "btnF3_1";
            this.btnF3_1.Size = new System.Drawing.Size(122, 42);
            this.btnF3_1.TabIndex = 0;
            this.btnF3_1.Text = "di chi sono figlia?";
            this.btnF3_1.UseVisualStyleBackColor = true;
            this.btnF3_1.Click += new System.EventHandler(this.btnF3_1_Click);
            // 
            // form_figlia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 170);
            this.Controls.Add(this.btnF3_1);
            this.Name = "form_figlia";
            this.Text = "form_figlia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnF3_1;
    }
}