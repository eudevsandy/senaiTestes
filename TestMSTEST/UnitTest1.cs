using Projeto_teste;

namespace TestMSTEST
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void somarDoisNumeros()
        {
            //Arrange - Preparação
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //Act - Ação do teste
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - Verificação do teste
            Assert.AreEqual(rNum, resultado);

        }
        [DataTestMethod]
        [DataRow(1,1,2)]
        [DataRow(2,2,4)]
        [DataRow (1,1,2)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //act - ação
            var resultado = Operacoes.Somar(pNum, sNum);

            //assert - verificar

            Assert.AreEqual (rNum, resultado);
        }

        [TestMethod]
        public void SubtrairDoisNumero()
        {
            //arrange
            double pNum = 1;
            double sNum = 2;
            double rNum = 1;

            //act - ação
            var resultado = Operacoes.Subtrair(pNum, sNum);

            //Assert - verificar

            Assert.AreEqual(rNum, resultado);
        }
        [DataTestMethod]
        [DataRow (5,2,3)]
        [DataRow (2,1,1)]
        [DataRow(2,5,-3)]
        [DataRow(3,3,0)]
        [DataRow(10,4,6)]
        public void SubtrairDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //act
            var resultado = Operacoes.Subtrair(pNum, sNum);

            //Assert - Verificando

            Assert.AreEqual(rNum, resultado);
        }
    }
}