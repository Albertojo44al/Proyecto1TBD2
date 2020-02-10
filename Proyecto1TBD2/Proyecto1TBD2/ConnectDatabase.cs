using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Proyecto1TBD2
{
    public partial class ConnectDataBase : Form
    {
        public FbConnectionStringBuilder fbc;
        public Conection obj = new Conection();
        FbConnection con = new FbConnection();
        public ConnectDataBase()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        

        private void test_Click(object sender, EventArgs e)
        {
            fbc = new FbConnectionStringBuilder();
            fbc.ServerType = FbServerType.Embedded;
            fbc.UserID = user.Text;
            fbc.Password = pass.Text;
            fbc.Database = @""+Database.Text+".FDB";
            fbc.Charset = charset.SelectedItem.ToString();
            obj.setPath(fbc.ToString());
            con = obj.Conectar();
            
            //FbConnection.ClearAllPools();
            //FbConnection.DropDatabase(fbc.ToString());


        }

        private void finish_Click(object sender, EventArgs e)
        {

            Tools t = new Tools(con);
            Inicio i = new Inicio(fbc.ToString(), con);
            i.Hide();
            i.Show();
            t.Show();
            this.Hide();
            

           
        }
        private void ConnectDataBase_Load(object sender, EventArgs e)
        {

        }
    }
}
