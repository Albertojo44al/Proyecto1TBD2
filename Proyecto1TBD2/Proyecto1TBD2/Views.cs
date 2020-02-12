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
using System.Collections;

namespace Proyecto1TBD2
{
    public partial class Views : Form
    {
        FbConnection con;
        ArrayList al;
        public Views(FbConnection _con)
        {
            InitializeComponent();
            this.Location = new Point(470, 173);
            con = _con;
        }

        private void Views_Load(object sender, EventArgs e)
        {
            Tabs();
        }
        public void Data(DataGridView dgv)//show data in dataGridView
        {
            try
            {
                string sql = "select * from " + tabs.SelectedItem.ToString() + ";";
                FbCommand cmd = new FbCommand(sql, con);
                FbDataAdapter dta = new FbDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                dta.Fill(dt);
                dgv.DataSource = dt;
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void Tabs()//list the tables of dataBase
        {
            try
            {
                string sql = "SELECT DISTINCT RDB$RELATION_NAME FROM RDB$RELATIONS WHERE RDB$VIEW_BLR IS NOT NULL AND RDB$SYSTEM_FLAG =0;";

                FbCommand cmd = new FbCommand(sql, con);
                FbDataReader reader = cmd.ExecuteReader();

                al = new ArrayList();
                while (reader.Read())
                {
                    al.Add(reader.GetString(0).Trim());
                }

                tabs.DataSource = al;
                tabs.SelectedIndexChanged += tabs_SelectedIndexChanged;
            }
            catch (Exception)
            {
                MessageBox.Show("You are not connected to a database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddView a = new AddView(con);
            a.Show();
        }

        private void show_Click(object sender, EventArgs e)
        {
            Data(dataTable);
        }

        private void button1_Click(object sender, EventArgs e)//delete view
        {
            var result = MessageBox.Show("Are you sure to delete the " + tabs.SelectedItem.ToString() + " view", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    string sql = "DROP VIEW " + tabs.SelectedItem.ToString() + " ;";
                    FbCommand cmd = new FbCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    ddl(sql,false);
                    MessageBox.Show("View droped!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("View not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void ddl(string _data, bool createTable)//call dll
        {
            ShowDDL s = new ShowDDL();
            s.sortData(_data, createTable);
        }
    }
}
