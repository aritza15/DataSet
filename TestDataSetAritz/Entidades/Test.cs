using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Test : IEquatable<Test>
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Test(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public Test(int id)
        {
            Id = id;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Test);
        }

        public bool Equals(Test other)
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
