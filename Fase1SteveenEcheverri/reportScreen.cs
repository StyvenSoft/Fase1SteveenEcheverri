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
    public partial class ReportScreen : Form
    {
        Employee theEmployee = new Employee();

        public ReportScreen(
            int idEmployee,
            string fullName,
            string gender,
            string position,
            int workingDays,
            int dailySalary
        )
        {
            InitializeComponent();
            string payDay = DateTime.Now.ToString("dd/MM/yyyy");
            txtPayDay.Text = payDay;

            label9.Text = fullName;
            label10.Text = Convert.ToString(idEmployee);
            label11.Text = gender;
            label12.Text = position;
            label13.Text = Convert.ToString(dailySalary);
            label14.Text = Convert.ToString(workingDays);

            label15.Text = Convert.ToString(theEmployee.CalculateEarnedSalary(workingDays, dailySalary));
        }
    }
}
