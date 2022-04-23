namespace Exercicio_Aluguel.Models
{
    public class Moradia
    {
        protected string Endereco { get; set; }
        protected int CEP { get; set; }
        protected double TamanhoEmMetros { get; set; }
        protected int QuantidadeDeBanheiros { get; set; }
        protected int QuantidadeDeQuartos { get; set; }
        protected List<Morador> Moradores { get; set; }

        public double CalcularValor()
        {
            return 0;
        }

        public void AdicionarMoradores(List<Morador> Moradores)
        {
            List<Morador> Morador1 = new List<Morador>;

        }
    }
}