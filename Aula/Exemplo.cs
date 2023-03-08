namespace Aula;
class Exemplo
{
   //atributos

   public string nome = "";
   public int idade = 0;
   public bool vacinado = false;


   //metodos

   public void mostramsg(){
    Console.WriteLine("oi 2F!");
   }

   public void mostranome(string texto){
    Console.WriteLine("oi "+ texto );

   }

   public string msg(){
    return "olá tudo bemmm?";
   }

   public int somar(int a,int b){
    return a+b;
   }
}
