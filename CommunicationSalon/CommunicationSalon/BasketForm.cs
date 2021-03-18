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
    public partial class BasketForm : Form
    {
        List<ProductInOrder> po;
        Order o;
        public BasketForm(List<ProductInOrder> po, Order o)
        {
            InitializeComponent();
            this.po = po;
            this.o = o;
            fillDGV();
        }
        private void fillDGV()
        {
            infoDGV.DataSource = po;
        }
        private void createOrderB_Click(object sender, EventArgs e)
        {
            AddChangeOrderForm addChangeOrderForm = new AddChangeOrderForm(o, po);
            addChangeOrderForm.Show();
            Close();
        }
    }
}
