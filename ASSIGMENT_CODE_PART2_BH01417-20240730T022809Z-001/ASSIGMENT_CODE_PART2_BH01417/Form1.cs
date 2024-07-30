using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSIGMENT_CODE_PART2_BH01417
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbGender_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lsvBill.View = View.Details;
            //lsvBill.GridLines = true;
            //lsvBill.FullRowSelect = true;


            //lsvBill.Columns.Add("No", 50);
            //lsvBill.Columns.Add("Name", 150);
            //lsvBill.Columns.Add("Phone", 100);
            //lsvBill.Columns.Add("Gender", 50);

            ListViewItem add1 = new ListViewItem();
            add1.Text = "01";
            add1.SubItems.Add("Lâm");
            add1.SubItems.Add("5158986");
            add1.SubItems.Add("MALE");

            lsvBill.Items.Add(add1);
        }

        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvBill.SelectedItems.Count > 0)
            {
                ListViewItem select_Item = lsvBill.SelectedItems[0];

                string No = select_Item.SubItems[0].Text;
                string Name = select_Item.SubItems[1].Text;
                string Phone = select_Item.SubItems[2].Text;
                string Gender = select_Item.SubItems[3].Text;

                // đẩy dữ liệu vào form
                tbNo.Text = No;
                tbName.Text = Name;
                tbPhone.Text = Phone;

                if (Gender == "FEMALE")
                {
                    rbF.Checked = true;
                }
                else if (Gender == "MALE")
                {
                    rbM.Checked = true;
                }
            }
            else
            {
                // xoá các mục khi không cái nào được chọn
                tbNo.Text = "";
                tbName.Text = "";
                tbPhone.Text = "";
                rbF.Checked = false;
                rbM.Checked = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string No = tbNo.Text;
            string Name = tbName.Text;
            string Phone = tbPhone.Text;


            string Gender = null;
            if (rbF.Checked)
            {
                Gender = "FEMALE";
            }
            else if (rbM.Checked)
            {
                Gender = "MALE";
            }
            


            ListViewItem item = new ListViewItem();
            item.Text = No;
            item.SubItems.Add(Name);
            item.SubItems.Add(Phone);
            item.SubItems.Add(Gender);

            lsvBill.Items.Add(item);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lsvBill.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvBill.SelectedItems[0];
                item.SubItems.Clear();

                string No = tbNo.Text;
                string Name = tbName.Text;
                string Phone = tbPhone.Text;

                string Gender = null;
                if (rbF.Checked)
                {
                    Gender = "FEMALE";
                }
                else if (rbM.Checked)
                {
                    Gender = "MALE";
                }
                

                item.Text = No;
                item.SubItems.Add(Name);
                item.SubItems.Add(Phone);
                item.SubItems.Add(Gender);
                


                tbNo.Text = null;
                tbName.Text = null;
                tbPhone.Text = null;
                rbF.Checked = false;
                rbM.Checked = false;
               
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLastMonth.Text) || string.IsNullOrEmpty(tbThisMonth.Text))
            {
                MessageBox.Show("PLEASE ENTER FULLY");
                return;
            }

            if (int.TryParse(tbLastMonth.Text, out int LastMonth) && int.TryParse(tbThisMonth.Text, out int ThisMonth))

                if (LastMonth >= ThisMonth)
                {
                    MessageBox.Show("Wrong.");
                    return;
                }
            int consump = int.Parse(tbThisMonth.Text) - int.Parse(tbLastMonth.Text);

            double type = int.Parse(tbType.Text);
            int people = int.Parse(tbPeople.Text);
            double consumpPerson = consump / people;

            double price = 0;
            if (type == 1)
            {
                if (consump <= 10)
                {
                    price = consump * 5.937;
                }
                else if (consump <= 20)
                {
                    price = (10 * 5.973) + ((consump - 10) * 7.052);
                }
                else if (consump <= 30)
                {
                    price = (10 * 5.973) + (10 * 7.052) + ((consump - 20) * 8.699);
                }
                else
                {
                    price = (10 * 5.973) + (10 * 7.052) + (10 * 8.699) + ((consump - 30) * 15.929);
                }
            }
            else if (type == 2)
            {
                price = consump * 22.068;
            }
            else if (type == 3)
            {
                price = consump * 9.955;
            }
            else if (type == 4)
            {
                price = consump * 11.615;
            }
            else
            {
                MessageBox.Show("Invalid");
                return;
            }
            double envFee = price * 0.1;
            double VAT = price * 0.1;
            double totalBill = price + VAT + envFee;

            if (lsvBill.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvBill.SelectedItems[0];
                selectedItem.SubItems.Add(consump.ToString("") + " m3");
                selectedItem.SubItems.Add(totalBill.ToString("") + " VND");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lsvBill.SelectedItems.Count > 0)
            {
                lsvBill.Items.Remove(lsvBill.SelectedItems[0]);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có muốn thoát thật không",
               "Warning",
               MessageBoxButtons.YesNo);

            if (exit == DialogResult.Yes)
            {
                Hide();
            }
        }
    }
}
