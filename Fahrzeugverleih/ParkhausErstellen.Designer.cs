namespace Fahrzeugverleih
{
    partial class ParkhausErstellen
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fahrzeugArtComboBox = new System.Windows.Forms.ComboBox();
            this.fahrzeugArtLabel = new System.Windows.Forms.Label();
            this.kennzeichenLabel = new System.Windows.Forms.Label();
            this.kennzeichenMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.herstellerLabel = new System.Windows.Forms.Label();
            this.herstellerComboBox = new System.Windows.Forms.ComboBox();
            this.modellLabel = new System.Windows.Forms.Label();
            this.modellTextBox = new System.Windows.Forms.TextBox();
            this.anschaffungspreisLabel = new System.Windows.Forms.Label();
            this.anschaffungspreisTextBox = new System.Windows.Forms.TextBox();
            this.zulassungsdatumLabel = new System.Windows.Forms.Label();
            this.zulassungsdatumMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fahrzeugSpeichernButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.fahrzeugArtComboBox, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.fahrzeugArtLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.kennzeichenLabel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.kennzeichenMaskedTextBox, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.herstellerLabel, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.herstellerComboBox, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.modellLabel, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.modellTextBox, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.anschaffungspreisLabel, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.anschaffungspreisTextBox, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.zulassungsdatumLabel, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.zulassungsdatumMaskedTextBox, 1, 5);
            this.tableLayoutPanel.Location = new System.Drawing.Point(18, 4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 9;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(384, 238);
            this.tableLayoutPanel.TabIndex = 20;
            // 
            // fahrzeugArtComboBox
            // 
            this.fahrzeugArtComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fahrzeugArtComboBox.FormattingEnabled = true;
            this.fahrzeugArtComboBox.Items.AddRange(new object[] {
            "PKW",
            "LKW",
            "Motorrad"});
            this.fahrzeugArtComboBox.Location = new System.Drawing.Point(195, 3);
            this.fahrzeugArtComboBox.Name = "fahrzeugArtComboBox";
            this.fahrzeugArtComboBox.Size = new System.Drawing.Size(186, 21);
            this.fahrzeugArtComboBox.TabIndex = 0;
            // 
            // fahrzeugArtLabel
            // 
            this.fahrzeugArtLabel.AutoSize = true;
            this.fahrzeugArtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrzeugArtLabel.Location = new System.Drawing.Point(3, 0);
            this.fahrzeugArtLabel.Name = "fahrzeugArtLabel";
            this.fahrzeugArtLabel.Size = new System.Drawing.Size(96, 18);
            this.fahrzeugArtLabel.TabIndex = 1;
            this.fahrzeugArtLabel.Text = "Fahrzeug Art:";
            // 
            // kennzeichenLabel
            // 
            this.kennzeichenLabel.AutoSize = true;
            this.kennzeichenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kennzeichenLabel.Location = new System.Drawing.Point(3, 27);
            this.kennzeichenLabel.Name = "kennzeichenLabel";
            this.kennzeichenLabel.Size = new System.Drawing.Size(97, 18);
            this.kennzeichenLabel.TabIndex = 2;
            this.kennzeichenLabel.Text = "Kennzeichen:";
            // 
            // kennzeichenMaskedTextBox
            // 
            this.kennzeichenMaskedTextBox.Location = new System.Drawing.Point(195, 30);
            this.kennzeichenMaskedTextBox.Mask = "L??-L? 0099";
            this.kennzeichenMaskedTextBox.Name = "kennzeichenMaskedTextBox";
            this.kennzeichenMaskedTextBox.Size = new System.Drawing.Size(186, 20);
            this.kennzeichenMaskedTextBox.TabIndex = 3;
            // 
            // herstellerLabel
            // 
            this.herstellerLabel.AutoSize = true;
            this.herstellerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.herstellerLabel.Location = new System.Drawing.Point(3, 54);
            this.herstellerLabel.Name = "herstellerLabel";
            this.herstellerLabel.Size = new System.Drawing.Size(75, 18);
            this.herstellerLabel.TabIndex = 4;
            this.herstellerLabel.Text = "Hersteller:";
            // 
            // herstellerComboBox
            // 
            this.herstellerComboBox.FormattingEnabled = true;
            this.herstellerComboBox.Location = new System.Drawing.Point(195, 57);
            this.herstellerComboBox.Name = "herstellerComboBox";
            this.herstellerComboBox.Size = new System.Drawing.Size(186, 21);
            this.herstellerComboBox.TabIndex = 5;
            // 
            // modellLabel
            // 
            this.modellLabel.AutoSize = true;
            this.modellLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modellLabel.Location = new System.Drawing.Point(3, 80);
            this.modellLabel.Name = "modellLabel";
            this.modellLabel.Size = new System.Drawing.Size(56, 18);
            this.modellLabel.TabIndex = 6;
            this.modellLabel.Text = "Modell:";
            // 
            // modellTextBox
            // 
            this.modellTextBox.Location = new System.Drawing.Point(195, 83);
            this.modellTextBox.Name = "modellTextBox";
            this.modellTextBox.Size = new System.Drawing.Size(186, 20);
            this.modellTextBox.TabIndex = 7;
            // 
            // anschaffungspreisLabel
            // 
            this.anschaffungspreisLabel.AutoSize = true;
            this.anschaffungspreisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anschaffungspreisLabel.Location = new System.Drawing.Point(3, 106);
            this.anschaffungspreisLabel.Name = "anschaffungspreisLabel";
            this.anschaffungspreisLabel.Size = new System.Drawing.Size(170, 18);
            this.anschaffungspreisLabel.TabIndex = 8;
            this.anschaffungspreisLabel.Text = "Anschaffungspreis (in €):";
            // 
            // anschaffungspreisTextBox
            // 
            this.anschaffungspreisTextBox.Location = new System.Drawing.Point(195, 109);
            this.anschaffungspreisTextBox.Name = "anschaffungspreisTextBox";
            this.anschaffungspreisTextBox.Size = new System.Drawing.Size(186, 20);
            this.anschaffungspreisTextBox.TabIndex = 9;
            // 
            // zulassungsdatumLabel
            // 
            this.zulassungsdatumLabel.AutoSize = true;
            this.zulassungsdatumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zulassungsdatumLabel.Location = new System.Drawing.Point(3, 134);
            this.zulassungsdatumLabel.Name = "zulassungsdatumLabel";
            this.zulassungsdatumLabel.Size = new System.Drawing.Size(129, 18);
            this.zulassungsdatumLabel.TabIndex = 10;
            this.zulassungsdatumLabel.Text = "Zulassungsdatum:";
            // 
            // zulassungsdatumMaskedTextBox
            // 
            this.zulassungsdatumMaskedTextBox.Location = new System.Drawing.Point(195, 137);
            this.zulassungsdatumMaskedTextBox.Mask = "00/00/0000";
            this.zulassungsdatumMaskedTextBox.Name = "zulassungsdatumMaskedTextBox";
            this.zulassungsdatumMaskedTextBox.Size = new System.Drawing.Size(186, 20);
            this.zulassungsdatumMaskedTextBox.TabIndex = 11;
            this.zulassungsdatumMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // fahrzeugSpeichernButton
            // 
            this.fahrzeugSpeichernButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrzeugSpeichernButton.Location = new System.Drawing.Point(252, 248);
            this.fahrzeugSpeichernButton.Name = "fahrzeugSpeichernButton";
            this.fahrzeugSpeichernButton.Size = new System.Drawing.Size(150, 34);
            this.fahrzeugSpeichernButton.TabIndex = 30;
            this.fahrzeugSpeichernButton.Text = "Parkhaus speichern";
            this.fahrzeugSpeichernButton.UseVisualStyleBackColor = true;
            // 
            // ParkhausErstellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 301);
            this.Controls.Add(this.fahrzeugSpeichernButton);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "ParkhausErstellen";
            this.Text = "ParkhausErstellen";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.ComboBox fahrzeugArtComboBox;
        private System.Windows.Forms.Label fahrzeugArtLabel;
        private System.Windows.Forms.Label kennzeichenLabel;
        private System.Windows.Forms.MaskedTextBox kennzeichenMaskedTextBox;
        private System.Windows.Forms.Label herstellerLabel;
        private System.Windows.Forms.ComboBox herstellerComboBox;
        private System.Windows.Forms.Label modellLabel;
        private System.Windows.Forms.TextBox modellTextBox;
        private System.Windows.Forms.Label anschaffungspreisLabel;
        private System.Windows.Forms.TextBox anschaffungspreisTextBox;
        private System.Windows.Forms.Label zulassungsdatumLabel;
        private System.Windows.Forms.MaskedTextBox zulassungsdatumMaskedTextBox;
        private System.Windows.Forms.Button fahrzeugSpeichernButton;
    }
}