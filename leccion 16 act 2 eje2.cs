using System;

class Program

static void Main()

int[numerosEnteros = new int[8];
int numeroMayor = 0;
int posicionMayor = 0;

for (int i = 0; i < 8; i++)

    Console.Write($'"Ingrese el número {i + 1}:");
    numerosEnteros[i] =
    int.Parse(Console.ReadLine());

if (i == 0)

    numeroMayor = numerosEnteros[i];
posicionMayor = i + 1;

else if (numerosEnteros[i] > numeroMayor)

    -

    numeroMayor = numerosEnteros[i];
posicionMayor = i + 1;

Console.WriteLine($"\nEl número mayor es:
{ numeroMayor}
");
Console.WriteLine($"Se encuentra en la
posición: { posicionMayor}
");