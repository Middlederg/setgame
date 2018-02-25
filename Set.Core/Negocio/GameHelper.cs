using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using Set.Core.Model;

namespace Set.Core.Negocio
{
    public static class GameHelper
    {
        public static IEnumerable<Carta> GetCartas(bool principiante = false) => GetCartasOrdenadas(principiante).ToList().DesordenarLista();

        public static IEnumerable<Carta> GetCartasOrdenadas(bool principiante = false)
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

    //class DistinctItemComparer : IEqualityComparer<List<Carta>>
    //{
    //    public bool Equals(Item x, Item y)
    //    {
    //        return x.Id == y.Id &&
    //            x.Name == y.Name &&
    //            x.Code == y.Code &&
    //            x.Price == y.Price;
    //    }

    //    public bool Equals(IEnumerable<Carta> x, IEnumerable<Carta> y)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public bool Equals(List<Carta> x, List<Carta> y)
    //    {
    //        return x.Id == y.Id &&
    //            x.Name == y.Name &&
    //            x.Code == y.Code &&
    //            x.Price == y.Price;
    //    }

    //    public int GetHashCode(Item obj)
    //    {
    //        return obj.Id.GetHashCode() ^
    //            obj.Name.GetHashCode() ^
    //            obj.Code.GetHashCode() ^
    //            obj.Price.GetHashCode();
    //    }

    //    public int GetHashCode(IEnumerable<Carta> obj)
    //    {
    //        return obj.Sum(x => x.Id()) obj.Id.GetHashCode() ^
    //            obj.Name.GetHashCode() ^
    //            obj.Code.GetHashCode() ^
    //            obj.Price.GetHashCode();
    //    }

    //    public int GetHashCode(List<Carta> obj)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

}