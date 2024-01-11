using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;

namespace CapaDatos
{
    public class GestorDatos
    {
        EstadoEntities bdEstadoEntities;
        public GestorDatos(out string error)
        {
            error = null;
            try
            {
                bdEstadoEntities = new EstadoEntities();
            }
            catch (Exception e)
            {
                error = e.Message;
            }
        }



        //1. DATOS DE PROVINCIAS: Mostrar en combo los nombres de las provincias ordenadas alfabéticamente. Al elegir una se verán sus datos en las etiquetas correspondientes
        public List<Provincia> GetProvinciaList() 
        {
            return bdEstadoEntities.Provincias.OrderBy(prov => prov.Nombre).ToList();
        }



        // 2. CONSULTAS: Método que devuelve localidades habitadas más pequeñas ordenadas por provincia y por nombre de localidad
        public List<Localidade> GetLocalidadesPequenhasOrdenadas(out int? numMin)
        {
            var minHabs = bdEstadoEntities.Localidades.Where(l => l.NumHab > 0).Min(l => l.NumHab);

            numMin = minHabs;

            return bdEstadoEntities.Localidades.Where(l => l.NumHab == minHabs).OrderBy(l => l.Provincia.Nombre).ThenBy(l=> l.Nombre).ToList();
        }

        // 2B. CONSULTAS: Método que devuelve las provincias ordenadas de mayor a menor por número de habitantes, y después por nombre.
        public List<Provincia> GetOrderedProvinciasPerHabs()
        {
            var provincias = bdEstadoEntities.Provincias.OrderByDescending(p => p.Localidades.Sum(l => l.NumHab)).ThenBy(p => p.Nombre).ToList();
            return provincias;
        }



        // 3. ABANDONADAS: Método con argumento (idProvincia) que devuelve las localidades DTO abandonadas. Si el argumento está vacío, devuelve las de todo el estado.
        public List<LocalidadDTO> GetAbandonadas(string idProv, out string error)
        {
            error = "";
            if (String.IsNullOrEmpty(idProv) || idProv == "")
            {
                return bdEstadoEntities.Localidades
                    .Where(l => l.NumHab == 0 || l.NumHab == null)
                    .Select(l => new LocalidadDTO
                    {
                        Id = l.Id,
                        Localidad = l.Nombre,
                        IdProv = l.IdProv,
                        Provincia = l.Provincia.Nombre
                    })
                    .ToList();
            }
            var prov = bdEstadoEntities.Provincias.Find(idProv.ToUpper());

            if (prov == null)
            {
                error = $"No existe ninguna provincia con ID {idProv}";
                return null;
            }

            return prov.Localidades.Where(l => l.NumHab == 0 || l.NumHab == null)
                .Select(l => new LocalidadDTO
                {
                    Id = l.Id,
                    Localidad = l.Nombre,
                    IdProv = l.IdProv,
                    Provincia = l.Provincia.Nombre
                })
                .ToList();
        }



        // 4. BORRAR LOCALIDADES DE LA PROVINCIA.
        // Método 1 devuelve localidades por trozo de su nombre
        public List<Localidade> GetLocalidadesPorTrozoNombre(string idProv, string trozoNomb, out string error)
        {
            error = "";
            
            var provincia = bdEstadoEntities.Provincias.SingleOrDefault(p => p.Id == idProv.ToUpper());
            
            if (provincia == null)
            {
                error = $"No existe ninguna provincia con ID {idProv}";
                return null;
            }

            var localidades = provincia.Localidades.Where(l => l.Nombre.ToLower().StartsWith(trozoNomb.ToLower())).ToList();

            if (localidades.Count == 0)
            {
                error = $"No existen localidades que comiencen por {trozoNomb}";
                return null;
            }

            return localidades;
        }
        // método 2 elimina todas las localidades por idProvincia y trozoNombre por el que empieza
        public void DeleteLocalidades(string idProv, string trozoNomb, out string message)
        {
            message = "";

            try
            {
                var provincia = bdEstadoEntities.Provincias.SingleOrDefault(p => p.Id == idProv.ToUpper());
                if (provincia == null)
                {
                    message = $"No existe ninguna provincia con el identificador {idProv}";
                    return;
                }

                var localidadesPorTrozoNombre = provincia.Localidades.Where(l => l.Nombre.ToLower().StartsWith(trozoNomb.ToLower())).ToList();
                if (localidadesPorTrozoNombre.Count() == 0)
                {
                    message = $"{provincia.Nombre} no tiene localidades que comiencen por {trozoNomb}";
                    return;
                }

                //Eliminamos las localidades
                string borradas = "";
                foreach (var loc in localidadesPorTrozoNombre)
                {
                    bdEstadoEntities.Localidades.Remove(loc);
                    borradas += $"{loc.Nombre}, ";
                }

                //Guardamos cambios en la BD
                try
                {
                    int numAfectados = bdEstadoEntities.SaveChanges();
                    message = $"En {provincia.Nombre} se han borrado {numAfectados} localidades que comenzaban por {trozoNomb}: {borradas}";
                } 
                catch (Exception ex) 
                { 
                    Console.WriteLine(ex); 
                }
                return;
            } 
            catch (Exception ex)
            {
                message = $"No se ha podido borrar por {ex.ToString()}";
            }
        }



        // 5. ALTA DE LOCALIDADES. Controlamos errores y guardamos nueva Localidad en la BD
        public void PostLocalidad(string idLocal, string nombLocal, string numHabs, string idProv, out string error)
        {
            error = string.Empty;

            // Validación idLocal
            if (!(int.TryParse(idLocal, out int idLocalINT) && idLocalINT >= 0 && idLocalINT <= 999)) 
            {
                error = "El ID de la localidad a añadir debe ser un número entre 0 y 999";
                return;
            }

            // Validación nombLocal
            if (nombLocal == null || nombLocal.Length == 0 || nombLocal == "")
            {
                error = "El nombre de la localidad a añadir no puede estar vacío";
                return;
            }

            // Validación numHabs
            if (!(int.TryParse(numHabs, out int numHabsINT) && numHabsINT >= 1))
            {
                error = "No se pueden guardar en la BD localidades abandonadas";
                return;
            }

            // Validación existe la Provincia con el ID especificado?
            if (!bdEstadoEntities.Provincias.Any(p => p.Id == idProv.ToUpper()))
            {
                error = $"No existe la provincia con ID {idProv}";
                return;
            }


            // Guardamos la nueva localidad
            Provincia prov = bdEstadoEntities.Provincias.Find(idProv.ToUpper());
            bdEstadoEntities.Localidades.Add(new Localidade(idLocalINT, nombLocal, idProv, numHabsINT, prov));
            try
            {
                int nAfectados = bdEstadoEntities.SaveChanges();
                if (nAfectados > 0)
                {
                    Console.WriteLine("Se ha guardado la localidad correctamente");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        } 

    }
}
