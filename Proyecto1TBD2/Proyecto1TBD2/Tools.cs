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
    public partial class Tools :   Form
    {


        FbConnection con = new FbConnection();
        Conection obj = new Conection();
        string path;
        public Tools()
        {
            InitializeComponent();
            this.Location = new Point(262, 173);  
        }
        public Tools(FbConnection _con)
        {
            InitializeComponent();
            this.Location = new Point(262, 173);
            con = _con;
           

        }


        public void setPath(string _path)
        {
            path = _path;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tables_Click(object sender, EventArgs e)
        {
            Tables t = new Tables(con); 
            t.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Indexes i = new Indexes(con);
            i.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Views v = new Views(con);
            v.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
