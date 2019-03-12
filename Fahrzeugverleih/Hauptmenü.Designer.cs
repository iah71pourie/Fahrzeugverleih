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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.parkhäuserGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fahrzeugErstellenButton
            // 
            this.fahrzeugErstellenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrzeugErstellenButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fahrzeugErstellenButton.Location = new System.Drawing.Point(6, 204);
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
            this.fahrzeugLöschenButton.Location = new System.Drawing.Point(6, 244);
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
            this.sucheTextBox.Location = new System.Drawing.Point(6, 24);
            this.sucheTextBox.Name = "sucheTextBox";
            this.sucheTextBox.Size = new System.Drawing.Size(140, 26);
            this.sucheTextBox.TabIndex = 3;
            this.sucheTextBox.TextChanged += new System.EventHandler(this.sucheTextBox_TextChanged);
            // 
            // sucheLabel
            // 
            this.sucheLabel.AutoSize = true;
            this.sucheLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucheLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sucheLabel.Location = new System.Drawing.Point(6, 3);
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
            this.parkhäuserGroupBox.Location = new System.Drawing.Point(84, 22);
            this.parkhäuserGroupBox.Name = "parkhäuserGroupBox";
            this.parkhäuserGroupBox.Size = new System.Drawing.Size(417, 387);
            this.parkhäuserGroupBox.TabIndex = 10;
            this.parkhäuserGroupBox.TabStop = false;
            this.parkhäuserGroupBox.Text = "Parkhäuser";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1094, 592);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.fahrzeugErstellenButton);
            this.tabPage1.Controls.Add(this.sucheLabel);
            this.tabPage1.Controls.Add(this.fahrzeugLöschenButton);
            this.tabPage1.Controls.Add(this.sucheTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1086, 566);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.parkhäuserGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1086, 566);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(156, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // HauptmenüForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1099, 597);
            this.Controls.Add(this.tabControl1);
            this.Name = "HauptmenüForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Verleih Hauptmenü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HauptmenüForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.parkhäuserGroupBox.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

