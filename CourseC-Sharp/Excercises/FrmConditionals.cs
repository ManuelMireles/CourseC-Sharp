using CourseC_Sharp.POO;
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
    public partial class FrmConditionals : Form

    {
        /// <summary>
        /// 
        /// </summary>
        public FrmConditionals()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSimple_Click(object sender, EventArgs e)
        {
            try
            {
                int star = Convert.ToInt32(txtStar.Text);
                int end = Convert.ToInt32(txtEnd.Text);
                if (star < end)
                {
                    MessageBox.Show("El valor inicial es menor", "Comparación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El valor inicial es Mayor", "Comparación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

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
        private void btnMultiple_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(txtStar.Text);
                int y = Convert.ToInt32(txtEnd.Text);
                if (x < y)
                {
                    MessageBox.Show("es x es menor que y", "Comparación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (x == y)
                {
                    MessageBox.Show("x  es igual y", "Comparación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // x  es igual a y
                }
                else if (x > y)
                {
                    MessageBox.Show("x  es mayor que y", "Comparación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No definido", "Comparación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            try
            {

                int x = Convert.ToInt32(txtStar.Text);
                switch (x)
                {
                    case 1:
                        MessageBox.Show("X es igual a 1", "Comparación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        MessageBox.Show("X es igual a 2", "Comparación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        MessageBox.Show("X es diferente a 1 o 2", "Comparación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
