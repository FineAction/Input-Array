class Program
{

    public static void Main(string[] args)
    {
        string Consoleinput;
        string input0;
        string input1;

        Console.WriteLine ("Specify Parameters ( this will Parameter[0] )");
        Consoleinput = Console.ReadLine(); input0 = Consoleinput;
        Console.WriteLine ($"Parameter[1]: {input0} "); Console.Clear();

        Console.WriteLine ("Please enter Parameter[1]");
        Consoleinput = Console.ReadLine(); input1 = Consoleinput;
        Console.WriteLine ($"Parameter[2]: {input1} "); Console.Clear();

        string[] Parameters = { input0, input1 };
        Console.WriteLine($"Parameter Array built. P1 {Parameters[0]} : P2 {Parameters[1]} ");
    }
}