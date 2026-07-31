namespace sistema_bancario.Models
{
    public class ContaCorrente : Conta
    {
        private const decimal Limite = 200;

        public ContaCorrente(string titular, decimal saldo)
            : base(titular, saldo)
        {
        }

        public override void Sacar(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentException("Valor inválido.");

            if (Saldo - valor < -Limite)
                throw new InvalidOperationException("Limite insuficiente.");

            Saldo -= valor;
        }
    }
}

