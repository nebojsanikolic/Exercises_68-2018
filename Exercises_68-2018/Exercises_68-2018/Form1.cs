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

namespace Exercises_68_2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<ExerciseResult> lista = new List<ExerciseResult>();
            string constring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FacultyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string commandtext = "Select * FROM ExerciseResults";
            SqlCommand com = new SqlCommand(commandtext, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new ExerciseResult(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetInt32(3)));

            }
            foreach(ExerciseResult er in lista)
            {
                listBox1.Items.Add(er.ToString());
            }

        }
    }
}
