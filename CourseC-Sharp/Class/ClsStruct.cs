using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseC_Sharp.Class
{
    public struct ClsStructCar
    {
        public string Name;
        public string Model;
        public int Year; 
        public string Make;

        public bool IsNewCar()
        {
            if (Year == DateTime.Now.Year)
                return true;
            else
                return false;
        }
    }
}
