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
    public partial class reportScreen : Form
    {
        public reportScreen()
        {
            InitializeComponent();
            string payDay = DateTime.Now.ToString("dd-MM-yyyy");
            txtPayDay.Text = payDay;
        }
    }
}
