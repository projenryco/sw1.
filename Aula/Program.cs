namespace Aula;
class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("Hello, World!");
       // Console.ReadKey();


       //instanciar um objeto a partir de uma classe

       Exemplo exe01 = new Exemplo();

       exe01.mostramsg();

       exe01.mostranome("ryco");

       Console.WriteLine(exe01.msg());

       Console.WriteLine("a soma é: " + exe01.somar( +10,4));
    }
}
