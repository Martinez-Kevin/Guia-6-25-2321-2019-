using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guia_6__25_2321_2019_.Models
{
    public class conversion
    {
        public decimal medida { get; set; }

        public Magnitudes mg { get; set; }

        public TipoConver conver { get; set; }


    }

    public enum Magnitudes
    {
        Temperatura, Peso, Longitud
    }

    public enum TipoConver
    {
        Celcius_Kelvin,Kelvin_Celcius,Kilogramos_Libras,Libras_Kilogramos,Metros_Pulgadas,Pulgadas_Metros
    }
}