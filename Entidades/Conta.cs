

namespace ConsoleHeranca.Entidades
{
    public class Conta
    {
        public int Numero { get; private set; }
        public string Proprietario { get; private set; }
        public double SaldoConta { get; protected set; }

        public Conta()
        {

        }

        public Conta(int numero, string proprietario, double saldoConta)
        {
            Numero = numero;
            Proprietario = proprietario;
            SaldoConta = saldoConta;
        }

        public void Saque(double valor)
        {
            SaldoConta -= valor + 5.0;
        }

        public void Deposito(double valor)
        {
            SaldoConta += valor;
        }
    }
}
