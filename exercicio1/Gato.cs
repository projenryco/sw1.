namespace heranca_polimorfismo;
class Gato:Animal
{

    public string? Nome {get;set;}
     public override string? fala()
  {
    return base.fala ("miau");
  }
}
}