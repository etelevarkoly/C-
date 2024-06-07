namespace sztringek 
{
    class Program 
    {
        static void Main(string[] args)
        {
            string firstName = "Mosh";
            // var firstName = "Mosh";
            var lastName = "Varkoly";
            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("{0} {1}", firstName, lastName);
            System.Console.WriteLine(myFullName);

            var names = new string[3] {"asd1", "asd2", "asd3"};
            var formattedNames = string.Join(";", names);
            System.Console.WriteLine(formattedNames);

            // verbatim strings:
            var text = "hi josh\nujsorbaIromEzt\nEztIsUjSorbaIrom\nc:\\folder1\\folder2"
            var budgetText = @"hi josh
            ujsorbaIromEzt
            EztIsUjSorbaIrom
            c:\folder1\folder2"

            /*
            ezek full ugyanazok lesznek, mivel a 
            "string" mappelve van a .NET frameworkben a 
            "String" classra.

            String asd = "asd";
            string asd = "asd";

            vagy az "int" az "Int32" .NET classra:
            int i;
            Int j;

            */

        }
    }
}