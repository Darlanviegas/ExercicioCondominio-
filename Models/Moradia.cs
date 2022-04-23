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

        public Moradia(string endereco, int cep, double tamanhoemmetros, int quantidadedebanheiros, int quantidadedequartos)
        {
            Endereco = endereco;
            CEP = cep;
            TamanhoEmMetros = tamanhoemmetros;
            QuantidadeDeBanheiros = quantidadedebanheiros;
            QuantidadeDeQuartos = quantidadedequartos;
            Moradores = new List<Morador>();
        }

        public virtual double CalcularValorAluguel()
        {
            return 0;
        }

        public void AdicionarMorador(Morador morador)
        {
            Moradores.Add(morador);
        }
        public void RemoverMorador(string cpf)
        {
            Moradores.RemoveAll(morador => morador.GetCPF() == cpf);
        }
    }
}