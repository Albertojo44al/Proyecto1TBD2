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
    public partial class Triggers : Form
    {
        FbConnection con;
        ArrayList al, nal;
        bool modify;
        public Triggers(FbConnection _con)
        {
            InitializeComponent();
            this.Location = new Point(470, 173);
            con = _con;
        }


        private void Triggers_Load(object sender, EventArgs e)
        {
            Tabs();
            ShowTriggers();
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
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

                tabs.DataSource = al;
                tabs.SelectedIndexChanged += tabs_SelectedIndexChanged;
                cmd.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("You are not connected to a database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to delete the " + showTriggers.SelectedItem.ToString() + " trigger", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    string sql = "DROP TRIGGER " + showTriggers.SelectedItem.ToString()+";";
                    FbCommand cmd = new FbCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("Succes!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ddl(sql, false);
                }
                catch (Exception)
                {
                    MessageBox.Show("check trigger name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
        }

        private void showTriggers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ShowTriggers()//list the tables of dataBase
        {
            try
            {
                string sql = "SELECT RDB$TRIGGER_NAME FROM RDB$TRIGGERS WHERE RDB$SYSTEM_FLAG = 0;";
                FbCommand cmd = new FbCommand(sql, con);
                FbDataReader reader = cmd.ExecuteReader();

                nal = new ArrayList();
                while (reader.Read())
                {
                    nal.Add(reader.GetString(0).Trim());
                }

                showTriggers.DataSource = nal;
                showTriggers.SelectedIndexChanged += showTriggers_SelectedIndexChanged;
                cmd.Dispose();
                ddl(sql, false);
            }
            catch (Exception)
            {
                MessageBox.Show("You are not connected to a database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void compile_Click(object sender, EventArgs e)
        {
            string inst, updt, dlt, onEvent="";
            inst = (insert.Checked) ? " INSERT " : "";
            updt = (update.Checked) ? " UPDATE " : "";
            dlt = (delete.Checked) ? " DELETE " : "";
            if(insert.Checked && update.Checked && delete.Checked)
            {
                onEvent = inst + "OR" + updt + "OR" + dlt;
            }else if(insert.Checked && update.Checked)
            {
                onEvent = inst + "OR" + updt;
            }else if (insert.Checked && delete.Checked)
            {
                onEvent = inst + "OR" + dlt;
            }
            else if (update.Checked && delete.Checked)
            {
                onEvent = updt + "OR" + dlt;
            }else if (insert.Checked)
            {
                onEvent = inst;
            }
            else if (update.Checked)
            {
                onEvent = updt;
            }
            else if (delete.Checked)
            {
                onEvent = dlt;
            }

            string type;
            if (before.Checked)
                type = " BEFORE ";
            else
                type = " AFTER ";


            try
            {

                //CREATE OR ALTER TRIGGER BIU_EMPLOYEES
                //FOR NEW_TABLE
                //BEFORE INSERT OR UPDATE AS
                //BEGIN
                //NEW.NOMBRE = UPPER(NEW.NOMBRE);
                //END;
                string sql = "";
                if (modify) {
                   sql = "ALTER TRIGGER " + showTriggers.SelectedItem.ToString() + " ACTIVE " + type + onEvent + " AS " + code.Text;
                }
                else
                {
                    sql = "CREATE TRIGGER " + nameTrigger.Text + " FOR " + tabs.SelectedItem.ToString() + type + onEvent + " AS " + code.Text;
                }
                FbCommand cmd = new FbCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Succes!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                ddl(sql, false);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrateTrigger(bool update)
        {

        }

        private void updatePrimary_Click(object sender, EventArgs e)
        {
            
            modify = true;
            MessageBox.Show("Press compile", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void add_Click(object sender, EventArgs e)
        {
            modify = false;
            MessageBox.Show("Press compile", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ddl(string _data, bool createTable)//call dll
        {
            ShowDDL s = new ShowDDL();
            s.sortData(_data, createTable);
        }
    }
}
