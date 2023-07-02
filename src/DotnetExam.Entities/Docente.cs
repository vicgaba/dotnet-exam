using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DotnetExam.Entities
{
    public class Docente : Persona
    {
        public int DocenteId { get; set; }
        public int Antiguedad { get; set; }

        public Docente(int Id, string nombre, string apellido, int DocenteID, int Antiguedad)
        {
            this.Id = Id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DocenteId = DocenteID;
            this.Antiguedad = Antiguedad;

        }
    }       
}
