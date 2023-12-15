// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hola mundo");

/* ------------------ Variables ------------------- */
// Programa que calcula el área de un rectángulo
// Lado A * Lado B
// double ladoA;
// double ladoB;
// double resultado;

// Console.WriteLine("Calcula el área de un rectángulo");
// Console.WriteLine("Ingresa el valor del lado A: ");

// // Leer el valor del lado A
// ladoA = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Ingresa el valor del lado A: ");
// ladoB = Convert.ToDouble(Console.ReadLine());

// resultado = ladoA * ladoB;

// Console.WriteLine($"El área del rectángulo es: {resultado}");

/* ------------------ La palabra reservada var ------------------- */

// var → Se utiliza para utilizar datos implícitos.
// Es decir, el tipo de dato depende del valor que se le asigne.
// var ladoA = Convert.ToDouble(Console.ReadLine());
// var ladoB = Convert.ToDouble(Console.ReadLine());

// var resultado = ladoA * ladoB;

// Console.WriteLine($"El área del rectángulo es: {resultado}");

/* ------------------ Uso de constantes ------------------- */

// PI * radio * radio

// var radio = 0.0; // Con esto C# infiere que es un float
// var resultado = 0.0; // Con esto C# infiere que es un float

// const double PI = 3.1416; // No se puede modificar el valor de la constante

// Console.WriteLine("Ingrese el valor del radio: ");
// radio = Convert.ToDouble(Console.ReadLine());

// resultado = Math.PI * radio * radio;

// Console.WriteLine($"El área del círculo es: {resultado}");

/* ------------------ Operadores aritméticos ------------------- */

// +, -, *, /, %

// var ladoA = 0d;
// var ladoB = 0d;
// var resultado = 0d;

// Console.WriteLine("Calcula el área de un triangulo rectángulo");


// Console.WriteLine("Ingresa el valor del lado A: ");
// ladoA = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Ingresa el valor del lado B: ");
// ladoB = Convert.ToDouble(Console.ReadLine());

// resultado = (ladoA + ladoB) / 2;

// Console.WriteLine($"El área del círculo es: {resultado}");

/* ------------------ Operadores lógicos ------------------- */

// &&, ||, !, ^

// bool valor1 = true;
// bool valor2 = false;
// bool valor3 = false;

// var (valor1, valor2, valor3) = (true, true, false);

// bool resultado = valor1 && valor2;
// Console.WriteLine($"El resultado es: {resultado}");

// resultado = valor1 || valor2;
// Console.WriteLine($"El resultado es: {resultado}");

// resultado = valor1 || valor2 || valor3;
// Console.WriteLine($"El resultado es: {resultado}");

// resultado = (valor1 && valor2) || valor3;
// Console.WriteLine($"El resultado es: {resultado}");

// bool resultXor = valor1 ^ valor2; // Si son diferentes, el resultado es true
// Console.WriteLine($"El resultado es: {resultXor}");

/* ------------------ Operadores relacionales ------------------- */

// var (valor1, valor2, valor3) = (10, 10, 5);

// Console.WriteLine($"Los valores son: {valor1}, {valor2}, {valor3}");

// bool resultado = valor1 == valor2;

// Console.WriteLine($"El resultado es: {resultado}");

// resultado = valor1 != valor2;

// Console.WriteLine($"El resultado es: {resultado}");

// resultado = valor1 > valor3;

// Console.WriteLine($"El resultado es: {resultado}");

/* ------------------ Strings en C# ------------------- */

// Console.WriteLine("Ricardo Perez ID!");

// int altura = 168;
// int edad = 89;
// string nombre = "Ricardo Perez";
// string infomacion = "Nació en Buenos Aires, Argentina. Estudia en la Universidad de Buenos Aires.";
// var hobby = "deportista";

// string tarjetaDeIdentificacion = $"La información de {nombre} es la siguiente: \n" +
//     $"Altura: {altura} cm \n" +
//     $"Edad: {edad} años \n" +
//     $"Hobby: {hobby} \n" +
//     $"Información adicional: {infomacion}";

// Console.WriteLine(tarjetaDeIdentificacion);

/* ------------------ Condicional IF ------------------- */

// int totalJugador = 23;
// int totalDealer = 15;
// string message = "";


// // BlackJack: Juntar 21 pidiendo cartas o en caso de tener menos de 21 igual ttener mayor puntaje que el dealer

// if (totalJugador > totalDealer && totalJugador <= 21)
// {
//     message = "Venciste al dealer. Felicidades!";
// }
// else if (totalJugador <= totalDealer)
// {
//     message = "Perdiste contra el dealer. Suerte para la próxima!";
// }
// else
// {
//     message = "Condición no válida";
// }

// Console.WriteLine(message);

/* ------------------ Condicional Switch ------------------- */


// int totalJugador = 25;
// int totalDealer = 15;
// string message = "";
// string? switchControl = "menu";

