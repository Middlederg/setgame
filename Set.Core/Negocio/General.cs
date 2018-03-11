using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Reflection;
using System.ComponentModel;

namespace Set.Core.Negocio
{
    public static class General
    {
        private static Random r = new Random(DateTime.Now.Millisecond);

        /// <summary>
        /// Numero aleatorio entre dos números, incluidos ambos
        /// </summary>
        /// <param name="inf">Número inferior</param>
        /// <param name="sup">Número superior</param>
        /// <returns></returns>
        public static int NumAleatorio(int inf, int sup) => r.Next(inf, sup + 1);

        /// <summary>
        /// Devuelve elemento al azar de una lista
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static T ElementoAleatorio<T>(IEnumerable<T> lista)
        {
            if (lista == null || !lista.Any()) return default(T);
            return lista.ElementAt(NumAleatorio(0, lista.Count() - 1));
        }

        /// <summary>
        /// Obtiene una imagen guardada como recurso en el proyecto
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static Image ObtenerRecurso(string nombre) => (Image)Properties.Resources.ResourceManager.GetObject(nombre);

        /// <summary>
        /// Desordena al azar una lista de elementos
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static IEnumerable<T> DesordenarLista<T>(this List<T> lista)
        {
            List<T> mazoAuxiliar = new List<T>();

            int pasadas = lista.Count();
            for (int i = 0; i < pasadas; i++)
            {
                int pos = r.Next(0, lista.Count);
                T o = lista[pos];
                mazoAuxiliar.Add(o);
                lista.Remove(o);
            }
            return mazoAuxiliar;
        }

        /// <summary>
        /// Obtiene la descricpción aplicada como atributo a una enumeración
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Descripcion(this Enum value)
        {
            Type type = value.GetType();
            DescriptionAttribute atributo = Attribute.GetCustomAttribute(type.GetField(Enum.GetName(type, value)),
                               typeof(DescriptionAttribute)) as DescriptionAttribute;
            return atributo?.Description ?? value.ToString();
        }

        /// <summary>
        /// Devuelve lista T de posibles valores de una enumeración
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<T> GetEnumList<T>() => new List<T>((T[])Enum.GetValues(typeof(T)));

        /// <summary>
        /// Devuelve lista strings de posibles valores de una enumeración
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<string> GetEnumListString<T>() => GetEnumList<T>().Select(x => x.ToString());

        /// <summary>
        /// Quita acentos y pone en minusculas
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Simplificar(this string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return string.Empty;
            return value.Trim().ToLowerInvariant()
                .Replace("á", "a")
                .Replace("é", "e")
                .Replace("í", "i")
                .Replace("ó", "o")
                .Replace("ú", "u");
        }
    }
}