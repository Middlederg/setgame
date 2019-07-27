using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Set.Core
{
    public static class Files
    {
        /// <summary>
        /// Lee el fichero de mejores puntuaciones. 
        /// Si no existiera devuelve lista vacía
        /// </summary>
        /// <returns></returns>
        public static List<Score> LeerBestScores()
        {
            string ruta = Properties.Resources.BestScorePath;

            try
            {
                FileStream fs = new FileStream(ruta, FileMode.Open);
                BinaryFormatter binForm = new BinaryFormatter();
                List<Score> lista = (List<Score>)binForm.Deserialize(fs);
                fs.Close();
                return lista;
            }
            catch (Exception)
            {
                return new List<Score>();
            }
        }

        /// <summary>
        /// Lee el fichero de puntuaciones y guarda la nueva puntuación
        /// </summary>
        /// <param name="score"></param>
        public static void GuardarPuntuacion(Score score)
        {
            var scores = LeerBestScores();
            scores.Add(score);
            FileStream fs = new FileStream(Properties.Resources.BestScorePath, FileMode.Create);
            BinaryFormatter binForm = new BinaryFormatter();
            binForm.Serialize(fs, scores);
            fs.Close();
        }

    }
}