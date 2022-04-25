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
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); //sebagai data koneksi ke DBMSnya / untuk melakukan koneksi kedalam mysqlnya
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
            DataTable Kota = new DataTable();
            

            sqlQuery = " SELECT t.team_name, t.team_id, t.home_stadium,t.city, t.capacity , m.manager_name, p.player_name  FROM team t, manager m, player p where t.manager_id = m.manager_id and p.player_id = t.captain_id";

            //sqlQuery = "select manager_name from manager m, team t where t.team_id = '" + CboxKiri.SelectedValue.ToString() + "' and m.manager_id = t.manager_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(managerKiri); 
            sqlAdapter.Fill(captainKiri);
            sqlAdapter.Fill(stadium);
            sqlAdapter.Fill(capacity);
            sqlAdapter.Fill(Kota);
           
            LbManagerKiri.Text = "Manager : " + managerKiri.Rows[CboxKiri.SelectedIndex][5].ToString();
            LbCaptainKiri.Text = "Captain : " + captainKiri.Rows[CboxKiri.SelectedIndex][6].ToString();
            LbStadium.Text = "Stadium : " + stadium.Rows[CboxKiri.SelectedIndex][2] +", "+ Kota.Rows[CboxKiri.SelectedIndex][3];
            LbCapacity.Text = "Capacity : " + capacity.Rows[CboxKiri.SelectedIndex][4].ToString();
            





        }

        private void CboxKanan_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable managerKanan = new DataTable();
            DataTable captainKanan = new DataTable();
             

            sqlQuery = "SELECT t.team_name, t.team_id, t.home_stadium,  t.capacity , m.manager_name, p.player_name FROM team t, manager m, player p where t.manager_id = m.manager_id and p.player_id = t.captain_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(managerKanan);
            sqlAdapter.Fill(captainKanan);
            
            LbManagerKanan.Text = "Manager : "+ managerKanan.Rows[CboxKanan.SelectedIndex][4].ToString();
            LbCaptainKanan.Text = "Captain : "+ captainKanan.Rows[CboxKanan.SelectedIndex][5].ToString();



            



        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            DataTable tanggalskor = new DataTable();
           
                sqlQuery = "select Date_format(m2.match_date, '%d %M %Y'), concat(m2.goal_home, ' - ', m2.goal_away), m2.team_home, m2.team_away from `match` m2 where m2.team_home = '" + CboxKiri.SelectedValue.ToString() + "' and team_away = '" + CboxKanan.SelectedValue.ToString() + "'";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(tanggalskor);
            LbTanggalFormat.Text = tanggalskor.Rows[0][0].ToString();
            LbSkorAkhir.Text = tanggalskor.Rows[0][1].ToString();

             

            DataTable hasilpertandingan = new DataTable();

            sqlQuery= "SELECT * from dmatch d, player p, `match` m where d.match_id = m.match_id and d.player_id = p.player_id and m.team_home = '" + CboxKiri.SelectedValue.ToString() + "' and team_away = '" + CboxKanan.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(hasilpertandingan);
            DtHasil.DataSource = hasilpertandingan;
  

        }
    }
}
