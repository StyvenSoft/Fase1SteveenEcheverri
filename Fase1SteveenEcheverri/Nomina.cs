using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase1SteveenEcheverri
{
    public class Nomina
    {
        private int idEmployee;
        private string fullName;
        private string gender;
        private string position;
        private string workingDays;
        private string dailySalary;

        public int IdEmployee
        {
            get
            {
                return idEmployee;
            }

            set
            {
                idEmployee = value;
            }
        }

        public string FullName
        {
            get
            {
                return fullName;
            }

            set
            {
                fullName = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }

        public string WorkingDays
        {
            get
            {
                return workingDays;
            }

            set
            {
                workingDays = value;
            }
        }

        public string DailySalary
        {
            get
            {
                return dailySalary;
            }

            set
            {
                dailySalary = value;
            }
        }
    }
}
