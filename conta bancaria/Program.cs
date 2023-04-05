namespace conta_bancaria;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("exercicio conta bancaria");
        Conta conta = new Conta();
        conta.nomeCliente = "enryco";
        conta.limite = 500;

        conta.depositar(200);
        conta.sacar(50);
        double saldo = conta.ConsultaSaldo();

        Console.WriteLine("seu saldo é de: " + saldo);
    }
}
