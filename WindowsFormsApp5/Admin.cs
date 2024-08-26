using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Admin : Form
    {
        String user = ""; 
        public Admin()
        {
            InitializeComponent();
        }
        public string ID
        {
            get { return user.ToString(); }
        }
        public Admin(String username)
        {
            InitializeComponent();
            userlabel.Text = username;
            user = username;
            uC_Listar1.ID = ID;
            uC_Perfil1.ID = ID;
        }



        private void Admin_Load(object sender, EventArgs e)
        {
             cU_AddUser1.Visible = false;
            uC_Perfil1.Visible = false;
            uC_Listar1.Visible = false;
            btnPainel.PerformClick();

        }

        private void btnPainel_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = true;
            uC_Dashboard1.BringToFront();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cU_AddUser1.Visible = true;
            cU_AddUser1.BringToFront();


        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            uC_Listar1.Visible = true;
            uC_Listar1.BringToFront();

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            uC_Perfil1.Visible = true;
            uC_Perfil1.BringToFront();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }
    }
}
