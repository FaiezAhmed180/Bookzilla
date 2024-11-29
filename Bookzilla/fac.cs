using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookzilla
{
    public partial class fac : Form
    {
        public fac()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=FAIEZAHMED;Initial Catalog=Bookzila;Integrated Security=True;TrustServerCertificate=True");
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {

        }

        private void fac_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IBookBuilder builder = new BookBuilder();
            builder.SetAuthorName(authorname.Text);
            builder.SetPublisherName(Publishername.Text);
            builder.SetNumberOfPages(int.Parse(bookpages.Text));
            builder.SetPublishDate(DateTime.Parse(date.Text));
            builder.SetDescription(description.Text);
            builder.SetCategory(category.Text);
            builder.SetBookTitle(booktittle.Text);

            Book newBook = builder.GetBook();
        }
    }
}
