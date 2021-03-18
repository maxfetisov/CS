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
        private Order o;
        private List<ProductInOrder> po;
        private List<Brand> brands = StaticContext.context.Brand.ToList();
        private List<TypeProduct> typeProducts = StaticContext.context.TypeProduct.ToList();
        public AddChangeProductForm()
        {
            InitializeComponent();
            changeB.Visible = deleteB.Visible = countL.Visible = countM.Visible = countP.Visible = cL.Visible = articleTB.ReadOnly = false;
            fillBrandCB();
            fillTypeProductCB();
        }
        public AddChangeProductForm(Product p)
        {
            InitializeComponent();
            addB.Visible = countL.Visible = countM.Visible = countP.Visible = cL.Visible = false;
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
        public AddChangeProductForm(Product p, ref Order o, ref List<ProductInOrder> po)
        {
            InitializeComponent();
            addB.Visible = changeB.Visible = deleteB.Visible = brandCB.Enabled = typeProductCB.Enabled = priceNUD.Enabled = quantityInStockNUD.Enabled = false;
            articleTB.ReadOnly = nameTB.ReadOnly = modelTB.ReadOnly = true;
            this.p = p;
            this.o = o;
            this.po = po;
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

        private void countM_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(countL.Text);
            if(c > 1)
            {
                countL.Text = (c - 1).ToString();
            }
        }

        private void countP_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(countL.Text);
            if (c < p.QuantityInStock)
            {
                countL.Text = (c + 1).ToString();
            }
        }

        private void intoBasketB_Click(object sender, EventArgs e)
        {
            ProductInOrder pio = new ProductInOrder(
                o.Id, 
                p.Article, 
                Convert.ToInt32(countL.Text)
                );
            po.Add(pio);
        }
    }
}
