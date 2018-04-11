using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CourseC_Sharp.Class
{
    /// <summary>
    /// Ejemplo
    /// </summary>
    public class ClsCar
    {
        private int _year = 2018;
        private string _model = "";

        /// <summary>
        /// Ejemplo de sobre carga de datos
        /// </summary>
        public ClsCar()
        {
            // no se hace nada 
        }
        /// <summary>
        /// Sobrecar de constructor con año de fabricacion
        /// </summary>
        /// <param name="year">fabricacion</param>
        public ClsCar(int year)
        {
            _year = year;
        }
        /// <summary>
        ///  Sobrecar de constructor con año de fabricacion y nombre del modelo
        /// </summary>
        /// <param name="year">FAño de fabricacion</param>
        /// <param name="model">Nombre del modelo del auto</param>
        public ClsCar(int year, string model)
        {
            _year = year;
            _model = model;
        }


        /// <summary>
        /// Fabricate
        /// </summary>
        public string Maker { get; set; }
        /// <summary>
        /// Año de fabricacion del carro
        /// </summary>
        public int Year {
            get { return _year; }
            set { _year = value; }
        }
        /// <summary>
        /// Ejemplo de una propiedad
        /// </summary>
        private int Year2 { get; set; }

        /// <summary>
        /// Indica si el carro es nuevo
        /// </summary>
        /// <returns>Si o No</returns>
        public string IsNewCar()
        {
            if (Year == DateTime.Now.Year)
                return "SI";
            else
                return "NO";
        }

        /// <summary>
        /// Modelo del carro 
        /// </summary>
        public string Model {
            get { return _model; }
            set { _model = value; }
        }

        public TypeCar Type { get; set; }

      

        public string GetDescription()
        {

            Type type = this.Type.GetType();
            MemberInfo[] memInfo = type.GetMember(Type.ToString());
            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = (object[])memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attrs != null && attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return Type.ToString();
        }



        public string  GetAllInformation {
            get {
                return string.Format("Modelo: {0}, Año: {1}, Fabricante: {2}, Es nuevo: {3}, Descripcion:{4}", Model, Year, Maker,IsNewCar(), GetDescription());
            }
        }


    }
    

    /// <summary>
    ///Determina el tipo de carro
    /// </summary>
    public enum TypeCar:int 
    {
        [Description("Auto con maletero")]
        Hatchback = 1,
        [Description("Auto con cajuela")]
        Sedan = 2,
        [Description("Auto con ascientos altos")]
        MPV = 3,
        [Description("Auto utilitario deportivo")]
        SUV = 4,
        [Description("Auto de 2 puertas")]
        Coupe = 5,
        [Description("No especificado")]
        Other = 0

    }
}
