namespace ToysDashboard.DB
{
    partial class BillsWindow
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
            ProductsOf = new FlowLayoutPanel();
            skyButton1 = new DesktopSupport.SkyButton();
            skyButton2 = new DesktopSupport.SkyButton();
            ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
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
            Grid.Location = new Point(12, 34);
            Grid.MultiSelect = false;
            Grid.Name = "Grid";
            Grid.ReadOnly = true;
            Grid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grid.Size = new Size(776, 150);
            Grid.TabIndex = 10002;
            Grid.SelectionChanged += Grid_SelectionChanged;
            // 
            // ProductsOf
            // 
            ProductsOf.Location = new Point(12, 190);
            ProductsOf.Name = "ProductsOf";
            ProductsOf.Size = new Size(200, 248);
            ProductsOf.TabIndex = 10003;
            // 
            // skyButton1
            // 
            skyButton1.BackColor = SystemColors.Highlight;
            skyButton1.BackgroundImageLayout = ImageLayout.Stretch;
            skyButton1.DefaultColor = SystemColors.Highlight;
            skyButton1.FlatAppearance.BorderSize = 0;
            skyButton1.FlatStyle = FlatStyle.Flat;
            skyButton1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            skyButton1.ForeColor = SystemColors.Control;
            skyButton1.Hover = Color.Empty;
            skyButton1.Location = new Point(545, 349);
            skyButton1.Name = "skyButton1";
            skyButton1.Size = new Size(119, 89);
            skyButton1.TabIndex = 10004;
            skyButton1.Text = "skyButton1";
            skyButton1.UseVisualStyleBackColor = false;
            // 
            // skyButton2
            // 
            skyButton2.BackColor = SystemColors.Highlight;
            skyButton2.BackgroundImageLayout = ImageLayout.Stretch;
            skyButton2.DefaultColor = SystemColors.Highlight;
            skyButton2.FlatAppearance.BorderSize = 0;
            skyButton2.FlatStyle = FlatStyle.Flat;
            skyButton2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            skyButton2.ForeColor = SystemColors.Control;
            skyButton2.Hover = Color.Empty;
            skyButton2.Location = new Point(670, 349);
            skyButton2.Name = "skyButton2";
            skyButton2.Size = new Size(119, 89);
            skyButton2.TabIndex = 10005;
            skyButton2.Text = "skyButton2";
            skyButton2.UseVisualStyleBackColor = false;
            // 
            // BillsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(skyButton2);
            Controls.Add(skyButton1);
            Controls.Add(ProductsOf);
            Controls.Add(Grid);
            Name = "BillsWindow";
            Text = "BillsWindow";
            Load += BillsWindow_Load;
            Controls.SetChildIndex(Grid, 0);
            Controls.SetChildIndex(ProductsOf, 0);
            Controls.SetChildIndex(skyButton1, 0);
            Controls.SetChildIndex(skyButton2, 0);
            ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DesktopSupport.SkyGrid Grid;
        private FlowLayoutPanel ProductsOf;
        private DesktopSupport.SkyButton skyButton1;
        private DesktopSupport.SkyButton skyButton2;
    }
}