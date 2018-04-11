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
    public partial class FrmArrays : Form
    {

        private char[] _chars = new char[5];
        private string[] _words = new string[5];
        private int[] _numbers = new int[10];
        private int[,] _bidimentional = new int[3,2];

        //List<t> var = new List<t>();
       private  List<string> _examples = new List<string>();


        public FrmArrays()
        {
            InitializeComponent();
            _chars = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            _words = new string[5] { "Pais", "Estado", "Municipio", "Colonia", "Calle" };
            _numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            _bidimentional = new[,] { { 1, 2, 3 }, { 4, 5, 6 } };

            FillList();

        }

        /// <summary>
        /// Metodo para llenar un proceso 
        /// </summary>
        private void FillList()
        {
            _examples.Add("TOMATE");
            _examples.Add("FRIJOL");
            _examples.Add("CEBOLLA");
            _examples.Add("MANZANA");
            _examples.Add("AGUACATE");
            _examples.Add("MANDADO");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChars_Click(object sender, EventArgs e)
        {
            try
            {
                int position = Convert.ToInt32(txtPosition.Text);
                _chars[position-1] =Convert.ToChar( txtValue .Text);

                StringBuilder result = new StringBuilder();
                result.AppendLine("Arreglos de Letras");
                for (int i = 0; i <= _chars.Length-1; i++)
                {
                    result.AppendLine(_chars[i].ToString());
                }
                txtResults.Text = result.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       
        private void btnWords_Click(object sender, EventArgs e)
        {
            try
            {
                int position = Convert.ToInt32(txtPosition.Text);
                _words[position-1] = txtValue.Text;

                StringBuilder result = new StringBuilder();
                result.AppendLine("Arreglos de Numeros");
                for (int i = 0; i <=_words.Length - 1; i++)
                {
                    result.AppendLine(_words[i].ToString());
                }
                txtResults.Text = result.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNumbers_Click(object sender, EventArgs e)
        {
            try
            {
                int position = Convert.ToInt32(txtPosition.Text);
                _numbers[position-1] = Convert.ToInt32(txtValue.Text);

                StringBuilder result = new StringBuilder();
                result.AppendLine("Arreglos de Numeros");
                for (int i = 0; i <= _numbers.Length - 1; i++)
                {
                    result.AppendLine(_numbers[i].ToString());
                }
                txtResults.Text = result.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Metodo para agregar un nuevo elemento en la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _examples.Add(txtValueList.Text.ToUpper());
                DisplayList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Metodo para eliminar el valor de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _examples.Remove(txtValueList.Text.ToUpper());
                DisplayList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Metodo buscar un dato en la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (_examples.Contains(txtValueList.Text.ToUpper()))
            {
                MessageBox.Show("Dato encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dato no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DisplayList();

        }




        private void DisplayList()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Listado de valores");
            foreach (string  item in _examples )
                result.AppendLine(item);
            txtResults.Text = result.ToString();
        }


        private Order order = Order.Descending;
        /// <summary>
        /// Metodo para reordernar los elementos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReorder_Click(object sender, EventArgs e)
        {
            if (order == Order.Descending)
            {
                 _examples.Sort((a, b) => a.CompareTo(b)); // ascending sort
                order = Order.Ascending;
               // _examples.Sort();

            }
            else
            {
                _examples.Sort((a, b) => -1 * a.CompareTo(b)); // descending sort
                order = Order.Descending;
                //_examples.Reverse();
            }

            // _examples = _examples.OrderBy(i => i).ToList();
            
          

            DisplayList();
        }
        /// <summary>
        /// Enum para indicar el tipo de ordenacion de los datos
        /// </summary>
      private enum Order
        {
            Ascending=1,
            Descending=2
        }

        
    }
}
