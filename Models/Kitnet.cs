namespace Exercicio_Aluguel.Models
{
    public class Kitnet : Moradia
    {
        public double CalcularValor(double TamanhoEmMetros)
        {
            return TamanhoEmMetros*30;
        }
    }
}