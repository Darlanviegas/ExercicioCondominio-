namespace Exercicio_Aluguel.Models
{
    public class Casa : Moradia
    {
        private bool ComQuintal { get; set; }
        public Casa(string endereco, int cep, double tamanhoMetros, int quantidadeBanheiros, int quantidadeQuartos, bool comQuintal) : base(endereco, cep, tamanhoMetros, quantidadeBanheiros, quantidadeQuartos)
        {
            ComQuintal = comQuintal;
        }
        public override double CalcularValorAluguel()
        {   
            double valorAluguel = (TamanhoEmMetros * 35) + (QuantidadeDeQuartos * 10) + (QuantidadeDeBanheiros * 5);
            if(ComQuintal == true){
                valorAluguel = valorAluguel*1.1;
            }
            return valorAluguel;
        }
    }

}