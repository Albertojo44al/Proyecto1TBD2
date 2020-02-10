using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using System.Windows.Forms;

namespace Proyecto1TBD2
{
    public class Conection
    {
        FbConnection con;
        string path;

        public void setPath(string _path)
        {
            path = _path;
        }

        public FbConnection Conectar()
        {
            try
            {
                con = new FbConnection(path);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                    MessageBox.Show("Connected!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return con;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database file was not found on the host. Please check the name of the Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
