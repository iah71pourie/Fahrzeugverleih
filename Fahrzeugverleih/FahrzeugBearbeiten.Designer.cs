namespace Fahrzeugverleih
{
    partial class FahrzeugBearbeiten
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
            this.fahrzeugArtComboBox = new System.Windows.Forms.ComboBox();
            this.fahrzeugArtLabel = new System.Windows.Forms.Label();
            this.fahrzeugLöschenButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fahrzeugArtComboBox
            // 
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
            // fahrzeugLöschenButton
            // 
            this.fahrzeugLöschenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrzeugLöschenButton.Location = new System.Drawing.Point(247, 229);
            this.fahrzeugLöschenButton.Name = "fahrzeugLöschenButton";
            this.fahrzeugLöschenButton.Size = new System.Drawing.Size(150, 34);
            this.fahrzeugLöschenButton.TabIndex = 3;
            this.fahrzeugLöschenButton.Text = "Fahrzeug speichern";
            this.fahrzeugLöschenButton.UseVisualStyleBackColor = true;
            this.fahrzeugLöschenButton.Click += new System.EventHandler(this.fahrzeugLöschenButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.fahrzeugArtComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.fahrzeugArtLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 210);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fahrzeug Art:";
            // 
            // FahrzeugBearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 276);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.fahrzeugLöschenButton);
            this.Name = "FahrzeugBearbeiten";
            this.Text = "Fahrzeug";
            this.Load += new System.EventHandler(this.FahrzeugErstellenForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox fahrzeugArtComboBox;
        private System.Windows.Forms.Label fahrzeugArtLabel;
        private System.Windows.Forms.Button fahrzeugLöschenButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
    }
}