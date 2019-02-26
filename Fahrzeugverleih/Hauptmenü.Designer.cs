namespace Fahrzeugverleih
{
    partial class HauptmenüForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.fahrzeugErstellenButton = new System.Windows.Forms.Button();
            this.fahrzeugeListBox = new System.Windows.Forms.ListBox();
            this.fahrzeugLöschenButton = new System.Windows.Forms.Button();
            this.sucheTextBox = new System.Windows.Forms.TextBox();
            this.sucheLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fahrzeugErstellenButton
            // 
            this.fahrzeugErstellenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrzeugErstellenButton.Location = new System.Drawing.Point(403, 360);
            this.fahrzeugErstellenButton.Name = "fahrzeugErstellenButton";
            this.fahrzeugErstellenButton.Size = new System.Drawing.Size(140, 34);
            this.fahrzeugErstellenButton.TabIndex = 0;
            this.fahrzeugErstellenButton.Text = "Fahrzeug erstellen";
            this.fahrzeugErstellenButton.UseVisualStyleBackColor = true;
            this.fahrzeugErstellenButton.Click += new System.EventHandler(this.fahrzeugErstellenButton_Click);
            // 
            // fahrzeugeListBox
            // 
            this.fahrzeugeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrzeugeListBox.FormattingEnabled = true;
            this.fahrzeugeListBox.ItemHeight = 18;
            this.fahrzeugeListBox.Location = new System.Drawing.Point(6, 12);
            this.fahrzeugeListBox.Name = "fahrzeugeListBox";
            this.fahrzeugeListBox.Size = new System.Drawing.Size(245, 382);
            this.fahrzeugeListBox.TabIndex = 1;
            this.fahrzeugeListBox.DoubleClick += new System.EventHandler(this.fahrzeugeListBox_DoubleClick);
            // 
            // fahrzeugLöschenButton
            // 
            this.fahrzeugLöschenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrzeugLöschenButton.Location = new System.Drawing.Point(257, 360);
            this.fahrzeugLöschenButton.Name = "fahrzeugLöschenButton";
            this.fahrzeugLöschenButton.Size = new System.Drawing.Size(140, 34);
            this.fahrzeugLöschenButton.TabIndex = 2;
            this.fahrzeugLöschenButton.Text = "Fahrzeug löschen";
            this.fahrzeugLöschenButton.UseVisualStyleBackColor = true;
            // 
            // sucheTextBox
            // 
            this.sucheTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucheTextBox.Location = new System.Drawing.Point(257, 37);
            this.sucheTextBox.Name = "sucheTextBox";
            this.sucheTextBox.Size = new System.Drawing.Size(286, 26);
            this.sucheTextBox.TabIndex = 3;
            this.sucheTextBox.TextChanged += new System.EventHandler(this.sucheTextBox_TextChanged);
            // 
            // sucheLabel
            // 
            this.sucheLabel.AutoSize = true;
            this.sucheLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucheLabel.Location = new System.Drawing.Point(256, 16);
            this.sucheLabel.Name = "sucheLabel";
            this.sucheLabel.Size = new System.Drawing.Size(143, 18);
            this.sucheLabel.TabIndex = 4;
            this.sucheLabel.Text = "Kennzeichen Suche:";
            // 
            // HauptmenüForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 401);
            this.Controls.Add(this.sucheLabel);
            this.Controls.Add(this.sucheTextBox);
            this.Controls.Add(this.fahrzeugLöschenButton);
            this.Controls.Add(this.fahrzeugeListBox);
            this.Controls.Add(this.fahrzeugErstellenButton);
            this.Name = "HauptmenüForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Verleih Hauptmenü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HauptmenüForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fahrzeugErstellenButton;
        private System.Windows.Forms.ListBox fahrzeugeListBox;
        private System.Windows.Forms.Button fahrzeugLöschenButton;
        private System.Windows.Forms.TextBox sucheTextBox;
        private System.Windows.Forms.Label sucheLabel;
    }
}

