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
using ToysCore.Models;

namespace ToysDashboard.DB
{
    public partial class BasicInfoWindow : CustomWindow
    {
        public BasicInfoWindow()
        {
            InitializeComponent();
        }

        private async void BasicInfoWindow_Load(object sender, EventArgs e)
        {
            var tc = new tcore();

            var Selected = await tc.BasicInfo.FirstOrDefaultAsync();

            if (Selected != null)
            {
                AddressOfUs.Text = Selected.AddressOfUs;
                facebookurl.Text = Selected.fblink;
                phone.Text = Selected.PhoneOfUs;
            }
        }

        private async void Save_Click(object sender, EventArgs e)
        {
            var tc = new tcore();

            tc.BasicInfo.RemoveRange(tc.BasicInfo);

            await tc.SaveChangesAsync();

            await tc.BasicInfo.AddAsync(new BasicInfo()
            {
                AddressOfUs = AddressOfUs.Text,
                fblink = facebookurl.Text,
                PhoneOfUs = phone.Text
            });

            await tc.SaveChangesAsync();
        }
    }
}
