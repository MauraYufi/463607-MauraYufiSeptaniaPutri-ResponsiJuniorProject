using Npgsql;
using System.Data;

namespace Responsi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=2022;Username=postgres;Password=informatika;Database=responsi";
        public static NpgsqlCommand cmd;
        private string sql = null;
        public DataTable dt;
        public int id;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            sql = @"select * from read_data()";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            NpgsqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            dgv.DataSource = dt;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //if (cbDep.Text == 'HR')
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}