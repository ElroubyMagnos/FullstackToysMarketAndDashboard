namespace GazaAIDashboard.Source
{
    partial class CustomWindow
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
            TitleBar = new Panel();
            CloseBtn = new Button();
            TitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // TitleBar
            // 
            TitleBar.BackColor = Color.FromArgb(53, 114, 239);
            TitleBar.Controls.Add(CloseBtn);
            TitleBar.Dock = DockStyle.Top;
            TitleBar.Location = new Point(0, 0);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(498, 28);
            TitleBar.TabIndex = 10001;
            TitleBar.MouseDown += TitleBar_MouseDown;
            TitleBar.MouseMove += TitleBar_MouseMove;
            TitleBar.MouseUp += TitleBar_MouseUp;
            // 
            // CloseBtn
            // 
            CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseBtn.BackColor = Color.Red;
            CloseBtn.FlatAppearance.BorderSize = 0;
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.Font = new Font("Arial Black", 8F, FontStyle.Bold);
            CloseBtn.ForeColor = Color.White;
            CloseBtn.Location = new Point(456, 1);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(42, 27);
            CloseBtn.TabIndex = 1000;
            CloseBtn.Text = "X";
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // CustomWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 224);
            Controls.Add(TitleBar);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomWindow";
            TitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TitleBar;
        private Button CloseBtn;
    }
}