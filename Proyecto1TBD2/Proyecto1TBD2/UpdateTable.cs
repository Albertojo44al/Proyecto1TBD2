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
    public partial class UpdateTable : Form
    {
        FbConnection con;
        string delete,table;
        public UpdateTable(FbConnection _con,string _table)
        {
            InitializeComponent();
            con = _con;
            table = _table;
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
                delete = selectedColumn.Name.ToString();
            }
            catch (Exception)
            {

            }
        }

        public void dll(string _data, bool _createTable)//call dll
        {
            ShowDDL s = new ShowDDL();
            s.sortData(_data, _createTable);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "ALTER TABLE " +table +" DROP "+ delete + ";";
                FbCommand cmd = new FbCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("column delete succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                dll(sql, false);

            }
            catch (Exception)
            {
                MessageBox.Show("select an appropriate column", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newField_Click(object sender, EventArgs e)
        {
            string primary = (primarykey.Checked) ? "primary key" : "";
            String notNull = (notnull.Checked) ? "not null" : "";
            string lengthType = (type.SelectedItem.ToString().Equals("VARCHAR") || type.SelectedItem.ToString().Equals("CHAR")) ? "(" + length.Text + ")" : "";
            string data = fieldName.Text + " " + type.SelectedItem.ToString() + lengthType + " " + notNull + " " + primary;
            fieldName.Clear();
            length.Clear();
            string sql = "ALTER TABLE " + table + " ADD " + data + ";";
            try
            {
                FbCommand cmd = new FbCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("column add succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                dll(sql, false);
            }
            catch (Exception)
            {
                MessageBox.Show("select the appropiate data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTable_Load(object sender, EventArgs e)
        {
            Data(dataTable);
        }
    }
}
