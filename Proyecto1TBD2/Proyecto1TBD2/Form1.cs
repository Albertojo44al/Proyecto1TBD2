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
    public partial class Form1 : Form
    {
        OdbcCommand DbCommand;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FbConnectionStringBuilder fbc = new FbConnectionStringBuilder();
            fbc.ServerType = FbServerType.Embedded;
            fbc.UserID = "SYSDBA";
            fbc.Password = "masterkey";
            fbc.Dialect = 3;
            fbc.Database = @"nuevaPrueba.fdb";
            fbc.Charset = "UTF8";
            FbConnection.CreateDatabase(fbc.ToString());
            FbConnection con = new FbConnection(fbc.ToString());
            con.Open();
        }           

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
