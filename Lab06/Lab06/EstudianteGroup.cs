using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Lab06
{
    public class EstudianteGroup : List<Estudiante>
    {
        public string Nombre { get; set; }

        public EstudianteGroup(string nombre)
        {
            Nombre = nombre;
        }
    }

}

