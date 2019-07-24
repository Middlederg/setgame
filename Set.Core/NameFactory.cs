using System.Collections.Generic;
using System.Linq;

namespace Set.Core.Negocio
{
    public static class NameFactory
    {
        private static readonly string[] Nombres = { "Ricardio", "Vicente", "Emiliano", "Felix",
                                   "Verónica", "Montserrat", "Andrea", "Olga", "Nacho", "Domingo",
                                   "César", "Agustín", "Hugo", "Tomás", "Rafael", "Donatello", "Miguel Angel",
                            "Leonardo", "Nieves", "Isabel", "Irene", "Mar", "Alicia", "Carla", "Eva",
                            "Lidia", "Aurora", "Celia", "Claudia", "Amparo", "Sebastián", "Samuel", "Mauricio Saurio", "Jesucristo" };

        public static string GetRandomName() => Nombres.GetRandomItem();

        public static string GetRandomName(IEnumerable<string> usedNames)
        {
            string nombre;
            if (usedNames == null)
                return GetRandomName();
            do
            {
                nombre = GetRandomName();
            }
            while (usedNames.Contains(nombre));
            return nombre;
        }
    }
}