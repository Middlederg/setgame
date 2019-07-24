using System;
using System.Collections.Generic;
using System.Drawing;

namespace Set.Core.Negocio
{
    public static class Util
    {
        /// <summary>
        /// Obtiene una imagen guardada como recurso en el proyecto
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static Image ObtenerRecurso(string nombre) => (Image)Properties.Resources.ResourceManager.GetObject(nombre);        

        public static List<T> GetEnumList<T>() => new List<T>((T[])Enum.GetValues(typeof(T)));

        /// <summary>
        /// Quita acentos y pone en minusculas
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Simplify(this string value)
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