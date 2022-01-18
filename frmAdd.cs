using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BL;
using DA;

namespace _3layer
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }
       public bool isclick = false;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            isclick = true;
            Najm Nj = new Najm();
           //Nj.id = int.Parse(txtId.Text);
            Nj.name1 = txtname.Text;
            Nj.family = txtfamily.Text;
            Nj.tell = txttell.Text;
            Nj.born = txtborn.Text;
            Form1 frm1 = new Form1();
            if (txtId.Text == "")
            {
                Nj.Add();
                MessageBox.Show("کاربر مورد نظر اضافه شد");                           
            }
               
                
            else
            {
               
                Nj.id = int.Parse(txtId.Text);
                Nj.udate();
                MessageBox.Show("کاربر مورد نظر ویرایش شد");             
            }
            frm1.bindingSource1.DataSource = Nj.select();  
            this.Close();
           

        }
    }
}
