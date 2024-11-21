namespace ToysDashboard
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            logo = new PictureBox();
            Password = new DesktopSupport.PasswordBox();
            Username = new TextBox();
            Enterbtn = new DesktopSupport.SkyButton();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.BackgroundImage = Properties.Resources.logo;
            logo.BackgroundImageLayout = ImageLayout.Stretch;
            logo.Location = new Point(107, 34);
            logo.Name = "logo";
            logo.Size = new Size(197, 120);
            logo.TabIndex = 10002;
            logo.TabStop = false;
            // 
            // Password
            // 
            Password.Location = new Point(55, 216);
            Password.Margin = new Padding(4, 3, 4, 3);
            Password.Name = "Password";
            Password.RightToLeft = RightToLeft.Yes;
            Password.Size = new Size(285, 31);
            Password.TabIndex = 1;
            Password.KeyDown += Username_KeyDown;
            // 
            // Username
            // 
            Username.Location = new Point(57, 187);
            Username.Name = "Username";
            Username.PlaceholderText = "اسم المستخدم";
            Username.RightToLeft = RightToLeft.Yes;
            Username.Size = new Size(281, 23);
            Username.TabIndex = 0;
            Username.KeyDown += Username_KeyDown;
            // 
            // Enterbtn
            // 
            Enterbtn.BackColor = SystemColors.Highlight;
            Enterbtn.BackgroundImageLayout = ImageLayout.Stretch;
            Enterbtn.DefaultColor = SystemColors.Highlight;
            Enterbtn.FlatAppearance.BorderSize = 0;
            Enterbtn.FlatStyle = FlatStyle.Flat;
            Enterbtn.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Enterbtn.ForeColor = SystemColors.Control;
            Enterbtn.Hover = Color.Empty;
            Enterbtn.Location = new Point(57, 253);
            Enterbtn.Name = "Enterbtn";
            Enterbtn.Size = new Size(75, 30);
            Enterbtn.TabIndex = 2;
            Enterbtn.Text = "دخول";
            Enterbtn.UseVisualStyleBackColor = false;
            Enterbtn.Click += Enterbtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(418, 299);
            Controls.Add(Enterbtn);
            Controls.Add(Username);
            Controls.Add(Password);
            Controls.Add(logo);
            Name = "Login";
            Text = "Form1";
            Controls.SetChildIndex(logo, 0);
            Controls.SetChildIndex(Password, 0);
            Controls.SetChildIndex(Username, 0);
            Controls.SetChildIndex(Enterbtn, 0);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logo;
        private DesktopSupport.PasswordBox Password;
        private TextBox Username;
        private DesktopSupport.SkyButton Enterbtn;
    }
}
