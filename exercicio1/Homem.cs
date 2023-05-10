namespace heranca_polimorfismo;
class Homem:Animal
{

    public string? Nome {get;set;}

     public override string? fala()
  {
    return base.fala()+"oii";
  }
}
