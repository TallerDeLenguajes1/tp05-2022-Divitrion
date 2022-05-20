int a,b,operacion,resultado=0;
bool end=true;

do
{
    Console.WriteLine("Que operacion quiere hacer");
    Console.WriteLine("Resta [0], Suma [1], Multiplicacion [2], Division [3]");
    operacion = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese los numeros a operar");
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());

    switch (operacion)
    {
        case 0:
            resultado = a-b;
        break;
        case 1:
            resultado = a+b;
        break;
        case 2:
            resultado = a*b;
        break;
        case 3:
            resultado = a/b;
        break;
    }

    Console.WriteLine($"El resultado es: {resultado}");

    Console.WriteLine("Quiere hacer otra operacion? No [0], Si [1]");
    operacion = Convert.ToInt32(Console.ReadLine());
    if (operacion<1)
    {
        end=false;
    }

} while (end);
