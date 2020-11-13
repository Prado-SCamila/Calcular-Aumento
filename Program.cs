using System;

namespace Calcular_Aumento
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double salfinal;
            double i = 0.30;
            
            Console.WriteLine("Para saber se tem direito ao aumento, digite seu salário");
            salario = double.Parse(Console.ReadLine());
            
            salfinal = salario + (salario*i);

            if(salario< 500){
              Console.WriteLine("Você recebeu o aumento de 30%. Seu novo salário é :"+salfinal);
            }else{
                Console.WriteLine("Você não tem direito ao aumento.");
            }
        }
    }
}
