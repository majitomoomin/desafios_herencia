using desafio_1;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¿Qué tipo de calculadora te gustaría usar? (normal(1)/cientifica(2))");
        int tipoCalculadora = Convert.ToInt32(Console.ReadLine());

        if (tipoCalculadora == 1)
        {
            Calculadora calc = new Calculadora();
            Console.WriteLine("Ingrese dos números:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el número de la operación que desea realizar: (1. Sumar, 2. Restar, 3. Multiplicar, 4. Dividir)");
            int operacion = Convert.ToInt32(Console.ReadLine());

            switch (operacion)
            {
                case 1:
                    Console.WriteLine($"Resultado: {calc.Sumar(num1, num2)}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado: {calc.Restar(num1, num2)}");
                    break;
                case 3:
                    Console.WriteLine($"Resultado: {calc.Multi(num1, num2)}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Resultado: {calc.Divi(num1, num2)}");
                    }
                    else
                    {
                        Console.WriteLine("Error: División por cero.");
                    }
                    break;
                default:
                    Console.WriteLine("Operación no reconocida.");
                    break;
            }
        }
        else if (tipoCalculadora == 2)
        {
            CalculadoraCientifica calcCientifica = new CalculadoraCientifica();

            Console.WriteLine("Ingrese el número de la operación que desea realizar: (1. Potencia, 2. Raíz, 3. Módulo, 4. Logaritmo)");
            int operacion = Convert.ToInt32(Console.ReadLine());

            switch (operacion)
            {
                case 1:
                    Console.WriteLine("Ingrese dos números:");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Resultado: {calcCientifica.Potencia(num1, num2)}");
                    break;
                case 2:
                    Console.WriteLine("Ingrese un número:");
                    double num = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Resultado: {calcCientifica.Raiz(num)}");
                    break;
                case 3:
                    Console.WriteLine("Ingrese dos números:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Resultado: {calcCientifica.Modulo(num1, num2)}");
                    break;
                case 4:
                    Console.WriteLine("Ingrese un número:");
                    num = Convert.ToDouble(Console.ReadLine());
                    if (num > 0)
                    {
                        Console.WriteLine($"Resultado: {calcCientifica.Logaritmo(num)}");
                    }
                    else
                    {
                        Console.WriteLine("Error: El logaritmo de un número negativo o cero no está definido.");
                    }
                    break;
                default:
                    Console.WriteLine("Operación no reconocida.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Tipo de calculadora no reconocido.");
        }
    }
}

