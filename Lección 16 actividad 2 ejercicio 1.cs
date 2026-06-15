using System;

class Program

static void Main()

intl edadesPersonas = new int[7];
int cantidadMayoresEdad = 0;

for (int i = 0; i < 7; i++)

    Console.Write($'"Ingrese la edad de la persona {i
    + 1}: ");
edadesPersonas[i] =
int.Parse(Console.ReadLine());

if (edadesPersonas[i] >= 18)

    cantidadMayoresEdad++;

Console.WriteLine('$"InCantidad de personas

mayores de edad: { cantidadMayoresEdad}
");
}