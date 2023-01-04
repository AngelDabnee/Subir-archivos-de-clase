// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Recibe 30 números y determina e imprime menor entre ellos.");
//DE. 
double[] numeros = new double[30];//Arreglo para los 30 numeros
double menor = 0;
//Proceso. 
Console.WriteLine("Capturaremos 30 números");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Captura el número No. " + (i+1));//Comienza el arreglo para capturar los 30 numeros
    numeros[i] = double.Parse(Console.ReadLine());
}
for (int i = 0; i < numeros.Length; i++)
{
	for (int k = 0; k < numeros.Length-1; k++)//Hacemos el ordenamiento de la burbuja para ordenar 30 numeros menor a mayor
	{
		if (numeros[k] > numeros[k+1])
		{
			double temp = numeros[k];
			numeros[k] = numeros[k + 1];
			numeros[k + 1] = temp;
		}
	}
	menor = numeros[0];//Es la posición donde colocamos el número menor
}
//DE
Console.WriteLine($"El número menor de los que capturaste es {menor}");
