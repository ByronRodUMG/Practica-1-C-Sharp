byte edad, num1, num2;
ushort result;
long num3, num4, suma, resta, prod;

Console.WriteLine("Cual es tu edad?");
edad = Convert.ToByte(Console.ReadLine());
Console.WriteLine("No aparentas tener " + edad + " años.");

Console.WriteLine("\nAhora ingresa dos números de dos cifras para multiplicarlos: ");
Console.Write("Número 1: ");
num1 = Convert.ToByte(Console.ReadLine());
Console.Write("Número 2: ");
num2 = Convert.ToByte(Console.ReadLine());
result = Convert.ToUInt16(num1 * num2);
Console.WriteLine("El producto es " + result);

Console.WriteLine("\nPor último, ingresa dos números para sumar, restar y multiplicar: ");
Console.Write("Número 1: ");
num3 = Convert.ToInt64(Console.ReadLine());
Console.Write("Número 2: ");
num4 = Convert.ToInt64(Console.ReadLine());
suma = num3 + num4;
resta = num3 - num4;
prod = num3 * num4;
Console.WriteLine("La suma de los números es " + suma);
Console.WriteLine("La resta de los números es " + resta);
Console.WriteLine("El producto de los números es " + prod);