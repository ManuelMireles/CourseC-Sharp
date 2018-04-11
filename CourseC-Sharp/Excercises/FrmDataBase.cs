using CourseC_Sharp.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseC_Sharp.Excercises
{
    public partial class FrmDataBase : Form
    {
        public FrmDataBase()
        {
            InitializeComponent();
        }

        private string _conectionString = "Datasource =\"Auto.sdf\";Password=\"123456\"";
        private SqlCeConnection _conn;
        private SqlCeCommand _cmd;
        private SqlCeDataAdapter _da;
        private DataTable _dt = new DataTable();



        /// <summary>
        /// Metodo para crear una base de datos compata.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateDB_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCeEngine sql = new SqlCeEngine(_conectionString);
                sql.CreateDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


        }

        /// <summary>
        /// Metodo para crear una nueva tabla en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            try
            {
                _conn = new SqlCeConnection(_conectionString);
                _conn.Open();
                string query = @"Create table Auto (id int primary key identity(1,1) , 
                                    Modelo  nvarchar(50),
                                    Fabricante nvarchar(50),
                                    Año int ,
                                    Tipo int                          
                            )";
                _cmd = new SqlCeCommand(query, _conn);
                _cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }


        /// <summary>
        /// Metodo para desplegar la informacion de una tabla
        /// </summary>
        /// <param name="lst"></param>
        /// <param name="dt"></param>
        private void FillList(ListView lst, DataTable dt)
        {
            lst.BeginUpdate();
            lst.View = View.Details;
            lst.Items.Clear();
            lst.GridLines = true;
            lst.Columns.Clear();          
            lst.EndUpdate();


            foreach (DataColumn col in dt.Columns)
            {
                lst.Columns.Add(col.ToString());
            }

            List<ListViewItem> items = new List<ListViewItem>();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                for (int i = 0; i < dt.Columns.Count ; i++)
                {
                    if (i == 0)
                        item.Text = (row[i].ToString());
                    else
                        item.SubItems.Add(row[i].ToString());
                }

                items.Add(item);

            }
            lst.Items.AddRange(items.ToArray());


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisplayData_Click(object sender, EventArgs e)
        {
            GetData();
        }

        /// <summary>
        /// 
        /// </summary>
        private void GetData()
        {
            try
            {

                _conn = new SqlCeConnection(_conectionString);
                _conn.Open();
                string query = @"select * from  Auto ";
                _cmd = new SqlCeCommand(query, _conn);
                _da = new SqlCeDataAdapter(_cmd);
                _dt = new DataTable();
                _da.Fill(_dt);
                FillList(lstDisplayData, _dt);

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
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @" Insert into Auto  (Modelo, Fabricante,Año,Tipo )
                                              values(@Modelo, @Fabricante,@Año,@Tipo)";
                _conn = new SqlCeConnection(_conectionString);
                _conn.Open();

                _cmd = new SqlCeCommand(query, _conn);
                _cmd.Parameters.AddWithValue("@Modelo", txtModel.Text.ToString());
                _cmd.Parameters.AddWithValue("@Fabricante", txtMake.Text);
                _cmd.Parameters.AddWithValue("@Año", Convert.ToInt32(numYear.Value));
                _cmd.Parameters.AddWithValue("@Tipo", cmbType.SelectedIndex);
                _cmd.ExecuteNonQuery();
                GetData();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @" Delete Auto where ID= @ID";
                _conn = new SqlCeConnection(_conectionString);
                _conn.Open();

                _cmd = new SqlCeCommand(query, _conn);
                _cmd.Parameters.AddWithValue("@ID", Convert.ToInt32 (txtId.Text) );

                _cmd.ExecuteNonQuery();
               //_cmd.ExecuteReader();  Se ejecuta en tiempo de ejecucion y devuelve fila por fila se requiere un ciclo while para leer de la base de datos
               //_cmd.ExecuteScalar(); Obtiene un solo campo o variable de la base de datos.

                GetData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// Leera de la base de datos y los almacenara en una clase.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPOO_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @" Select * from  Auto";
                _conn = new SqlCeConnection(_conectionString);
                _conn.Open();

                _cmd = new SqlCeCommand(query, _conn);

                List<ClsCar> lst = new List<ClsCar>();

                SqlCeDataReader reader=   _cmd.ExecuteReader();
                while (reader.Read())
                {
                    ClsCar car= new ClsCar();

                    car.Model = reader["Modelo"].ToString();
                    car.Year = Convert.ToInt32(reader["Año"]);
                    car.Maker = reader["Fabricante"].ToString();
                    car.Type = (TypeCar)Convert.ToInt32(reader["Tipo"]);
                    lst.Add(car);
                }




                StringBuilder result = new StringBuilder();
                foreach (ClsCar item in lst)
                    result.AppendLine(item.GetAllInformation);

                txtResults.Text = result.ToString();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
