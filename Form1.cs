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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Najm najm = new Najm();
            bindingSource1.DataSource = najm.select();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            frmAdd Fadd = new frmAdd();
            Fadd.txtId.Visible = false;
            Fadd.ShowDialog();
          //if(Fadd.isclick==true)
          //{
          //     Najm nj = new Najm();
          //     bindingSource1.DataSource = nj.select();
          //}
          
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
           
            string v = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            Najm nj = new Najm();
            nj.id = int.Parse(v);
            DataTable dt = nj.selectone();
            frmAdd fadd = new frmAdd();
            fadd.txtId.Visible = true;
            fadd.txtId.Enabled = false;
            fadd.txtId.Text = dt.Rows[0]["Id"].ToString();
            fadd.txtname.Text = dt.Rows[0]["Name1"].ToString();
            fadd.txtfamily.Text = dt.Rows[0]["Family"].ToString();
            fadd.txttell.Text = dt.Rows[0]["tell"].ToString();
            fadd.txtborn.Text = dt.Rows[0]["born"].ToString();
            fadd.Show();
            //if (fadd.isclick == true)
            //{               
            //    bindingSource1.DataSource = nj.select();
            //}
            
           
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string v = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            MessageBox.Show("آیا مطمِين به حذف هستید ", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            Najm Nj = new Najm();
            Nj.id = int.Parse(v);
            Nj.delete();
            bindingSource1.DataSource = Nj.select();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            bindingSource1.Filter = txtsearch.Text ==""?"": string.Format("Name1 like '{0}%',txtsearch.text");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void txtserchN_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
