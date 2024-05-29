using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetirementChecked
{
    public class CheckPensions
    {
        double age;
        bool gender;
        
        public double Age
        {
            get { return age; }
            set { age = value; }
        }
        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string PensionFund()
        {
            age = Math.Round(age);
            if (gender)
            {
                if (age <= 0 || age < 60 || age > 150)
                    return "Не проходит";
                else 
                    return "Проходит";
            }
            else {
                if (age <= 0 || age < 65 || age > 150)
                    return "Не проходит";
                else
                    return "Проходит";
            }
        }
    }
}
