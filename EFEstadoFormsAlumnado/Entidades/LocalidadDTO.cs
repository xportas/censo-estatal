using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LocalidadDTO : IEquatable<LocalidadDTO>
    {
        public int Id;
        public string Localidad;
        public string IdProv;
        public string Provincia;

        public LocalidadDTO() { }
        public LocalidadDTO(int id, string localidad, string idProv, string provincia)
        {
            Id = id;
            Localidad = localidad;
            IdProv = idProv;
            Provincia = provincia;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as LocalidadDTO);
        }

        public bool Equals(LocalidadDTO other)
        {
            return !(other is null) &&
                   Id == other.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public static bool operator ==(LocalidadDTO left, LocalidadDTO right)
        {
            return EqualityComparer<LocalidadDTO>.Default.Equals(left, right);
        }

        public static bool operator !=(LocalidadDTO left, LocalidadDTO right)
        {
            return !(left == right);
        }
    }
}
