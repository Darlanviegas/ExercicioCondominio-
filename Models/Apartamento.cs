namespace Exercicio_Aluguel.Models
{
    public class Apartamento : Moradia
    {
        private int Andar { get; set; }
        private double ValorCondominio { get; set; }

        public Apartamento(string endereco, int cep, double tamanhoemmetros, int quantidadedebanheiros, int quantidadedequartos, int andar, double valorcondominio):base(endereco, cep, tamanhoemmetros, quantidadedebanheiros, quantidadedequartos)
        {
            Andar = andar;
            ValorCondominio = valorcondominio;
        }

        public double CalcularValorAluguel()
        {
            return (TamanhoEmMetros * 40) + (QuantidadeDeQuartos * 10) + (QuantidadeDeBanheiros * 5) + ValorCondominio;
        }
    }
}