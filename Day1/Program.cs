public class Day1
{
    public static void Main()
    {
        var caloriesPerElf = new List<int>();
        string line;
        bool nextElf = false;
        bool read = true;
        int totalElfCalory = 0;
        int top3Total = 0;
        int index = 0;
        Console.WriteLine("Input: ");

        while (read) { 
            line = Console.ReadLine();

            // Program requires 2 new lines to exit (one new line to raise flag, another new line to exit)
            if (line == string.Empty && nextElf)
            {
                read = false;

                // Current elf, more than one entry
            }
            else if (line != string.Empty)
            {
                nextElf = false;
                totalElfCalory += int.Parse(line);
            }
            else
            {
                // Add current elf total to list of totals. Flag to check if it the last elf.
                caloriesPerElf.Add(totalElfCalory);
                totalElfCalory = 0;
                nextElf = true;
            }
        }

        for (int i=0;i<3;i++)
        {
            index = caloriesPerElf.IndexOf(caloriesPerElf.Max());
            top3Total += caloriesPerElf[index];
            caloriesPerElf.RemoveAt(index);
        }

        Console.WriteLine(top3Total);
    }
}