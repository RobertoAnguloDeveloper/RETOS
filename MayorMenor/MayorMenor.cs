using System;

namespace MayorMenor
{
    class MayorMenor
    {
        public static void Main(string[] args){
            int num1, num2;
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            if(num1 > num2){
                Console.WriteLine("El numero mayor es: " + num1 + " y la diferencia entre ambos es: "+ (num1-num2));
            }else if(num1 == num2){
                Console.WriteLine("Los numeros son iguales y la diferencia entre ambos es: 0");
            }else{
                Console.WriteLine("El numero mayor es: " + num2 + " y la diferencia entre ambos es: "+ (num2-num1));
            }

        }
    }
}