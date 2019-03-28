namespace Fahrzeugverleih
{
    partial class ParkhausForm
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
            this.ortLabel = new System.Windows.Forms.Label();
            this.plzLabel = new System.Windows.Forms.Label();
            this.plzMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.straßeLabel = new System.Windows.Forms.Label();
            this.ortTextBox = new System.Windows.Forms.TextBox();
            this.anschaffungspreisLabel = new System.Windows.Forms.Label();
            this.pkwParkplätzeTextBox = new System.Windows.Forms.TextBox();
            this.fahrzeugSpeichernButton = new System.Windows.Forms.Button();
            this.straßeTextBox = new System.Windows.Forms.TextBox();
            this.lkwParkplätzeLabel = new System.Windows.Forms.Label();
            this.motorradParktplätzeLabel = new System.Windows.Forms.Label();
            this.lkwParkplätzeTextBox = new System.Windows.Forms.TextBox();
            this.motorradParkplätzeTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.ortLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.plzLabel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.plzMaskedTextBox, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.straßeLabel, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.anschaffungspreisLabel, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.pkwParkplätzeTextBox, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.ortTextBox, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.straßeTextBox, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.lkwParkplätzeLabel, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.motorradParktplätzeLabel, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.lkwParkplätzeTextBox, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.motorradParkplätzeTextBox, 1, 6);
            this.tableLayoutPanel.Location = new System.Drawing.Point(18, 4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(384, 238);
            this.tableLayoutPanel.TabIndex = 20;
            // 
            // ortLabel
            // 
            this.ortLabel.AutoSize = true;
            this.ortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ortLabel.Location = new System.Drawing.Point(3, 0);
            this.ortLabel.Name = "ortLabel";
            this.ortLabel.Size = new System.Drawing.Size(33, 18);
            this.ortLabel.TabIndex = 1;
            this.ortLabel.Text = "Ort:";
            // 
            // plzLabel
            // 
            this.plzLabel.AutoSize = true;
            this.plzLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plzLabel.Location = new System.Drawing.Point(3, 28);
            this.plzLabel.Name = "plzLabel";
            this.plzLabel.Size = new System.Drawing.Size(39, 18);
            this.plzLabel.TabIndex = 2;
            this.plzLabel.Text = "PLZ:";
            // 
            // plzMaskedTextBox
            // 
            this.plzMaskedTextBox.Location = new System.Drawing.Point(195, 31);
            this.plzMaskedTextBox.Mask = "00000";
            this.plzMaskedTextBox.Name = "plzMaskedTextBox";
            this.plzMaskedTextBox.Size = new System.Drawing.Size(186, 20);
            this.plzMaskedTextBox.TabIndex = 1;
            // 
            // straßeLabel
            // 
            this.straßeLabel.AutoSize = true;
            this.straßeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.straßeLabel.Location = new System.Drawing.Point(3, 56);
            this.straßeLabel.Name = "straßeLabel";
            this.straßeLabel.Size = new System.Drawing.Size(56, 18);
            this.straßeLabel.TabIndex = 4;
            this.straßeLabel.Text = "Straße:";
            // 
            // ortTextBox
            // 
            this.ortTextBox.Location = new System.Drawing.Point(195, 3);
            this.ortTextBox.Name = "ortTextBox";
            this.ortTextBox.Size = new System.Drawing.Size(186, 20);
            this.ortTextBox.TabIndex = 0;
            // 
            // anschaffungspreisLabel
            // 
            this.anschaffungspreisLabel.AutoSize = true;
            this.anschaffungspreisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anschaffungspreisLabel.Location = new System.Drawing.Point(3, 116);
            this.anschaffungspreisLabel.Name = "anschaffungspreisLabel";
            this.anschaffungspreisLabel.Size = new System.Drawing.Size(165, 18);
            this.anschaffungspreisLabel.TabIndex = 8;
            this.anschaffungspreisLabel.Text = "Anzahl PKW Parkplätze";
            // 
            // pkwParkplätzeTextBox
            // 
            this.pkwParkplätzeTextBox.Location = new System.Drawing.Point(195, 119);
            this.pkwParkplätzeTextBox.Name = "pkwParkplätzeTextBox";
            this.pkwParkplätzeTextBox.Size = new System.Drawing.Size(186, 20);
            this.pkwParkplätzeTextBox.TabIndex = 3;
            // 
            // fahrzeugSpeichernButton
            // 
            this.fahrzeugSpeichernButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrzeugSpeichernButton.Location = new System.Drawing.Point(252, 248);
            this.fahrzeugSpeichernButton.Name = "fahrzeugSpeichernButton";
            this.fahrzeugSpeichernButton.Size = new System.Drawing.Size(150, 34);
            this.fahrzeugSpeichernButton.TabIndex = 6;
            this.fahrzeugSpeichernButton.Text = "Parkhaus speichern";
            this.fahrzeugSpeichernButton.UseVisualStyleBackColor = true;
            this.fahrzeugSpeichernButton.Click += new System.EventHandler(this.fahrzeugSpeichernButton_Click);
            // 
            // straßeTextBox
            // 
            this.straßeTextBox.Location = new System.Drawing.Point(195, 59);
            this.straßeTextBox.Name = "straßeTextBox";
            this.straßeTextBox.Size = new System.Drawing.Size(186, 20);
            this.straßeTextBox.TabIndex = 2;
            // 
            // lkwParkplätzeLabel
            // 
            this.lkwParkplätzeLabel.AutoSize = true;
            this.lkwParkplätzeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkwParkplätzeLabel.Location = new System.Drawing.Point(3, 152);
            this.lkwParkplätzeLabel.Name = "lkwParkplätzeLabel";
            this.lkwParkplätzeLabel.Size = new System.Drawing.Size(163, 18);
            this.lkwParkplätzeLabel.TabIndex = 11;
            this.lkwParkplätzeLabel.Text = "Anzahl LKW Parkplätze";
            // 
            // motorradParktplätzeLabel
            // 
            this.motorradParktplätzeLabel.AutoSize = true;
            this.motorradParktplätzeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorradParktplätzeLabel.Location = new System.Drawing.Point(3, 188);
            this.motorradParktplätzeLabel.Name = "motorradParktplätzeLabel";
            this.motorradParktplätzeLabel.Size = new System.Drawing.Size(121, 36);
            this.motorradParktplätzeLabel.TabIndex = 12;
            this.motorradParktplätzeLabel.Text = "Anzahl Motorrad Parkplätze";
            // 
            // lkwParkplätzeTextBox
            // 
            this.lkwParkplätzeTextBox.Location = new System.Drawing.Point(195, 155);
            this.lkwParkplätzeTextBox.Name = "lkwParkplätzeTextBox";
            this.lkwParkplätzeTextBox.Size = new System.Drawing.Size(186, 20);
            this.lkwParkplätzeTextBox.TabIndex = 4;
            // 
            // motorradParkplätzeTextBox
            // 
            this.motorradParkplätzeTextBox.Location = new System.Drawing.Point(195, 191);
            this.motorradParkplätzeTextBox.Name = "motorradParkplätzeTextBox";
            this.motorradParkplätzeTextBox.Size = new System.Drawing.Size(186, 20);
            this.motorradParkplätzeTextBox.TabIndex = 5;
            // 
            // ParkhausForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 301);
            this.Controls.Add(this.fahrzeugSpeichernButton);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "ParkhausForm";
            this.Text = "ParkhausErstellen";
            this.Load += new System.EventHandler(this.ParkhausErstellen_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label ortLabel;
        private System.Windows.Forms.Label plzLabel;
        private System.Windows.Forms.MaskedTextBox plzMaskedTextBox;
        private System.Windows.Forms.Label straßeLabel;
        private System.Windows.Forms.TextBox ortTextBox;
        private System.Windows.Forms.Label anschaffungspreisLabel;
        private System.Windows.Forms.TextBox pkwParkplätzeTextBox;
        private System.Windows.Forms.Button fahrzeugSpeichernButton;
        private System.Windows.Forms.TextBox straßeTextBox;
        private System.Windows.Forms.Label lkwParkplätzeLabel;
        private System.Windows.Forms.Label motorradParktplätzeLabel;
        private System.Windows.Forms.TextBox lkwParkplätzeTextBox;
        private System.Windows.Forms.TextBox motorradParkplätzeTextBox;
    }
}