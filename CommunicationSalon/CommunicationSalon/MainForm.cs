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
                        addB.Visible = true;
                        infoDGV.DataSource = StaticContext.context.Brand.ToList();
                        break;
                    }
                case 1:
                    {
                        addB.Visible = false;
                        infoDGV.DataSource = StaticContext.context.Consumer.ToList();
                        break;
                    }
                case 2:
                    {
                        addB.Visible = true;
                        infoDGV.DataSource = StaticContext.context.Gender.ToList();
                        break;
                    }
                case 3:
                    {
                        addB.Visible = false;
                        infoDGV.DataSource = StaticContext.context.Order.ToList();
                        break;
                    }
                case 4:
                    {
                        addB.Visible = true;
                        infoDGV.DataSource = StaticContext.context.OrderStatus.ToList();
                        break;
                    }
                case 5:
                    {
                        addB.Visible = true;
                        infoDGV.DataSource = StaticContext.context.PhoneNumber.ToList();
                        break;
                    }
                case 6:
                    {
                        addB.Visible = true;
                        infoDGV.DataSource = StaticContext.context.Product.ToList();
                        break;
                    }
                case 7:
                    {
                        addB.Visible = false;
                        infoDGV.DataSource = StaticContext.context.ProductInOrder.ToList();
                        break;
                    }
                case 8:
                    {
                        addB.Visible = true;
                        infoDGV.DataSource = StaticContext.context.RoleConsumers.ToList();
                        break;
                    }
                case 9:
                    {
                        addB.Visible = true;
                        infoDGV.DataSource = StaticContext.context.Tariff.ToList();
                        break;
                    }
                case 10:
                    {
                        addB.Visible = true;
                        infoDGV.DataSource = StaticContext.context.TypeProduct.ToList();
                        break;
                    }
                case 11:
                    {
                        addB.Visible = true;
                        infoDGV.DataSource = StaticContext.context.User.ToList();
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

        private void registrateB_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            Close();
        }

        private void changeUserB_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            Close();
        }

        private void infoDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            change(e);
        }
        private void change(DataGridViewCellEventArgs e)
        {
            switch (tableChoiceCB.SelectedItem.ToString())
            {
                case "Brand":
                    {
                        AddChangeBrandForm addChangeBrandForm = new AddChangeBrandForm(StaticContext.context.Brand.Find(Convert.ToInt32(infoDGV.Rows[e.RowIndex].Cells[0].Value)));
                        addChangeBrandForm.Show();
                        break;
                    }
                case "Consumer":
                    {

                        break;
                    }
                case "Gender":
                    {
                        AddChangeGenderForm addChangeGenderForm = new AddChangeGenderForm(StaticContext.context.Gender.Find(Convert.ToInt32(infoDGV.Rows[e.RowIndex].Cells[0].Value)));
                        addChangeGenderForm.Show();
                        break;
                    }
                case "Order":
                    {
                        break;
                    }
                case "OrderStatus":
                    {
                        AddChangeOrderStatusForm addChangeOrderStatusForm = new AddChangeOrderStatusForm(StaticContext.context.OrderStatus.Find(Convert.ToInt32(infoDGV.Rows[e.RowIndex].Cells[0].Value)));
                        addChangeOrderStatusForm.Show();
                        break;
                    }
                case "PhoneNumber":
                    {
                        AddChangePhoneNumberForm addChangePhoneNumberForm = new AddChangePhoneNumberForm(StaticContext.context.PhoneNumber.Find(infoDGV.Rows[e.RowIndex].Cells[0].Value));
                        addChangePhoneNumberForm.Show();
                        break;
                    }
                case "Product":
                    {
                        AddChangeProductForm addChangeProductForm = new AddChangeProductForm(StaticContext.context.Product.Find(infoDGV.Rows[e.RowIndex].Cells[0].Value));
                        addChangeProductForm.Show();
                        break;
                    }
                case "ProductInOrder":
                    {
                        break;
                    }
                case "RoleConsumer":
                    {
                        AddChangeRoleConsumerForm addChangeRoleConsumerForm = new AddChangeRoleConsumerForm(StaticContext.context.RoleConsumers.Find(Convert.ToInt32(infoDGV.Rows[e.RowIndex].Cells[0].Value)));
                        addChangeRoleConsumerForm.Show();
                        break;
                    }
                case "Tariff":
                    {
                        AddChangeTariffForm addChangeTariffForm = new AddChangeTariffForm(StaticContext.context.Tariff.Find(Convert.ToInt32(infoDGV.Rows[e.RowIndex].Cells[0].Value)));
                        addChangeTariffForm.Show();
                        break;
                    }
                case "TypeProduct":
                    {
                        AddChangeTypeProductForm addChangeTypeProductForm = new AddChangeTypeProductForm(StaticContext.context.TypeProduct.Find(Convert.ToInt32(infoDGV.Rows[e.RowIndex].Cells[0].Value)));
                        addChangeTypeProductForm.Show();
                        break;
                    }
                case "User":
                    {
                        AddChangeUserForm addChangeUserForm = new AddChangeUserForm(StaticContext.context.User.Find(Convert.ToInt32(infoDGV.Rows[e.RowIndex].Cells[0].Value)));
                        addChangeUserForm.Show();
                        break;
                    }
            }
        }
        private void add()
        {
            switch (tableChoiceCB.SelectedItem.ToString())
            {
                case "Brand":
                    {
                        AddChangeBrandForm addChangeBrandForm = new AddChangeBrandForm();
                        addChangeBrandForm.Show();
                        break;
                    }
                case "Consumer":
                     {
                        
                        break;
                    }
                case "Gender":
                         {
                        AddChangeGenderForm addChangeGenderForm = new AddChangeGenderForm();
                        addChangeGenderForm.Show();
                        break;
                    }
                case "Order":
                         {
                        break;
                    }
                case "OrderStatus":
                    {
                        AddChangeOrderStatusForm addChangeOrderStatusForm = new AddChangeOrderStatusForm();
                        addChangeOrderStatusForm.Show();
                        break;
                    }
                case "PhoneNumber":
                    {
                        AddChangePhoneNumberForm addChangePhoneNumberForm = new AddChangePhoneNumberForm();
                        addChangePhoneNumberForm.Show();
                        break;
                    }
                case "Product":
                    {
                        AddChangeProductForm addChangeProductForm = new AddChangeProductForm();
                        addChangeProductForm.Show();
                        break;
                    }
                case "ProductInOrder":
                    {
                        break;
                    }
                case "RoleConsumer":
                    {
                        AddChangeRoleConsumerForm addChangeRoleConsumerForm = new AddChangeRoleConsumerForm();
                        addChangeRoleConsumerForm.Show();
                        break;
                    }
                case "Tariff":
                    {
                        AddChangeTariffForm addChangeTariffForm = new AddChangeTariffForm();
                        addChangeTariffForm.Show();
                        break;
                    }
                case "TypeProduct":
                    {
                        AddChangeTypeProductForm addChangeTypeProductForm = new AddChangeTypeProductForm();
                        addChangeTypeProductForm.Show();
                        break;
                    }
                case "User":
                    {
                        AddChangeUserForm addChangeUserForm = new AddChangeUserForm();
                        addChangeUserForm.Show();
                        break;
                    }
            }
        }

        private void addB_Click(object sender, EventArgs e)
        {
            add();
        }
    }
}
