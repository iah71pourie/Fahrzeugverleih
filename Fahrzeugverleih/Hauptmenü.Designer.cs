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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fahrzeugErstellenButton = new System.Windows.Forms.Button();
            this.fahrzeugLöschenButton = new System.Windows.Forms.Button();
            this.fahrzeugeKennzeichenSucheTextBox = new System.Windows.Forms.TextBox();
            this.sucheLabel = new System.Windows.Forms.Label();
            this.fahrzeugeListBox = new System.Windows.Forms.ListBox();
            this.parkhausLöschenButton = new System.Windows.Forms.Button();
            this.parkhausErstellenButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.fahrzeugeTabPage = new System.Windows.Forms.TabPage();
            this.gesammteSteuerschuldLabel = new System.Windows.Forms.Label();
            this.gesammteSteuerschuldTextBox = new System.Windows.Forms.TextBox();
            this.fahrzeugeDataGridView = new System.Windows.Forms.DataGridView();
            this.parkhäuserTabPage = new System.Windows.Forms.TabPage();
            this.parkplatzTrennenButton = new System.Windows.Forms.Button();
            this.parkplatzZuweisenButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.parkhäuserKennzeichenSucheTextBox = new System.Windows.Forms.TextBox();
            this.parkhäuserDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.fahrzeugeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeugeDataGridView)).BeginInit();
            this.parkhäuserTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkhäuserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fahrzeugErstellenButton
            // 
            this.fahrzeugErstellenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrzeugErstellenButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fahrzeugErstellenButton.Location = new System.Drawing.Point(850, 387);
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
            // fahrzeugeKennzeichenSucheTextBox
            // 
            this.fahrzeugeKennzeichenSucheTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrzeugeKennzeichenSucheTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fahrzeugeKennzeichenSucheTextBox.Location = new System.Drawing.Point(850, 32);
            this.fahrzeugeKennzeichenSucheTextBox.Name = "fahrzeugeKennzeichenSucheTextBox";
            this.fahrzeugeKennzeichenSucheTextBox.Size = new System.Drawing.Size(236, 26);
            this.fahrzeugeKennzeichenSucheTextBox.TabIndex = 1;
            this.fahrzeugeKennzeichenSucheTextBox.TextChanged += new System.EventHandler(this.fahrzeugeKennzeichenSucheTextBox_TextChanged);
            // 
            // sucheLabel
            // 
            this.sucheLabel.AutoSize = true;
            this.sucheLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucheLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sucheLabel.Location = new System.Drawing.Point(847, 11);
            this.sucheLabel.Name = "sucheLabel";
            this.sucheLabel.Size = new System.Drawing.Size(143, 18);
            this.sucheLabel.TabIndex = 4;
            this.sucheLabel.Text = "Kennzeichen Suche:";
            // 
            // fahrzeugeListBox
            // 
            this.fahrzeugeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrzeugeListBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fahrzeugeListBox.FormattingEnabled = true;
            this.fahrzeugeListBox.ItemHeight = 18;
            this.fahrzeugeListBox.Location = new System.Drawing.Point(803, 6);
            this.fahrzeugeListBox.Name = "fahrzeugeListBox";
            this.fahrzeugeListBox.Size = new System.Drawing.Size(287, 436);
            this.fahrzeugeListBox.TabIndex = 6;
            this.fahrzeugeListBox.DoubleClick += new System.EventHandler(this.fahrzeugeListBox_DoubleClick);
            // 
            // parkhausLöschenButton
            // 
            this.parkhausLöschenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkhausLöschenButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.parkhausLöschenButton.Location = new System.Drawing.Point(682, 392);
            this.parkhausLöschenButton.Name = "parkhausLöschenButton";
            this.parkhausLöschenButton.Size = new System.Drawing.Size(115, 50);
            this.parkhausLöschenButton.TabIndex = 5;
            this.parkhausLöschenButton.Text = "Parkhaus löschen";
            this.parkhausLöschenButton.UseVisualStyleBackColor = true;
            this.parkhausLöschenButton.Click += new System.EventHandler(this.parkhausLöschenButton_Click);
            // 
            // parkhausErstellenButton
            // 
            this.parkhausErstellenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkhausErstellenButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.parkhausErstellenButton.Location = new System.Drawing.Point(561, 392);
            this.parkhausErstellenButton.Name = "parkhausErstellenButton";
            this.parkhausErstellenButton.Size = new System.Drawing.Size(115, 50);
            this.parkhausErstellenButton.TabIndex = 4;
            this.parkhausErstellenButton.Text = "Parkhaus erstellen";
            this.parkhausErstellenButton.UseVisualStyleBackColor = true;
            this.parkhausErstellenButton.Click += new System.EventHandler(this.parkhausErstellenButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.fahrzeugeTabPage);
            this.tabControl.Controls.Add(this.parkhäuserTabPage);
            this.tabControl.Location = new System.Drawing.Point(-3, -2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1104, 474);
            this.tabControl.TabIndex = 0;
            // 
            // fahrzeugeTabPage
            // 
            this.fahrzeugeTabPage.Controls.Add(this.gesammteSteuerschuldLabel);
            this.fahrzeugeTabPage.Controls.Add(this.gesammteSteuerschuldTextBox);
            this.fahrzeugeTabPage.Controls.Add(this.fahrzeugeDataGridView);
            this.fahrzeugeTabPage.Controls.Add(this.fahrzeugErstellenButton);
            this.fahrzeugeTabPage.Controls.Add(this.sucheLabel);
            this.fahrzeugeTabPage.Controls.Add(this.fahrzeugLöschenButton);
            this.fahrzeugeTabPage.Controls.Add(this.fahrzeugeKennzeichenSucheTextBox);
            this.fahrzeugeTabPage.Location = new System.Drawing.Point(4, 22);
            this.fahrzeugeTabPage.Name = "fahrzeugeTabPage";
            this.fahrzeugeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.fahrzeugeTabPage.Size = new System.Drawing.Size(1096, 448);
            this.fahrzeugeTabPage.TabIndex = 0;
            this.fahrzeugeTabPage.Text = "Fahrzeuge";
            this.fahrzeugeTabPage.UseVisualStyleBackColor = true;
            // 
            // gesammteSteuerschuldLabel
            // 
            this.gesammteSteuerschuldLabel.AutoSize = true;
            this.gesammteSteuerschuldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gesammteSteuerschuldLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gesammteSteuerschuldLabel.Location = new System.Drawing.Point(847, 173);
            this.gesammteSteuerschuldLabel.Name = "gesammteSteuerschuldLabel";
            this.gesammteSteuerschuldLabel.Size = new System.Drawing.Size(164, 18);
            this.gesammteSteuerschuldLabel.TabIndex = 6;
            this.gesammteSteuerschuldLabel.Text = "Steuerschuld gesammt:";
            // 
            // gesammteSteuerschuldTextBox
            // 
            this.gesammteSteuerschuldTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gesammteSteuerschuldTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gesammteSteuerschuldTextBox.Location = new System.Drawing.Point(850, 194);
            this.gesammteSteuerschuldTextBox.Name = "gesammteSteuerschuldTextBox";
            this.gesammteSteuerschuldTextBox.ReadOnly = true;
            this.gesammteSteuerschuldTextBox.Size = new System.Drawing.Size(161, 26);
            this.gesammteSteuerschuldTextBox.TabIndex = 5;
            this.gesammteSteuerschuldTextBox.TabStop = false;
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
            this.fahrzeugeDataGridView.Location = new System.Drawing.Point(6, 6);
            this.fahrzeugeDataGridView.MultiSelect = false;
            this.fahrzeugeDataGridView.Name = "fahrzeugeDataGridView";
            this.fahrzeugeDataGridView.ReadOnly = true;
            this.fahrzeugeDataGridView.RowHeadersVisible = false;
            this.fahrzeugeDataGridView.RowHeadersWidth = 20;
            this.fahrzeugeDataGridView.RowTemplate.Height = 25;
            this.fahrzeugeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fahrzeugeDataGridView.Size = new System.Drawing.Size(838, 431);
            this.fahrzeugeDataGridView.TabIndex = 0;
            this.fahrzeugeDataGridView.DoubleClick += new System.EventHandler(this.fahrzeugeDataGridView_DoubleClick);
            // 
            // parkhäuserTabPage
            // 
            this.parkhäuserTabPage.Controls.Add(this.parkplatzTrennenButton);
            this.parkhäuserTabPage.Controls.Add(this.parkplatzZuweisenButton);
            this.parkhäuserTabPage.Controls.Add(this.label1);
            this.parkhäuserTabPage.Controls.Add(this.parkhäuserKennzeichenSucheTextBox);
            this.parkhäuserTabPage.Controls.Add(this.parkhäuserDataGridView);
            this.parkhäuserTabPage.Controls.Add(this.fahrzeugeListBox);
            this.parkhäuserTabPage.Controls.Add(this.parkhausErstellenButton);
            this.parkhäuserTabPage.Controls.Add(this.parkhausLöschenButton);
            this.parkhäuserTabPage.Location = new System.Drawing.Point(4, 22);
            this.parkhäuserTabPage.Name = "parkhäuserTabPage";
            this.parkhäuserTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.parkhäuserTabPage.Size = new System.Drawing.Size(1096, 448);
            this.parkhäuserTabPage.TabIndex = 1;
            this.parkhäuserTabPage.Text = "Parkhäuser";
            this.parkhäuserTabPage.UseVisualStyleBackColor = true;
            // 
            // parkplatzTrennenButton
            // 
            this.parkplatzTrennenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkplatzTrennenButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.parkplatzTrennenButton.Location = new System.Drawing.Point(682, 314);
            this.parkplatzTrennenButton.Name = "parkplatzTrennenButton";
            this.parkplatzTrennenButton.Size = new System.Drawing.Size(115, 50);
            this.parkplatzTrennenButton.TabIndex = 3;
            this.parkplatzTrennenButton.Text = "Parkplatz trennen";
            this.parkplatzTrennenButton.UseVisualStyleBackColor = true;
            this.parkplatzTrennenButton.Click += new System.EventHandler(this.parkplatzTrennenButton_Click);
            // 
            // parkplatzZuweisenButton
            // 
            this.parkplatzZuweisenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkplatzZuweisenButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.parkplatzZuweisenButton.Location = new System.Drawing.Point(561, 314);
            this.parkplatzZuweisenButton.Name = "parkplatzZuweisenButton";
            this.parkplatzZuweisenButton.Size = new System.Drawing.Size(115, 50);
            this.parkplatzZuweisenButton.TabIndex = 2;
            this.parkplatzZuweisenButton.Text = "Parkplatz zuweisen";
            this.parkplatzZuweisenButton.UseVisualStyleBackColor = true;
            this.parkplatzZuweisenButton.Click += new System.EventHandler(this.parkplatzZuweisenButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(558, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kennzeichen Suche:";
            // 
            // parkhäuserKennzeichenSucheTextBox
            // 
            this.parkhäuserKennzeichenSucheTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkhäuserKennzeichenSucheTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.parkhäuserKennzeichenSucheTextBox.Location = new System.Drawing.Point(561, 28);
            this.parkhäuserKennzeichenSucheTextBox.Name = "parkhäuserKennzeichenSucheTextBox";
            this.parkhäuserKennzeichenSucheTextBox.Size = new System.Drawing.Size(236, 26);
            this.parkhäuserKennzeichenSucheTextBox.TabIndex = 1;
            this.parkhäuserKennzeichenSucheTextBox.TextChanged += new System.EventHandler(this.parkhäuserKennzeichenSucheTextBox_TextChanged);
            // 
            // parkhäuserDataGridView
            // 
            this.parkhäuserDataGridView.AllowUserToAddRows = false;
            this.parkhäuserDataGridView.AllowUserToDeleteRows = false;
            this.parkhäuserDataGridView.AllowUserToResizeColumns = false;
            this.parkhäuserDataGridView.AllowUserToResizeRows = false;
            this.parkhäuserDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.parkhäuserDataGridView.ColumnHeadersHeight = 25;
            this.parkhäuserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.parkhäuserDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.parkhäuserDataGridView.Location = new System.Drawing.Point(11, 6);
            this.parkhäuserDataGridView.MultiSelect = false;
            this.parkhäuserDataGridView.Name = "parkhäuserDataGridView";
            this.parkhäuserDataGridView.ReadOnly = true;
            this.parkhäuserDataGridView.RowHeadersVisible = false;
            this.parkhäuserDataGridView.RowHeadersWidth = 20;
            this.parkhäuserDataGridView.RowTemplate.Height = 25;
            this.parkhäuserDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.parkhäuserDataGridView.Size = new System.Drawing.Size(544, 436);
            this.parkhäuserDataGridView.TabIndex = 0;
            this.parkhäuserDataGridView.SelectionChanged += new System.EventHandler(this.parkhäuserDataGridView_SelectionChanged);
            this.parkhäuserDataGridView.DoubleClick += new System.EventHandler(this.parkhäuserDataGridView_DoubleClick);
            // 
            // HauptmenüForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1099, 469);
            this.Controls.Add(this.tabControl);
            this.Name = "HauptmenüForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fahrzeugverleih Hauptmenü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HauptmenüForm_FormClosing);
            this.Load += new System.EventHandler(this.HauptmenüForm_Load);
            this.tabControl.ResumeLayout(false);
            this.fahrzeugeTabPage.ResumeLayout(false);
            this.fahrzeugeTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeugeDataGridView)).EndInit();
            this.parkhäuserTabPage.ResumeLayout(false);
            this.parkhäuserTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkhäuserDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fahrzeugErstellenButton;
        private System.Windows.Forms.Button fahrzeugLöschenButton;
        private System.Windows.Forms.TextBox fahrzeugeKennzeichenSucheTextBox;
        private System.Windows.Forms.Label sucheLabel;
        private System.Windows.Forms.ListBox fahrzeugeListBox;
        private System.Windows.Forms.Button parkhausLöschenButton;
        private System.Windows.Forms.Button parkhausErstellenButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage fahrzeugeTabPage;
        private System.Windows.Forms.DataGridView fahrzeugeDataGridView;
        private System.Windows.Forms.TabPage parkhäuserTabPage;
        private System.Windows.Forms.Label gesammteSteuerschuldLabel;
        private System.Windows.Forms.TextBox gesammteSteuerschuldTextBox;
        private System.Windows.Forms.DataGridView parkhäuserDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox parkhäuserKennzeichenSucheTextBox;
        private System.Windows.Forms.Button parkplatzTrennenButton;
        private System.Windows.Forms.Button parkplatzZuweisenButton;
    }
}

