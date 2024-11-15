using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void Resultado()
    {
        int resultado = _calc.Somar(4,5);

        Assert.Equal(9, resultado);
    }
   [Fact]
    public void DeveSomar10Com10eRetornar20()
    {
         //Arrange

         int num1 = 10;
         int num2 = 10;

         //Act

         int resultado = _calc.Somar(num1, num2);
         //Assert
         Assert.Equal(20, resultado);
    }

       [Fact]
    public void DeveVerificarSe4EhPar()
    {
         //Arrange
         int num = 4;

         //Act

        bool resultado = _calc.EhPar(num);
         //Assert
         Assert.True(resultado);

         
    }

    [Theory]
[InlineData(2)]
[InlineData(4)]
[InlineData(6)]

        public void DeveVerificarSeElesSaoPares(int numero)
        {
            //Act
       bool resultado = _calc.EhPar(numero);

            //assert
            Assert.True(resultado);
        }

        
    [Theory]
[InlineData(new int [] {8, 10, 12})]
        public void DeveVerificarSeSaoPares(int[] numeros)
        {
            //Act
    foreach (var item in numeros)
    {

            //assert;
          Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
        }
}