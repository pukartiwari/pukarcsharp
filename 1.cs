using System.Data.SqlClient;

namespace day3rd
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data source=.\\SQLEXPRESS;Initial Catalog=day1st ;user id = sa;       password=kist@123;");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "Insert into Resturant values ('swornim','sankhu','98456899','radhe')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.InnerException);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = ("Update Resturant set name='hari',address='thali'where id=5");
                SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data updated sucessfully");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = ("Delete From Resturant where id=8");
            SqlCommand cmd=new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted sucessfully");
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] row = new string[] { "1", "anja", "ktm", "9851243" };
            Display.Rows.Add(row);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string data3 = id.Text;
            string data = name.Text;
            string data1=address.Text;
            string data2 = conc.Text; 
            Display.Rows.Add(data3,data,data1,data2);
        }
    }
}
