namespace caixa;

class   Produto
{
private string? Nome {get; set;}

public double Preco {get; set;}


public void MostraDados(){
    Console.WriteLine("Nome: " + this.Nome);
    Console.WriteLine("preço: " + this.Preco);
}
public void AlteraNome (string nome){
    this.Nome = nome;
}
public void AlteraPreco (double preco){
    this.Preco = preco;
}





}