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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            StaticContext.context.Brand.Find(1);
            StaticContext.context.SaveChanges();
            tableChoiceCB.SelectedIndex = 0;
        }
        public void FillDGV()
        {
            switch (tableChoiceCB.SelectedIndex)
            {
                case 0:
                    {
                        infoDGV.DataSource = StaticContext.context.Consumer.ToList();
                        break;
                    }
                case 1:
                    {
                        infoDGV.DataSource = StaticContext.context.Order.ToList();
                        break;
                    }
                case 2:
                    {
                        infoDGV.DataSource = StaticContext.context.PhoneNumber.ToList();
                        break;
                    }
                case 3:
                    {
                        infoDGV.DataSource = StaticContext.context.Product.ToList();
                        break;
                    }
                case 4:
                    {
                        infoDGV.DataSource = StaticContext.context.Tariff.ToList();
                        break;
                    }
            }
        }

        private void tableChoiceCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void fill_Click(object sender, EventArgs e)
        {
            StartData sd = new StartData();
            sd.fill();
        }
    }
}
