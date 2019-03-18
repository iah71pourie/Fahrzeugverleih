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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fahrzeugErstellenButton = new System.Windows.Forms.Button();
            this.fahrzeugLöschenButton = new System.Windows.Forms.Button();
            this.sucheTextBox = new System.Windows.Forms.TextBox();
            this.sucheLabel = new System.Windows.Forms.Label();
            this.parkhäuserListBox = new System.Windows.Forms.ListBox();
            this.parkhausLöschenButton = new System.Windows.Forms.Button();
            this.parkhausErstellenButton = new System.Windows.Forms.Button();
            this.parkhäuserGroupBox = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.fahrzeugeTabPage = new System.Windows.Forms.TabPage();
            this.fahrzeugeDataGridView = new System.Windows.Forms.DataGridView();
            this.parkhäuserTabPage = new System.Windows.Forms.TabPage();
            this.gesammteSteuerschuldLabel = new System.Windows.Forms.Label();
            this.gesammteSteuerschuldTextBox = new System.Windows.Forms.TextBox();
            this.parkhäuserGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.fahrzeugeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeugeDataGridView)).BeginInit();
            this.parkhäuserTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // fahrzeugErstellenButton
            // 
            this.fahrzeugErstellenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrzeugErstellenButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fahrzeugErstellenButton.Location = new System.Drawing.Point(843, 387);
            this.fahrzeugErstellenButton.Name = "fahrzeugErstellenButton";
            this.fahrzeugErstellenButton.Size = new System.Drawing.Size(115, 50);
            this.fahrzeugErstellenButton.TabIndex = 2;
            this.fahrzeugErstellenButton.Text = "Fahrzeug erstellen";
            this.fahrzeugErstellenButton.UseVisualStyleBackColor = true;
            this.fahrzeugErstellenButton.Click += new System.EventHandler(this.fahrzeugErstellenButton_Click);
            // 
            // fahrzeugLöschenButton
            // 
            this.fahrzeugLöschenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrzeugLöschenButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fahrzeugLöschenButton.Location = new System.Drawing.Point(971, 387);
            this.fahrzeugLöschenButton.Name = "fahrzeugLöschenButton";
            this.fahrzeugLöschenButton.Size = new System.Drawing.Size(115, 50);
            this.fahrzeugLöschenButton.TabIndex = 3;
            this.fahrzeugLöschenButton.Text = "Fahrzeug löschen";
            this.fahrzeugLöschenButton.UseVisualStyleBackColor = true;
            this.fahrzeugLöschenButton.Click += new System.EventHandler(this.fahrzeugLöschenButton_Click);
            // 
            // sucheTextBox
            // 
            this.sucheTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucheTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sucheTextBox.Location = new System.Drawing.Point(843, 30);
            this.sucheTextBox.Name = "sucheTextBox";
            this.sucheTextBox.Size = new System.Drawing.Size(237, 26);
            this.sucheTextBox.TabIndex = 1;
            this.sucheTextBox.TextChanged += new System.EventHandler(this.sucheTextBox_TextChanged);
            // 
            // sucheLabel
            // 
            this.sucheLabel.AutoSize = true;
            this.sucheLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucheLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sucheLabel.Location = new System.Drawing.Point(840, 9);
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
            this.tabControl1.Controls.Add(this.fahrzeugeTabPage);
            this.tabControl1.Controls.Add(this.parkhäuserTabPage);
            this.tabControl1.Location = new System.Drawing.Point(-3, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1104, 474);
            this.tabControl1.TabIndex = 12;
            // 
            // fahrzeugeTabPage
            // 
            this.fahrzeugeTabPage.Controls.Add(this.gesammteSteuerschuldLabel);
            this.fahrzeugeTabPage.Controls.Add(this.gesammteSteuerschuldTextBox);
            this.fahrzeugeTabPage.Controls.Add(this.fahrzeugeDataGridView);
            this.fahrzeugeTabPage.Controls.Add(this.fahrzeugErstellenButton);
            this.fahrzeugeTabPage.Controls.Add(this.sucheLabel);
            this.fahrzeugeTabPage.Controls.Add(this.fahrzeugLöschenButton);
            this.fahrzeugeTabPage.Controls.Add(this.sucheTextBox);
            this.fahrzeugeTabPage.Location = new System.Drawing.Point(4, 22);
            this.fahrzeugeTabPage.Name = "fahrzeugeTabPage";
            this.fahrzeugeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.fahrzeugeTabPage.Size = new System.Drawing.Size(1096, 448);
            this.fahrzeugeTabPage.TabIndex = 0;
            this.fahrzeugeTabPage.Text = "Fahrzeuge";
            this.fahrzeugeTabPage.UseVisualStyleBackColor = true;
            // 
            // fahrzeugeDataGridView
            // 
            this.fahrzeugeDataGridView.AllowUserToAddRows = false;
            this.fahrzeugeDataGridView.AllowUserToDeleteRows = false;
            this.fahrzeugeDataGridView.AllowUserToResizeColumns = false;
            this.fahrzeugeDataGridView.AllowUserToResizeRows = false;
            this.fahrzeugeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fahrzeugeDataGridView.ColumnHeadersHeight = 25;
            this.fahrzeugeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.fahrzeugeDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.fahrzeugeDataGridView.Location = new System.Drawing.Point(6, 9);
            this.fahrzeugeDataGridView.MultiSelect = false;
            this.fahrzeugeDataGridView.Name = "fahrzeugeDataGridView";
            this.fahrzeugeDataGridView.ReadOnly = true;
            this.fahrzeugeDataGridView.RowHeadersVisible = false;
            this.fahrzeugeDataGridView.RowHeadersWidth = 20;
            this.fahrzeugeDataGridView.RowTemplate.Height = 25;
            this.fahrzeugeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fahrzeugeDataGridView.Size = new System.Drawing.Size(831, 428);
            this.fahrzeugeDataGridView.TabIndex = 0;
            this.fahrzeugeDataGridView.DoubleClick += new System.EventHandler(this.fahrzeugeDataGridView_DoubleClick);
            // 
            // parkhäuserTabPage
            // 
            this.parkhäuserTabPage.Controls.Add(this.parkhäuserGroupBox);
            this.parkhäuserTabPage.Location = new System.Drawing.Point(4, 22);
            this.parkhäuserTabPage.Name = "parkhäuserTabPage";
            this.parkhäuserTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.parkhäuserTabPage.Size = new System.Drawing.Size(1096, 448);
            this.parkhäuserTabPage.TabIndex = 1;
            this.parkhäuserTabPage.Text = "Parkhäuser";
            this.parkhäuserTabPage.UseVisualStyleBackColor = true;
            // 
            // gesammteSteuerschuldLabel
            // 
            this.gesammteSteuerschuldLabel.AutoSize = true;
            this.gesammteSteuerschuldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gesammteSteuerschuldLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gesammteSteuerschuldLabel.Location = new System.Drawing.Point(840, 171);
            this.gesammteSteuerschuldLabel.Name = "gesammteSteuerschuldLabel";
            this.gesammteSteuerschuldLabel.Size = new System.Drawing.Size(164, 18);
            this.gesammteSteuerschuldLabel.TabIndex = 6;
            this.gesammteSteuerschuldLabel.Text = "Steuerschuld gesammt:";
            // 
            // gesammteSteuerschuldTextBox
            // 
            this.gesammteSteuerschuldTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gesammteSteuerschuldTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gesammteSteuerschuldTextBox.Location = new System.Drawing.Point(843, 192);
            this.gesammteSteuerschuldTextBox.Name = "gesammteSteuerschuldTextBox";
            this.gesammteSteuerschuldTextBox.ReadOnly = true;
            this.gesammteSteuerschuldTextBox.Size = new System.Drawing.Size(161, 26);
            this.gesammteSteuerschuldTextBox.TabIndex = 5;
            this.gesammteSteuerschuldTextBox.TabStop = false;
            // 
            // HauptmenüForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1099, 469);
            this.Controls.Add(this.tabControl1);
            this.Name = "HauptmenüForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fahrzeugverleih Hauptmenü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HauptmenüForm_FormClosing);
            this.Load += new System.EventHandler(this.HauptmenüForm_Load);
            this.parkhäuserGroupBox.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.fahrzeugeTabPage.ResumeLayout(false);
            this.fahrzeugeTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeugeDataGridView)).EndInit();
            this.parkhäuserTabPage.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage fahrzeugeTabPage;
        private System.Windows.Forms.DataGridView fahrzeugeDataGridView;
        private System.Windows.Forms.TabPage parkhäuserTabPage;
        private System.Windows.Forms.Label gesammteSteuerschuldLabel;
        private System.Windows.Forms.TextBox gesammteSteuerschuldTextBox;
    }
}

