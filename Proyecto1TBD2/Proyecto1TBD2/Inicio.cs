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
        FbConnectionStringBuilder path;
        public Inicio()
        {
            InitializeComponent();
            this.Location = new Point(262, 113);
        }
        public Inicio(FbConnectionStringBuilder _path, FbConnection _con)
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
            this.Hide();
            ConnectDataBase con = new ConnectDataBase();
            con.Show();

                
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Tools t = new Tools(con,"");
            t.Show();
        }

        private void drop_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to drop the " + path.Database + " Database", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    con.Close();
                    con.Close();
                    FbConnection.ClearAllPools();
                    FbConnection.DropDatabase(path.ToString());
                    Tools t = new Tools();
                    t.Close();
                    MessageBox.Show("Database " + path.Database + " has been removed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database file was not found on the host. Please connect to a Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            CreateUser c = new CreateUser(con);
            c.Show();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string users = "";
            string sql = "SELECT DISTINCT RDB$USER FROM RDB$USER_PRIVILEGES;";
            FbCommand cmd = new FbCommand(sql, con);
            
            
            try
            {
                FbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    users += reader.GetString(0).Trim()+ " \n";
                }
                MessageBox.Show(users, "USERS", MessageBoxButtons.OK);
                ddl(sql, false);
            }
            catch (Exception)
            {
                MessageBox.Show("Yo are not connected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void ddl(string _data, bool createTable)//call dll
        {
            ShowDDL s = new ShowDDL();
            s.sortData(_data, createTable);
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
