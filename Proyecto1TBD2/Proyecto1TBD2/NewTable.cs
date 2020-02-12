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
    public partial class NewTable : Form
    {
        FbConnection con = new FbConnection();
       
        ArrayList fields = new ArrayList();
        public NewTable(FbConnection _con)
        {
            InitializeComponent();
            con = _con;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "CREATE TABLE " + tablename.Text+ "(";
            foreach(string field in fields)
            {
                sql += field + ",";
            }
            string newsql = sql.TrimEnd(',');
            newsql += ");";
            try
            {
                
                FbCommand cmd = new FbCommand(newsql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Table created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.Dispose();
                dll(newsql,true);
                this.Hide();
            }
            catch (Exception ex)
            {
                fields = new ArrayList();
                MessageBox.Show("please check the primary key or the data type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void dll(string _data,bool _createTable)//call dll
        {
            ShowDDL s = new ShowDDL();
            s.sortData(_data, _createTable);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string primary = (primarykey.Checked)?"primary key":"";
            String notNull = (notnull.Checked) ?"not null":"";
            string lengthType = (type.SelectedItem.ToString().Equals("VARCHAR")|| type.SelectedItem.ToString().Equals("CHAR")) ? "("+length.Text+")" : "";
            fields.Add(fieldName.Text +" "+ type.SelectedItem.ToString()+ lengthType + " " + notNull + " " + primary) ;
            fieldName.Clear();
            length.Clear();
        }

        private void length_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
