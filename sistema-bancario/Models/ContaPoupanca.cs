 namespace sistema_bancario.Models
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(string titular, decimal saldo)
            : base(titular, saldo)
        {
        }

        public override void Sacar(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentException("Valor inválido.");

            if (valor > Saldo)
                throw new InvalidOperationException("Saldo insuficiente.");

            Saldo -= valor;
        }
    }
}