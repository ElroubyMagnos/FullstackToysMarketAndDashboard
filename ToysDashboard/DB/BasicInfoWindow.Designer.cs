namespace ToysDashboard.DB
{
    partial class BasicInfoWindow
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
            AddressOfUs = new TextBox();
            label1 = new Label();
            label2 = new Label();
            facebookurl = new TextBox();
            label3 = new Label();
            phone = new TextBox();
            Save = new DesktopSupport.SkyButton();
            SuspendLayout();
            // 
            // AddressOfUs
            // 
            AddressOfUs.Location = new Point(40, 53);
            AddressOfUs.Name = "AddressOfUs";
            AddressOfUs.PlaceholderText = "العنوان الذي يظهر للعميل";
            AddressOfUs.RightToLeft = RightToLeft.Yes;
            AddressOfUs.Size = new Size(226, 23);
            AddressOfUs.TabIndex = 0;
            AddressOfUs.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 56);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 10003;
            label1.Text = "عنوان المكان";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 103);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 10005;
            label2.Text = "رابط الفيس بوك";
            // 
            // facebookurl
            // 
            facebookurl.Location = new Point(40, 100);
            facebookurl.Name = "facebookurl";
            facebookurl.PlaceholderText = "رابط الفيس بوك";
            facebookurl.RightToLeft = RightToLeft.Yes;
            facebookurl.Size = new Size(226, 23);
            facebookurl.TabIndex = 1;
            facebookurl.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 150);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 10007;
            label3.Text = "رقم الشركة";
            // 
            // phone
            // 
            phone.Location = new Point(40, 147);
            phone.Name = "phone";
            phone.PlaceholderText = "رقم الشركة";
            phone.RightToLeft = RightToLeft.Yes;
            phone.Size = new Size(226, 23);
            phone.TabIndex = 2;
            phone.TextAlign = HorizontalAlignment.Center;
            // 
            // Save
            // 
            Save.BackColor = SystemColors.Highlight;
            Save.BackgroundImageLayout = ImageLayout.Stretch;
            Save.DefaultColor = SystemColors.Highlight;
            Save.FlatAppearance.BorderSize = 0;
            Save.FlatStyle = FlatStyle.Flat;
            Save.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Save.ForeColor = SystemColors.Control;
            Save.Hover = Color.Empty;
            Save.Location = new Point(40, 191);
            Save.Name = "Save";
            Save.Size = new Size(75, 30);
            Save.TabIndex = 3;
            Save.Text = "حفظ";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // BasicInfoWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 250);
            Controls.Add(Save);
            Controls.Add(label3);
            Controls.Add(phone);
            Controls.Add(label2);
            Controls.Add(facebookurl);
            Controls.Add(label1);
            Controls.Add(AddressOfUs);
            Name = "BasicInfoWindow";
            Text = "BasicInfoWindow";
            Load += BasicInfoWindow_Load;
            Controls.SetChildIndex(AddressOfUs, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(facebookurl, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(phone, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(Save, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AddressOfUs;
        private Label label1;
        private Label label2;
        private TextBox facebookurl;
        private Label label3;
        private TextBox phone;
        private DesktopSupport.SkyButton Save;
    }
}