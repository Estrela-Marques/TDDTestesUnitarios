using System;
using Xunit;
using NewTalents;


namespace TesteNewTalents
{
    public class UnitTest1
    { 
        public Calculadora construirClasse()
        {
            string data = "09/11/2023";
            Calculadora calc = new Calculadora("09/11/2023");
            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int num1, int num2, int resultado)
        {
            // Arrange
            Calculadora calc = construirClasse();

            // Act
            int resultadoCalculadora = calc.somar(num1, num2);

            // Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void TesteSubtrair(int num1, int num2, int resultado)
        {
            // Arrange
            Calculadora calc = construirClasse();

            // Act
            int resultadoCalculadora = calc.subtrair(num1, num2);

            // Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int num1, int num2, int resultado)
        {
            // Arrange
            Calculadora calc = construirClasse();

            // Act
            int resultadoCalculadora = calc.multiplicar(num1, num2);

            // Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int num1, int num2, int resultado)
        {
            // Arrange
            Calculadora calc = construirClasse();

            // Act
            int resultadoCalculadora = calc.dividir(num1, num2);

            // Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = construirClasse();
            Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirClasse();

            calc.somar(1, 2);
            calc.somar(2, 8);
            calc.somar(3, 7);
            calc.somar(4, 1);

            var lista = calc.historico();

            Assert.NotEmpty(calc.historico());
            Assert.Equal(3, lista.Count);
        }
    }
}