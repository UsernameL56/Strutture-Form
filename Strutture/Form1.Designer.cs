namespace Strutture
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
            this.Nome = new System.Windows.Forms.TextBox();
            this.Prezzo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Salva = new System.Windows.Forms.Button();
            this.Cancellazione = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Update = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Somma = new System.Windows.Forms.Button();
            this.Percentuale = new System.Windows.Forms.Button();
            this.File = new System.Windows.Forms.Button();
            this.MaxMin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(110, 76);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(100, 20);
            this.Nome.TabIndex = 0;
            // 
            // Prezzo
            // 
            this.Prezzo.Location = new System.Drawing.Point(266, 76);
            this.Prezzo.Name = "Prezzo";
            this.Prezzo.Size = new System.Drawing.Size(100, 20);
            this.Prezzo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezzo";
            // 
            // Salva
            // 
            this.Salva.Location = new System.Drawing.Point(110, 204);
            this.Salva.Name = "Salva";
            this.Salva.Size = new System.Drawing.Size(75, 23);
            this.Salva.TabIndex = 4;
            this.Salva.Text = "Salva";
            this.Salva.UseVisualStyleBackColor = true;
            this.Salva.Click += new System.EventHandler(this.Salva_Click);
            // 
            // Cancellazione
            // 
            this.Cancellazione.Location = new System.Drawing.Point(191, 204);
            this.Cancellazione.Name = "Cancellazione";
            this.Cancellazione.Size = new System.Drawing.Size(75, 23);
            this.Cancellazione.TabIndex = 5;
            this.Cancellazione.Text = "Cancella";
            this.Cancellazione.UseVisualStyleBackColor = true;
            this.Cancellazione.Click += new System.EventHandler(this.Cancellazione_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.SkyBlue;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(502, 60);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(273, 355);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(272, 204);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 7;
            this.Update.Text = "Modifica";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Modifica";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(266, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(263, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Percentuale";
            // 
            // Somma
            // 
            this.Somma.Location = new System.Drawing.Point(110, 248);
            this.Somma.Name = "Somma";
            this.Somma.Size = new System.Drawing.Size(75, 23);
            this.Somma.TabIndex = 13;
            this.Somma.Text = "Somma";
            this.Somma.UseVisualStyleBackColor = true;
            this.Somma.Click += new System.EventHandler(this.Somma_Click);
            // 
            // Percentuale
            // 
            this.Percentuale.Location = new System.Drawing.Point(191, 248);
            this.Percentuale.Name = "Percentuale";
            this.Percentuale.Size = new System.Drawing.Size(75, 23);
            this.Percentuale.TabIndex = 14;
            this.Percentuale.Text = "Percentuale";
            this.Percentuale.UseVisualStyleBackColor = true;
            // 
            // File
            // 
            this.File.Location = new System.Drawing.Point(273, 248);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(75, 23);
            this.File.TabIndex = 15;
            this.File.Text = "File";
            this.File.UseVisualStyleBackColor = true;
            this.File.Click += new System.EventHandler(this.File_Click);
            // 
            // MaxMin
            // 
            this.MaxMin.Location = new System.Drawing.Point(113, 289);
            this.MaxMin.Name = "MaxMin";
            this.MaxMin.Size = new System.Drawing.Size(75, 23);
            this.MaxMin.TabIndex = 16;
            this.MaxMin.Text = "Max-Min";
            this.MaxMin.UseVisualStyleBackColor = true;
            this.MaxMin.Click += new System.EventHandler(this.MaxMin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(835, 474);
            this.Controls.Add(this.MaxMin);
            this.Controls.Add(this.File);
            this.Controls.Add(this.Percentuale);
            this.Controls.Add(this.Somma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Cancellazione);
            this.Controls.Add(this.Salva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prezzo);
            this.Controls.Add(this.Nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Prezzo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Salva;
        private System.Windows.Forms.Button Cancellazione;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Somma;
        private System.Windows.Forms.Button Percentuale;
        private System.Windows.Forms.Button File;
        private System.Windows.Forms.Button MaxMin;
    }
}

