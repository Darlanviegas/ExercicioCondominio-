namespace Exercicio_Aluguel.Models
{
    public class Casa:Moradia
    {
        private bool ComQuintal { get; set; }
        public double CalcularValor(double TamanhoEmMetros, int QuantidadeDeQuartos, int QuantidadeDeBanheiros)
        {
            return (TamanhoEmMetros*35)+(QuantidadeDeQuartos*10)+ (QuantidadeDeBanheiros*5);
        }
    }

}