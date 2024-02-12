using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CaculadoraImp _calc;

    public CalculadoraTestes()
    {
        _calc = new CaculadoraImp();
    }

    [Fact]
    public void Devesomar5com10ERetornar15()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(15, resultado);
        


    }
}