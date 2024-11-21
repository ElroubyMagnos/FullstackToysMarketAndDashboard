namespace ToysDashboard
{
    partial class Dashboard
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
            BasicInfoEnter = new Button();
            CategoriesEnter = new Button();
            ProductsEnter = new Button();
            BillsEnter = new Button();
            PrivChatEnter = new Button();
            NotifyCount = new Label();
            MsgsTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // BasicInfoEnter
            // 
            BasicInfoEnter.Location = new Point(12, 34);
            BasicInfoEnter.Name = "BasicInfoEnter";
            BasicInfoEnter.Size = new Size(177, 157);
            BasicInfoEnter.TabIndex = 10002;
            BasicInfoEnter.Text = "بيانات الموقع";
            BasicInfoEnter.UseVisualStyleBackColor = true;
            BasicInfoEnter.Click += BasicInfoEnter_Click;
            // 
            // CategoriesEnter
            // 
            CategoriesEnter.Location = new Point(195, 34);
            CategoriesEnter.Name = "CategoriesEnter";
            CategoriesEnter.Size = new Size(177, 157);
            CategoriesEnter.TabIndex = 10003;
            CategoriesEnter.Text = "الاقسام";
            CategoriesEnter.UseVisualStyleBackColor = true;
            CategoriesEnter.Click += CategoriesEnter_Click;
            // 
            // ProductsEnter
            // 
            ProductsEnter.Location = new Point(12, 197);
            ProductsEnter.Name = "ProductsEnter";
            ProductsEnter.Size = new Size(177, 157);
            ProductsEnter.TabIndex = 10004;
            ProductsEnter.Text = "المنتجات";
            ProductsEnter.UseVisualStyleBackColor = true;
            ProductsEnter.Click += ProductsEnter_Click;
            // 
            // BillsEnter
            // 
            BillsEnter.Location = new Point(195, 197);
            BillsEnter.Name = "BillsEnter";
            BillsEnter.Size = new Size(177, 157);
            BillsEnter.TabIndex = 10005;
            BillsEnter.Text = "الفواتير";
            BillsEnter.UseVisualStyleBackColor = true;
            BillsEnter.Click += BillsEnter_Click;
            // 
            // PrivChatEnter
            // 
            PrivChatEnter.Location = new Point(12, 360);
            PrivChatEnter.Name = "PrivChatEnter";
            PrivChatEnter.Size = new Size(177, 157);
            PrivChatEnter.TabIndex = 10006;
            PrivChatEnter.Text = "المحادثات الخاصة";
            PrivChatEnter.UseVisualStyleBackColor = true;
            PrivChatEnter.Click += PrivChatEnter_Click;
            // 
            // NotifyCount
            // 
            NotifyCount.AutoSize = true;
            NotifyCount.BackColor = SystemColors.Control;
            NotifyCount.Font = new Font("Segoe UI", 13F);
            NotifyCount.ForeColor = Color.Red;
            NotifyCount.Location = new Point(136, 379);
            NotifyCount.Name = "NotifyCount";
            NotifyCount.Size = new Size(22, 25);
            NotifyCount.TabIndex = 10007;
            NotifyCount.Text = "0";
            // 
            // MsgsTimer
            // 
            MsgsTimer.Enabled = true;
            MsgsTimer.Interval = 2555;
            MsgsTimer.Tick += MsgsTimer_Tick;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 531);
            Controls.Add(NotifyCount);
            Controls.Add(PrivChatEnter);
            Controls.Add(BillsEnter);
            Controls.Add(ProductsEnter);
            Controls.Add(CategoriesEnter);
            Controls.Add(BasicInfoEnter);
            Name = "Dashboard";
            Text = "Dashboard";
            Controls.SetChildIndex(BasicInfoEnter, 0);
            Controls.SetChildIndex(CategoriesEnter, 0);
            Controls.SetChildIndex(ProductsEnter, 0);
            Controls.SetChildIndex(BillsEnter, 0);
            Controls.SetChildIndex(PrivChatEnter, 0);
            Controls.SetChildIndex(NotifyCount, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BasicInfoEnter;
        private Button CategoriesEnter;
        private Button ProductsEnter;
        private Button BillsEnter;
        private Button PrivChatEnter;
        private Label NotifyCount;
        private System.Windows.Forms.Timer MsgsTimer;
    }
}