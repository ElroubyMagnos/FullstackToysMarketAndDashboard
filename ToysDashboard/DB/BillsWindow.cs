using GazaAIDashboard.Source;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToysCore;

namespace ToysDashboard.DB
{
    public partial class BillsWindow : CustomWindow
    {
        public BillsWindow()
        {
            InitializeComponent();
        }

        private async void BillsWindow_Load(object sender, EventArgs e)
        {
            var t = new tcore();

            Grid.DataSource = await t.Bills.Where(x => x.IsOpen).ToListAsync();
        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
