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
using ToysDashboard.DB;

namespace ToysDashboard
{
    public partial class Dashboard : CustomWindow
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void BasicInfoEnter_Click(object sender, EventArgs e)
        {
            Hide();
            new BasicInfoWindow().ShowDialog();
            Show();
        }

        private void CategoriesEnter_Click(object sender, EventArgs e)
        {
            Hide();
            new CategoriesWindow().ShowDialog();
            Show();
        }

        private void ProductsEnter_Click(object sender, EventArgs e)
        {
            Hide();
            new ProductsWindow().ShowDialog();
            Show();
        }

        private void PrivChatEnter_Click(object sender, EventArgs e)
        {
            Hide();
            new PrivateChatWindow().ShowDialog();
            Show();
        }

        private async void MsgsTimer_Tick(object sender, EventArgs e)
        {
            var tc = new tcore();

            NotifyCount.Text = (await tc.Messages.Where(x => !x.SeenByPanelManager).CountAsync()).ToString();
        }

        private void BillsEnter_Click(object sender, EventArgs e)
        {
            Hide();
            new BillsWindow().ShowDialog();
            Show();
        }
    }
}
