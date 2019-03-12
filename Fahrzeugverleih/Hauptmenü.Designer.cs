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
            this.fahrzeugLöschenButton = new System.Windows.Forms.Button();
            this.sucheTextBox = new System.Windows.Forms.TextBox();
            this.sucheLabel = new System.Windows.Forms.Label();
            this.parkhäuserListBox = new System.Windows.Forms.ListBox();
            this.parkhausLöschenButton = new System.Windows.Forms.Button();
            this.parkhausErstellenButton = new System.Windows.Forms.Button();
            this.parkhäuserGroupBox = new System.Windows.Forms.GroupBox();
            this.fahrzeugeListBox = new System.Windows.Forms.ListBox();
            this.fahrzeugeGroupBox = new System.Windows.Forms.GroupBox();
            this.parkhäuserGroupBox.SuspendLayout();
            this.fahrzeugeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fahrzeugErstellenButton
            // 
            this.fahrzeugErstellenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrzeugErstellenButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fahrzeugErstellenButton.Location = new System.Drawing.Point(257, 307);
            this.fahrzeugErstellenButton.Name = "fahrzeugErstellenButton";
            this.fahrzeugErstellenButton.Size = new System.Drawing.Size(140, 34);
            this.fahrzeugErstellenButton.TabIndex = 0;
            this.fahrzeugErstellenButton.Text = "Fahrzeug erstellen";
            this.fahrzeugErstellenButton.UseVisualStyleBackColor = true;
            this.fahrzeugErstellenButton.Click += new System.EventHandler(this.fahrzeugErstellenButton_Click);
            // 
            // fahrzeugLöschenButton
            // 
            this.fahrzeugLöschenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrzeugLöschenButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fahrzeugLöschenButton.Location = new System.Drawing.Point(257, 347);
            this.fahrzeugLöschenButton.Name = "fahrzeugLöschenButton";
            this.fahrzeugLöschenButton.Size = new System.Drawing.Size(140, 34);
            this.fahrzeugLöschenButton.TabIndex = 2;
            this.fahrzeugLöschenButton.Text = "Fahrzeug löschen";
            this.fahrzeugLöschenButton.UseVisualStyleBackColor = true;
            this.fahrzeugLöschenButton.Click += new System.EventHandler(this.fahrzeugLöschenButton_Click);
            // 
            // sucheTextBox
            // 
            this.sucheTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucheTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sucheTextBox.Location = new System.Drawing.Point(257, 38);
            this.sucheTextBox.Name = "sucheTextBox";
            this.sucheTextBox.Size = new System.Drawing.Size(140, 26);
            this.sucheTextBox.TabIndex = 3;
            this.sucheTextBox.TextChanged += new System.EventHandler(this.sucheTextBox_TextChanged);
            // 
            // sucheLabel
            // 
            this.sucheLabel.AutoSize = true;
            this.sucheLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucheLabel.Location = new System.Drawing.Point(257, 17);
            this.sucheLabel.Name = "sucheLabel";
            this.sucheLabel.Size = new System.Drawing.Size(143, 18);
            this.sucheLabel.TabIndex = 4;
            this.sucheLabel.Text = "Kennzeichen Suche:";
            // 
            // parkhäuserListBox
            // 
            this.parkhäuserListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkhäuserListBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.parkhäuserListBox.FormattingEnabled = true;
            this.parkhäuserListBox.ItemHeight = 18;
            this.parkhäuserListBox.Location = new System.Drawing.Point(152, 17);
            this.parkhäuserListBox.Name = "parkhäuserListBox";
            this.parkhäuserListBox.Size = new System.Drawing.Size(245, 364);
            this.parkhäuserListBox.TabIndex = 5;
            // 
            // parkhausLöschenButton
            // 
            this.parkhausLöschenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkhausLöschenButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.parkhausLöschenButton.Location = new System.Drawing.Point(6, 347);
            this.parkhausLöschenButton.Name = "parkhausLöschenButton";
            this.parkhausLöschenButton.Size = new System.Drawing.Size(140, 34);
            this.parkhausLöschenButton.TabIndex = 8;
            this.parkhausLöschenButton.Text = "Parkhaus löschen";
            this.parkhausLöschenButton.UseVisualStyleBackColor = true;
            // 
            // parkhausErstellenButton
            // 
            this.parkhausErstellenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkhausErstellenButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.parkhausErstellenButton.Location = new System.Drawing.Point(6, 307);
            this.parkhausErstellenButton.Name = "parkhausErstellenButton";
            this.parkhausErstellenButton.Size = new System.Drawing.Size(140, 34);
            this.parkhausErstellenButton.TabIndex = 9;
            this.parkhausErstellenButton.Text = "Parkhaus erstellen";
            this.parkhausErstellenButton.UseVisualStyleBackColor = true;
            // 
            // parkhäuserGroupBox
            // 
            this.parkhäuserGroupBox.BackColor = System.Drawing.Color.Crimson;
            this.parkhäuserGroupBox.Controls.Add(this.parkhausErstellenButton);
            this.parkhäuserGroupBox.Controls.Add(this.parkhausLöschenButton);
            this.parkhäuserGroupBox.Controls.Add(this.parkhäuserListBox);
            this.parkhäuserGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.parkhäuserGroupBox.Location = new System.Drawing.Point(435, 12);
            this.parkhäuserGroupBox.Name = "parkhäuserGroupBox";
            this.parkhäuserGroupBox.Size = new System.Drawing.Size(417, 387);
            this.parkhäuserGroupBox.TabIndex = 10;
            this.parkhäuserGroupBox.TabStop = false;
            this.parkhäuserGroupBox.Text = "Parkhäuser";
            // 
            // fahrzeugeListBox
            // 
            this.fahrzeugeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrzeugeListBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fahrzeugeListBox.FormattingEnabled = true;
            this.fahrzeugeListBox.ItemHeight = 18;
            this.fahrzeugeListBox.Location = new System.Drawing.Point(6, 17);
            this.fahrzeugeListBox.Name = "fahrzeugeListBox";
            this.fahrzeugeListBox.Size = new System.Drawing.Size(245, 364);
            this.fahrzeugeListBox.TabIndex = 1;
            this.fahrzeugeListBox.DoubleClick += new System.EventHandler(this.fahrzeugeListBox_DoubleClick);
            // 
            // fahrzeugeGroupBox
            // 
            this.fahrzeugeGroupBox.BackColor = System.Drawing.Color.Goldenrod;
            this.fahrzeugeGroupBox.Controls.Add(this.fahrzeugeListBox);
            this.fahrzeugeGroupBox.Controls.Add(this.fahrzeugErstellenButton);
            this.fahrzeugeGroupBox.Controls.Add(this.fahrzeugLöschenButton);
            this.fahrzeugeGroupBox.Controls.Add(this.sucheLabel);
            this.fahrzeugeGroupBox.Controls.Add(this.sucheTextBox);
            this.fahrzeugeGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fahrzeugeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.fahrzeugeGroupBox.Name = "fahrzeugeGroupBox";
            this.fahrzeugeGroupBox.Size = new System.Drawing.Size(417, 387);
            this.fahrzeugeGroupBox.TabIndex = 11;
            this.fahrzeugeGroupBox.TabStop = false;
            this.fahrzeugeGroupBox.Text = "Fahrzeuge";
            // 
            // HauptmenüForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(861, 407);
            this.Controls.Add(this.fahrzeugeGroupBox);
            this.Controls.Add(this.parkhäuserGroupBox);
            this.Name = "HauptmenüForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Verleih Hauptmenü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HauptmenüForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.parkhäuserGroupBox.ResumeLayout(false);
            this.fahrzeugeGroupBox.ResumeLayout(false);
            this.fahrzeugeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fahrzeugErstellenButton;
        private System.Windows.Forms.Button fahrzeugLöschenButton;
        private System.Windows.Forms.TextBox sucheTextBox;
        private System.Windows.Forms.Label sucheLabel;
        private System.Windows.Forms.ListBox parkhäuserListBox;
        private System.Windows.Forms.Button parkhausLöschenButton;
        private System.Windows.Forms.Button parkhausErstellenButton;
        private System.Windows.Forms.GroupBox parkhäuserGroupBox;
        private System.Windows.Forms.ListBox fahrzeugeListBox;
        private System.Windows.Forms.GroupBox fahrzeugeGroupBox;
    }
}

