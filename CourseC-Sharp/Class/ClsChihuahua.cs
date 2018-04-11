using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseC_Sharp.Class
{
    class ClsChihuahua : ClsDog
    {

        public override string bay()
        {
           return "El chihuahua esta ladrando";
        }


        public override string Sleep()
        {
            return "El chihuahua esta durmiendo";
        }
    }



    class ClsPastorAleman : ClsDog
    {

        public override string Sleep()
        {
            return "El pastor aleman esta durmiendo";
        }
    }





}
