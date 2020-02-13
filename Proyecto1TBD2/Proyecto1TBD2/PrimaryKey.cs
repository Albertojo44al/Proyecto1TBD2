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
    public partial class PrimaryKey : Form
    {
        FbConnection con;
        string table,actualPrimary;
        bool update;
        public PrimaryKey(FbConnection _con, string _table,string _actualPrimary, bool _update)
        {
            InitializeComponent();
            con = _con;
            table = _table;
            actualPrimary = _actualPrimary;
            update = _update;
        }

        public void Data(DataGridView dgv)//show data in dataGridView
        {
            try
            {
                string sql = "select * from " + table + ";";
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
        private void dataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indexColumn = e.ColumnIndex;
                DataGridViewColumn selectedColumn = dataTable.Columns[indexColumn];
                newPrimary.Text = selectedColumn.Name.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void PrimaryKey_Load(object sender, EventArgs e)
        {
            Data(dataTable);
        }

        private void commit_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                if (update)
                {
                    sql = "ALTER TABLE " + table + " DROP CONSTRAINT " + actualPrimary + ", ADD PRIMARY KEY (" + newPrimary.Text + "); ";
                }
                else
                {
                    sql = "ALTER TABLE " + table + " ADD PRIMARY KEY (" + newPrimary.Text + ");";
                }
                FbCommand cmd = new FbCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();           
                MessageBox.Show("Succes!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                ddl(sql, false);
            }
            catch
            {
                MessageBox.Show("Be sure to the primary key name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ddl(string _data, bool createTable)//call dll
        {
            ShowDDL s = new ShowDDL();
            s.sortData(_data, createTable);
        }
    }
}
