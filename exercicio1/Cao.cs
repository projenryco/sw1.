namespace exercicio1;
class Cao:Animal
{

    public string? Nome {get;set;}
    
     public override string? fala()
     {
        return base.fala()+ "au au";
     }
}
