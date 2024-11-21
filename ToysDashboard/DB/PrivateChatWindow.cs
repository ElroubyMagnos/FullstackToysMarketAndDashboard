using GazaAIDashboard.Source;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToysCore;
using ToysCore.Models;
using ToysDashboard.Properties;
using Message = ToysCore.Models.Message;

namespace ToysDashboard.DB
{
    public partial class PrivateChatWindow : CustomWindow
    {
        public PrivateChatWindow()
        {
            InitializeComponent();
        }

        private async void PrivateChatWindow_Load(object sender, EventArgs e)
        {
            var tc = new tcore();

            foreach (var msg in await tc.Messages.OrderByDescending(x => x.ID).Select(x => new
            {
                x.SenderIP
            }).Distinct().Take(100).ToListAsync())
            {
                if (!Ips.Items.Contains(msg.SenderIP))
                {
                    Ips.Items.Add(msg.SenderIP);
                }
            }
        }

        private async void Ips_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tc = new tcore();

            var MyMessages = await tc.Messages
                .Where(x => x.SenderIP == Ips.SelectedItem.ToString())
                .OrderBy(x => x.ID)
                .ToArrayAsync();

            Chat.Clear();

            foreach (var msg in MyMessages)
            {
                if (msg.SendByPanel)
                    Chat.AppendText(msg.Content + "\n", Color.Black);
                else Chat.AppendText(msg.Content + "\n", Color.Red);

                if (!msg.SeenByPanelManager)
                {
                    msg.SeenByPanelManager = true;

                    tc.Messages.Update(msg);

                    await tc.SaveChangesAsync();
                }
            }
        }

        private async void Send_Click(object sender, EventArgs e)
        {
            if (Message.Text.Length == 0)
            {
                MessageBox.Show("من فضلك اكتب رسالة");
            }

            var tc = new tcore();

            await tc.Messages.AddAsync(new Message()
            {
                Content = Message.Text,
                SendByPanel = true,
                SeenByPanelManager = true,
                SenderIP = Ips.SelectedItem.ToString(),
                SeenByCustomer = false
            });

            await tc.SaveChangesAsync();

            Message.Text = "";
        }

        private void Message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Send_Click(sender, e);
            }
        }

        int MsgCount = 0;
        private async void MsgsTimer_Tick(object sender, EventArgs e)
        {
            if (Ips.SelectedItem == null)
                return;

            var tc = new tcore();

            var Counter = await tc.Messages
                .Where(x => x.SenderIP == Ips.SelectedItem.ToString()).CountAsync();

            if (Counter == MsgCount)
                return;

            MsgCount = Counter;

            SoundPlayer sp = new SoundPlayer(Resources.chateffect);
            sp.Play();

            Ips_SelectedIndexChanged(sender, e);
        }

        private void PrivateChatWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            MsgsTimer.Enabled = false;
        }
    }
}
