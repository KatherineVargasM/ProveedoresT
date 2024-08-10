using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Proveedores.Config;

namespace Proveedores.Models
{
    internal class ProveedoresModel
    {
        public int IdProveedor { get; set; }
        public string NombreEmpresa { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        private ConexionBDD conexionBDD = new ConexionBDD();

        public List<ProveedoresModel> Todos()
        {
            string cadena = "select * from Proveedores";
            SqlDataAdapter adapter = new SqlDataAdapter(cadena, conexionBDD.AbrirConexion());
            DataTable data = new DataTable();
            adapter.Fill(data);

            List<ProveedoresModel> listaProveedores = new List<ProveedoresModel>();

            foreach (DataRow fila in data.Rows)
            {
                ProveedoresModel proveedor = new ProveedoresModel
                {
                    IdProveedor = Convert.ToInt32(fila["IdProveedor"]),
                    NombreEmpresa = fila["NombreEmpresa"].ToString(),
                    Direccion = fila["Direccion"].ToString(),
                    Telefono = fila["Telefono"].ToString()
                };
                listaProveedores.Add(proveedor);
            }
            conexionBDD.CerrarConexion();
            return listaProveedores;
        }

        public ProveedoresModel Obtener(int idProveedor)
        {
            string cadena = "select * from Proveedores where IdProveedor = @IdProveedor";
            SqlCommand cmd = new SqlCommand(cadena, conexionBDD.AbrirConexion());
            cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);
            SqlDataReader lector = cmd.ExecuteReader();

            ProveedoresModel proveedor = null;
            if (lector.Read())
            {
                proveedor = new ProveedoresModel
                {
                    IdProveedor = Convert.ToInt32(lector["IdProveedor"]),
                    NombreEmpresa = lector["NombreEmpresa"].ToString(),
                    Direccion = lector["Direccion"].ToString(),
                    Telefono = lector["Telefono"].ToString()
                };
            }
            lector.Close();
            conexionBDD.CerrarConexion();
            return proveedor;
        }

        public string Insertar(ProveedoresModel proveedor)
        {
            try
            {
                string cadena = "insert into Proveedores (NombreEmpresa, Direccion, Telefono) values (@NombreEmpresa, @Direccion, @Telefono)";
                SqlCommand cmd = new SqlCommand(cadena, conexionBDD.AbrirConexion());
                cmd.Parameters.AddWithValue("@NombreEmpresa", proveedor.NombreEmpresa);
                cmd.Parameters.AddWithValue("@Direccion", proveedor.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
                cmd.ExecuteNonQuery();
                return "ok";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                conexionBDD.CerrarConexion();
            }
        }

        public string Editar(ProveedoresModel proveedor)
        {
            try
            {
                string cadena = "update Proveedores set NombreEmpresa = @NombreEmpresa, Direccion = @Direccion, Telefono = @Telefono where IdProveedor = @IdProveedor";
                SqlCommand cmd = new SqlCommand(cadena, conexionBDD.AbrirConexion());
                cmd.Parameters.AddWithValue("@NombreEmpresa", proveedor.NombreEmpresa);
                cmd.Parameters.AddWithValue("@Direccion", proveedor.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
                cmd.Parameters.AddWithValue("@IdProveedor", proveedor.IdProveedor);
                cmd.ExecuteNonQuery();
                return "ok";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                conexionBDD.CerrarConexion();
            }
        }

        public string Eliminar(ProveedoresModel proveedor)
        {
            try
            {
                string cadena = "delete from Proveedores where IdProveedor = @IdProveedor";
                SqlCommand cmd = new SqlCommand(cadena, conexionBDD.AbrirConexion());
                cmd.Parameters.AddWithValue("@IdProveedor", proveedor.IdProveedor);
                cmd.ExecuteNonQuery();
                return "ok";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                conexionBDD.CerrarConexion();
            }
        }
    }
}
