namespace ArrrayTombokGec 
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[5] { 1, 2, 3, 4, 5 };
            // var szamok = new int[5] { 1, 2, 3, 4, 5 };

            var flags = new bool[3];
            flags[0] = true;
            System.Console.WriteLine(flags[1]);

            // ha OBJECT INITIALIZATION SYNTAX-szal adok 
            // értékeket a tömbömnek, akkor MUSZÁJ pont 
            // annyit adnom, amennyi tagja van.
            // erre hibát dob:
            var nevek = new string[3] { "sanyi", "pisti"};

            // erre már nem:
            var nevek = new string[3] { "sanyi", "pisti", "etele"};
            System.Console.WriteLine(nevek[0]);
            System.Console.WriteLine(nevek[1]);
            System.Console.WriteLine(nevek[2]);
        }
    }
}