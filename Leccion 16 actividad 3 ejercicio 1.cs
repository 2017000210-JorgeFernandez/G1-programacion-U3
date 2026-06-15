using System;

class Program

static void Main()

int[numerosEnteros = new int[15];
bool existeRepetido = false;

// Ingreso de datos
for (int indice = 0; indice < 15; indice++)

    Console.Write($"Ingrese el número {indice + 1}:
    ");
    numerosEnteros[indice] =
    int.Parse(Console.ReadLine());

// Buscar números repetidos
for (int indice = 0; indice < 14; indice++)

    for (int comparador = indice + 1; comparador <

    15; comparador++)
        if (numerosEnteros[indice] ==
numerosEnteros[comparador])

            existeRepetido = true;

// Mostrar resultado
if (existeRepetido)

    Console.WriteLine("Sí existe al menos un
    número repetido.");

else

    Console.WriteLine("No existe ningún número
    repetido.");

}

