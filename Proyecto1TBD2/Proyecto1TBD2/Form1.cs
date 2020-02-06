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
            OdbcConnection DbConnection = new OdbcConnection("Dsn=PROYECTO1TDB2;Uid=sysdba; Pwd=masterkey");
            DbConnection.Open();
            if (DbConnection.State == System.Data.ConnectionState.Open)
                MessageBox.Show("Simon");
            else
                MessageBox.Show("Nel");

            string sql = "INSERT INTO PRUEBA (CODIGO,NOMBRE) VALUES (2,'JOSE');";
            DbCommand = new OdbcCommand(sql, DbConnection);
            DbCommand.ExecuteNonQuery();
        }
    }
}
