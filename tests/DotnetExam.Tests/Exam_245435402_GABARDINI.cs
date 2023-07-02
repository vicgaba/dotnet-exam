using DotnetExam.Entities;
using System.Collections.Generic;
using Xunit;

namespace DotnetExam.Tests
{
    public class Exam_24435402_GABARDINI
    {
        [Fact]
        public void Test1_Teoria_NET()
        {

            //Describa la diferencia entre .NET Framework y .NET Core
            var respuesta = "La principal diferencia radica en que .NET Core es multiplataforma" +
                "o sea que puede ejecutarse no solo en Windows sino también en Linux y Mac";

            Assert.NotEqual(string.Empty, respuesta);


        }

        [Fact]
        public void Test2_Teoria_Assembly()
        {


            //Describa que es un assembly o ensamblado en .NET
            var respuesta = "Los ensamblados son archivos .exe o .dll que continen el código y los" +
                "recursos de una aplicación. Es como una biblioteca de código que se puede utilizar " +
                "en diferentes aplicaciones ";

            Assert.NotEqual(string.Empty, respuesta);


        }


        [Fact]
        public void Test3_Teoria_IL()
        {


            //Describa que es el Lenguaje Intermedio o IL
            var respuesta = "Es un formato de código compacto que se puede admitir en cualquier " +
                "sistema operativo o arquitectura. Es el lenguaje en el que se compilan los " +
                "lenguajes de alto nivel como C#.";

            Assert.NotEqual(string.Empty, respuesta);


        }




        [Fact]
        public void Test4_DateTime_Formatting()
        {
           

            var finalWorldCupMatch = new DateTime(2022, 12, 18, 15, 30, 23);


            Assert.Equal("18/12/22 15:30:23", finalWorldCupMatch.ToString("dd/MM/yy HH:mm:ss"));
            Assert.Equal("18/12/22 03:30 p", finalWorldCupMatch.ToString("dd/MM/yy hh:mm t"));
            Assert.Equal("18 de diciembre de 2022", finalWorldCupMatch.ToString("dd") + " de " + finalWorldCupMatch.ToString("MMMM") + " de " + finalWorldCupMatch.ToString("yyyy"));


        }

        [Fact]
        public void Test5_DateTime_Days()
        {


            var finalWorldCupMatch = new DateTime(2022, 12, 18, 15, 30, 23);
            var today = new DateTime(2023, 5, 9, 15, 00, 00);

            var result = today.Subtract(finalWorldCupMatch);

            Assert.Equal("141 Días totales desde la final del mundo", $"{result.Days} Días totales " +
                $"desde la final del mundo");

        }



        [Fact]
        public void Test6_POO_Alumno()
        {
            var alumno = new Alumno();
            alumno.AlumnoId = 123456;
            alumno.Legajo = "000010/22";
            alumno.Nombre = "Lionel";
            alumno.Apellido = "Messi";
            
            Assert.Equal(123456, alumno.AlumnoId);
            Assert.Equal("000010/22", alumno.Legajo);
            Assert.Equal("Lionel Messi", alumno.NombreCompleto);
        }



        [Fact]
        public void Test6_POO_Materia()
        {
            var materia = new Materia();
            materia.Nombre = "Programacion III";
            materia.MateriaId = 123456;

            Assert.Equal("Programacion III", materia.Nombre);
            Assert.Equal(123456, materia.MateriaId);

        }

        [Fact]
        public void Test8_POO_UML()
        {
            //En base al diagrama UML del examen
            //Codifique las clases e interfaces necesarias

            var docente = new Docente(1, "Lionel", "Scaloni", 1, 1);

            var alumno1 = new Alumno(101010, "Lionel", "Messi", 101010, "101010");

            var alumno2 = new Alumno(777, "Rodrigo", "De Paul", 777, "000007/22");

            var materia = new Materia();
            materia.MateriaId = 123456;
            materia.Nombre = "Programacion III";

            materia.Alumnos.Add(alumno1);
            materia.Alumnos.Add(alumno2);



            Assert.Equal("Programacion III", materia.Nombre);
            Assert.Equal(123456, materia.MateriaId);

            Assert.Equal(1, materia.Profesor.Id);
            Assert.Equal(1, materia.Profesor.DocenteId);
            Assert.Equal("Lionel", materia.Profesor.Nombre);
            Assert.Equal("Scaloni", materia.Profesor.Apellido);

            Assert.Equal(101010, materia.Alumnos.First().Id);
            Assert.Equal("101010", materia.Alumnos.First().Legajo);
            Assert.Equal(101010, materia.Alumnos.First().AlumnoId);
            Assert.Equal("Lionel", materia.Alumnos.First().Nombre);
            Assert.Equal("Messi", materia.Alumnos.First().Apellido);

            Assert.Equal(777, materia.Alumnos.Last().Id);
            Assert.Equal(777, materia.Alumnos.Last().AlumnoId);
            Assert.Equal("000007/22", materia.Alumnos.Last().Legajo);
            Assert.Equal("Rodrigo", materia.Alumnos.Last().Nombre);
            Assert.Equal("De Paul", materia.Alumnos.Last().Apellido);

        }

        [Fact]
        public void Test9_Collection_GetCountFirtLast()
        {
            //Utilice la coleccion del trabajo practico que presento
            //Para poder con el generador completar dicha coleccion
            //y buscar las primeras materias y primeros y ultimos alumnos
            var materias = new List<Materia>();

            
            
            materias.AddRange(MateriaGenerador.Generar(10000, 1000));

            Assert.Equal(10000, materias.Count);

            Assert.Equal(1000, materias.First().Alumnos.Count);
            Assert.Equal("M1-000001/23", materias.First().Alumnos.First().Legajo);
            Assert.Equal("M1-001000/23", materias.First().Alumnos.Last().Legajo);

            Assert.Equal(1000, materias.Last().Alumnos.Count);
            Assert.Equal("M10000-000001/23", materias.Last().Alumnos.First().Legajo);
            Assert.Equal("M10000-001000/23", materias.Last().Alumnos.Last().Legajo);

        }


        [Fact]
        public void Test10_Linq_BuscarLegajo()
        {
            //Busque los alumnos en las materias que contengan el legajo 000999
            //Utilice la coleccion del trabajo practico que presento
            //var materias = new List<Materia>();
            var materias = new List<Materia>();
            
            materias.AddRange(MateriaGenerador.Generar(1000, 10000));

            var miDiccionario = new Dictionary<int, List<Materia>>();
            
            miDiccionario.Add(1, materias);

//            materias.AddRange(MateriaGenerador.Generar(1000, 10000));

            //Ayuda: where a.Legajo.Contains("000999/23")
           var query = (from diccionario in miDiccionario.Values
                        from materia in diccionario
                        from alumno in materia.Alumnos  
                        where alumno.Legajo.Contains("000999/23")
                        select alumno).Count();
//                         where materia.Alumnos.Legajo.Contains("000999/23")
  //                       select materias).Count();
            Assert.Equal(1000, query);

        }

    }
}