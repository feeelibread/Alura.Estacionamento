using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using Xunit;

namespace AluraEstacionamento.Testes
{
    public class VeiculoTestes
    {
        [Fact]
        public void TestaVeiculoAcelerar()
        {

            //Padrão de desenvolvimento AAA

            //Arrange = Prepara o cenário para a criação de métodos a serem testados
            var veiculo = new Veiculo();

            //Act = O método que queremos testar
            veiculo.Acelerar(10);

            //Assert = Verificar se os testes foram bem
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestaVeiculoFrear()
        {   
            //Arrange
            var veiculo = new Veiculo();

            //Act
            veiculo.Frear(10);

            //Assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestaVeiculoTipo()
        {
            //Arrange
            var veiculo = new Veiculo();

            //Act

            //Assert
            Assert.Equal(TipoVeiculo.Automovel, veiculo.Tipo);
        }
    }
}