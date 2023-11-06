namespace Atividade
{
    class Clientes
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public float Valor { get; protected set; }
        public float ValorImposto { get; protected set; }
        public float Total { get; protected set; }

        public virtual void PagarImposto(float v)
        {
            Valor = v;
            ValorImposto = Valor * 10 / 100;
            Total = Valor + ValorImposto;
        }
    }
}
