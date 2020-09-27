using System;
using System.Collections.Generic;
using System.Text;

namespace ClassPractice
{
    class FullEmployee
    {
        public int salary;
        public int sickTime;
        public string vacation;
        private bool medicalPlan;
        private bool dentalPlan;
        private string car;

        public int Taxes()
        {
            return 1;
        }

        public int Benefits()
        {
            return 2;
        }
    }
}
