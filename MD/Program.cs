

class Matematika
{
    static void Main(string[] args)
    {
        // Paprasa lietotāja ievadi A mainīgajam

        Console.WriteLine("Ievadiet A mainīgo:");
        double A = double.Parse(Console.ReadLine());

        // Paprasa lietotāja ievadi B mainīgajam

        Console.WriteLine("Ievadiet B mainīgo:");
        double B = double.Parse(Console.ReadLine());

        // Izprintē abus mainīgos

        Console.WriteLine("Skaitlis A = " + A);
        Console.WriteLine("Skaitlis B = " + B);

        // Tiek veikta reizināšana ar abiem mainīgajiem

        double rezultats = A * B;
        string reizinashana = $"{A}*{B}= {rezultats}";

        // Izprintē reizināšanas rezultātu 

        Console.WriteLine("Operācijas reizināt darbība:  " + reizinashana);

        // Tiek veikta atņemšanas darbība ar abiem mainīgajiem

        double rezultats2 = A - B;
        string atnemshana = $"{A}-{B}= {rezultats2}";

        // Izprintē atņemšanas rezultātu

        Console.WriteLine("Operācijas atņemt darbība:  " + atnemshana);

        // Tiek veikta saskaitīšanas darbība ar abiem mainīgajiem

        double rezultats3 = A + B;
        string saskaitishana = $"{A}+{B}= {rezultats3}";

        // Izprintē saskaitīšanas darbība ar abiem mainīgajiem

        Console.WriteLine("Operācijas summa darbība: " + saskaitishana);

        // Tiek veikta dalīšanas darbība ar abiem mainīgajiem 

        double rezultats4 = A / B;
        string dalishana = $"{A}/{B}= {rezultats4}";

        Console.WriteLine("Operācijas dalīt darbība: " +  dalishana);
    }




    









}