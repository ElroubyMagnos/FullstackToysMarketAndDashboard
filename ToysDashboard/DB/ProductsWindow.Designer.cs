namespace ToysDashboard.DB
{
    partial class ProductsWindow
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            ImageOf = new PictureBox();
            Grid = new DesktopSupport.SkyGrid();
            TitleOf = new TextBox();
            DescOf = new TextBox();
            BuyPrice = new DesktopSupport.FixedDecimalBox();
            SellPrice = new DesktopSupport.FixedDecimalBox();
            Discount = new DesktopSupport.FixedDecimalBox();
            Categories = new DesktopSupport.FixedStringComboBox();
            SaveAll = new DesktopSupport.SkyButton();
            DeleteSelected = new DesktopSupport.SkyButton();
            ((System.ComponentModel.ISupportInitialize)ImageOf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
            SuspendLayout();
            // 
            // ImageOf
            // 
            ImageOf.BackColor = SystemColors.ActiveCaption;
            ImageOf.BackgroundImageLayout = ImageLayout.Stretch;
            ImageOf.Location = new Point(482, 190);
            ImageOf.Name = "ImageOf";
            ImageOf.Size = new Size(123, 97);
            ImageOf.TabIndex = 10002;
            ImageOf.TabStop = false;
            ImageOf.Click += Image_Click;
            // 
            // Grid
            // 
            Grid.AllowUserToAddRows = false;
            Grid.AllowUserToDeleteRows = false;
            Grid.BackgroundColor = Color.White;
            Grid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid.EditMode = DataGridViewEditMode.EditProgrammatically;
            Grid.GridColor = SystemColors.ActiveCaption;
            Grid.Location = new Point(12, 34);
            Grid.MultiSelect = false;
            Grid.Name = "Grid";
            Grid.ReadOnly = true;
            Grid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grid.Size = new Size(593, 150);
            Grid.TabIndex = 10003;
            // 
            // TitleOf
            // 
            TitleOf.Location = new Point(260, 190);
            TitleOf.Name = "TitleOf";
            TitleOf.PlaceholderText = "اسم المنتج";
            TitleOf.RightToLeft = RightToLeft.Yes;
            TitleOf.Size = new Size(216, 23);
            TitleOf.TabIndex = 0;
            // 
            // DescOf
            // 
            DescOf.Location = new Point(260, 219);
            DescOf.Multiline = true;
            DescOf.Name = "DescOf";
            DescOf.PlaceholderText = "وصف المنتج";
            DescOf.RightToLeft = RightToLeft.Yes;
            DescOf.Size = new Size(216, 68);
            DescOf.TabIndex = 1;
            // 
            // BuyPrice
            // 
            BuyPrice.Font = new Font("Tahoma", 10F);
            BuyPrice.Location = new Point(154, 190);
            BuyPrice.Name = "BuyPrice";
            BuyPrice.PlaceholderText = "سعر الشراء";
            BuyPrice.RightToLeft = RightToLeft.Yes;
            BuyPrice.Size = new Size(100, 24);
            BuyPrice.TabIndex = 10004;
            BuyPrice.Text = "0";
            BuyPrice.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // SellPrice
            // 
            SellPrice.Font = new Font("Tahoma", 10F);
            SellPrice.Location = new Point(12, 190);
            SellPrice.Name = "SellPrice";
            SellPrice.PlaceholderText = "سعر البيع";
            SellPrice.RightToLeft = RightToLeft.Yes;
            SellPrice.Size = new Size(136, 24);
            SellPrice.TabIndex = 10005;
            SellPrice.Text = "0";
            SellPrice.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // Discount
            // 
            Discount.Font = new Font("Tahoma", 10F);
            Discount.Location = new Point(154, 218);
            Discount.Name = "Discount";
            Discount.PlaceholderText = "المخصوم";
            Discount.RightToLeft = RightToLeft.Yes;
            Discount.Size = new Size(100, 24);
            Discount.TabIndex = 10006;
            Discount.Text = "0";
            Discount.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // Categories
            // 
            Categories.Font = new Font("Tahoma", 10F);
            Categories.FormattingEnabled = true;
            Categories.Location = new Point(12, 248);
            Categories.Name = "Categories";
            Categories.ReadOnly = false;
            Categories.Size = new Size(242, 24);
            Categories.TabIndex = 10007;
            // 
            // SaveAll
            // 
            SaveAll.BackColor = SystemColors.Highlight;
            SaveAll.BackgroundImageLayout = ImageLayout.Stretch;
            SaveAll.DefaultColor = SystemColors.Highlight;
            SaveAll.FlatAppearance.BorderSize = 0;
            SaveAll.FlatStyle = FlatStyle.Flat;
            SaveAll.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveAll.ForeColor = SystemColors.Control;
            SaveAll.Hover = Color.Empty;
            SaveAll.Location = new Point(455, 308);
            SaveAll.Name = "SaveAll";
            SaveAll.Size = new Size(150, 30);
            SaveAll.TabIndex = 10008;
            SaveAll.Text = "حفظ البيانات";
            SaveAll.UseVisualStyleBackColor = false;
            SaveAll.Click += SaveAll_Click;
            // 
            // DeleteSelected
            // 
            DeleteSelected.BackColor = SystemColors.Highlight;
            DeleteSelected.BackgroundImageLayout = ImageLayout.Stretch;
            DeleteSelected.DefaultColor = SystemColors.Highlight;
            DeleteSelected.FlatAppearance.BorderSize = 0;
            DeleteSelected.FlatStyle = FlatStyle.Flat;
            DeleteSelected.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteSelected.ForeColor = SystemColors.Control;
            DeleteSelected.Hover = Color.Empty;
            DeleteSelected.Location = new Point(299, 308);
            DeleteSelected.Name = "DeleteSelected";
            DeleteSelected.Size = new Size(150, 30);
            DeleteSelected.TabIndex = 10009;
            DeleteSelected.Text = "حذف المختار";
            DeleteSelected.UseVisualStyleBackColor = false;
            DeleteSelected.Click += DeleteSelected_Click;
            // 
            // ProductsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 349);
            Controls.Add(DeleteSelected);
            Controls.Add(SaveAll);
            Controls.Add(Categories);
            Controls.Add(Discount);
            Controls.Add(SellPrice);
            Controls.Add(BuyPrice);
            Controls.Add(DescOf);
            Controls.Add(TitleOf);
            Controls.Add(Grid);
            Controls.Add(ImageOf);
            Name = "ProductsWindow";
            Text = "ProductsWindow";
            Load += ProductsWindow_Load;
            Controls.SetChildIndex(ImageOf, 0);
            Controls.SetChildIndex(Grid, 0);
            Controls.SetChildIndex(TitleOf, 0);
            Controls.SetChildIndex(DescOf, 0);
            Controls.SetChildIndex(BuyPrice, 0);
            Controls.SetChildIndex(SellPrice, 0);
            Controls.SetChildIndex(Discount, 0);
            Controls.SetChildIndex(Categories, 0);
            Controls.SetChildIndex(SaveAll, 0);
            Controls.SetChildIndex(DeleteSelected, 0);
            ((System.ComponentModel.ISupportInitialize)ImageOf).EndInit();
            ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ImageOf;
        private DesktopSupport.SkyGrid Grid;
        private TextBox TitleOf;
        private TextBox DescOf;
        private DesktopSupport.FixedDecimalBox BuyPrice;
        private DesktopSupport.FixedDecimalBox SellPrice;
        private DesktopSupport.FixedDecimalBox Discount;
        private DesktopSupport.FixedStringComboBox Categories;
        private DesktopSupport.SkyButton SaveAll;
        private DesktopSupport.SkyButton DeleteSelected;
    }
}