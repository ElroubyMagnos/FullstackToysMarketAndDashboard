using DesktopSupport;
using GazaAIDashboard.Source;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToysCore;
using ToysCore.Models;

namespace ToysDashboard.DB
{
    public partial class CategoriesWindow : CustomWindow
    {
        public CategoriesWindow()
        {
            InitializeComponent();
        }

        private async void CategoriesWindow_Load(object sender, EventArgs e)
        {
            var tc = new tcore();

            Grid.DataSource = await tc.Categories.Select(x => new
            {
                x.ID,
                x.Name,
                x.Desc
            }).ToListAsync();
        }

        private async void SaveAll_Click(object sender, EventArgs e)
        {
            if (NameOf.Text.Length == 0 || DescOf.Text.Length == 0)
            {
                MessageBox.Show("من فضلك املئ كل الخانات");
                return;
            }

            if (ImageOf.BackgroundImage == null)
            {
                MessageBox.Show("لا يمكن ترك الصورة فارغة");
                return;
            }

            var tc = new tcore();

            var Selected = await tc.Categories.FirstOrDefaultAsync(x => x.Name == NameOf.Text);

            if (Selected == null)
            {
                await tc.Categories.AddAsync(new Category()
                {
                    Name = NameOf.Text,
                    Desc = DescOf.Text,
                    Image = ImageOf.BackgroundImage.ToArray()
                });

                await tc.SaveChangesAsync();

                NameOf.Clear();
                DescOf.Clear();

                CategoriesWindow_Load(sender, e);
            }
            else MessageBox.Show("لا يمكن اضافة اقسام باسماء متشابهه");
        }

        private async void DeleteSelected_Click(object sender, EventArgs e)
        {
            if (Grid.SelectedRows.Count > 0)
            {
                var tc = new tcore();

                var Selected = await tc.Categories.FirstOrDefaultAsync(x => x.ID == Grid.SelectedRows[0].Cells[0].Value.ToString().IntOrDefault());

                if (Selected != null)
                {
                    tc.Categories.Remove(Selected);

                    await tc.SaveChangesAsync();

                    CategoriesWindow_Load(sender, e);
                }
            }
        }

        private void ImageOf_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();

            if (OP.ShowDialog() == DialogResult.OK)
            {
                ImageOf.BackgroundImage = Image.FromFile(OP.FileName).ResizeImage(500, 500);
            }
        }
    }
}
