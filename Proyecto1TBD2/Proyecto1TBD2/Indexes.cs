﻿using System;
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
    public partial class Indexes : Form
    {
        FbConnection con;
        ArrayList al;
        string index, primary, foreign;
        public Indexes(FbConnection _con)
        {
            InitializeComponent();
            this.Location = new Point(470, 173);
            con = _con;
        }

        private void Indexes_Load(object sender, EventArgs e)
        {
            Tabs();
        }

        private void button4_Click(object sender, EventArgs e)
        {

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

                comboBox1.DataSource = al;
                comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            }
            catch (Exception)
            {
                MessageBox.Show("You are not connected to a database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ForeignKey f = new ForeignKey(con, comboBox1.SelectedItem.ToString(),foreign,false);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showIndexes(indexesTable,1);
            showIndexes(foreignTable, 2);
            showIndexes(primaryTable, 3);
        }

        public void showIndexes(DataGridView dgv, int tab)//show data in dataGridView
        {
            try
            {
                string sql = "";
                if (tab == 1)
                {
                    sql = "SELECT RDB$INDEX_NAME AS INDEX_NAME FROM RDB$INDICES WHERE RDB$RELATION_NAME = '" + comboBox1.SelectedItem.ToString() + "' AND RDB$FOREIGN_KEY IS NULL; ";
                }else if(tab == 2)
                {
                    sql = "SELECT (RC.RDB$CONSTRAINT_NAME) AS CONSTRAINT_NAME, (SG.RDB$FIELD_NAME) AS FIELD_NAME FROM RDB$INDICES IX LEFT JOIN RDB$INDEX_SEGMENTS SG ON (IX.RDB$INDEX_NAME = SG.RDB$INDEX_NAME) LEFT JOIN RDB$RELATION_CONSTRAINTS RC ON (RC.RDB$INDEX_NAME = IX.RDB$INDEX_NAME) WHERE RC.RDB$CONSTRAINT_TYPE = 'FOREIGN KEY'AND RC.RDB$RELATION_NAME = '" + comboBox1.SelectedItem.ToString()+"';";
                }
                else
                {
                    sql = "SELECT (RC.RDB$CONSTRAINT_NAME) AS CONSTRAINT_NAME, (SG.RDB$FIELD_NAME) AS FIELD_NAME FROM RDB$INDICES IX LEFT JOIN RDB$INDEX_SEGMENTS SG ON (IX.RDB$INDEX_NAME = SG.RDB$INDEX_NAME) LEFT JOIN RDB$RELATION_CONSTRAINTS RC ON (RC.RDB$INDEX_NAME = IX.RDB$INDEX_NAME) WHERE RC.RDB$CONSTRAINT_TYPE = 'PRIMARY KEY'AND RC.RDB$RELATION_NAME = '" + comboBox1.SelectedItem.ToString() + "';";
                }
                FbCommand cmd = new FbCommand(sql, con);
                FbDataAdapter dta = new FbDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                dta.Fill(dt);
                dgv.DataSource = dt;
                cmd.Dispose();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void ddl(string _data, bool createTable)//call dll
        {
            ShowDDL s = new ShowDDL();
            s.sortData(_data, createTable);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PrimaryKey p = new PrimaryKey(con, comboBox1.SelectedItem.ToString(), primary,false);
            p.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddIndex a = new AddIndex(con, comboBox1.SelectedItem.ToString());
            a.Show();
        }

     

        private void primaryTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            int i = e.RowIndex;
            DataGridViewRow selectedRow = primaryTable.Rows[i];
            primary = selectedRow.Cells[0].Value.ToString();
            primaryS.Text = primary;
            }
            catch (Exception)
            {

            }
        }

        private void foreignTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            int i = e.RowIndex;
            DataGridViewRow selectedRow = foreignTable.Rows[i];
            foreign = selectedRow.Cells[0].Value.ToString();
            foreignS.Text = foreign;
            }
            catch (Exception)
            {

            }
}

        private void update_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Are you sure to inactive or acitve the index", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            { 
               
            }
        }

        private void updatePrimary_Click(object sender, EventArgs e)
        {
            PrimaryKey p = new PrimaryKey(con, comboBox1.SelectedItem.ToString(), primary.Trim(), true);
            p.Show();
        }

        private void updateForeign_Click(object sender, EventArgs e)
        {
            ForeignKey f = new ForeignKey(con, comboBox1.SelectedItem.ToString(), foreign.Trim(), true);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteIPF d = new DeleteIPF(con, index, primary, foreign, comboBox1.SelectedItem.ToString());
            d.Show();
        }

        private void indexesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                DataGridViewRow selectedRow = indexesTable.Rows[i];
                index = selectedRow.Cells[0].Value.ToString();
                indexS.Text = index;
            }
            catch (Exception)
            {

            }
        }
    }
}
