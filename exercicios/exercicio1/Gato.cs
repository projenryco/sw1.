namespace exercicio1;
class Gato:Animal
{

    public string? Nome {get;set;}
     public override string? fala()
  {
    return base.fala() + ("miau");
  }
}

