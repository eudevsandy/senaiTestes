using Projeto_teste;

namespace TestXunity
{
    public class UnitTest1
    {
        private object SomaDoisNumeros;

        [Fact]
        public void SomarDoisNumeros()
        {
            //Arrange - Preparacao
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //Act - ação
            var resultado = Operacoes.Somar(pNum, sNum);

            Assert.Equal(rNum, resultado);


        }
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2,2,4)]
        [InlineData(3,2,5)]
        [InlineData(1,1,2)]
        [InlineData(1,1,2)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //act - ação
            var resultado = Operacoes.Somar(pNum, sNum);
            Assert.Equal(rNum, resultado);


        }
        [Fact]
        public void SubtrairDoisNumeros()
        {
            double pNum = 2;
            double sNum = 1;
            double rNum = 1;
            //act

            var resultado = Operacoes.Subtrair(pNum, sNum);
            //Assert
            Assert.Equal(rNum, resultado);
        }
        [Theory]
        [InlineData(2,1,1)]
        [InlineData(5,2,3)]
        [InlineData(3, 1, 2)]
        public void SubtrairDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            var resultado = Operacoes.Subtrair(pNum, sNum);
            //Assert
            Assert.Equal(rNum, resultado);
        }


    }
}