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
    public partial class EmployeeScreen : Form
    {

        Nomina theNomina = new Nomina();

        public EmployeeScreen()
        {
            InitializeComponent();
        }

        private void checkBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMale.Checked == true)
            {
                checkBoxFemale.Checked = false;
            }
        }

        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFemale.Checked == true)
            {
                checkBoxMale.Checked = false;
            }
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbPosition.SelectedIndex;
            if (index == 0)
            {
                txtSalary.Text = "60000";
            } else if (index == 1)
            {
                txtSalary.Text = "65000";
            }
            else if (index == 2)
            {
                txtSalary.Text = "70000";
            }
            else if (index == 3)
            {
                txtSalary.Text = "40000";
            }
            else
            {
                txtSalary.Text = "50000";
            }
        }

        private void btnSaveRegister_Click(object sender, EventArgs e)
        {
            if (txtIdentification.Text != "" &&
                txtFullName.Text != "" &&
                txtDays.Text != "" &&
                txtSalary.Text != "")
            {
                int idEmployee;

                if (!int.TryParse(txtIdentification.Text, out idEmployee))
                {
                    errorProvider1.SetError(txtIdentification, "Debe ingresar un número de estrato");
                    return;
                }
                
                theNomina.IdEmployee = Convert.ToInt32(txtIdentification.Text);
                theNomina.FullName = txtFullName.Text;
                if (checkBoxMale.Checked == true)
                {
                    theNomina.Gender = "Masculino";
                }
                else
                {
                    theNomina.Gender = "Femenino";
                }
                theNomina.Position = cmbPosition.SelectedItem.ToString();
                theNomina.WorkingDays = txtDays.Text;
                theNomina.DailySalary = txtSalary.Text;
                MessageBox.Show("Datos guardados con exito!");
            } else
            {
                MessageBox.Show("Dede ingresar toda la información en los campos!");
            }
        }

        private void btnCalculatePayroll_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "" ||
                txtDays.Text == "" ||
                txtIdentification.Text == "" ||
                txtSalary.Text == ""
            )
            {
                errorProvider1.SetError(txtFullName, "Debe ingresar un nombre completo de empleado");
                errorProvider1.SetError(txtDays, "Debe ingresar los días laborados");
                errorProvider1.SetError(txtIdentification, "Debe ingresar un número de Identificación");
                errorProvider1.SetError(txtSalary, "Debe seleccionar un cargo");
                return;
            }

            ReportScreen calculateReport = new ReportScreen(
                theNomina.IdEmployee,
                theNomina.FullName,
                theNomina.Gender,
                theNomina.Position,
                Convert.ToInt32(theNomina.WorkingDays),
                Convert.ToInt32(theNomina.DailySalary)
            );
            calculateReport.Show();
            this.Hide();
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
