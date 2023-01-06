using Alura.Estacionamento.Modelos;
using Xunit;

namespace AluraEstacionamento.Testes
{
    public class VeiculoTestes
    {
        [Fact]
        public void TestaVeiculoAcelerar()
        {

            //Padr�o de desenvolvimento AAA

            //Arrange = Prepara o cen�rio para a cria��o de m�todos a serem testados
            var veiculo = new Veiculo();

            //Act = O m�todo que queremos testar
            veiculo.Acelerar(10);

            //Assert = Verificar se os testes foram bem
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestaVeiculoFrear()
        {
            var veiculo = new Veiculo();
            veiculo.Frear(10);
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }
    }
}