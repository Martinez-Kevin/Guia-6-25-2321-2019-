using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guia_6__25_2321_2019_.Models
{
    public class calculo_operaciones
    {
        public decimal num1 { get; set; }

        public decimal num2 { get; set; }

        public Operaciones op { get; set; }
    }

    public enum Operaciones
    {
        Suma,Resta,Multiplicacion,Division
    }
}