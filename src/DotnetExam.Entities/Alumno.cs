namespace DotnetExam.Entities
{
    public class Alumno : Persona
    {
        public int AlumnoId { get; set; }
        public string Legajo { get; set; }
        
        public Alumno()
        {

        }
        public Alumno(int Id, string Nombre, string Apellido, int AlumnoID, string Legajo)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.AlumnoId = AlumnoID;
            this.Legajo = Legajo;
        }
    }
}