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
    
    public partial class AddView : Form
    {
        FbConnection con;
        ArrayList al;
        int indexColumn;
        string vista="", tabla="";
        public AddView(FbConnection _con)
        {
            InitializeComponent();
            this.Location = new Point(470, 173);
            con = _con;
        }

        private void View_Load(object sender, EventArgs e)
        {
            Tabs();
        }


        public void Tabs()//list the tables of dataBase
        {
            try
            {
                string sql = "SELECT DISTINCT RDB$RELATION_NAME FROM RDB$RELATIONS WHERE RDB$VIEW_BLR IS NULL AND RDB$SYSTEM_FLAG =0;";
              
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

        private void show_Click_1(object sender, EventArgs e)
        {
            Data(dataTable);
        }

        private void dataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexColumn = e.ColumnIndex;
            DataGridViewColumn selectedColumn = dataTable.Columns[indexColumn];
            nameColumn.Text = selectedColumn.Name.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newVista = vista.TrimEnd(',');
            string newTabla = tabla.TrimEnd(',');

            try
            {
                string sql = "CREATE VIEW " + nameView.Text + "(" + newVista + ") AS SELECT " + newTabla + " FROM " + tabs.SelectedItem.ToString() + ";";
                FbCommand cmd = new FbCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                ddl(sql, true);
                MessageBox.Show("View created!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Select the proper table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            char  a = (char)34;
            vista += a + viewColumn.Text +a + ",";

            tabla += nameColumn.Text + ",";
            viewColumn.Clear();
            nameColumn.Clear();
        }

        private void dataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void ddl(string _data, bool createTable)//call dll
        {
            ShowDDL s = new ShowDDL();
            s.sortData(_data, createTable);
        }
    }
}
