using System;

namespace saldoMedio
{
    class Program
    {
        static void Main(string[] args)
        {
			double saldo, credito;

			Console.WriteLine("Informe seu último saldo");
			saldo = double.Parse(Console.ReadLine());

			if (saldo <= 200)
			{
				credito = 0;
			}
			else if (saldo <= 400)
			{
				credito = saldo * 0.2;
			}
			else if (saldo <= 600)
			{
				credito = saldo *  0.3;
			}
			else
			{
				credito = saldo *  0.4;
			}

			Console.WriteLine("Seu saldo médio é R${0} e crédito de R${1}", saldo.ToString("F2"), credito.ToString("F2"));
		}
    }
}
