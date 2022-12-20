using System.Globalization;

// Exercício 1
/*
Console.WriteLine("Digite o primeiro número:");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
int n2 = int.Parse(Console.ReadLine());

int soma = n1 + n2;

Console.WriteLine($"A soma de {n1} e {n2} é {soma}");
*/

//Exercício 2
/*
Console.WriteLine("Digite o raio:");
double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double pi = double.Parse(Math.PI.ToString("F5"));

double area = pi * Math.Pow(raio, 2);
Console.WriteLine($"A área é: " + area.ToString("F4", CultureInfo.InvariantCulture));
*/

//Exercício 3 (Método 1)
/*
Console.WriteLine("Digite o primeiro termo:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo termo:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o terceiro termo:");
int c = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o qaurto termo:");
int d = int.Parse(Console.ReadLine());

int diferenca = (a * b) - (c * d);

Console.WriteLine("A diferença é " +diferenca);
*/

//Exercício 3 (Método 2)
/*
Console.WriteLine("Digite os quatro termos (na mesma linha)");
string[] vet = Console.ReadLine().Split(' ');
int a = int.Parse(vet[0]);
int b = int.Parse(vet[1]);
int c = int.Parse(vet[2]);
int d = int.Parse(vet[3]);

int diferenca = (a * b) - (c * d);

Console.WriteLine("A diferença é " + diferenca);
*/

//Exercício 4
/*
Console.WriteLine("Digite seu código:");
int code = int.Parse(Console.ReadLine());

Console.WriteLine("Digite suas horas trabalhadas:");
double money = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Digite o valor que você recebe por hora:");
double hours = double.Parse(Console.ReadLine());

double salary = money * hours;

Console.WriteLine("");

Console.WriteLine($"Seu código é: {code}");
Console.WriteLine("Você recebeu R$" +salary.ToString("F2"));
*/

//Exercício 5 (Método 1)
/*
Console.WriteLine("Digite o código do produto 1, o número de produtos e o valor do produto (na mesma linha)");
string[] vet1 = Console.ReadLine().Split(' ');
int code1 = int.Parse(vet1[0]);
int qtd1 = int.Parse(vet1[1]);
double value1 = double.Parse(vet1[2]);
double product1 = (qtd1 * value1);
 
Console.WriteLine("Digite o código do produto 2, o número de produtos e o valor do produto (na mesma linha)");
string[] vet2 = Console.ReadLine().Split(' ');
int code2 = int.Parse(vet2[0]);
int qtd2 = int.Parse(vet2[1]);
double value2 = double.Parse(vet2[2]);
double product2 = (qtd2 * value2);

double totalValue = (product1 + product2);

Console.WriteLine($"Valor a pagar: R$ {totalValue}", totalValue.ToString("F2"));
*/

//Exercício 5 (Método 2)
/*
Console.WriteLine("Digite o código do produto 1:");
int code1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o número de peças do produto 1:");
int qtd1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor do produto 1:");
double value1 = double.Parse(Console.ReadLine());
double price1 = (qtd1 * value1);

Console.WriteLine("Digite o código do produto 2:");
int code2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o número de peças do produto 2:");
int qtd2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor do produto 2:");
double value2 = double.Parse(Console.ReadLine());
double price2 = (qtd2 * value2);

double totalPrice = (price1 + price2);

Console.WriteLine($"Valor a pagar: R$ " +totalPrice.ToString("F2"));
*/

//Exercício 6
/*
Console.WriteLine("Digite o primeiro valor:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo valor:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o terceiro valor:");
double c = double.Parse(Console.ReadLine());

double pi = double.Parse(Math.PI.ToString("F5"));


//área triângulo
double triangulo = (a * c) / 2;

//área círculo
double circulo = Math.Pow(c, 2) * pi;

//área trapézio
double trapezio = ((a + b) * c) / 2;

//área quadrado
double quadrado = Math.Pow(b, 2);

//área retângulo
double retangulo = (a * b);

Console.WriteLine("Triângulo: " + triangulo.ToString("F3"));
Console.WriteLine("Circulo : " + circulo.ToString("F3"));
Console.WriteLine("Trapézio: " + trapezio.ToString("F3"));
Console.WriteLine("Quadrado: " + quadrado.ToString("F3"));
Console.WriteLine("retângulo: " + retangulo.ToString("F3"));
*/