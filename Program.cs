Program.Main();
public static partial class Program{

    static List<int>[] sticks = new List<int>[] {
    new List<int>(),
    new List<int>(),
    new List<int>()
    };
    static int pucksCount;
    static void Main()
    {
        AddPucks();
        //while (true)
        {
            Write();
            GetValue();
        }
    }
    static void Write()
    {
        Clear();
        Console.SetCursorPosition(0, 0);
        for (int i = 0; i < sticks.Length; i++)
        {
            for (int j = 0; j < sticks[i].Count; j++)
            {
                Console.Write(sticks[i][j]);
            }
            Console.WriteLine();
        }
    }
    static void Clear()
    {
        for (int j = 0; j < sticks.Length + 2; j++)
        {
            Console.SetCursorPosition(0, j);
            for (int i = 0; i < pucksCount; i++)
            {
                Console.Write(" ");
            }
        }
    }
    static void GetValue()
    {
        string firstText;
        firstText = Console.ReadLine();
        Console.Write(firstText);
        if () {}
    }
    static void Replace(int from, int to)
    {
        if (from >= 0 && from <= 2 && to >= 0 && to <= 2)
        {
            if (sticks[from][sticks[from].Count - 1] < sticks[to][sticks[to].Count() - 1])
            {
                sticks[to].Add(sticks[from][sticks[from].Count - 1]);
                sticks[from].Remove(sticks[from].Count - 1);
            }
        }
    }
    static void AddPucks()
    {
        pucksCount = int.Parse(Console.ReadLine());
        Clear();

        for (int i = pucksCount; i > 0; i--)
        {
            sticks[0].Add(i);

        }
    }
}