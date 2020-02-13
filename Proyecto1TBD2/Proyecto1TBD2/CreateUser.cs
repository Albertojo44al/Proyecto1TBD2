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
    public partial class CreateUser : Form
    {
        FbConnection con;
        public CreateUser(FbConnection _con)
        {
            InitializeComponent();
            con = _con;
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (password.Text.Equals(confirmPassword.Text))
            {
                try
                {
                    //CREATE USER prueb PASSWORD '123' GRANT ADMIN ROLE;
                    string sql = "CREATE USER "+username.Text+" PASSWORD '"+password.Text+"';";
                    FbCommand cmd = new FbCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("Succes!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    ddl(sql, false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString()+"user not valid or yo are not connected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Passwords don't match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ddl(string _data, bool createTable)//call dll
        {
            ShowDDL s = new ShowDDL();
            s.sortData(_data, createTable);
        }
    }
}
