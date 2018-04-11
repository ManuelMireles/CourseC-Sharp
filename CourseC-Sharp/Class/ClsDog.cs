using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseC_Sharp.Class
{


    /// <summary>
    /// Clase para ejemplificar el Polimorfismo
    /// </summary>
    public abstract  class ClsDog
    {
        public virtual string bay()
        {
            return "El perro esta ladrando";
        }

        public abstract string Sleep();
    }
}
