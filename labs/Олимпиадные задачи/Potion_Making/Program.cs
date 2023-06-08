namespace PotionMaking
{
    internal class Program
    {
        static void Main()
        {
            var actions = new List<string>();
            using (var sr = new StreamReader("input.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    actions.Add(line);
                }
            }

            var ingr = new List<List<string>>();
            foreach (var action in actions)
            {
                var parts = action.Split();
                ingr.Add(parts.Skip(1).ToList());
            }

            var spell = "";
            var cast = new List<string>();
            var potion = new List<string>();

            for (var i = 0; i < actions.Count; i++)
            {
                var parts = actions[i].Split();
                for (var j = 0; j < ingr[i].Count; j++)
                {
                    if (int.TryParse(ingr[i][j], out int castInd))
                    {
                        if (potion.Count < castInd)
                        {
                            potion.RemoveAt(castInd - 1);
                        }
                        ingr[i][j] = cast[castInd - 1];
                    }
                }

                if (parts[0] == "MIX")
                {
                    spell += "MX" + string.Join("", ingr[i]) + "XM";
                }
                else if (parts[0] == "WATER")
                {
                    spell += "WT" + string.Join("", ingr[i]) + "TW";
                }
                else if (parts[0] == "DUST")
                {
                    spell += "DT" + string.Join("", ingr[i]) + "TD";
                }
                else if (parts[0] == "FIRE")
                {
                    spell += "FR" + string.Join("", ingr[i]) + "RF";
                }

                cast.Add(spell);
                potion.Add(spell);
                spell = "";
            }

            Console.WriteLine(potion[potion.Count - 1]);

            using (StreamReader sr = new StreamReader("output.txt"))
            {
                string answer = sr.ReadToEnd();
                if (potion[potion.Count - 1] == answer)
                {
                    Console.WriteLine("Успешно");
                }
            }

            Console.ReadKey();

        }
    }
}