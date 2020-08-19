namespace CalcApp
{
    partial class FormCalculator
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
            this.numericUpDownTermen1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTermen2 = new System.Windows.Forms.NumericUpDown();
            this.buttonAdunare = new System.Windows.Forms.Button();
            this.buttonScadere = new System.Windows.Forms.Button();
            this.buttonInmultire = new System.Windows.Forms.Button();
            this.buttonImpartire = new System.Windows.Forms.Button();
            this.textBoxRezultat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTermen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTermen2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownTermen1
            // 
            this.numericUpDownTermen1.Location = new System.Drawing.Point(185, 132);
            this.numericUpDownTermen1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownTermen1.Name = "numericUpDownTermen1";
            this.numericUpDownTermen1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownTermen1.TabIndex = 0;
            // 
            // numericUpDownTermen2
            // 
            this.numericUpDownTermen2.Location = new System.Drawing.Point(414, 132);
            this.numericUpDownTermen2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownTermen2.Name = "numericUpDownTermen2";
            this.numericUpDownTermen2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownTermen2.TabIndex = 1;
            // 
            // buttonAdunare
            // 
            this.buttonAdunare.Location = new System.Drawing.Point(60, 214);
            this.buttonAdunare.Name = "buttonAdunare";
            this.buttonAdunare.Size = new System.Drawing.Size(75, 23);
            this.buttonAdunare.TabIndex = 2;
            this.buttonAdunare.Text = "Adunare";
            this.buttonAdunare.UseVisualStyleBackColor = true;
            this.buttonAdunare.Click += new System.EventHandler(this.buttonAdunare_Click);
            // 
            // buttonScadere
            // 
            this.buttonScadere.Location = new System.Drawing.Point(213, 214);
            this.buttonScadere.Name = "buttonScadere";
            this.buttonScadere.Size = new System.Drawing.Size(75, 23);
            this.buttonScadere.TabIndex = 3;
            this.buttonScadere.Text = "Scadere";
            this.buttonScadere.UseVisualStyleBackColor = true;
            this.buttonScadere.Click += new System.EventHandler(this.buttonScadere_Click);
            // 
            // buttonInmultire
            // 
            this.buttonInmultire.Location = new System.Drawing.Point(363, 214);
            this.buttonInmultire.Name = "buttonInmultire";
            this.buttonInmultire.Size = new System.Drawing.Size(75, 23);
            this.buttonInmultire.TabIndex = 4;
            this.buttonInmultire.Text = "Inmultire";
            this.buttonInmultire.UseVisualStyleBackColor = true;
            this.buttonInmultire.Click += new System.EventHandler(this.buttonInmultire_Click);
            // 
            // buttonImpartire
            // 
            this.buttonImpartire.Location = new System.Drawing.Point(518, 214);
            this.buttonImpartire.Name = "buttonImpartire";
            this.buttonImpartire.Size = new System.Drawing.Size(75, 23);
            this.buttonImpartire.TabIndex = 5;
            this.buttonImpartire.Text = "Impartire";
            this.buttonImpartire.UseVisualStyleBackColor = true;
            this.buttonImpartire.Click += new System.EventHandler(this.buttonImpartire_Click);
            // 
            // textBoxRezultat
            // 
            this.textBoxRezultat.Enabled = false;
            this.textBoxRezultat.Location = new System.Drawing.Point(185, 295);
            this.textBoxRezultat.Name = "textBoxRezultat";
            this.textBoxRezultat.Size = new System.Drawing.Size(349, 22);
            this.textBoxRezultat.TabIndex = 6;
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxRezultat);
            this.Controls.Add(this.buttonImpartire);
            this.Controls.Add(this.buttonInmultire);
            this.Controls.Add(this.buttonScadere);
            this.Controls.Add(this.buttonAdunare);
            this.Controls.Add(this.numericUpDownTermen2);
            this.Controls.Add(this.numericUpDownTermen1);
            this.Name = "FormCalculator";
            this.Text = "FormCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTermen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTermen2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownTermen1;
        private System.Windows.Forms.NumericUpDown numericUpDownTermen2;
        private System.Windows.Forms.Button buttonAdunare;
        private System.Windows.Forms.Button buttonScadere;
        private System.Windows.Forms.Button buttonInmultire;
        private System.Windows.Forms.Button buttonImpartire;
        private System.Windows.Forms.TextBox textBoxRezultat;
    }
}