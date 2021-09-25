namespace es_01
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnF2_1 = new System.Windows.Forms.Button();
            this.txt_f2 = new System.Windows.Forms.TextBox();
            this.btnf2_2 = new System.Windows.Forms.Button();
            this.btnF2_apriFiglia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SONO LA FORM 2";
            // 
            // btnF2_1
            // 
            this.btnF2_1.Location = new System.Drawing.Point(42, 85);
            this.btnF2_1.Name = "btnF2_1";
            this.btnF2_1.Size = new System.Drawing.Size(107, 36);
            this.btnF2_1.TabIndex = 1;
            this.btnF2_1.Text = "leggi valore del txt";
            this.btnF2_1.UseVisualStyleBackColor = true;
            this.btnF2_1.Click += new System.EventHandler(this.btnF2_1_Click);
            // 
            // txt_f2
            // 
            this.txt_f2.Location = new System.Drawing.Point(42, 183);
            this.txt_f2.Name = "txt_f2";
            this.txt_f2.Size = new System.Drawing.Size(107, 20);
            this.txt_f2.TabIndex = 2;
            this.txt_f2.TextChanged += new System.EventHandler(this.txt_f2_TextChanged);
            // 
            // btnf2_2
            // 
            this.btnf2_2.Location = new System.Drawing.Point(42, 127);
            this.btnf2_2.Name = "btnf2_2";
            this.btnf2_2.Size = new System.Drawing.Size(107, 36);
            this.btnf2_2.TabIndex = 3;
            this.btnf2_2.Text = "invia a f1";
            this.btnf2_2.UseVisualStyleBackColor = true;
            this.btnf2_2.Click += new System.EventHandler(this.btnf2_2_Click);
            // 
            // btnF2_apriFiglia
            // 
            this.btnF2_apriFiglia.Location = new System.Drawing.Point(42, 223);
            this.btnF2_apriFiglia.Name = "btnF2_apriFiglia";
            this.btnF2_apriFiglia.Size = new System.Drawing.Size(107, 55);
            this.btnF2_apriFiglia.TabIndex = 4;
            this.btnF2_apriFiglia.Text = "apri form figlia";
            this.btnF2_apriFiglia.UseVisualStyleBackColor = true;
            this.btnF2_apriFiglia.Click += new System.EventHandler(this.btnF2_apriFiglia_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 281);
            this.Controls.Add(this.btnF2_apriFiglia);
            this.Controls.Add(this.btnf2_2);
            this.Controls.Add(this.txt_f2);
            this.Controls.Add(this.btnF2_1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnF2_1;
        private System.Windows.Forms.TextBox txt_f2;
        private System.Windows.Forms.Button btnf2_2;
        private System.Windows.Forms.Button btnF2_apriFiglia;
    }
}