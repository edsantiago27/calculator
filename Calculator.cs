using Microsoft.FSharp.Core;

namespace calculator;

public class Calculator
{

    private static readonly string[] Operators = { "+", "-", "*" };

    public string GenerateExpression(List<int> numbers)
    {
        return GenerateExpressionHelper(numbers, 0, "", 0);
    }

    private string GenerateExpressionHelper(List<int> numbers, int index, string currentExpression, int currentTotal)
    {
        if (index == numbers.Count)
        {
            if (currentTotal % 101 == 0)
            {
                // Cuando la suma total actual es divisible por 101, 
                // retornamos la expresión actual ya que es una solución válida.
                return currentExpression;
            }
            else
            {
                // Si la suma total actual no es divisible por 101, 
                // retornamos una cadena vacía indicando que esta rama no produce una solución.
                return "";
            }
        }

        foreach (var op in Operators)
        {
            var nextTotal = ComputeNextTotal(currentTotal, numbers[index], op);
            var nextExpression = currentExpression + (index > 0 ? " " + op + " " : "") + numbers[index];
            var result = GenerateExpressionHelper(numbers, index + 1, nextExpression, nextTotal);

            if (result != "")
            {
                return result;
            }
        }

        // Si ninguno de los operadores produce una solución, retornamos una cadena vacía.
        return "";
    }

    private int ComputeNextTotal(int currentTotal, int number, string op)
    {
        // Calcula el total acumulado hasta ahora aplicando el operador correspondiente.
        switch (op)
        {
            case "+":
                return currentTotal + number;
            case "-":
                return currentTotal - number;
            case "*":
                return currentTotal * number;
            default:
                throw new ArgumentException("Operator not supported.");
        }
    }

}
