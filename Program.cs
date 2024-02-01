namespace MeuSuperBanco
{
    internal class Program
    {

        static void Main(string[] args)
        {

            MeuSuperBanco.ContaBanco contaB = new ContaBanco("Luiz Paulo", 10000);
            Console.WriteLine($"A conta {contaB.Numero} de {contaB.Dono} foi criado com o saldo no valor de {contaB.Saldo} reais");


            contaB.Sacar(800, DateTime.Now, "Fiz as compras");
            Console.WriteLine($"A conta está com {contaB.Saldo} reais");

            try
            {
                contaB.Sacar(100, DateTime.Now, "pagar a internet");
                Console.WriteLine($"A conta está com {contaB.Saldo} reais");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message );
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Operação não realizada");
            }

            contaB.Sacar(1500, DateTime.Now, "pagar o aluguel");
            Console.WriteLine($"A conta está com {contaB.Saldo} reais");

            contaB.Sacar(2000, DateTime.Now, "pagar escola das crianças");
            Console.WriteLine($"A conta está com {contaB.Saldo} reais");

            contaB.Depositar(300, DateTime.Now, "recebi um pagamento");
            Console.WriteLine($"A conta está com {contaB.Saldo} reais");

            Console.WriteLine(contaB.PegarMovimentacao());

        }

    }
}
