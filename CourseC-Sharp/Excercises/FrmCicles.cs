using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseC_Sharp.Cicles
{
    public partial class FrmCicles : Form
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public FrmCicles()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ciclo for
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFor_Click(object sender, EventArgs e)
        {
            try
            {
                int star = Convert.ToInt32(txtStar.Text);
                int end= Convert.ToInt32(txtEnd.Text);
                StringBuilder result = new StringBuilder();
                result.AppendLine("Ciclo FOR");
                for (int i = star; i < end; i++)
                {
                    //result=result+ i.i.ToString();
                    result.AppendLine(i.ToString());
                    if (i == 3)
                        break;

                }

                txtResults.Text = result.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(  ex.Message, "Mensaje de error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                 
            }
        }
        /// <summary>
        /// Ciclo While
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWhile_Click(object sender, EventArgs e)
        {
            try
            {
                int star = Convert.ToInt32(txtStar.Text);
                int end = Convert.ToInt32(txtEnd.Text);
                StringBuilder result = new StringBuilder();
                result.AppendLine("Ciclo WHILE");
                               
                while (star <=end)
                {
                    star++;
                    result.AppendLine(star.ToString());
                }
          
                txtResults.Text = result.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            try
            {
                int star = Convert.ToInt32(txtStar.Text);
                int end = Convert.ToInt32(txtEnd.Text);
                StringBuilder result = new StringBuilder();
                result.AppendLine("Ciclo DO WHILE");

                do
                {
                    result.AppendLine(star.ToString());
                    star++;
                    

                } while (star < end);
                txtResults.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        /// <summary>
        /// Ciclo ForEach
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnForEach_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder result = new StringBuilder();
                result.AppendLine("Ciclo FOREACH");

                foreach (char c in txtStar.Text)
                {
                    result.AppendLine(c.ToString());
                }              
                txtResults.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
