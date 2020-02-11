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
        public AddData(FbConnection _con)
        {
            InitializeComponent();
            con = _con;
        }


        private void AddData_Load(object sender, EventArgs e)
        {
            addColumns();
        }
        Label[] labels;
        public void addColumns()
        {
            int y = 30;
            labels = new Label[10]; 
            for(int i = 0; i < 10; i++)
            {
                labels[i] = new Label();
                labels[i].Location = new Point(100, y);
                labels[i].Name = "text" + i.ToString();
                labels[i].Size = new Size(74, 20);
                labels[i].TabIndex = i;
                labels[i].Text = "Hola" + i;
                labels[i].Visible = true;
                labels[i].BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(this.labels[i]);
                y += 40;
            }

        }
    }

   
}
