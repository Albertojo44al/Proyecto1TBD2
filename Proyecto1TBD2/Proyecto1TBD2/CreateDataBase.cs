using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using FirebirdSql.Data.FirebirdClient;


namespace Proyecto1TBD2
{
    public partial class CreateDataBase : Form
    {
        FbConnectionStringBuilder fbc = new FbConnectionStringBuilder();
        public CreateDataBase()
        {
            InitializeComponent();
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        { 
            fbc.ServerType = FbServerType.Embedded;
            fbc.UserID = user.Text;
            fbc.Password = pass.Text;
            fbc.Dialect = Int32.Parse(dialect.SelectedItem.ToString());
            fbc.Database = @""+Database.Text+".FDB";
            fbc.Charset = charset.SelectedItem.ToString();
            FbConnection.CreateDatabase(fbc.ToString());
           
        }           

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
