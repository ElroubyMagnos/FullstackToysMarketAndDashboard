namespace ToysDashboard.DB
{
    partial class CategoriesWindow
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
            Grid = new DesktopSupport.SkyGrid();
            IDOf = new DesktopSupport.IntegerBox();
            NameOf = new TextBox();
            DescOf = new TextBox();
            SaveAll = new DesktopSupport.SkyButton();
            DeleteSelected = new DesktopSupport.SkyButton();
            ImageOf = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageOf).BeginInit();
            SuspendLayout();
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
            Grid.Location = new Point(12, 38);
            Grid.MultiSelect = false;
            Grid.Name = "Grid";
            Grid.ReadOnly = true;
            Grid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grid.Size = new Size(321, 179);
            Grid.TabIndex = 10002;
            // 
            // IDOf
            // 
            IDOf.Location = new Point(233, 223);
            IDOf.Name = "IDOf";
            IDOf.ReadOnly = true;
            IDOf.RightToLeft = RightToLeft.Yes;
            IDOf.Size = new Size(100, 23);
            IDOf.TabIndex = 0;
            IDOf.Text = "0";
            IDOf.TextAlign = HorizontalAlignment.Center;
            IDOf.Value = 0;
            // 
            // NameOf
            // 
            NameOf.Location = new Point(12, 223);
            NameOf.Name = "NameOf";
            NameOf.PlaceholderText = "اسم القسم";
            NameOf.RightToLeft = RightToLeft.Yes;
            NameOf.Size = new Size(215, 23);
            NameOf.TabIndex = 1;
            NameOf.TextAlign = HorizontalAlignment.Center;
            // 
            // DescOf
            // 
            DescOf.Location = new Point(12, 252);
            DescOf.Multiline = true;
            DescOf.Name = "DescOf";
            DescOf.PlaceholderText = "وصف القسم";
            DescOf.RightToLeft = RightToLeft.Yes;
            DescOf.Size = new Size(215, 186);
            DescOf.TabIndex = 2;
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
            SaveAll.Location = new Point(121, 444);
            SaveAll.Name = "SaveAll";
            SaveAll.Size = new Size(212, 30);
            SaveAll.TabIndex = 3;
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
            DeleteSelected.Location = new Point(12, 444);
            DeleteSelected.Name = "DeleteSelected";
            DeleteSelected.Size = new Size(103, 30);
            DeleteSelected.TabIndex = 4;
            DeleteSelected.Text = "حذف";
            DeleteSelected.UseVisualStyleBackColor = false;
            DeleteSelected.Click += DeleteSelected_Click;
            // 
            // ImageOf
            // 
            ImageOf.BackColor = SystemColors.ActiveCaption;
            ImageOf.BackgroundImageLayout = ImageLayout.Stretch;
            ImageOf.Location = new Point(233, 252);
            ImageOf.Name = "ImageOf";
            ImageOf.Size = new Size(100, 63);
            ImageOf.TabIndex = 10003;
            ImageOf.TabStop = false;
            ImageOf.Click += ImageOf_Click;
            // 
            // CategoriesWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 493);
            Controls.Add(ImageOf);
            Controls.Add(DeleteSelected);
            Controls.Add(SaveAll);
            Controls.Add(DescOf);
            Controls.Add(NameOf);
            Controls.Add(IDOf);
            Controls.Add(Grid);
            Name = "CategoriesWindow";
            Text = "CategoriesWindow";
            Load += CategoriesWindow_Load;
            Controls.SetChildIndex(Grid, 0);
            Controls.SetChildIndex(IDOf, 0);
            Controls.SetChildIndex(NameOf, 0);
            Controls.SetChildIndex(DescOf, 0);
            Controls.SetChildIndex(SaveAll, 0);
            Controls.SetChildIndex(DeleteSelected, 0);
            Controls.SetChildIndex(ImageOf, 0);
            ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImageOf).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DesktopSupport.SkyGrid Grid;
        private DesktopSupport.IntegerBox IDOf;
        private TextBox NameOf;
        private TextBox DescOf;
        private DesktopSupport.SkyButton SaveAll;
        private DesktopSupport.SkyButton DeleteSelected;
        private PictureBox ImageOf;
    }
}