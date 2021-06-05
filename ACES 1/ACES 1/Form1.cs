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

namespace ACES_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=diyetveri_050621");
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            if (baglanti.state.ToString() == "Closed")
            {
                baglanti.Open();
                MessageBox.Show("Acildi.");
            }
            
        }

        private void btnKapa_Click(object sender, EventArgs e)
        {
            if (baglanti.state.ToString() == "Opened")
            {
                baglanti.Close();
                MessageBox.Show("Kapandi.");
            }
        }
    }
}
