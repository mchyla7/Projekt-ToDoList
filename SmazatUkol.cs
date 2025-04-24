using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Projekt_ToDoList
{
    class SmazatUkol
    {
        private static string cesta = "C:\\Chila\\data.txt";

        public static void Smazat(SeznamUkoluForm.Ukol ukol)
        {
            if (File.Exists(cesta))
            {
                var lines = File.ReadAllLines(cesta).ToList();
                var ukolString = ukol.ToString().Trim();
                int startIndex = -1;

                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i].Trim() == "---")
                    {
                        var taskBlock = string.Join("\n", lines.Skip(i).Take(6)).Trim();
                        if (taskBlock == ukolString)
                        {
                            startIndex = i;
                            break;
                        }
                    }
                }

                if (startIndex != -1)
                {
                    lines.RemoveRange(startIndex, 6); // Odebrat úkol
                    File.WriteAllLines(cesta, lines);
                }
            }
        }
    }
}