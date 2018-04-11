using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseC_Sharp.Class
{
   public abstract  class ClsAbstCar:ClsMaker, IVehicle
    {

      public   ClsAbstCar(int numberTires,  int numbersSit, int engine)
        {
            NumberTires = numberTires;
            NumbersSit = numbersSit;
            Engine = engine;
        }
            

        public abstract int NumberTires { get; set; }

        public abstract int NumbersSit { get; set; }

        public abstract int  Engine{ get; set; }



        /// <summary>
        /// Implementacion de interface
        /// </summary>
        /// <param name="key"></param>
        public void EngineStart(bool key)
        {
            if (key == true)
                MessageBox.Show("El auto ha sido encendido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No hay llave no se puede encender el auto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public void DisplayMakerInformacion()
        {
            string info = string.Format("Propietario: {0}, Pais: {1}", Owner, Country);

        }
    }
}
