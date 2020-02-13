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
    public partial class AddIndex : Form
    {
        FbConnection con;
        string table, column;
        ArrayList al;
        public AddIndex(FbConnection _con, string _table)
        {
            InitializeComponent();
            con = _con;
           
            table = _table;
           
        }

        private void AddIndex_Load(object sender, EventArgs e)
        {
            actualTable.Text = "Table: "+table;
            Tabs();
        }

        public void Tabs()//list the tables of dataBase
        {
            try
            {
                string sql = "select rdb$field_name from rdb$relation_fields where rdb$relation_name = '"+table+"'; ";
                FbCommand cmd = new FbCommand(sql, con);
                FbDataReader reader = cmd.ExecuteReader();

                al = new ArrayList();
                while (reader.Read())
                {
                    al.Add(reader.GetString(0).Trim());
                }

                columns.DataSource = al;
                columns.SelectedIndexChanged += columns_SelectedIndexChanged;
                cmd.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("You are not connected to a database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void ddl(string _data, bool createTable)//call dll
        {
            ShowDDL s = new ShowDDL();
            s.sortData(_data, createTable);
        }

        private void columns_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void commit_Click(object sender, EventArgs e)
        {
            try
            {
                string u = (unique.Checked) ? "UNIQUE" : "";
                string sql = "CREATE " + u + " INDEX " + newIndex.Text + " ON " + table + " (" + columns.SelectedItem.ToString() + ");";
                FbCommand cmd = new FbCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succes!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                ddl(sql, false);
            }
            catch (Exception)
            {
                MessageBox.Show("Be sure to the index name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
