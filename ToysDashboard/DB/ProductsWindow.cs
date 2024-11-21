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
    public partial class ProductsWindow : CustomWindow
    {
        public ProductsWindow()
        {
            InitializeComponent();
        }

        private async void ProductsWindow_Load(object sender, EventArgs e)
        {
            var tc = new tcore();

            Grid.DataSource = await tc.Products.Select(x => new
            {
                x.ID,
                x.Title,
                x.Description,
                x.BuyPrice,
                x.Price,
                x.DiscountNow,
                x.CategoryName
            }).ToListAsync();

            Categories.Items.Clear();

            foreach (var cat in tc.Categories.Select(x => new
            {
                x.Name
            }))
            {
                Categories.Items.Add(cat.Name);
            }
        }

        private async void SaveAll_Click(object sender, EventArgs e)
        {
            foreach (TextBox cont in Controls.OfType<TextBox>())
            {
                if (cont.Text.Length == 0)
                {
                    MessageBox.Show("لقد نسيت خانة");
                    return;
                }
            }

            if (ImageOf.BackgroundImage == null)
            {
                MessageBox.Show("لم تختر صورة");
                return;
            }

            if (SellPrice.Value <= BuyPrice.Value)
            {
                MessageBox.Show("لا يمكن ان يكون سعر البيع اقل او يساوي سعر الشراء");
                return;
            }

            var tc = new tcore();

            var Selected = await tc.Products.FirstOrDefaultAsync(x => x.Title == TitleOf.Text);
            if (Selected != null)
            {
                MessageBox.Show("لا يمكن اضافة منتجات متشابهة الاسم");
            }


            await tc.Products.AddAsync(new Product()
            {
                Image = ImageOf.BackgroundImage.ToArray(),
                Title = TitleOf.Text,
                BuyPrice = (double)BuyPrice.Value,
                Price = (double)SellPrice.Value,
                Description = DescOf.Text,
                DiscountNow = (double)Discount.Value,
                CategoryID = (await tc.Categories.FirstOrDefaultAsync(x => x.Name == Categories.Text)).ID,
                CategoryName = Categories.Text
            });

            await tc.SaveChangesAsync();

            foreach (TextBox cont in Controls.OfType<TextBox>())
            {
                cont.Clear();
            }

            ProductsWindow_Load(sender, e);

        }

        private void Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();

            if (OP.ShowDialog() == DialogResult.OK)
            {
                ImageOf.BackgroundImage = Image.FromFile(OP.FileName).ResizeImage(500, 500);
            }
        }

        private async void DeleteSelected_Click(object sender, EventArgs e)
        {
            if (Grid.SelectedRows.Count > 0)
            {
                var tc = new tcore();

                var Selected = await tc.Products.FirstOrDefaultAsync(x => x.ID == Grid.SelectedRows[0].Cells[0].Value.ToString().IntOrDefault());

                if (Selected != null)
                {
                    tc.Products.Remove(Selected);

                    await tc.SaveChangesAsync();

                    ProductsWindow_Load(sender, e);
                }
            }
        }
    }
}
