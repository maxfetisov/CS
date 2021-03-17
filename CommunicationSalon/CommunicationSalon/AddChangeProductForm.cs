using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunicationSalon
{
    public partial class AddChangeProductForm : Form
    {
        private Product p;
        private List<Brand> brands = StaticContext.context.Brand.ToList();
        private List<TypeProduct> typeProducts = StaticContext.context.TypeProduct.ToList();
        public AddChangeProductForm()
        {
            InitializeComponent();
            changeB.Visible = deleteB.Visible = false;
            articleTB.ReadOnly = false;
            fillBrandCB();
            fillTypeProductCB();
        }
        public AddChangeProductForm(Product p)
        {
            InitializeComponent();
            addB.Visible = false;
            articleTB.ReadOnly = true;
            this.p = p;
            fillBrandCB();
            fillTypeProductCB();
            articleTB.Text = p.Article;
            brandCB.SelectedIndex = brands.IndexOf(StaticContext.context.Brand.Find(p.BrandId));
            nameTB.Text = p.Name;
            modelTB.Text = p.Model;
            typeProductCB.SelectedIndex = typeProducts.IndexOf(StaticContext.context.TypeProduct.Find(p.TypeProductId));
            priceNUD.Value = p.Price;
            quantityInStockNUD.Value = p.QuantityInStock;
        }
        private void fillBrandCB()
        {
            foreach (Brand b in brands)
            {
                brandCB.Items.Add(b.Name);
            }
        }
        private void fillTypeProductCB()
        {
            foreach (TypeProduct tp in typeProducts)
            {
                typeProductCB.Items.Add(tp.Name);
            }
        }
        private void deleteB_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Уверен?", "Предупреждение", MessageBoxButtons.YesNo))
            {
                StaticContext.context.Product.Remove(p);
                StaticContext.context.SaveChanges();
                Close();
            }
        }

        private void changeB_Click(object sender, EventArgs e)
        {
            p.BrandId = brands[brandCB.SelectedIndex].Id;
            p.Name = nameTB.Text;
            p.Model = modelTB.Text;
            p.TypeProductId = typeProducts[typeProductCB.SelectedIndex].Id;
            p.Price = priceNUD.Value;
            p.QuantityInStock = (int)quantityInStockNUD.Value;
            StaticContext.context.SaveChanges();
            Close();
        }

        private void addB_Click(object sender, EventArgs e)
        {
            StaticContext.context.Product.Add(new Product(articleTB.Text, brands[brandCB.SelectedIndex].Id, nameTB.Text, modelTB.Text, typeProducts[typeProductCB.SelectedIndex].Id, priceNUD.Value, (int)quantityInStockNUD.Value));
            StaticContext.context.SaveChanges();
            Close();
        }
    }
}
