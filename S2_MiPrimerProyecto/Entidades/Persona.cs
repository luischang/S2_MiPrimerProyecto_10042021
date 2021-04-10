using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_MiPrimerProyecto.Entidades
{
    public class Persona
    {
        public string dni { get; set; }

        public string nombreCompleto { get; set; }

        public int telefono { get; set; }

        public Persona()
        { 
        
        }

        public Persona(string dni, string nombreCompleto, int telefono)
        {
            this.dni = dni;
            this.nombreCompleto = nombreCompleto;
            this.telefono = telefono;
        }



    }
}
