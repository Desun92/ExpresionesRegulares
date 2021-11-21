using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpresionesRegulares
{
    class Validaciones
    {
        public static bool ValidarTelefono(string telefono, ref string cadena)
        {
            Regex fijo = new Regex(@"^(\+34\s?)?[8-9]\d{2}\s?\d{3}\s?\d{3}$");
            Regex movil = new Regex(@"^(\+34\s?)?[6-7]\d{2}\s?\d{3}\s?\d{3}$");
            bool correcto = fijo.IsMatch(telefono);

            //Si no es correcto, comprobamos que no sea un móvil
            if (!correcto)
            {
                correcto = movil.IsMatch(telefono);
                if (correcto)
                    cadena = "Es un teléfono móvil correcto";
                else
                    cadena = "No es un teléfono válido";
            }
            else
                cadena = "Es un teléfono fijo correcto";

            return correcto;
        }

        public static bool ValidarCP(string cp, ref string cadena)
        {
            Regex regex = new Regex(@"^([0-4]\d{4})$|^((50|51|52)\d{3})$");
            bool correcto = regex.IsMatch(cp) && Convert.ToInt32(cp.Substring(0, 2)) > 0;

            if (correcto)
                cadena = "Es un código postal válido";
            else
                cadena = "No es un código postal válido";

            return correcto;
        }

        public static bool ValidarEmail(string email, ref string cadena)
        {
            Regex regex = new Regex(@"^([a-zA-Z0-9]([\-|\.|_][a-zA-Z0-9])?)+\@([a-zA-Z0-9]([\-|\.|_][a-zA-Z0-9])?)+\.[a-zA-Z]{2,5}$");
            bool correcto = regex.IsMatch(email);

            if (correcto)
                cadena = "Es un email válido";
            else
                cadena = "No es un email válido";

            return correcto;
        }

        public static bool ValidarNIF(string Nif, ref string cadena)
        {
            Nif=Nif.ToUpper();
            Regex nif = new Regex(@"^\d{8}\-?[A-Z]$");
            Regex nie = new Regex(@"^[XYZ]\d{7}\-?[A-Z]$");
            bool correcto = nif.IsMatch(Nif);
            string secuenciaLetras = "TRWAGMYFPDXBNJZSQVHLCKE";

            //Si no es correcto, comprobamos que no sea un nie
            if (!correcto)
            {
                correcto = nie.IsMatch(Nif);
                if (!correcto)
                    cadena = "No es un NIF/NIE válido";
                else
                {
                    //Si es un nie, comprobamos que la última letra sea la que corresponda
                    char letraNie;
                    Nif=Nif.Replace("X", "0").Replace("Y", "1").Replace("Z", "2").Replace("-","");
                    letraNie = Convert.ToChar(Nif.Substring(Nif.Length-1));

                    string subNie = Nif.Substring(0, 8);
                    int indiceLetra = Convert.ToInt32(subNie) % 23;

                    if (letraNie == secuenciaLetras[indiceLetra])
                        cadena = "Es un NIE válido";
                    else
                    {
                        cadena = "No es un NIE válido";
                        correcto = false;
                    }
                }
            }
            else
            {
                //Si es un nif válido, comprobamos que la última letra sea la que corresponda
                char letraNif;
                Nif = Nif.Replace("-","");
                letraNif = Convert.ToChar(Nif.Substring(Nif.Length - 1));

                string subNif = Nif.Substring(0,8);
                int indiceLetra = Convert.ToInt32(subNif) % 23;

                if (letraNif == secuenciaLetras[indiceLetra])
                    cadena = "Es un NIF válido";
                else
                {
                    cadena = "No es un NIF válido";
                    correcto = false;
                }
            }

            return correcto;
        }

        public static bool ValidarCCC(string ccc, ref string cadena)
        {
            Regex regex = new Regex(@"^\d{20}$|\d{4}\s\d{4}\s\d{2}\s\d{10}");
            bool correcto = regex.IsMatch(ccc);

            if (correcto)
            {
                //Si es correcto comprobamos que los dígitos de control sean los correctos
                ccc = ccc.Replace(" ","");
                string primerBloque = ccc.Substring(0, 8);
                primerBloque = "00" + primerBloque;
                string primerDC = ccc.Substring(8, 1);
                string segundoDC = ccc.Substring(9, 1);
                string segundoBloque = ccc.Substring(10);
                bool comprobarPrimerDigito = validarDC(primerBloque, primerDC);
                bool comprobarSegundoDigito = validarDC(segundoBloque, segundoDC);

                if (comprobarPrimerDigito && comprobarSegundoDigito)
                    cadena = "Es un CCC correcto";
                else
                {
                    cadena = "No es un CCC válido";
                    correcto = false;
                }
                   
            }
            else
            {
                cadena = "No es un CCC válido";
            }

            return correcto;
        }

        public static bool validarDC(string ccc, string dc)
        {
            int[] pesos = {1,2,4,8,5,10,9,7,3,6};
            int sumaMultiplicacion = 0;
            bool correcto = false;

            if (ccc.Length != pesos.Length)
            {
                Console.WriteLine("Error en el CCC");
            }
            else
            {
                for (int i = 0; i < pesos.Length; i++)
                {
                    sumaMultiplicacion += pesos[i] * Convert.ToInt32(ccc.Substring(i, 1));
                }
                sumaMultiplicacion = sumaMultiplicacion % 11;
                sumaMultiplicacion = 11 - sumaMultiplicacion;
                if (sumaMultiplicacion == 10)
                    sumaMultiplicacion = 1;
                if (sumaMultiplicacion == 11)
                    sumaMultiplicacion = 0;

                if (sumaMultiplicacion.ToString() == dc)
                    correcto = true;
            }

            return correcto;
        }

        public static bool ValidarTarjeta(string tarjeta, ref string cadena)
        {
            Regex regex = new Regex(@"^\d{16}|\d{4}\s\d{4}\s\d{4}\s\d{4}$");
            bool correcto = regex.IsMatch(tarjeta);

            if (correcto)
            {
                //Si es correcto comprobamos que el número de control lo sea también
                tarjeta = tarjeta.Replace(" ", "");
                int ultimoDigito = AlgoritmoDeLuhn(tarjeta);
                if (ultimoDigito == 0)
                    cadena = "Es una tarjeta válida";
                else
                {
                    cadena = "No es una tarjeta válida";
                    correcto = false;
                }
            }
            else
                cadena = "No es una tarjeta válida";

            return correcto;
        }

        public static int AlgoritmoDeLuhn(string numero)
        {
            string[] digitosImpares = new string[8];
            string[] digitosPares = new string[8];
            int contadorImpares = 0;
            int contadorPares = 0;
            int sumaChar = 0;
            string[] digitosParesSumados = new string[8];

            for (int i = 0; i < numero.Length; i++)
            {
                if (i % 2 == 0)
                {
                    int num = Convert.ToInt32(numero[i].ToString());
                    int numAñadir = 2 * num;
                    digitosPares[contadorPares] = Convert.ToString(numAñadir);
                    contadorPares++;
                }
                else
                {
                    digitosImpares[contadorImpares] = numero[i].ToString();
                    contadorImpares++;
                }
            }

            contadorPares = 0;

            foreach (String num in digitosPares)
            {
                char[] suma = num.ToCharArray();

                foreach (char nume in suma)
                {
                    sumaChar += int.Parse(nume.ToString());
                }
                digitosParesSumados[contadorPares] = Convert.ToString(sumaChar);
                contadorPares++;
                sumaChar = 0;
            }

            int sumaDigitos = 0;
            for (int i = 0; i < digitosImpares.Length; i++)
            {
                sumaDigitos += Convert.ToInt32(digitosImpares[i].ToString()) + Convert.ToInt32(digitosParesSumados[i].ToString());
            }

            sumaDigitos = sumaDigitos % 10;

            return sumaDigitos;
        }
    }
}
