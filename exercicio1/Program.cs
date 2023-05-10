namespace exercicio1;
class Program
{
    static void Main(string[] args)
    {
        Cao marley = new Cao();
        Gato troxa = new Gato();
        Homem ryco = new Homem();


        Console.WriteLine("Chamei o gato e ele: " + troxa.fala());
        Console.WriteLine("Chamei o cão e ele: " + marley.fala());
        Console.WriteLine("Chamei o homem e ele: " + ryco.fala());
    }
}
