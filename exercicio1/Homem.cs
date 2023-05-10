namespace exercicio1;
class Homem:Animal
{

    public string? Nome {get;set;}

     public override string? fala()
  {
    return base.fala()+"oii";
  }
}
