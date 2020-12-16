using C = System.Console;

namespace DZ6
{
    class Program
    {
        static void Main()
        {
            C.WriteLine("Богатый Анатолий var2\n---------------------------------------------------------\n\n");
            try
            {
                Yuan yuan10 = new Yuan(10);
                Yuan yuan_10 = new Yuan(10);
                Yuan yuan20 = new Yuan(20);

                Euro euro10 = new Euro(10);
                Euro euro_10 = new Euro(10);
                Euro euro20 = new Euro(20);

                Dollar dollar10 = new Dollar(10);
                Dollar dollar_10 = new Dollar(10);
                Dollar dollar20 = new Dollar(20);

                C.WriteLine(Dollar.ToList());

                C.WriteLine($"dollar10 == dollar20?\t{dollar10 == dollar20}");
                C.WriteLine($"dollar10 == dollar_10?\t{dollar10 == dollar_10}\n\n");

                Dollar.Destroy(ref dollar_10);
                Dollar.ToRubExchangeRate = 70;
                C.WriteLine(dollar_10?.ToString());
                C.WriteLine(Dollar.ToList());

                C.WriteLine(Euro.ToList());
                C.WriteLine(Yuan.ToList());

                C.ReadKey();
            }
            catch (System.Exception e)
            {
                C.WriteLine(e.Message);
            }
        }
    }
}
