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
    public partial class Tables : Form
    {
        FbConnection con = new FbConnection();
        string deleteS;
        public Tables()
        {
            InitializeComponent();
            this.Location = new Point(470, 173);
        }
        public Tables(FbConnection _con)
        {
            InitializeComponent();
            this.Location = new Point(470, 173);
            con = _con;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewTable t = new NewTable(con);
            t.Show();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Tabs()
        {
            try
            {
                string sql = "select distinct RDB$RELATION_NAME FROM RDB$RELATIONS WHERE RDB$VIEW_BLR IS NULL AND RDB$SYSTEM_FLAG =0;";
                FbCommand cmd = new FbCommand(sql, con);
                FbDataReader reader = cmd.ExecuteReader();

                ArrayList al = new ArrayList();
                while (reader.Read())
                {
                    al.Add(reader.GetString(0).Trim());
                }

                tabs.DataSource = al;
                tabs.SelectedIndexChanged += tabs_SelectedIndexChanged;
            }catch(Exception ex)
            {
                MessageBox.Show("You are not connected to a database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Data(DataGridView dgv)
        {
            try
            {
                string sql = "select * from "+tabs.SelectedItem.ToString()+";";
                FbCommand cmd = new FbCommand(sql, con);
                FbDataAdapter dta = new FbDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                dta.Fill(dt);
                dgv.DataSource = dt;
                cmd.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            Tabs();
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void show_Click(object sender, EventArgs e)
        {
            Data(dataTable);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            var result =MessageBox.Show("Are you sure to delete the "+ tabs.SelectedItem.ToString() +" table", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                try
                {
                    
                    string sql = "drop table " + tabs.SelectedItem.ToString() + ";";
                    FbCommand cmd = new FbCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    
                }catch(FirebirdSql.Data.FirebirdClient.FbException ex)
                {
                    MessageBox.Show("Table is in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddData a = new AddData(con, tabs.SelectedItem.ToString());
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(deleteS);
        }

        int numberOfColumns()
        {
            string sql = "select count(rdb$field_name) from rdb$relation_fields where rdb$relation_name ='" + tabs.SelectedItem.ToString() + "';";
            FbCommand cmd = new FbCommand(sql, con);
            FbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int columns = reader.GetInt32(0);
            cmd.Dispose();
            return columns;
        }

       
        private void dataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataTable.Rows[index];
            deleteS = selectedRow.Cells[0].Value.ToString();

        }
    }
}
