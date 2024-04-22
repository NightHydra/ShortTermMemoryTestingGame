namespace COGS_Final
{
    partial class StatisticsPage
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
            this.LatenessTable = new System.Windows.Forms.DataGridView();
            this.Round = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.LatenessTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderStatTable)).BeginInit();
            this.SuspendLayout();
            // 
            // LatenessTable
            // 
            this.LatenessTable.AllowUserToAddRows = false;
            this.LatenessTable.AllowUserToDeleteRows = false;
            this.LatenessTable.AllowUserToResizeColumns = false;
            this.LatenessTable.AllowUserToResizeRows = false;
            this.LatenessTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.LatenessTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.LatenessTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LatenessTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Round});
            this.LatenessTable.Location = new System.Drawing.Point(34, 97);
            this.LatenessTable.Name = "LatenessTable";
            this.LatenessTable.ReadOnly = true;
            this.LatenessTable.RowHeadersWidth = 102;
            this.LatenessTable.RowTemplate.Height = 40;
            this.LatenessTable.Size = new System.Drawing.Size(981, 1128);
            this.LatenessTable.TabIndex = 0;
            this.LatenessTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Round
            // 
            this.Round.HeaderText = "Column1";
            this.Round.MinimumWidth = 12;
            this.Round.Name = "Round";
            this.Round.ReadOnly = true;
            this.Round.Width = 182;
            // 
            // OrderStatTable
            // 
            this.OrderStatTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.OrderStatTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.OrderStatTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderStatTable.Location = new System.Drawing.Point(1066, 97);
            this.OrderStatTable.Name = "OrderStatTable";
            this.OrderStatTable.RowHeadersWidth = 102;
            this.OrderStatTable.RowTemplate.Height = 40;
            this.OrderStatTable.Size = new System.Drawing.Size(910, 1136);
            this.OrderStatTable.TabIndex = 1;
            this.OrderStatTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderStatTable_CellContentClick);
            // 
            // StatisticsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1988, 1284);
            this.Controls.Add(this.OrderStatTable);
            this.Controls.Add(this.LatenessTable);
            this.Name = "StatisticsPage";
            this.Text = "Results";
            ((System.ComponentModel.ISupportInitialize)(this.LatenessTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderStatTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LatenessTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Round;
        private System.Windows.Forms.DataGridView OrderStatTable;
    }
}