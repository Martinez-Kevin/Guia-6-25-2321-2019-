using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Guia_6__25_2321_2019_.Controllers
{
    public class EjerciciosController : Controller
    {
        // GET: Ejercicios
        public ActionResult Operaciones()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Operaciones(Models.calculo_operaciones obCalculo)
        {
            int op = Convert.ToInt32(obCalculo.op);
            decimal resultado;
            switch (op)
            {
                case 0:
                    resultado = obCalculo.num1 + obCalculo.num2;
                    ViewBag.resultado = resultado;
                    break;
                case 1:
                    resultado = obCalculo.num1 - obCalculo.num2;
                    ViewBag.resultado = resultado;
                    break;
                case 2:
                    resultado = obCalculo.num1 * obCalculo.num2;
                    ViewBag.resultado = resultado;
                    break;
                case 3:
                    try
                    {
                        resultado = obCalculo.num1 / obCalculo.num2;
                        ViewBag.resultado = resultado;
                    }
                    catch (DivideByZeroException)
                    {

                        string e = "No se puede dividir por cero";
                        ViewBag.resultado = e;
                    }
                    break;
            }
            return View(obCalculo);
        }

        public ActionResult Conversion()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Conversion(Models.conversion obConversion)
        {
            int mg = Convert.ToInt32(obConversion.mg);
            int conver = Convert.ToInt32(obConversion.conver);
            decimal resultado;
            switch (mg)
            {
                case 0:
                    if (conver == 0)
                    {
                        resultado = obConversion.medida + 273.15m;
                        ViewBag.resultado = Math.Round(resultado, 3) + " K";
                    }
                    else if (conver == 1)
                    {
                        resultado = obConversion.medida - 273.15m;
                        ViewBag.resultado = Math.Round(resultado, 3) + " C°";
                    }
                    break;
                case 1:
                    if (conver == 2)
                    {
                        resultado = obConversion.medida * 2.205m;
                        ViewBag.resultado = Math.Round(resultado, 5) + " lb";
                    }
                    else if (conver == 3)
                    {
                        resultado = obConversion.medida / 2.205m;
                        ViewBag.resultado = Math.Round(resultado, 5) + " kg";
                    }
                    break;
                case 2:
                    if (conver == 4)
                    {
                        resultado = obConversion.medida * 39.37m;
                        ViewBag.resultado = Math.Round(resultado, 3) + " pulgadas";
                    }
                    else if (conver == 5)
                    {
                        resultado = obConversion.medida / 39.37m;
                        ViewBag.resultado = Math.Round(resultado, 3) + " metros";
                    }
                    break;
            }

            return View(obConversion);

        }

        public ActionResult Notas()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Notas(Models.notas obCalculoP)
        {
            decimal promedio;
            promedio = (obCalculoP.nota1 + obCalculoP.nota2 + obCalculoP.nota3) / 3;

            if (promedio == 10)
            {
                ViewBag.resultado = "Felicidades su promedio es de: " + Math.Round(promedio, 2);

            }
            else if (promedio >= 7 && promedio < 10)
            {
                ViewBag.resultado = "Aprobado: " + Math.Round(promedio, 2);
            }
            else if(promedio < 7 && promedio >=4)
            {
                ViewBag.resultado = "Aplazado: " + Math.Round(promedio, 2);
            }
            else if (promedio <=4 && promedio>=0)
            {
                ViewBag.resultado = "Debe buscar un tutor: " + Math.Round(promedio, 2);
            }
            return View(obCalculoP);
        }
    }
}