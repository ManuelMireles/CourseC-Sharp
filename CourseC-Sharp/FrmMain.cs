using CourseC_Sharp.Cicles;
using CourseC_Sharp.Excercises;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseC_Sharp
{
    public partial class FrmMain : Form
    {
        private int _exerciseToDo;
       
        /// <summary>
        /// Constructor del formulario, en el cual se inicializan los componentes del formulario
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
            _exerciseToDo = 1;
        }

        
        /// <summary>
        /// metodo que se ejecuta al inicio 
        /// </summary>
        /// <param name="sender">Objecto que desata la acción</param>
        /// <param name="e">Argumentos o propiedades del evento</param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
 
        }

        /// <summary>
        /// Evento que se ejecuta cuando se modifica el estatus del check del control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbExercise1_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton rdb = (RadioButton)sender;
            if (  sender== rdbExerciseCicles)
            {
                _exerciseToDo = 1;

            }else if (sender== rdbConditionals)
            {
                _exerciseToDo = 2;
            }
            else if (sender == rdbArraysList)
            {
                _exerciseToDo = 3;
            }else if (sender==rdbExercisePOO)
            {
                _exerciseToDo = 4;
            }
             else if (sender== rdbPoliform)
            {
                _exerciseToDo = 5;
            }
            else if (sender == rdbForms)
            {
                _exerciseToDo = 6;
            }
        }


        /// <summary>
        /// IR al ejercicio seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            switch (_exerciseToDo)
            {

                case 1:
                    FrmCicles frm = new FrmCicles();
                    frm.ShowDialog();
                    break;

                case 2:
                    FrmConditionals frmC = new FrmConditionals();
                    frmC.ShowDialog();
                    break;

                case 3:
                    FrmArrays frmA = new FrmArrays();
                    frmA.ShowDialog();
                    break;

                case 4:
                    FrmPOO frmP = new FrmPOO();
                    frmP.ShowDialog();
                    break;

                case 5:
                    FrmPolymorphism frmPo = new FrmPolymorphism();
                    frmPo.ShowDialog();
                    break;
                case 6:
                    FrmDataBase frmDB = new FrmDataBase();
                    frmDB.ShowDialog();
                    break;
                default:
                    break;
            }
            this.Show();
        }

        
    }
}
