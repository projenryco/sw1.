namespace metodo_construtor;

class   Produto
{
public Produto(){
        this.Nome = "tico";
        this.Preco = 50;
    }

public Produto(string nome){
        this.Nome = nome;
        this.Preco = 40;
    }
public Produto(string nome, double desconto){
        this.Nome = "tico";
        this.Preco = 10*(1-(desconto/100));
    }

private string? Nome {get; set;}

private double Preco {get; set;}

private void cadastroNome(string nome){
    this.Nome = nome;
}

private void cadastroPreco(double preco){
    this.Preco = preco;
}


public void MostraDados(){
    Console.WriteLine("Nome: " + this.Nome);
    Console.WriteLine("preço: " + this.Preco);
}
}




