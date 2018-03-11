using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using Set.Core.Enums;
using Set.Core.Model;
using Set.Core.Negocio;

namespace Set.Core.Negocio
{
    public static class GameHelper
    {
        /// <summary>
        /// Obtiene lista de cartas con las que comienza la partida
        /// </summary>
        /// <param name="tutorial">En el nivel tutorial solo se juega con las cartas con relleno</param>
        /// <returns></returns>
        public static IEnumerable<Carta> GetCartas(bool tutorial = false) => GetCartasOrdenadas(tutorial).ToList().DesordenarLista();

        private static IEnumerable<Carta> GetCartasOrdenadas(bool principiante = false)
        {
            foreach (int numero in Enumerable.Range(1, 3))
                foreach (int color in Enumerable.Range(0, 3))
                    foreach (int forma in Enumerable.Range(0, 3))
                    {
                        if (principiante)
                            yield return new Carta(numero, (Color)color, (Shape) forma);
                        else
                        {
                            foreach (int relleno in Enumerable.Range(0, 3))
                                yield return new Carta(numero, (Color)color, (Shape)forma, (Shading) relleno);
                        }
                    }
        }

        private static string[] nombres = { "Ricardio", "Vicente", "Emiliano", "Felix",
                                   "Verónica", "Montserrat", "Andrea", "Olga", "Nacho", "Domingo",
                                   "César", "Agustín", "Hugo", "Tomás", "Rafael", "Donatello", "Miguel Angel",
                            "Leonardo", "Nieves", "Isabel", "Irene", "Mar", "Alicia", "Carla", "Eva",
                            "Lidia", "Aurora", "Celia", "Claudia", "Amparo", "Sebastián", "Samuel", "Mauricio Saurio", "Jesucristo" };

        /// <summary>
        /// Devuelve un nombre al azar
        /// </summary>
        /// <returns></returns>
        public static string NombreAleatorio() => General.ElementoAleatorio(nombres);

        /// <summary>
        /// Devuelve un nombre aleatorio que no este entre los nombres usados
        /// </summary>
        /// <param name="nombresUsuados"></param>
        /// <returns></returns>
        public static string NombreAleatorio(List<string> nombresUsuados)
        {
            string nombre;
            if (nombresUsuados == null)
                return NombreAleatorio();
            do
            {
                nombre = General.ElementoAleatorio(nombres);
            }
            while (nombresUsuados.Contains(nombre));
            return nombre;
        }

        /// <summary>
        /// Determina si un trío de cartas forma un set
        /// </summary>
        /// <param name="cartas"></param>
        /// <returns></returns>
        public static bool EsSet(this List<Carta> cartas)
        {
            if (cartas == null || cartas.Count != 3) throw new ArgumentNullException("deben pasarse 3 cartas como parámetro");

            if (!cartas.AsQueryable().Comun(x => x.Numero))
                if (!cartas.AsQueryable().Diferente(x => x.Numero))
                    return false;

            if (!cartas.AsQueryable().Comun(x => x.ColorCarta))
                if (!cartas.AsQueryable().Diferente(x => x.ColorCarta))
                    return false;

            if (!cartas.AsQueryable().Comun(x => x.Forma))
                if (!cartas.AsQueryable().Diferente(x => x.Forma))
                    return false;

            if (!cartas.AsQueryable().Comun(x => x.Interior))
                if (!cartas.AsQueryable().Diferente(x => x.Interior))
                    return false;

            return true;
        }

        /// <summary>
        /// Devuelve si las tres cartas tienen esa propiedad igual
        /// </summary>
        /// <typeparam name="T">tipo de la propiedad (se puede inferir)</typeparam>
        /// <param name="cartas">lista de tres cartas</param>
        /// <param name="conditionLambda">select</param>
        /// <returns></returns>
        public static bool Comun<T>(this IQueryable<Carta> cartas, Expression<Func<Carta, T>> conditionLambda)
            => cartas.Select(conditionLambda).Distinct().Count() == 1;

        /// <summary>
        /// Devuelve si las tres cartas tienen esa propiedad distinta
        /// </summary>
        /// <typeparam name="T">tipo de la propiedad (se puede inferir)</typeparam>
        /// <param name="cartas">lista de tres cartas</param>
        /// <param name="conditionLambda">select</param>
        /// <returns></returns>
        public static bool Diferente<T>(this IQueryable<Carta> cartas, Expression<Func<Carta, T>> conditionLambda)
            => cartas.Select(conditionLambda).Distinct().Count() == cartas.Count();


        #region Ficheros

        /// <summary>
        /// Lee el fichero de mejores puntuaciones. 
        /// Si no existiera devuelve lista vacía
        /// </summary>
        /// <returns></returns>
        public static List<Record> LeerBestScores()
        {
            string ruta = Properties.Resources.BestScorePath;

            try
            {
                FileStream fs = new FileStream(ruta, FileMode.Open);
                BinaryFormatter binForm = new BinaryFormatter();
                List<Record> lista = (List<Record>)binForm.Deserialize(fs);
                fs.Close();
                return lista;
            }
            catch (FileNotFoundException)
            {
                return new List<Record>();
            }
        }

        /// <summary>
        /// Lee el fichero de puntuaciones y guarda la nueva puntuación
        /// </summary>
        /// <param name="score"></param>
        public static void GuardarPuntuacion(Record score)
        {
            var scores = LeerBestScores();
            scores.Add(score);
            FileStream fs = new FileStream(Properties.Resources.BestScorePath, FileMode.Create);
            BinaryFormatter binForm = new BinaryFormatter();
            binForm.Serialize(fs, scores);
            fs.Close();
        }

        #endregion


    }
}