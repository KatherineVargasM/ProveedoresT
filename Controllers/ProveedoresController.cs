using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proveedores.Models;

namespace Proveedores.Controllers
{
    internal class ProveedoresController
    {
        private ProveedoresModel proveedoresModel = new ProveedoresModel();

        public List<ProveedoresModel> todos()
        {
            return proveedoresModel.Todos();
        }

        public ProveedoresModel obtener(int idProveedor)
        {
            return proveedoresModel.Obtener(idProveedor);
        }

        public string insertar(ProveedoresModel proveedor)
        {
            return proveedoresModel.Insertar(proveedor);
        }

        public string editar(ProveedoresModel proveedor)
        {
            return proveedoresModel.Editar(proveedor);
        }

        public string eliminar(ProveedoresModel proveedor)
        {
            return proveedoresModel.Eliminar(proveedor);
        }
    }
}
