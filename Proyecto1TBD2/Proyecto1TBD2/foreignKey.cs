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
    public partial class ForeignKey : Form
    {
        FbConnection con;
        ArrayList al;
        string table,actualForeign;
        bool update;
        public ForeignKey(FbConnection _con,string _table,string _actualForeign, bool _update)
        {
            InitializeComponent(); ;
            con = _con;
            actualTable.Text = "Table: "+_table;
            table = _table;
            actualForeign = _actualForeign;
            update = _update;
        }

        private void ForeignKey_Load(object sender, EventArgs e)
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
                cmd.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("You are not connected to a database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void commit_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                if (update)
                {
                    sql = "ALTER TABLE " + table + " DROP CONSTRAINT " + actualForeign + ", ADD FOREIGN KEY (" + foreign.Text.Trim() + ") REFERENCES " + tabs.SelectedItem.ToString() + "(" + key.Text.Trim() + ");";
                }
                else {
                    sql = "ALTER TABLE " + table + " ADD FOREIGN KEY (" + foreign.Text.Trim() + ") REFERENCES " + tabs.SelectedItem.ToString() + "(" + key.Text.Trim() + ");";
                }
                
                FbCommand cmd = new FbCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Succes!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                ddl(sql, false);
            }
            catch (Exception)
            {
                MessageBox.Show("Be sure to the foreign key name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ddl(string _data, bool createTable)//call dll
        {
            ShowDDL s = new ShowDDL();
            s.sortData(_data, createTable);
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void select_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select sg.rdb$field_name as field_name from rdb$indices ix left join rdb$index_segments sg on ix.rdb$index_name = sg.rdb$index_name left join rdb$relation_constraints rc on rc.rdb$index_name = ix.rdb$index_name where rc.rdb$constraint_type = 'PRIMARY KEY' AND RC.RDB$RELATION_NAME = '" + tabs.SelectedItem.ToString() + "'; ";
                FbCommand cmd = new FbCommand(sql, con);
                FbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                foreign.Text = reader.GetString(0);
                key.Text = reader.GetString(0);
                cmd.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("That table don't have a primary key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
