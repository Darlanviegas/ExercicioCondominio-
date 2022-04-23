namespace Exercicio_Aluguel.Models
{
    public class Kitnet : Moradia
    {
        public Kitnet(string endereco, int cep, double tamanhoMetros, int quantidadeBanheiros, int quantidadeQuartos, bool comQuintal) : base(endereco, cep, tamanhoMetros, quantidadeBanheiros, quantidadeQuartos)
        {
            
        }
        public override double CalcularValorAluguel()
        {
            return TamanhoEmMetros*30;
        }
    }
}