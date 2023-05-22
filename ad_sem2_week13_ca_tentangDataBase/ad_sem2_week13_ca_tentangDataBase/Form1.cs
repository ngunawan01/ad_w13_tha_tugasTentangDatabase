using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace ad_sem2_week13_ca_tentangDataBase
{
    public partial class Form1 : Form
    {
        public static string sqlConnection = "server=127.0.0.1;uid=root;pwd=Coconut23;database=premier_league";
        public string sqlQuery;
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        DataTable dtTable = new DataTable();
        string status = "1";
        string delete = "0";
        string penyimpan = "0";
        string penyimpan2 = "0";
        string idlama = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void updateDGV()
        {
            
            //dtTable = new DataTable();
            //sqlQuery = $"select player_name, nation, playing_pos, team_number, height, weight, birthdate from player p, nationality n where p.nationality_id = n.nationality_id and p.team_id = '{comboBoxTeamNameKanan.SelectedValue.ToString()}'; "; // select bla bla bla
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(dtTable);
            //dgv3.DataSource = dtTable;

            //dtTable = new DataTable();
            //sqlQuery = "select * from manager where working = 1"; // select bla bla bla
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(dtTable);
            //dgv1.DataSource = dtTable;

            //dtTable = new DataTable();
            //sqlQuery = "select * from manager where working = 0"; // select bla bla bla
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(dtTable);
            //dgv2.DataSource = dtTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dtTable = new DataTable();
            sqlQuery = "select nation, nationality_id from nationality"; // select bla bla bla
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTable);

            comboBoxNationality.DataSource = dtTable;
            comboBoxNationality.DisplayMember = "nation";
            comboBoxNationality.ValueMember = "nationality_id";


            dtTable = new DataTable();
            sqlQuery = "select team_id, team_name from team"; // select bla bla bla
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTable);

            comboBoxTeamName.DataSource = dtTable;
            comboBoxTeamName.DisplayMember = "team_name";
            comboBoxTeamName.ValueMember = "team_id";

            dtTable = new DataTable();
            sqlQuery = "select team_id, team_name from team"; // select bla bla bla
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTable);

            comboBoxTeamNamePlayerData.DataSource = dtTable;
            comboBoxTeamNamePlayerData.DisplayMember = "team_name";
            comboBoxTeamNamePlayerData.ValueMember = "team_id";

            dtTable = new DataTable();
            sqlQuery = "select team_id, team_name from team"; // select bla bla bla
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTable);

            comboBoxTeamNameKanan.DataSource = dtTable;
            comboBoxTeamNameKanan.DisplayMember = "team_name";
            comboBoxTeamNameKanan.ValueMember = "team_id";

            dtTable = new DataTable();
            sqlQuery = $"select manager_name, team_name, birthdate, nation from manager m, team t, nationality n where m.manager_id = t.manager_id and m.nationality_id = n.nationality_id and m.working = 1 and t.team_id = '{comboBoxTeamName.SelectedValue.ToString()}'; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTable);
            dgv1.DataSource = dtTable;

            dtTable = new DataTable();
            sqlQuery = "select m.manager_id, manager_name, nation, birthdate from manager m, team t, nationality n where m.nationality_id = n.nationality_id and m.working = 0;"; // select bla bla bla
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTable);
            dgv2.DataSource = dtTable;

            dtTable = new DataTable();
            sqlQuery = $"select player_name, nation, playing_pos, team_number, height, weight, birthdate from player p, nationality n where p.nationality_id = n.nationality_id and p.team_id = '{comboBoxTeamNameKanan.SelectedValue.ToString()}' and status = 1; "; // select bla bla bla
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTable);
            dgv3.DataSource = dtTable;
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            string stringDtpBirthDate = dtpBirthDate.Value.ToString("yyyy-MM-dd");
                   
            sqlQuery = $"INSERT INTO player VALUES ('{textBoxPlayerID.Text}', '{Convert.ToInt32(textBoxTeamNumber.Text)}', '{textBoxPlayerName.Text}',  '{comboBoxNationality.SelectedValue}', '{textBoxPosition.Text}', '{textBoxHeight.Text}','{textBoxWeight.Text}', '{stringDtpBirthDate}', '{comboBoxTeamNamePlayerData.SelectedValue}', 1, 0)"; //insert into bla bla bla alter table bla bla bla
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

            dtTable = new DataTable();
            sqlQuery = $"select player_name, nation, playing_pos, team_number, height, weight, birthdate from player p, nationality n where p.nationality_id = n.nationality_id and p.team_id = '{comboBoxTeamNameKanan.SelectedValue.ToString()}' and status = 1; "; // select bla bla bla
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTable);
            dgv3.DataSource = dtTable;

        }

        private void comboBoxTeamName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dtTable = new DataTable();
            //sqlQuery = $"select m.manager_id, manager_name, team_name, birthdate, nation from manager m, team t, nationality n where m.manager_id = t.manager_id and m.nationality_id = n.nationality_id and t.team_id = '{comboBoxTeamName.SelectedValue.ToString()}'; ";
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(dtTable);
            //dgv1.DataSource = dtTable;

            //try { idlama = dtTable.Rows[0][0].ToString(); }
            //catch { }
            

            //dtTable = new DataTable();
            //sqlQuery = "select m.manager_id, manager_name, nation, birthdate from manager m, team t, nationality n where m.nationality_id = n.nationality_id and m.working = 0;"; // select bla bla bla
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(dtTable);
            //dgv2.DataSource = dtTable;
        }

        private void comboBoxTeamNameKanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtTable = new DataTable();
            sqlQuery = $"select player_name, nation, playing_pos, team_number, height, weight, birthdate from player p, nationality n where p.nationality_id = n.nationality_id and p.team_id = '{comboBoxTeamNameKanan.SelectedValue.ToString()}' and status = 1; "; // select bla bla bla
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTable);
            dgv3.DataSource = dtTable;
           
        }

        private void comboBoxTeamNameKanan_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            sqlQuery = $"update team set manager_id = '{penyimpan}' where team_id = '{comboBoxTeamName.SelectedValue.ToString()}'; ";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

            //dtTable = new DataTable();
            //MessageBox.Show(comboBoxTeamName.SelectedValue.ToString());
            //sqlQuery = $"select manager_name, team_name, birthdate, nation from manager m, team t, nationality n where m.manager_id = t.manager_id and m.nationality_id = n.nationality_id and t.team_id = '{comboBoxTeamName.SelectedValue.ToString()}'; ";
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(dtTable);

            sqlQuery = $" UPDATE manager SET working = 0 WHERE manager_id = '{idlama}';"; //insert into bla bla bla alter table bla bla bla
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

            //dtTable = new DataTable();
            //sqlQuery = $"select manager_name, team_name, birthdate, nation from manager m, team t, nationality n where m.manager_id = t.manager_id and m.nationality_id = n.nationality_id and m.working = 1 and t.team_id = '{comboBoxTeamName.SelectedValue.ToString()}'; ";
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(dtTable);

            dtTable = new DataTable();
            sqlQuery = "select m.manager_id, manager_name, nation, birthdate from manager m, team t, nationality n where m.nationality_id = n.nationality_id and m.working = 0;"; // select bla bla bla
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTable);
            dgv2.DataSource = dtTable;

            sqlQuery = $" UPDATE manager SET working = 1 WHERE manager_id = '{penyimpan}';"; //insert into bla bla bla alter table bla bla bla
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

            dtTable = new DataTable();
            sqlQuery = $"select m.manager_id, manager_name, team_name, birthdate, nation from manager m, team t, nationality n where m.manager_id = t.manager_id and m.nationality_id = n.nationality_id and m.working = 1 and t.team_id = '{comboBoxTeamName.SelectedValue.ToString()}'; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTable);
            dgv1.DataSource = dtTable;
            idlama = dtTable.Rows[0][0].ToString();

            dtTable = new DataTable();
            sqlQuery = "select m.manager_id, manager_name, nation, birthdate from manager m, team t, nationality n where m.nationality_id = n.nationality_id and m.working = 0;"; // select bla bla bla
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTable);
            dgv2.DataSource = dtTable;
          
        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


        }

        private void dgv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtTable = new DataTable();
            sqlQuery = "select m.manager_id, manager_name, nation, birthdate from manager m, team t, nationality n where m.nationality_id = n.nationality_id and m.working = 0;"; // select bla bla bla
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTable);
            penyimpan = dtTable.Rows[e.RowIndex][0].ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dtTable = new DataTable();
            sqlQuery = $"select player_name, nation, playing_pos, team_number, height, weight, birthdate from player p, nationality n where p.nationality_id = n.nationality_id and p.team_id = '{comboBoxTeamNameKanan.SelectedValue.ToString()}' and status = 1; "; // select bla bla bla
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTable);

            int counter = 0;
            foreach (DataRow dtRow in dtTable.Rows)
            {
                counter++;
            }

            if (counter > 11)
            {
                sqlQuery = $"update player set status = 0 where player_name = '{penyimpan2}'; ";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }
            else
            {
                MessageBox.Show("Cannot Delete Player if you have 11 or less players in a team");
            }
            

            dtTable = new DataTable();
            sqlQuery = $"select player_name, nation, playing_pos, team_number, height, weight, birthdate from player p, nationality n where p.nationality_id = n.nationality_id and p.team_id = '{comboBoxTeamNameKanan.SelectedValue.ToString()}' and status = 1; "; // select bla bla bla
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTable);
            dgv3.DataSource = dtTable;
        }

        private void dgv3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtTable = new DataTable();
            sqlQuery = $"select player_name, nation, playing_pos, team_number, height, weight, birthdate from player p, nationality n where p.nationality_id = n.nationality_id and p.team_id = '{comboBoxTeamNameKanan.SelectedValue.ToString()}' and status = 1; "; // select bla bla bla
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTable);
            penyimpan2 = dtTable.Rows[e.RowIndex][0].ToString();
        }

        private void comboBoxTeamName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtTable = new DataTable();
            sqlQuery = $"select m.manager_id, manager_name, team_name, birthdate, nation from manager m, team t, nationality n where m.manager_id = t.manager_id and m.nationality_id = n.nationality_id and t.team_id = '{comboBoxTeamName.SelectedValue.ToString()}'; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTable);
            dgv1.DataSource = dtTable;

            try { idlama = dtTable.Rows[0][0].ToString(); }
            catch { }


            dtTable = new DataTable();
            sqlQuery = "select m.manager_id, manager_name, nation, birthdate from manager m, team t, nationality n where m.nationality_id = n.nationality_id and m.working = 0;"; // select bla bla bla
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTable);
            dgv2.DataSource = dtTable;
        }
    }
}
