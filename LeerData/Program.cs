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
                var cursos = db.Curso.Include(p => p.PrecioPromocion).AsNoTracking();

                foreach (var curso in cursos){
                    Console.WriteLine($"Curso: {curso.Titulo} -- Precio: {curso.PrecioPromocion.PrecioActual}");
                }


                System.Console.WriteLine("\n");


                var cursos2 = db.Curso.Include(c => c.ComentarioLista).AsNoTracking();

                foreach (var curso in cursos2){
                    System.Console.WriteLine(curso.Titulo);
                    foreach (var comentario in curso.ComentarioLista)
                    {
                        System.Console.WriteLine($"*********** {comentario.Alumno} dice: {comentario.ComentarioTexto}");
                    }
                }
                
            }
        }
    }
}
