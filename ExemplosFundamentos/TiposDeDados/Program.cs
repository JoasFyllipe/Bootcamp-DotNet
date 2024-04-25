using System.Data;
using ExemplosFundamentos.Models;


// string - cadeia de caracteres;
// int - tipo numerico inteiro;
// bool - verdadeiro ou falso;
// decimal - representar valores decimais monetarios "M";
// double - valor decimal;
// char - caractere unicode;
// DataTime - representação de datas, horas, manipular datas;



DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

 string apresentacao = "Olá, seja bem vindo";

 int quantidade = 1;
 Console.WriteLine("Valor da variável quantidade: " + quantidade);

 quantidade = 10;
 Console.WriteLine("Valor da variável quantidade: " + quantidade);

 double altura = 1.80;

 decimal preco = 1.80M;

 bool condicao = true;



 Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
 Console.WriteLine("Valor da variável preco: " + preco);
 Console.WriteLine("Valor da variável condicao: " + condicao);

  Pessoa pessoa1 = new Pessoa ();
 pessoa1.Nome = "Joás";
 pessoa1.Idade = 19;
 pessoa1.Apresentar();

 Pessoa _pessoa_FisicaRepresentacao = new Pessoa();