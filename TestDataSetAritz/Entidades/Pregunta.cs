using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pregunta : IEquatable<Pregunta>
    {
        public int Npregunta { get; set; }
        public string Enunciado { get; set; }
        public bool Respuesta { get; set; }
        public int IdTest { get; set; }

        public Pregunta(int npregunta, string enunciado, bool respuesta, int idTest)
        {
            Npregunta = npregunta;
            Enunciado = enunciado;
            Respuesta = respuesta;
            IdTest = idTest;
        }

        public Pregunta(int npregunta, string enunciado, bool respuesta) : this(npregunta)
        {
            Enunciado = enunciado;
            Respuesta = respuesta;
        }

        public Pregunta(int npregunta)
        {
            Npregunta = npregunta;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Pregunta);
        }

        public bool Equals(Pregunta other)
        {
            return other != null &&
                   Npregunta == other.Npregunta;
        }

        public override int GetHashCode()
        {
            return 692856879 + Npregunta.GetHashCode();
        }
    }
}
