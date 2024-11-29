using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace Bookzilla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        SqlConnection conn = new SqlConnection(@"Data Source=FAIEZAHMED;Initial Catalog=Bookzila;Integrated Security=True;TrustServerCertificate=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            String usernmae, passwords;
            usernmae = usernametxt.Text;
            passwords = textBox1pass.Text;

            try
            {
                using (conn)
                {
                    string query = "SELECT * FROM login WHERE username = @username AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@username", usernametxt.Text);
                        cmd.Parameters.AddWithValue("@password", textBox1pass.Text);

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                fac fc = new fac();
                                fc.Show();
                                this.Hide();
                                // Login successful
                                MessageBox.Show("Login successful!");
                            }
                            else
                            {
                                // Login failed
                                MessageBox.Show("Invalid username or password.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Display error message for any exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
