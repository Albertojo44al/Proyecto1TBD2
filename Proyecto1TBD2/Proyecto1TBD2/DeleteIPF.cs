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
    public partial class DeleteIPF : Form
    {
        FbConnection con;
        string index, primary, foreign, table;


        public DeleteIPF(FbConnection _con, string _index, string _primary, string _foreign, string _table)
        {
            InitializeComponent();
            con = _con;
            primary = _primary;
            foreign = _foreign;
            index = _index;
            table = _table;
        }

        private void commit_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure to delete the constraint?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    string sql = "";
                    if (dIndex.Checked)
                    {
                        sql = "DROP INDEX " + index + ";";
                    }
                    else if (dPrimary.Checked)
                    {
                        sql = "ALTER TABLE " + table + " DROP CONSTRAINT " + primary + ";";
                    }
                    else if (dForeign.Checked)
                    {
                        sql = "ALTER TABLE " + table + " DROP CONSTRAINT " + foreign + ";";
                    }
                    FbCommand cmd = new FbCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("Succes!", "Infomatio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ddl(sql, false);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Select an option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ddl(string _data, bool createTable)//call dll
        {
            ShowDDL s = new ShowDDL();
            s.sortData(_data, createTable);
        }

        private void DeleteIPF_Load(object sender, EventArgs e)
        {

        }
    }
}
