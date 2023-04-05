namespace aluno_media;
class Aluno
{
    public string nome ="";

    public double nota1,nota2;

    public double Obtermedia(){
        double media = (nota1+nota2)/2;
        return media;

    }

    public string obterSituacao (double media){
        string situacao = "";
        if(media>=6){
            situacao = 'aprovado'
        }
        else{
            situacao = 'reprovado'
        }
        return situacao


    }

}