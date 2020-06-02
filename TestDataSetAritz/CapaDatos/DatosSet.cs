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
   public class DatosSet
    {
        DataSetTest ds = new DataSetTest();
        CategoriasTableAdapter dsCategorias = new CategoriasTableAdapter();
        PreguntasTableAdapter dsPreguntas = new PreguntasTableAdapter();
        TestCategoriasTableAdapter dsTestCategorias = new TestCategoriasTableAdapter();
        TestsTableAdapter dsTests = new TestsTableAdapter();
        public DatosSet()
        {

            dsCategorias.Fill(ds.Categorias);
            dsPreguntas.Fill(ds.Preguntas);
            dsTests.Fill(ds.Tests);
            dsTestCategorias.Fill(ds.TestCategorias);

            if (ds.Tables.Count == 0)
            {
                return;
            }
            
        }
        public List<Pregunta> DevolverPreguntasPorTest(int IdTest, out string msg)
        {
            msg = "";
            
            List<PreguntasRow> drPregunta;
            drPregunta = ds.Preguntas.Where(drPreg => drPreg.IdTest == IdTest).ToList();
            List<Pregunta> preguntas = (from preg in drPregunta
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

            if (categorias == null)
            {
                msg = "La lista de categorias esta vacia";
                return null;
            }
            return categorias.AsReadOnly();
        }
        public ReadOnlyCollection<Test> DevolverTestPorCategoria(int IdCat, out string msg)
        {
           msg = "";
            
            CategoriasRow drCategorias = ds.Categorias.FindById(IdCat);
            if (drCategorias ==null)
            {
                msg = "La categoria no existe";
            }
            var drTestCategorias = drCategorias.GetTestCategoriasRows().ToList();
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
