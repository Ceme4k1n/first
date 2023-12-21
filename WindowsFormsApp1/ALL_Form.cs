using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ALL_Form : Form
    {
        public ALL_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cs = "Host=localhost;Database=Rabota;Username=postgres;Password=1234";
            var con = new NpgsqlConnection(cs);
            con.Open();

            string searchPathSql = "SET search_path TO \"Rab\"";
            var setSearchPathCmd = new NpgsqlCommand(searchPathSql, con);
            setSearchPathCmd.ExecuteNonQuery();


            string selectSql = "SELECT * FROM select_all_orders();";

            var selectCmd = new NpgsqlCommand(selectSql, con);


            var adapter = new NpgsqlDataAdapter(selectCmd);
            var dataTable = new DataTable();

            adapter.Fill(dataTable);

            ALL_grid.DataSource = dataTable;

            con.Close();
        }

        private void Add_prod_button_Click(object sender, EventArgs e)
        {
            Adding_Prod New_Prod = new Adding_Prod();
            this.Hide();
            New_Prod.Show();
        }

        private void Osnova_Button_Click(object sender, EventArgs e)
        {
            Form1 osnova = new Form1();
            this.Hide();
            osnova.Show();
        }

        private void Delete_product_button_Click(object sender, EventArgs e)
        {
            Delete_Form forma_delete = new Delete_Form();
            this.Hide();
            forma_delete.Show();
        }

        private void All_order_button_Click(object sender, EventArgs e)
        {
            From_Price_Update forma_update = new From_Price_Update();
            this.Hide();
            forma_update.Show();
        }
    }
}
