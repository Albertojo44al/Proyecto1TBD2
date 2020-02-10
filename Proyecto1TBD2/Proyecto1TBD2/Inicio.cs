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
    public partial class Inicio : Form
    {
        FbConnection con;
        String path;
        public Inicio()
        {
            InitializeComponent();
            this.Location = new Point(262, 113);
        }
        public Inicio(string _path, FbConnection _con)
        {
            InitializeComponent();
            this.Location = new Point(262, 113);
            con = _con;
            path = _path;
        }    

        private void create_Click(object sender, EventArgs e)
        {
            CreateDataBase cdb = new CreateDataBase();
            cdb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectDataBase con = new ConnectDataBase();
            con.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateDataBase cdb = new CreateDataBase();
            cdb.Show();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            ConnectDataBase con = new ConnectDataBase();
            con.Show();

                
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Tools t = new Tools();
            t.Show();
        }

        private void drop_Click(object sender, EventArgs e)
        {
            con.Close();
            FbConnection.ClearAllPools();
            FbConnection.DropDatabase(path);
            Tools t = new Tools();
            t.Hide();
        }
    }
}
