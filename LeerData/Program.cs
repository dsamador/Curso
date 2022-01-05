using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace leerdata
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppVentaCursosContext()){

                /* El metodo AsNoTracking permite no guardar en memoria el IQeryable que es devuelto,
                    el IQueryable es un arreglo de la consulta a base de datos
                 */
                var cursos = db.Curso.AsNoTracking();
                foreach (var curso in cursos){
                    Console.WriteLine(curso.Titulo + "----" + curso.Descripcion);
                }
            }
        }
    }
}
