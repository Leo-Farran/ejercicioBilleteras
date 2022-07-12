namespace Billeteras2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuesta = "S";
            string opcion = "";
            int cantBilletes = 0;
            var primerBilletera = new Billetera();

            Console.WriteLine("BIENVENIDO A SU GESTOR DE BILLETERAS");
            Console.WriteLine("Este gestor puede organizar 1 o 2 billeteras, calcular el total de cada una y combinarlas en caso de tener 2.");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Ingrese la denominacion del billete a cargar:");
                Console.WriteLine("1 - Billetes de $10");
                Console.WriteLine("2 - Billetes de $20");
                Console.WriteLine("3 - Billetes de $50");
                Console.WriteLine("4 - Billetes de $100");
                Console.WriteLine("5 - Billetes de $200");
                Console.WriteLine("6 - Billetes de $500");
                Console.WriteLine("7 - Billetes de $1000");
                Console.WriteLine();

                opcion = Console.ReadLine();
                Console.Clear();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese la cantidad de billetes a cargar");
                        cantBilletes = int.Parse(Console.ReadLine());
                        primerBilletera.billetesDe10 = cantBilletes;
                        Console.Clear();
                        break;

                    case "2":
                        Console.WriteLine("Ingrese la cantidad de billetes a cargar");
                        cantBilletes = int.Parse(Console.ReadLine());
                        primerBilletera.billetesDe20 = cantBilletes;
                        Console.Clear();
                        break;

                    case "3":
                        Console.WriteLine("Ingrese la cantidad de billetes a cargar");
                        cantBilletes = int.Parse(Console.ReadLine());
                        primerBilletera.billetesDe50 = cantBilletes;
                        Console.Clear();
                        break;

                    case "4":
                        Console.WriteLine("Ingrese la cantidad de billetes a cargar");
                        cantBilletes = int.Parse(Console.ReadLine());
                        primerBilletera.billetesDe100 = cantBilletes;
                        Console.Clear();
                        break;

                    case "5":
                        Console.WriteLine("Ingrese la cantidad de billetes a cargar");
                        cantBilletes = int.Parse(Console.ReadLine());
                        primerBilletera.billetesDe200 = cantBilletes;
                        Console.Clear();
                        break;

                    case "6":
                        Console.WriteLine("Ingrese la cantidad de billetes a cargar");
                        cantBilletes = int.Parse(Console.ReadLine());
                        primerBilletera.billetesDe500 = cantBilletes;
                        Console.Clear();
                        break;

                    case "7":
                        Console.WriteLine("Ingrese la cantidad de billetes a cargar");
                        cantBilletes = int.Parse(Console.ReadLine());
                        primerBilletera.billetesDe1000 = cantBilletes;
                        Console.Clear();
                        break;

                }
                Console.WriteLine("Desea cargar mas billetes? S/N");
                respuesta = Console.ReadLine().ToUpper();
                Console.WriteLine();
            } while (respuesta == "S");

            
            string respuesta2 = "S";
            var segundaBilletera = new Billetera();
            Console.WriteLine("Desea crear una segunda billetera? S/N");
            respuesta2 = Console.ReadLine().ToUpper();
            Console.WriteLine();

            if (respuesta2 != "S")
            {
                Console.WriteLine($"Billetes de $10: {primerBilletera.billetesDe10}");
                Console.WriteLine($"Billetes de $20: {primerBilletera.billetesDe20}");
                Console.WriteLine($"Billetes de $50: {primerBilletera.billetesDe50}");
                Console.WriteLine($"Billetes de $100: {primerBilletera.billetesDe100}");
                Console.WriteLine($"Billetes de $200: {primerBilletera.billetesDe200}");
                Console.WriteLine($"Billetes de $500: {primerBilletera.billetesDe500}");
                Console.WriteLine($"Billetes de $1000: {primerBilletera.billetesDe1000}");
                Console.WriteLine($"El total de la primer billetera es ${primerBilletera.Total()}");
            }
            else 
            {
                
                do
                {
                    Console.WriteLine("Ingrese la denominacion del billete a cargar:");
                    Console.WriteLine("1 - Billetes de $10");
                    Console.WriteLine("2 - Billetes de $20");
                    Console.WriteLine("3 - Billetes de $50");
                    Console.WriteLine("4 - Billetes de $100");
                    Console.WriteLine("5 - Billetes de $200");
                    Console.WriteLine("6 - Billetes de $500");
                    Console.WriteLine("7 - Billetes de $1000");
                    Console.WriteLine();

                    opcion = Console.ReadLine();
                    Console.Clear();
                    switch (opcion)
                    {
                        case "1":
                            Console.WriteLine("Ingrese la cantidad de billetes a cargar");
                            cantBilletes = int.Parse(Console.ReadLine());
                            segundaBilletera.billetesDe10 = cantBilletes;
                            Console.Clear();
                            break;

                        case "2":
                            Console.WriteLine("Ingrese la cantidad de billetes a cargar");
                            cantBilletes = int.Parse(Console.ReadLine());
                            segundaBilletera.billetesDe20 = cantBilletes;
                            Console.Clear();
                            break;

                        case "3":
                            Console.WriteLine("Ingrese la cantidad de billetes a cargar");
                            cantBilletes = int.Parse(Console.ReadLine());
                            segundaBilletera.billetesDe50 = cantBilletes;
                            Console.Clear();
                            break;

                        case "4":
                            Console.WriteLine("Ingrese la cantidad de billetes a cargar");
                            cantBilletes = int.Parse(Console.ReadLine());
                            segundaBilletera.billetesDe100 = cantBilletes;
                            Console.Clear();
                            break;

                        case "5":
                            Console.WriteLine("Ingrese la cantidad de billetes a cargar");
                            cantBilletes = int.Parse(Console.ReadLine());
                            segundaBilletera.billetesDe200 = cantBilletes;
                            Console.Clear();
                            break;

                        case "6":
                            Console.WriteLine("Ingrese la cantidad de billetes a cargar");
                            cantBilletes = int.Parse(Console.ReadLine());
                            segundaBilletera.billetesDe500 = cantBilletes;
                            Console.Clear();
                            break;

                        case "7":
                            Console.WriteLine("Ingrese la cantidad de billetes a cargar");
                            cantBilletes = int.Parse(Console.ReadLine());
                            segundaBilletera.billetesDe1000 = cantBilletes;
                            Console.Clear();
                            break;

                    }
                    Console.WriteLine("Desea cargar mas billetes? S/N");
                    respuesta = Console.ReadLine().ToUpper();
                } while (respuesta == "S");

                Console.WriteLine();
                Console.WriteLine($"El total de la primer billetera es ${primerBilletera.Total()}");
                Console.WriteLine($"Billetes de $10: {primerBilletera.billetesDe10}");
                Console.WriteLine($"Billetes de $20: {primerBilletera.billetesDe20}");
                Console.WriteLine($"Billetes de $50: {primerBilletera.billetesDe50}");
                Console.WriteLine($"Billetes de $100: {primerBilletera.billetesDe100}");
                Console.WriteLine($"Billetes de $200: {primerBilletera.billetesDe200}");
                Console.WriteLine($"Billetes de $500: {primerBilletera.billetesDe500}");
                Console.WriteLine($"Billetes de $1000: {primerBilletera.billetesDe1000}");
                Console.WriteLine();
                Console.WriteLine($"El total de la segunda billetera es ${segundaBilletera.Total()}");
                Console.WriteLine($"Billetes de $10: {segundaBilletera.billetesDe10}");
                Console.WriteLine($"Billetes de $20: {segundaBilletera.billetesDe20}");
                Console.WriteLine($"Billetes de $50: {segundaBilletera.billetesDe50}");
                Console.WriteLine($"Billetes de $100: {segundaBilletera.billetesDe100}");
                Console.WriteLine($"Billetes de $200: {segundaBilletera.billetesDe200}");
                Console.WriteLine($"Billetes de $500: {segundaBilletera.billetesDe500}");
                Console.WriteLine($"Billetes de $1000: {segundaBilletera.billetesDe1000}");
                Console.WriteLine();
            }
            string respuesta3 = "S";
            Console.WriteLine("Desea combinar sus billeteras? S/N");
            respuesta3 = Console.ReadLine().ToUpper();
            
            Console.WriteLine();

            if (respuesta3 == "S")
            {
                var terceraBilletera = new Billetera();
                terceraBilletera = primerBilletera.Combinar(segundaBilletera);
                Console.WriteLine($"El total de las dos billeteras es ${terceraBilletera.Total()}");
                Console.WriteLine($"Billetes de $10: {terceraBilletera.billetesDe10}");
                Console.WriteLine($"Billetes de $20: {terceraBilletera.billetesDe20}");
                Console.WriteLine($"Billetes de $50: {terceraBilletera.billetesDe50}");
                Console.WriteLine($"Billetes de $100: {terceraBilletera.billetesDe100}");
                Console.WriteLine($"Billetes de $200: {terceraBilletera.billetesDe200}");
                Console.WriteLine($"Billetes de $500: {terceraBilletera.billetesDe500}");
                Console.WriteLine($"Billetes de $1000: {terceraBilletera.billetesDe1000}");
                primerBilletera.vaciar();
                segundaBilletera.vaciar();
                Console.WriteLine($"El total de su primer billetera es ${primerBilletera.Total()}");
                Console.WriteLine($"El total de su segunda billetera es ${segundaBilletera.Total()}");
                Console.ReadKey();
            }
           
        }
    }
}