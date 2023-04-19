using TestesUnitarios.Desafio.Console.Services;

ValidacoesLista listaTeste = new();
ValidacoesString stringTeste = new();

var lista1 = new List<int> { -2, 3, -5, 4, -1 };
var teste1 = listaTeste.RemoverNumerosNegativos(lista1);

Console.WriteLine($"Lista: [{string.Join(", ", lista1)}] => [{string.Join(", ", teste1)}]");

var texto1 = "Die young is far too boring these days";
var palavra1 = "boring";
var teste2 = stringTeste.ContemCaractere(texto1, palavra1);

Console.WriteLine($"A frase '{texto1}' contém a palavra '{palavra1}'? => {teste2}");