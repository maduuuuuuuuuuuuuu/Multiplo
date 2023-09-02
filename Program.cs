double numero, multiplo, resultado;
Console.WriteLine("Multiplo");
Console.WriteLine("Digite um numero");
numero = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Avaliar se é multiplo de:");
multiplo = Convert.ToDouble(Console.ReadLine()!);
resultado = numero % multiplo;

if(resultado == 0){
    Console.WriteLine($"{numero} é multiplo de {multiplo}");
}
else{
    Console.WriteLine($"{numero} não é multiplo de {multiplo}");
}



