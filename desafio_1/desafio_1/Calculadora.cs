using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_1
{
    internal class Calculadora
    {
        public string Marca { get; set; }
        public string Serie { get; set; }

        public Calculadora()
        {
            Marca = "CASIO";
            Serie = "fx-82 LA PLUS";
        }

        public double Sumar(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Restar(double num1, double num2)
        {
            return num1 - num2;

        }

        public double Multi(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Divi(double num1, double num2)
        {
            if(num2 == 0)
            {
                throw new DivideByZeroException();
            }
            return num1 / num2;
        }
    }
}
