namespace Fahrzeugverleih
{
    partial class FahrzeugAuswahlForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fahrzeugeDataGridView = new System.Windows.Forms.DataGridView();
            this.fahrzeugAuswählenButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeugeDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.fahrzeugeDataGridView.Location = new System.Drawing.Point(12, 12);
            this.fahrzeugeDataGridView.MultiSelect = false;
            this.fahrzeugeDataGridView.Name = "fahrzeugeDataGridView";
            this.fahrzeugeDataGridView.ReadOnly = true;
            this.fahrzeugeDataGridView.RowHeadersVisible = false;
            this.fahrzeugeDataGridView.RowHeadersWidth = 20;
            this.fahrzeugeDataGridView.RowTemplate.Height = 25;
            this.fahrzeugeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fahrzeugeDataGridView.Size = new System.Drawing.Size(815, 426);
            this.fahrzeugeDataGridView.TabIndex = 1;
            // 
            // fahrzeugAuswählenButton
            // 
            this.fahrzeugAuswählenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrzeugAuswählenButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fahrzeugAuswählenButton.Location = new System.Drawing.Point(833, 388);
            this.fahrzeugAuswählenButton.Name = "fahrzeugAuswählenButton";
            this.fahrzeugAuswählenButton.Size = new System.Drawing.Size(115, 50);
            this.fahrzeugAuswählenButton.TabIndex = 3;
            this.fahrzeugAuswählenButton.Text = "Fahrzeug auswählen";
            this.fahrzeugAuswählenButton.UseVisualStyleBackColor = true;
            this.fahrzeugAuswählenButton.Click += new System.EventHandler(this.fahrzeugAuswählenButton_Click);
            // 
            // FahrzeugAuswahl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.fahrzeugAuswählenButton);
            this.Controls.Add(this.fahrzeugeDataGridView);
            this.Name = "FahrzeugAuswahl";
            this.Text = "FahrzeugAuswahl";
            this.Load += new System.EventHandler(this.FahrzeugAuswahl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeugeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView fahrzeugeDataGridView;
        private System.Windows.Forms.Button fahrzeugAuswählenButton;
    }
}