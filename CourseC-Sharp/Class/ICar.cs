using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseC_Sharp.Class
{
    /// <summary>
    /// Interface hereda laas acciones obligatorias debe tener un vehiculo
    /// </summary>
   public interface IVehicle
    {
       void EngineStart(bool key);
       void DisplayMakerInformacion();
    }
}
