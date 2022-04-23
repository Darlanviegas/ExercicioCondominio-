namespace Exercicio_Aluguel.Models
{
    public class Apartamento:Moradia
    {
        private int Andar { get; set; }
        private double ValorAluguel { get; set; }

        public double CalcularValor(double TamanhoEmMetros, int QuantidadeDeQuartos, int QuantidadeDeBanheiros, double ValorAluguel)
        {
            return (TamanhoEmMetros*40)+(QuantidadeDeQuartos*10)+(QuantidadeDeBanheiros*5)+ValorAluguel;
        }
    }
}