// switch (switchControl)
// {
//     case "menu":
//         Console.WriteLine("Welcome al C A S I N O");
//         Console.WriteLine("Escriba '21' para jugar al 21");

//         switchControl = Console.ReadLine();
//         break;

//     case "21":
//         if (totalJugador > totalDealer && totalJugador <= 21)
//         {
//             message = "Venciste al dealer. Felicidades!";
//         }
//         else if (totalJugador <= totalDealer && totalDealer <= 21)
//         {
//             message = "Perdiste contra el dealer. Suerte para la próxima!";
//         }
//         else
//         {
//             message = "Condición no válida";
//         }

//         Console.WriteLine(message);
//         break;

//     default:
//         Console.WriteLine("Opción no válida");
//         break;
// }

/* ------------------ Ciclo While y Do While ------------------- */
// int totalJugador = 0;
// int totalDealer = 0;
// int num = 0;
// string message = "";
// string? switchControl = "menu";
// string? controlCarta = "";

// while (true)
// {



//     switch (switchControl)
//     {
//         case "menu":
//             Console.WriteLine("Welcome al C A S I N O");
//             Console.WriteLine("Escriba '21' para jugar al 21");

//             switchControl = Console.ReadLine();
//             break;

//         case "21":
//             Random random = new();

//             do
//             {
//                 Console.WriteLine("Toma tu carta");

//                 num = random.Next(1, 11);
//                 totalJugador += num;

//                 Console.WriteLine($"Tu carta es: {num}");
//                 Console.WriteLine($"Tu total es: {totalJugador}");

//                 Console.WriteLine("¿Deseas otra carta? (Si/No)");

//                 controlCarta = Console.ReadLine();
//             }
//             while (controlCarta == "Si" && totalJugador <= 21);

//             totalDealer = random.Next(14, 22);


//             if (totalJugador > totalDealer && totalJugador <= 21)
//             {
//                 message = $"Venciste al dealer. Felicidades! Tu total fue: {totalJugador} y el del dealer fue: {totalDealer}";
//             }
//             else if (totalJugador <= totalDealer && totalDealer <= 21)
//             {
//                 message = $"Perdiste contra el dealer. Suerte para la próxima! Tu total fue: {totalJugador} y el del dealer fue: {totalDealer}";
//             }
//             else
//             {
//                 message = $"Te pasaste de 21. Perdiste! Tu total fue: {totalJugador} y el del dealer fue: {totalDealer}";
//             }

//             switchControl = "menu";

//             totalJugador = 0;
//             totalDealer = 0;

//             Console.WriteLine(message);
//             break;

//         default:
//             Console.WriteLine("Opción no válida");
//             switchControl = "menu";
//             break;
//     }
// }

/* ------------------ Ciclo For ------------------- */

int totalJugador = 0;
int totalDealer;
int num;
int platziCoins;
string message;
string? switchControl = "menu";

Console.WriteLine("Welcome al C A S I N O");
Console.WriteLine("¿Cuántas PlatziCoins deseas? \nRecuerda que necesitas una por ronda");
platziCoins = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < platziCoins;)
{
    Console.WriteLine($"Ronda {i + 1}");

    string? controlCarta;

    while (platziCoins - i > 0)
    {
        Console.WriteLine($"Tienes {platziCoins - i} PlatziCoins");
        switch (switchControl)
        {
            case "menu":

                Console.WriteLine("- Escriba '21' para jugar al 21");
                Console.WriteLine("- Escriba 'Salir' para salir");

                switchControl = Console.ReadLine();
                break;

            case "21":
                Random random = new();

                do
                {
                    Console.WriteLine("Toma tu carta");

                    num = random.Next(1, 11);
                    totalJugador += num;

                    Console.WriteLine($"Tu carta es: {num}");
                    Console.WriteLine($"Tu total es: {totalJugador}");

                    Console.WriteLine("¿Deseas otra carta? (Si/No)");

                    controlCarta = Console.ReadLine();
                }
                while (controlCarta == "Si" && totalJugador <= 21);

                totalDealer = random.Next(14, 22);


                if (totalJugador > totalDealer && totalJugador <= 21)
                {
                    message = $"Venciste al dealer. Felicidades! Tu total fue: {totalJugador} y el del dealer fue: {totalDealer}";
                }
                else if (totalJugador <= totalDealer && totalDealer <= 21)
                {
                    message = $"Perdiste contra el dealer. Suerte para la próxima! Tu total fue: {totalJugador} y el del dealer fue: {totalDealer}";
                }
                else
                {
                    message = $"Te pasaste de 21. Perdiste! Tu total fue: {totalJugador} y el del dealer fue: {totalDealer}";
                }

                switchControl = "menu";

                totalJugador = 0;

                Console.WriteLine(message);
                i++;
                break;

            default:
                Console.WriteLine("Opción no válida");
                switchControl = "menu";
                break;
        }


    }

    if (platziCoins - i == 0)
    {
        Console.WriteLine("No tienes más PlatziCoins. Vuelve pronto!");
        break;
    }
}