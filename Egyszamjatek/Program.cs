namespace Egyszamjatek
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var versenyzok = new List<Versenyzo>();

            foreach (var item in File.ReadAllLines(@"..\..\..\src\egyszamjatek1.txt"))
            {
                versenyzok.Add(new(item));
            };

            Console.WriteLine($"3. feladat: Játékosok száma: {versenyzok.Count} fő");


            Console.Write("4. feladat: Kérem a forduló sorszámát: ");
            int sorszam = int.Parse(Console.ReadLine()) - 1;

            double atlag = versenyzok.Average(v => v.Tippek[sorszam]);

            Console.WriteLine($"5. feladat: A megadott forduló tippjeinek átlaga: {Math.Round(atlag, 2)}");

            Console.ReadKey();
        }
    }
}