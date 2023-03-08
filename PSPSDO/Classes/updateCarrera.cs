using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSPSDO.BD;
using System.Web;

namespace Proyecto_Segundo_Parcial_2.Clases
{
    public class updateCarrera
    {
        public void show(DataGridView dgvCarreras)
        {
            try
            {
                ArrayList parametros = new ArrayList();
                BDContext bd = new BDContext();
                parametros.Add(new SqlParameter { ParameterName = "@pEstatus", SqlDbType = System.Data.SqlDbType.VarChar, Value = 1 });
                DataSet ds = bd.Fill("sp_GetCarrera", parametros);
                dgvCarreras.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("error inesperado: " + ex.Message);
            }
        }
        public void add(DataGridView dgvCarreras,string Nombre, string Clave, string Descripcion)
        {
            try
            {
                ArrayList parametros = new ArrayList();
                BDContext bd = new BDContext();
                parametros.Add(new SqlParameter { ParameterName = "@pClave", SqlDbType = System.Data.SqlDbType.VarChar, Value = Clave });
                parametros.Add(new SqlParameter { ParameterName = "@pNombre", SqlDbType = System.Data.SqlDbType.VarChar, Value = Nombre });
                parametros.Add(new SqlParameter { ParameterName = "@pDescripcion", SqlDbType = System.Data.SqlDbType.VarChar, Value = Descripcion });
                parametros.Add(new SqlParameter { ParameterName = "@pUltimoUsuario", SqlDbType = System.Data.SqlDbType.VarChar, Value = 9999 });
                bd.ExecuteNonQuery("sp_SetCarrera", parametros);


                updateCarrera Opciones= new updateCarrera();
                Opciones.show(dgvCarreras);

                MessageBox.Show("Registro completado");
            }


            catch (Exception ex)
            {
                MessageBox.Show("error inesperado: " + ex.Message);
            }
        }
        public void delete(DataGridView dgvCarreras, int ID)
        {
            try
            {
                ArrayList parametros = new ArrayList();
                BDContext bd = new BDContext();
                parametros.Add(new SqlParameter { ParameterName = "@pID", SqlDbType = System.Data.SqlDbType.VarChar, Value = (ID + 1) });
                bd.ExecuteNonQuery("SP_DeleteCarreras", parametros);
                updateCarrera Opciones = new updateCarrera();
                Opciones.show(dgvCarreras);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error inesperado: " + ex.Message);
            }
        }
    }
}
