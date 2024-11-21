namespace ToysDashboard.DB
{
    partial class PrivateChatWindow
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
            components = new System.ComponentModel.Container();
            Ips = new ListBox();
            Chat = new RichTextBox();
            Message = new TextBox();
            Send = new DesktopSupport.SkyButton();
            MsgsTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Ips
            // 
            Ips.FormattingEnabled = true;
            Ips.ItemHeight = 15;
            Ips.Location = new Point(12, 34);
            Ips.Name = "Ips";
            Ips.Size = new Size(120, 409);
            Ips.TabIndex = 10002;
            Ips.SelectedIndexChanged += Ips_SelectedIndexChanged;
            // 
            // Chat
            // 
            Chat.Location = new Point(138, 34);
            Chat.Name = "Chat";
            Chat.ReadOnly = true;
            Chat.Size = new Size(424, 380);
            Chat.TabIndex = 10003;
            Chat.Text = "";
            // 
            // Message
            // 
            Message.Location = new Point(138, 420);
            Message.Name = "Message";
            Message.Size = new Size(354, 23);
            Message.TabIndex = 0;
            Message.KeyDown += Message_KeyDown;
            // 
            // Send
            // 
            Send.BackColor = SystemColors.Highlight;
            Send.BackgroundImageLayout = ImageLayout.Stretch;
            Send.DefaultColor = SystemColors.Highlight;
            Send.FlatAppearance.BorderSize = 0;
            Send.FlatStyle = FlatStyle.Flat;
            Send.Font = new Font("Arial Narrow", 10.25F, FontStyle.Bold);
            Send.ForeColor = SystemColors.Control;
            Send.Hover = Color.Empty;
            Send.Location = new Point(498, 420);
            Send.Name = "Send";
            Send.Size = new Size(64, 24);
            Send.TabIndex = 10005;
            Send.Text = "ارسل";
            Send.UseVisualStyleBackColor = false;
            Send.Click += Send_Click;
            // 
            // MsgsTimer
            // 
            MsgsTimer.Enabled = true;
            MsgsTimer.Interval = 5000;
            MsgsTimer.Tick += MsgsTimer_Tick;
            // 
            // PrivateChatWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 450);
            Controls.Add(Send);
            Controls.Add(Message);
            Controls.Add(Chat);
            Controls.Add(Ips);
            Name = "PrivateChatWindow";
            Text = "PrivateChatWindow";
            FormClosing += PrivateChatWindow_FormClosing;
            Load += PrivateChatWindow_Load;
            Controls.SetChildIndex(Ips, 0);
            Controls.SetChildIndex(Chat, 0);
            Controls.SetChildIndex(Message, 0);
            Controls.SetChildIndex(Send, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Ips;
        private RichTextBox Chat;
        private TextBox Message;
        private DesktopSupport.SkyButton Send;
        private System.Windows.Forms.Timer MsgsTimer;
    }
}