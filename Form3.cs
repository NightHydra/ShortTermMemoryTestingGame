using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COGS_Final
{
    public partial class StatisticsPage : Form
    {
        public static GameStatistics prevGameStats;
        public StatisticsPage()
        {
            InitializeComponent();

            prevGameStats.fillInTableWithEachRoundLateness(LatenessTable);

            prevGameStats.fillInTableWithEachRoundOrder(OrderStatTable);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void OrderStatTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
