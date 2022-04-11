using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Praktikum_11_april
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string sqlConnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); //sebagai data koneksi ke DBMSnya
        public MySqlCommand sqlCommand; //memindahkan query ke database, query terjadi di dbmsnya
        public static MySqlDataAdapter sqlAdapter; //hasil dari query akan disimpan di mysqldata
        public string sqlQuery;


        private void Form1_Load(object sender, EventArgs e)
        {
            LbCapacity.Text = "";
            LbCaptainKiri.Text = "";
            LbManagerKiri.Text = "";
            LbStadium.Text = "";
            DataTable dtTeam = new DataTable();
            sqlQuery = "Select team_name as 'Nama Tim', team_id as 'ID' from team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            CboxKiri.DataSource = dtTeam;
            CboxKiri.DisplayMember = "Nama Tim";
            CboxKiri.ValueMember = "ID";

            DataTable dtTeamKanan = new DataTable();
            sqlQuery = "Select team_name as 'Nama Tim', team_id as 'ID' from team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamKanan);
            CboxKanan.DataSource = dtTeamKanan;
            CboxKanan.DisplayMember = "Nama Tim";
            CboxKanan.ValueMember = "ID";
        }

        private void LbManagerKiri_Click(object sender, EventArgs e)
        {
            //DataTable managerKiri = new DataTable();
            //sqlQuery = "select manager_name from manager m, team t where t.team_id = '" + CboxKiri.SelectedValue.ToString()+"'";
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(managerKiri);
            //LbManagerKiri.Text = managerKiri.Rows[0]["manager_name"].ToString();
        }

        private void CboxKiri_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable managerKiri = new DataTable();
            DataTable captainKiri = new DataTable();
            DataTable stadium = new DataTable();
            DataTable capacity = new DataTable();

            sqlQuery = " SELECT t.team_name, t.team_id, t.home_stadium, t.capacity , m.manager_name, p.player_name FROM team t, manager m, player p where t.manager_id = m.manager_id and p.player_id = t.captain_id";

            //sqlQuery = "select manager_name from manager m, team t where t.team_id = '" + CboxKiri.SelectedValue.ToString() + "' and m.manager_id = t.manager_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(managerKiri);
            sqlAdapter.Fill(captainKiri);
            sqlAdapter.Fill(stadium);
            sqlAdapter.Fill(capacity);
            LbManagerKiri.Text = "Manager : " + managerKiri.Rows[CboxKiri.SelectedIndex][4].ToString();
            LbCaptainKiri.Text = "Captain : " + captainKiri.Rows[CboxKiri.SelectedIndex][5].ToString();
            LbStadium.Text = "Stadium : " + stadium.Rows[CboxKiri.SelectedIndex][2].ToString();
            LbCapacity.Text = "Capacity : " + capacity.Rows[CboxKiri.SelectedIndex][3].ToString();




        }

        private void CboxKanan_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable managerKanan = new DataTable();
            DataTable captainKanan = new DataTable();

            sqlQuery = "SELECT t.team_name, t.team_id, t.home_stadium, t.capacity , m.manager_name, p.player_name FROM team t, manager m, player p where t.manager_id = m.manager_id and p.player_id = t.captain_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(managerKanan);
            sqlAdapter.Fill(captainKanan);
            LbManagerKanan.Text = managerKanan.Rows[CboxKanan.SelectedIndex][5].ToString();
            LbCaptainKanan.Text = captainKanan.Rows[CboxKanan.SelectedIndex][4].ToString();





        }
    }
}
