using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1TBD2
{
    public partial class ShowDDL : Form
    {
        string dllData;
        bool createTable;
        public ShowDDL(string _data, bool _createTable)
        {
            InitializeComponent();
            dllData = _data;
            createTable = _createTable;
        }

        public ShowDDL()
        {
            InitializeComponent();
        }
        public void sortData(string _data,bool _createTable)
        {
            int y = 0;
            string data = "";
            for (int i = 0; i < _data.Length; i++)
            {
               
                if ((_data[i] == '(' && !_createTable)|| (_data[i] == ')' && !_createTable) || _data[i] == ',')
                {
                    data += _data[i];
                    data += '\n';
                }
                else
                {
                    data += _data[i];
                }
            }
            MessageBox.Show(data,"DDL",MessageBoxButtons.OK);
        }

        private void ShowDLL_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            sortData(dllData, createTable);
        }
    }
}
