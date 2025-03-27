using System;
using System.IO;

namespace Projekt_ToDoList
{
    class UlozitUkol
    {
        public static bool UlozeniUkolu(string nazev, string podrobnosti, decimal datum, bool splneno, decimal datumPridani)
        {
            string cesta = "C:\\Chila\\data.txt";
            string data = "---\n" +
                          $"Název: \"{nazev}\"\n" +
                          $"Podrobnosti: \"{podrobnosti}\"\n" +
                          $"Datum: \"{DateTime.FromOADate((double)datum).ToString("dd.MM.yyyy")}\"\n" +
                          $"JeSplneno: \"{splneno}\"\n" +
                          $"Datum Přidání: \"{DateTime.FromOADate((double)datumPridani).ToString("dd.MM.yyyy")}\"\n";

            File.AppendAllText(cesta, data);
            return true;
        }
    }
}
