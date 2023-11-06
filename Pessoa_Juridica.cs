namespace Atividade
{
    class PessoaJuridica : Clientes
    {
        public string CNPJ { get; set; }
        public string IE { get; set; }

        public override void PagarImposto(float v)
        {
            Valor = v;
            ValorImposto = Valor * 20 / 100;
            Total = Valor + ValorImposto;
        }
    }
}
