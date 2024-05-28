namespace Egyszamjatek
{
    internal partial class Program
    {
        public class Versenyzo
        {
            public string Nev { get; set; }
            public List<int> Tippek { get; set; }

            public Versenyzo(string sor)
            {
                var x = sor.Split(" ");
                Nev = x[0];
                Tippek = new List<int>();
                for (int i = 1; i < x.Length; i++)
                {
                    Tippek.Add(int.Parse(x[i]));
                }
            }

            public override string ToString()
            {
                return $"{Nev}, {string.Join(";", Tippek)}";
            }
        }
    }
}
