// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        int temp;
        char unidinformada, unidfinal;

        // Solicitação para o usuário informar a temperatura e as unidades
        Console.WriteLine("Informe a temperatura: ");
        temp = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual unidade está sendo usada? (Digite apenas o símbolo ex. Celsius - C, Fahrenheit - F, Kelvin - K)");
        unidinformada = char.Parse(Console.ReadLine());
        Console.WriteLine("Qual unidade você quer converter? (Digite apenas o símbolo ex. Celsius - C, Fahrenheit - F, Kelvin - K)");
        unidfinal = char.Parse(Console.ReadLine());

        // Realiza a conversão das unidades de medida
        double resultado = ConverterTemperatura(temp, unidinformada, unidfinal);

        // Exibe o resultado
        if (double.IsNaN(resultado))
        {
            Console.WriteLine("Unidades inválidas ou incompatíveis.");
        }
        else
        {
            Console.WriteLine($"A temperatura convertida é: {resultado} {unidfinal}");
        }
    }

    // Função que realiza a conversão de temperatura
    static double ConverterTemperatura(int temp, char unidinformada, char unidfinal)
    {
        // Celsius para outra unidade
        if (unidinformada == 'C')
        {
            if (unidfinal == 'F')
                return (temp * 9 / 5) + 32;  // Celsius para Fahrenheit
            if (unidfinal == 'K')
                return temp + 273;         // Celsius para Kelvin
        }

        // Fahrenheit para outra unidade
        if (unidinformada == 'F')
        {
            if (unidfinal == 'C')
                return (temp - 32) * 5 / 9;   // Fahrenheit para Celsius
            if (unidfinal == 'K')
                return (temp - 32) * 5 / 9 + 273; // Fahrenheit para Kelvin
        }

        // Kelvin para outra unidade
        if (unidinformada == 'K')
        {
            if (unidfinal == 'C')
                return temp - 273;         // Kelvin para Celsius
            if (unidfinal == 'F')
                return (temp - 273) * 9 / 5 + 32; // Kelvin para Fahrenheit
        }

        // Caso as unidades não sejam válidas ou incompatíveis
        return double.NaN;
    }
}
