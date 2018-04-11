using CourseC_Sharp.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseC_Sharp.Excercises
{
    public partial class FrmPOO : Form
    {
        private List<ClsCar> _list = new List<ClsCar>();

        /// <summary>
        /// Constructor Inicial
        /// </summary>
        public FrmPOO()
        {
            InitializeComponent();

            ClsCar car1 = new ClsCar();
            car1.Model = "Sentra";
            car1.Year = 2018;
            car1.Maker = "Nissan";
            car1.Type = TypeCar.Sedan;
            _list.Add(car1);
        

            ClsCar car2 = new ClsCar(2016);
            car2.Model = "Yaris";
            car2.Maker = "Toyota";
            car2.Year = 2015;
            car2.Type = TypeCar.Sedan;
            _list.Add(car2);


            ClsCar car3 = new ClsCar(2018, "CRV");
            car3.Year = 2016;
            car3.Maker = "Honda";
            car3.Type = TypeCar.SUV;
            
            _list.Add(car3);

            ClsCar car4 = new ClsCar() { Maker = "Dodge", Year = 2015, Model = "Neon", Type = TypeCar.Coupe };

            _list.Add(car4);
             DisplayList();

        }



        private void DisplayList()
        {
            StringBuilder result = new StringBuilder();

            foreach  (ClsCar item in _list)
               result.AppendLine(item.GetAllInformation);

            txtResults.Text = result.ToString();


        }

        /// <summary>
        /// Metodo para agrear un nuevo carro a la lista.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            ClsCar car1 = new ClsCar();

            car1.Model = txtModel.Text;
            car1.Year = Convert.ToInt32 (   numYear.Value);
            car1.Maker =  txtMake.Text;
            car1.Type = (TypeCar) cmbType.SelectedIndex;
            _list.Add(car1);
            DisplayList();


        }
    }
}
