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

namespace CourseC_Sharp
{
    public partial class FrmPolymorphism : Form
    {
        /// <summary>
        /// Defuault constructor
        /// </summary>
        public FrmPolymorphism()
        {
            InitializeComponent();
            ClsChihuahua ch1 = new ClsChihuahua();
            ClsPastorAleman pa = new ClsPastorAleman();
          //  ClsDog dog = new ClsDog();
                        


            StringBuilder result = new StringBuilder();
            result.AppendLine(ch1.bay());
            result.AppendLine(ch1.Sleep());

            result.AppendLine(pa.bay());
            result.AppendLine(pa.Sleep());


            this.txtResults.Text = result.ToString();

        }
    }
}
