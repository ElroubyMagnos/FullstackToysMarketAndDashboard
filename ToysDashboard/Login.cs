using GazaAIDashboard.Source;

namespace ToysDashboard
{
    public partial class Login : CustomWindow
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Enterbtn_Click(object sender, EventArgs e)
        {
            if (Username.Text == "osama" && Password.PasswordContainer.Text == "osama123")
            {
                Hide();
                new Dashboard().ShowDialog();
                Application.Exit();
            }
            else MessageBox.Show("Wrong Password");
        }

        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Enterbtn_Click(sender, e);
            }
        }
    }
}
