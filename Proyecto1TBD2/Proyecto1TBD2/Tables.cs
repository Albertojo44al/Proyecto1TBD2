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
        string row, column, Showddl;
        DataGridViewRow selectedRow;
        DataGridViewColumn selectedColumn;
        ArrayList al;

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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)//AddTable
        {
            NewTable t = new NewTable(con);
            t.Show();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Tabs()//list the tables of dataBase
        {
            try
            {
                string sql = "SELECT DISTINCT RDB$RELATION_NAME FROM RDB$RELATIONS WHERE RDB$VIEW_BLR IS NULL AND RDB$SYSTEM_FLAG =0;";
                Showddl = sql;
                FbCommand cmd = new FbCommand(sql, con);
                FbDataReader reader = cmd.ExecuteReader();

                al = new ArrayList();
                while (reader.Read())
                {
                    al.Add(reader.GetString(0).Trim());
                }

                tabs.DataSource = al;
                tabs.SelectedIndexChanged += tabs_SelectedIndexChanged;
                cmd.Dispose();
            }catch(Exception)
            {
                MessageBox.Show("You are not connected to a database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Data(DataGridView dgv)//show data in dataGridView
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

        private void Tables_Load(object sender, EventArgs e)//combobox for tables
        {
            Tabs();
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void show_Click(object sender, EventArgs e)//show data in datagrid
        {
            Data(dataTable);
        }

        private void delete_Click(object sender, EventArgs e)//delete table
        {
            var result =MessageBox.Show("Are you sure to delete the "+ tabs.SelectedItem.ToString() +" table", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                try
                {
                    
                    string sql = "DROP TABLE " + tabs.SelectedItem.ToString() + ";";
                    FbCommand cmd = new FbCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    ddl(sql,false);
                }catch(FirebirdSql.Data.FirebirdClient.FbException ex)
                {
                    MessageBox.Show("Table is in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)//add data
        {
            AddData a = new AddData(con, tabs.SelectedItem.ToString(), selectedRow, dataTable.Columns, false);
            a.Show();
        }

        
        private void button1_Click(object sender, EventArgs e)//delete row
        {
            var result = MessageBox.Show("Are you sure to delete the " + row + " field", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    string sql = "delete from " + tabs.SelectedItem.ToString() + " where " + column + " = '" + row + "';";
                    FbCommand cmd = new FbCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    ddl(sql,false);
                    MessageBox.Show("delete field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Field not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ddl(string _data, bool createTable)//call dll
        {
            ShowDDL s = new ShowDDL();
            s.sortData(_data, createTable);
        }
        private void update_Click(object sender, EventArgs e)//Update Data
        {
            AddData a = new AddData(con, tabs.SelectedItem.ToString(), selectedRow, dataTable.Columns,true);
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ForeignKey f = new ForeignKey(con, tabs.SelectedItem.ToString());
            f.Show();
        }

        private void showTables_Click(object sender, EventArgs e)
        {
            string allTables = "";   
            foreach(string table in al)
            {
                allTables += table + "\n";
            }
            MessageBox.Show(allTables,"Tables of System",MessageBoxButtons.OK);
            ddl(Showddl,false);
        }

        private void dataTable_CellClick(object sender, DataGridViewCellEventArgs e) //extrae dats de la fila y columna seleccionada
        {
            int indexr = e.RowIndex;
            selectedRow = dataTable.Rows[indexr];
            selectedColumn = dataTable.Columns[0];
            row = selectedRow.Cells[0].Value.ToString();
            column = selectedColumn.Name.ToString();
            
        }
    }
}
