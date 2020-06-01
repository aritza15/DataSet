using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria : IEquatable<Categoria>
    {
        public int Id { get; set; }
        public string Nombre{ get; set; }

        public Categoria(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public Categoria(int id)
        {
            Id = id;
        }

        public Categoria()
        {
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Categoria);
        }

        public bool Equals(Categoria other)
        {
            return other != null &&
                   Id == other.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
    }
}
