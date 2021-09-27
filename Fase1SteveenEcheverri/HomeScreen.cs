using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase1SteveenEcheverri
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String passwordDefault = "123";

            if (txtPassword.Text == passwordDefault)
            {
                EmployeeScreen registrationEmployee = new EmployeeScreen();
                registrationEmployee.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("¡La contraseña es incorrecta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
    }
}
