namespace _3layer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lbsearch = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.born = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(438, 278);
            this.btnadd.Name = "btnadd";
            this.btnadd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "ایجاد:";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(357, 278);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "ویرایش:";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(276, 278);
            this.btndelete.Name = "btndelete";
            this.btndelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "حذف:";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(12, 278);
            this.btnexit.Name = "btnexit";
            this.btnexit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnexit.Size = new System.Drawing.Size(65, 23);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "خروج:";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lbsearch
            // 
            this.lbsearch.AutoSize = true;
            this.lbsearch.Location = new System.Drawing.Point(218, 283);
            this.lbsearch.Name = "lbsearch";
            this.lbsearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbsearch.Size = new System.Drawing.Size(43, 13);
            this.lbsearch.TabIndex = 4;
            this.lbsearch.Text = "جستجو:";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(92, 281);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(100, 20);
            this.txtsearch.TabIndex = 5;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.family,
            this.tell,
            this.born,
            this.Name1});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 232);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "کد";
            this.Id.Name = "Id";
            // 
            // family
            // 
            this.family.DataPropertyName = "Family";
            this.family.HeaderText = "فامیلی";
            this.family.Name = "family";
            // 
            // tell
            // 
            this.tell.DataPropertyName = "Tell";
            this.tell.HeaderText = "تلفن";
            this.tell.Name = "tell";
            // 
            // born
            // 
            this.born.DataPropertyName = "Born";
            this.born.HeaderText = "تاریخ تولد";
            this.born.Name = "born";
            // 
            // Name1
            // 
            this.Name1.DataPropertyName = "Name1";
            this.Name1.HeaderText = "نام";
            this.Name1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.Name1.Name = "Name1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 313);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lbsearch);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lbsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn family;
        private System.Windows.Forms.DataGridViewTextBoxColumn tell;
        private System.Windows.Forms.DataGridViewTextBoxColumn born;
        private System.Windows.Forms.DataGridViewLinkColumn Name1;
        public System.Windows.Forms.BindingSource bindingSource1;
    }
}