
using System.Drawing;

void CalcularEstoque()
{
    int estoqueMinino = 1000;
    int estoqueMaximo = 5000;
    double estoqueMedio = (estoqueMinino + estoqueMaximo) / 2;
    Console.WriteLine("Este é o Médio de um Parafuso: " + estoqueMedio);
}

//CalcularCotacaoDolar();
void CalcularCotacaoDolar()
{
    Console.WriteLine("Insira a cotação do Dólar Hoje em R$");
    double cotacaoDolar = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o seu valor em dolares $");
    // Parse para ler o valor em double
    double valorEmDolar = double.Parse(Console.ReadLine());
    double valorEmReais = cotacaoDolar * valorEmDolar;
   // ToString(F) --> para mostrar apenas 2 casas depois da vírgula;
    Console.WriteLine("Este é o seu valor em reais R$ " + valorEmReais.ToString("F"));
}


void CalcularComissao()
{
    // comissão de 5% do total da venda;
    string vendedora = "Camila Alves";

}