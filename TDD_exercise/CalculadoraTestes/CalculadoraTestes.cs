using System.ComponentModel;
using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    public CalculadoraImp _calc;
    public CalculadoraTestes()
    {
        _calc= new CalculadoraImp();
    }
    [Fact]
    void Somar10com5eSomar15()
    {
      int num1 = 10;
      int num2 = 5;

      int resultado = _calc.Somar(num1, num2);
      Assert.Equal(15,resultado);

    [Fact]
    void Subtrair10por5eResultar5()
    {
      int num1 = 10;
      int num2 = 5;

      int resultado = _calc.Subtrair(num1, num2);
      Assert.Equal(5,resultado);
    }

    [Fact]
    void Multiplicar10por5eResultar50()
    {
      int num1 = 10;
      int num2 = 5;

      int resultado = _calc.Multiplicar(num1, num2);
      Assert.Equal(50,resultado);
    }

    [Fact]
    void Dividir10por5eResultar2()
    {
      int num1 = 10;
      int num2 = 5;

      int resultado = _calc.Dividir(num1, num2);
      Assert.Equal(2,resultado);
    }
    void TestarDividirPorZero()
    {
      int num1 = 10;
      int num2 = 0;

      int resultado = _calc.Dividir(num1, num2);
      Assert.Throws<DivideByZeroException>(()=>resultado);
    }

    void TestarHistorico()
    {
      int num1 = 10;
      int num2 = 0;
      var lista = _calc.Historico();

      Assert.NotEmpty(lista);
      Assert.Equal(3,lista.Count); 
    }

    }
}