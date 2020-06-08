using CapaDatos.DataSetTestTableAdapters;
using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaDatos.DataSetTest;

namespace CapaDatos
{
    // TODO Debes cambiar la BD, ya Preguntas tenía mal la clave.
   public class DatosSet
    {
        // TODO No hay control de la BD, si no existe se producirá un error de ejecución. Debes contemplar el caso y conseguir que el usuario o usuaria final se entere del problema (y que por supuesto no se rompa)
        DataSetTest ds = new DataSetTest();
        CategoriasTableAdapter dsCategorias = new CategoriasTableAdapter();
        PreguntasTableAdapter dsPreguntas = new PreguntasTableAdapter();
        TestCategoriasTableAdapter dsTestCategorias = new TestCategoriasTableAdapter();
        TestsTableAdapter dsTests = new TestsTableAdapter();
        public DatosSet()
        {
            if(ds == null)
            {
                return;
            }
            dsCategorias.Fill(ds.Categorias);
            dsPreguntas.Fill(ds.Preguntas);
            dsTests.Fill(ds.Tests);
            dsTestCategorias.Fill(ds.TestCategorias);

            if (ds.Tables.Count == 0) // ¿Que sentido tiene esto?
            {
                return;
            }
            
        }
        public List<Pregunta> DevolverPreguntasPorTest(int IdTest, out string msg) // TODO Haces lo que siempre digo que no hay que hacer. Buscas entre TODAS las preguntas (pueden ser miles) en lugar de buscar el test (que por cierto no controlas que puede no existir) y de ese SUS preguntas (que ya serán pocas) --> Error fundamental
        {
            msg = "";

            TestsRow drTests = ds.Tests.FindById(IdTest);

            var drPreguntas = drTests.GetPreguntasRows();
            List<Pregunta> preguntas = (from preg in drPreguntas
                                        select new Pregunta(preg.NPregunta, preg.Enunciado, preg.Respuesta)).ToList();

            if (preguntas == null)
            {
                msg = "La lista de preguntas esta vacia";
                return null;
            }
            return preguntas;
        }
        public ReadOnlyCollection<Categoria> DevolverCategorias(out string msg)
        {
            msg = "";
            
            List<CategoriasRow> drCategoria;
            drCategoria = ds.Categorias.ToList();
            List<Categoria> categorias = (from cat in drCategoria
                                        select new Categoria(cat.Id, cat.Nombre)).ToList();

            if (categorias.Count()==0) // TODO Nunca puede serlo, analiza bien lo que será
            {
                msg = "La lista de categorias esta vacia";
                return null;
            }
            return categorias.AsReadOnly();
        }
        public ReadOnlyCollection<Test> DevolverTestPorCategoria(int IdCat, out string msg)
        {
           msg = "";
            
            CategoriasRow drCategoria = ds.Categorias.FindById(IdCat); // TODO ¿Por qué el nombre es en plural si solo es 1?
            if (drCategoria ==null)
            {
                msg = "La categoria no existe";
            }
            var drTestCategorias = drCategoria.GetTestCategoriasRows().ToList();
            var tests = (from test in drTestCategorias
                                select new Test(test.IdTest, test.TestsRow.Nombre)).ToList();


            if (tests.Count() == 0)
            {
                msg = "La lista de test esta vacia";
                return tests.AsReadOnly();
            }
            return tests.AsReadOnly();
        }
    }
}
