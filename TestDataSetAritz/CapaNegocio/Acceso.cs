using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Acceso
    {
        string mensaje { get; set; }

        DatosSet nuevoAcceso = new DatosSet();

        public ReadOnlyCollection<Categoria> DevolverCategorias(out string mensaje)
        {
            return nuevoAcceso.DevolverCategorias(out mensaje);
        }
        public ReadOnlyCollection<Test> DevolverTestPorCategoria(int idCat, out string mensaje)
        {
            return nuevoAcceso.DevolverTestPorCategoria(idCat, out mensaje);
        }
        public List<Pregunta> DevolverPreguntasPorTest(int idTest, out string mensaje)
        {
            return nuevoAcceso.DevolverPreguntasPorTest(idTest, out mensaje);
        }
    }
}
