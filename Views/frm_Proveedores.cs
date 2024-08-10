using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proveedores.Controllers;
using Proveedores.Models;

namespace Proveedores
{
    public partial class frm_Proveedores : Form
    {
        ProveedoresController proveedoresController = new ProveedoresController();
        public string IdProveedor = null;
        public frm_Proveedores()
        {
            InitializeComponent();
        }

        private void frm_Proveedores_Load(object sender, EventArgs e)
        {
            cargaLista();
        }

        public void cargaLista()
        {
            lst_Proveedores.DataSource = proveedoresController.todos();
            lst_Proveedores.DisplayMember = "NombreEmpresa";
            lst_Proveedores.ValueMember = "IdProveedor";
        }

        private void lst_Proveedores_DoubleClick(object sender, EventArgs e)
        {
            if (lst_Proveedores.SelectedItem != null)
            {
                ProveedoresModel proveedorSeleccionado = (ProveedoresModel)lst_Proveedores.SelectedItem;
                string mensaje = $"Nombre de la Empresa: {proveedorSeleccionado.NombreEmpresa}\n" +
                                 $"Direccion: {proveedorSeleccionado.Direccion}\n" +
                                 $"Telefono: {proveedorSeleccionado.Telefono}";


                MessageBox.Show(mensaje, "Informacion del Proveedor");
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (lst_Proveedores.SelectedItem != null)
            {
                IdProveedor = lst_Proveedores.SelectedValue.ToString();
                ProveedoresModel proveedor = proveedoresController.obtener(Convert.ToInt32(IdProveedor));
                if (proveedor != null)
                {
                    txt_NombreEmpresa.Text = proveedor.NombreEmpresa;
                    txt_Direccion.Text = proveedor.Direccion;
                    txt_Telefono.Text = proveedor.Telefono;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor de la lista.");
            }
        }

        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            ProveedoresModel proveedor = new ProveedoresModel
            {
                IdProveedor = Convert.ToInt32(IdProveedor),
                NombreEmpresa = txt_NombreEmpresa.Text,
                Direccion = txt_Direccion.Text,
                Telefono = txt_Telefono.Text
            };

            if (Convert.ToInt32(IdProveedor) > 0)
            {
                respuesta = proveedoresController.editar(proveedor);
            }
            else
            {
                respuesta = proveedoresController.insertar(proveedor);
            }

            if (respuesta == "ok")
            {
                IdProveedor = null;
                cargaLista();
                MessageBox.Show("Se guardo con exito.");
            }
            else
            {
                IdProveedor = null;
                MessageBox.Show("Error al guardar.");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (lst_Proveedores.SelectedItem != null)
            {
                ProveedoresModel proveedor = new ProveedoresModel
                {
                    IdProveedor = Convert.ToInt32(lst_Proveedores.SelectedValue)
                };
                string respuesta = proveedoresController.eliminar(proveedor);

                if (respuesta == "ok")
                {
                    cargaLista();
                    MessageBox.Show("Proveedor eliminado con exito.");
                }
                else
                {
                    MessageBox.Show("Error al eliminar el proveedor.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor de la lista.");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_NombreEmpresa.Text = string.Empty;
            txt_Direccion.Text = string.Empty;
            txt_Telefono.Text = string.Empty;
            IdProveedor = null;
            lst_Proveedores.ClearSelected();
        }
    }
}
