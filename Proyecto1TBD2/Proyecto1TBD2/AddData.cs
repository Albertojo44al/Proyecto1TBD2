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
    public partial class AddData : Form
    {
        public AddData()
        {
            InitializeComponent();
        }

        FbConnection con;
        bool update = false;
        String tableName;
        DataGridViewRow row;
        DataGridViewColumnCollection column;
        public AddData(FbConnection _con,string _tableName)
        {
            InitializeComponent();
            con = _con;
            tableName = _tableName;
        }

        public AddData(FbConnection _con, string _tableName, DataGridViewRow _row, DataGridViewColumnCollection _column, bool _update)
        {
            InitializeComponent();
            con = _con;
            tableName = _tableName;
            row = _row;
            column = _column;
            update = _update;
        }


        private void AddData_Load(object sender, EventArgs e)
        {
            addColumns();
            addTextbox();
        }
        Label[] labels;
        TextBox[] text;
        string commit;
            
        public void addColumns()
        {
            int y = 30,i=0;
            labels = new Label[numberOfColumns()];

            string sql = "select rdb$field_name from rdb$relation_fields where rdb$relation_name ='" + tableName + "';";
            FbCommand cmd = new FbCommand(sql, con);
            FbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                labels[i] = new Label();
                labels[i].Location = new Point(20, y);
                labels[i].Name = "text" + i.ToString();
                labels[i].Size = new Size(150, 20);
                labels[i].TabIndex = i;
                labels[i].Text = reader.GetString(0).Trim();
                labels[i].Visible = true;
                this.Controls.Add(this.labels[i]);
                y += 40;
            }
        }


        public void addTextbox()
        {
            int columns = numberOfColumns();
            int y = 30;
            text = new TextBox[columns];
            for(int i = 0; i < columns; i++)
            {
                text[i] = new TextBox();
                text[i].Location = new Point(180, y);
                text[i].Name = i.ToString();
                text[i].Size = new Size(220, 20);
                if (update == true)
                {
                    try
                    {
                        text[i].Text = row.Cells[i].Value.ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("You have not selected any row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                text[i].Visible = true;
                this.Controls.Add(this.text[i]);
                y += 40;
            }

        }




        int numberOfColumns()
        {
            string sql = "select count(rdb$field_name) from rdb$relation_fields where rdb$relation_name ='"+tableName+"';";
            FbCommand cmd = new FbCommand(sql, con);
            FbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int columns = reader.GetInt32(0);
            cmd.Dispose();
            return columns;
           
        }

        private void done_Click(object sender, EventArgs e)
        {
            string updt = "",sql,newsql;
            int columns = numberOfColumns();

            for (int i = 0;i<columns; i++)
            {
                if (update)
                    updt += column[i].Name.ToString() +" = "+ text[i].Text+',';
                else
                    commit += text[i].Text+",";
            }
            try
            {
                if (update){
                    sql = updt.TrimEnd(',');
                    newsql = "Update " + tableName + " set " + sql + " where " + column[0].Name.ToString() + " = " + row.Cells[0].Value.ToString() + ";";
                }
                else {
                    sql = commit.TrimEnd(',');
                    newsql = "insert into " + tableName + " values(" + sql + ");";
                }
                FbCommand cmd = new FbCommand(newsql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.Dispose();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Be sure to fill in the necessary fields correctly","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }

   
}
