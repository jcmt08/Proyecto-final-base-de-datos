using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Final
{
    public class ClassFinal
    {
        ClassDatos objd = new ClassDatos();

        public DataTable listar_canciones()
        {
            return objd.listar_canciones();
        }

        public DataTable buscar_canciones(ClassEntidad obje)
        {
            return objd.buscar_canciones(obje);
        }
        public DataTable buscar_canciones2(ClassEntidad obje)
        {
            return objd.buscar_canciones2(obje);
        }
        public DataTable buscar_canciones3(ClassEntidad obje)
        {
            return objd.buscar_canciones3(obje);
        }
        public DataTable buscar_canciones5(ClassEntidad obje)
        {
            return objd.buscar_canciones5(obje);
        }
        public DataTable buscar_canciones6(ClassEntidad obje)
        {
            return objd.buscar_canciones6(obje);
        }
        public DataTable buscar_canciones7(ClassEntidad obje)
        {
            return objd.buscar_canciones7(obje);
        }
        

        public String mantenimiento_canciones(ClassEntidad obje)
        {
            return objd.mantenimiento_canciones(obje);
        }
    }
}
