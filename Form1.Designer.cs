namespace TCPKlient
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
            this.MyPort = new System.Windows.Forms.TextBox();
            this.tAdres = new System.Windows.Forms.TextBox();
            this.Info_o_polaczeniu = new System.Windows.Forms.ListBox();
            this.bPolacz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MyPort
            // 
            this.MyPort.Location = new System.Drawing.Point(442, 12);
            this.MyPort.MaxLength = 65535;
            this.MyPort.Name = "MyPort";
            this.MyPort.Size = new System.Drawing.Size(423, 20);
            this.MyPort.TabIndex = 0;
            this.MyPort.Text = "0";
            // 
            // tAdres
            // 
            this.tAdres.Location = new System.Drawing.Point(13, 12);
            this.tAdres.Name = "tAdres";
            this.tAdres.Size = new System.Drawing.Size(423, 20);
            this.tAdres.TabIndex = 1;
            this.tAdres.Text = "Adres";
            // 
            // Info_o_polaczeniu
            // 
            this.Info_o_polaczeniu.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Info_o_polaczeniu.FormattingEnabled = true;
            this.Info_o_polaczeniu.ItemHeight = 25;
            this.Info_o_polaczeniu.Location = new System.Drawing.Point(12, 60);
            this.Info_o_polaczeniu.Name = "Info_o_polaczeniu";
            this.Info_o_polaczeniu.Size = new System.Drawing.Size(853, 154);
            this.Info_o_polaczeniu.TabIndex = 2;
            // 
            // bPolacz
            // 
            this.bPolacz.Location = new System.Drawing.Point(347, 254);
            this.bPolacz.Name = "bPolacz";
            this.bPolacz.Size = new System.Drawing.Size(203, 53);
            this.bPolacz.TabIndex = 3;
            this.bPolacz.Text = "Połącz";
            this.bPolacz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 412);
            this.Controls.Add(this.bPolacz);
            this.Controls.Add(this.Info_o_polaczeniu);
            this.Controls.Add(this.tAdres);
            this.Controls.Add(this.MyPort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MyPort;
        private System.Windows.Forms.TextBox tAdres;
        private System.Windows.Forms.ListBox Info_o_polaczeniu;
        private System.Windows.Forms.Button bPolacz;
    }
}

