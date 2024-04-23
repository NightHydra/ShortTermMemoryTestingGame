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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.LatenessTable.Location = new System.Drawing.Point(40, 193);
            this.LatenessTable.Name = "LatenessTable";
            this.LatenessTable.ReadOnly = true;
            this.LatenessTable.RowHeadersWidth = 102;
            this.LatenessTable.RowTemplate.Height = 40;
            this.LatenessTable.Size = new System.Drawing.Size(1400, 1128);
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
            this.OrderStatTable.Location = new System.Drawing.Point(1580, 185);
            this.OrderStatTable.Name = "OrderStatTable";
            this.OrderStatTable.RowHeadersWidth = 102;
            this.OrderStatTable.RowTemplate.Height = 40;
            this.OrderStatTable.Size = new System.Drawing.Size(1400, 1136);
            this.OrderStatTable.TabIndex = 1;
            this.OrderStatTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderStatTable_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(469, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lateness Table By Round";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2048, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(628, 63);
            this.label2.TabIndex = 3;
            this.label2.Text = "Order Of Timers Pressed";
            // 
            // StatisticsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2291, 1427);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderStatTable);
            this.Controls.Add(this.LatenessTable);
            this.Name = "StatisticsPage";
            this.Text = "Results";
            ((System.ComponentModel.ISupportInitialize)(this.LatenessTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderStatTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LatenessTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Round;
        private System.Windows.Forms.DataGridView OrderStatTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}