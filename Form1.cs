using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Collections;

namespace CoffeeShop2
{
    public partial class Form1 : Form
    {
        List<CoffeeStatus> status;
        List<Coffee> CoffeeList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grpEmp.Visible = false;
            RomanOrdBox.Visible = false;
            btnAdd.Visible = false;
            btnDel.Visible = false;
            btnShow.Visible = false;  
            

            CoffeeList = new List<Coffee>();
            CoffeeList.Add(new Coffee() { OrdId = 1, CustName = "Jay", orderType = OrderType.The_Tribal_Chief, CoffSize = SizeCoff.Large,Status = CoffeeStatus.Completed });
            CoffeeList.Add(new Coffee() { OrdId = 2, CustName = "Darian", orderType = OrderType.Superman_Punch, CoffSize = SizeCoff.Kids, Status = CoffeeStatus.NotStarted });
            CoffeeList.Add(new Coffee() { OrdId = 3, CustName = "Brandee",orderType = OrderType.The_Bloodline_Latte_Hot, CoffSize = SizeCoff.Medium, Status = CoffeeStatus.Deleted });
            CoffeeList.Add(new Coffee() { OrdId = 4, CustName = "Alyssa",orderType = OrderType.Superman_Punch, CoffSize = SizeCoff.Medium, Status = CoffeeStatus.OnHold });
            CoffeeList.Add(new Coffee() { OrdId = 5, CustName = "Lakyma", orderType = OrderType.Day_1_ish_Iced,CoffSize = SizeCoff.Small, Status = CoffeeStatus.NotStarted });
            CoffeeGrid.DataSource = CoffeeList;
            comboOrdType.DataSource = Enum.GetValues(typeof(OrderType));
            //comboStatus.DataSource = Enum.GetValues(typeof(CoffeeStatus));
            comboSize.DataSource = Enum.GetValues(typeof(SizeCoff));
            CoffeeGrid.Visible = false;
            CoffeeGrid.Columns["OrdId"].ReadOnly = true;
            CoffeeGrid.Columns["CustName"].ReadOnly = true;
            CoffeeGrid.Columns["Status"].ReadOnly = true;
            CoffeeGrid.Columns["orderType"].ReadOnly = true;
            CoffeeGrid.Columns["CoffSize"].ReadOnly = true;
            

        }       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtOrdId.Text != string.Empty && txtFname.Text != string.Empty && comboOrdType.Text != string.Empty)
            {
                Coffee newCoffee = new Coffee();
                newCoffee.OrdId = Int32.Parse(txtOrdId.Text);
                newCoffee.CustName = txtFname.Text;
                //newCoffee. =  //error will stay until converted until enum value
                newCoffee.CoffSize = (SizeCoff)comboSize.SelectedIndex;
                CoffeeList.Add(newCoffee);
                RefreshData();

            }
            else
            {
                Console.WriteLine("Please enter a valid entry");
            }
            Console.ReadLine();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //btnDel.Visible = false;
            
            CoffeeList.RemoveAt(CoffeeGrid.CurrentRow.Index);
            RefreshData();
        }
        

        private void btnAckMe_Click(object sender, EventArgs e)
        {
            RomanOrdBox.Visible = true;
            btnAdd.Visible = true;
            btnAdd.Enabled = true;
            btnDel.Visible = true;
            btnShow.Visible = true;
            grpEmp.Visible = true;
            CoffeeGrid.Visible = true;
        }
        

        private void RefreshData()
        {
            txtOrdId.Clear();
            txtFname.Clear();
            CoffeeGrid.DataSource = null;
            CoffeeGrid.DataSource = CoffeeList;


        }

        private void comboOrdType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboOrdType.Enabled = true;
            comboOrdType.Visible = true;
         
        }

        private void CoffPlaceOrderButt_Click(object sender, EventArgs e)
        {
            if (txtOrdId.Text != string.Empty && txtFname.Text != string.Empty && comboOrdType.Text != string.Empty)
            { 
                Coffee newCoffee = new Coffee();
                newCoffee.OrdId = Int32.Parse(txtOrdId.Text);
                newCoffee.CustName = txtFname.Text;
                newCoffee.orderType = (OrderType)comboOrdType.SelectedIndex; //error will stay until converted until enum value
                newCoffee.CoffSize = (SizeCoff)comboSize.SelectedIndex;
                CoffeeList.Add(newCoffee);
                RefreshData();

            }
            else
            {
                Console.WriteLine("Please enter a valid entry.");
            }
            Console.ReadLine();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
         
         
        }
    }
}
