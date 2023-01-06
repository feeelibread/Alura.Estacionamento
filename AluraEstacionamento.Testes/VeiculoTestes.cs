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
            var veiculo = new Veiculo();
            veiculo.Frear(10);
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }
    }
}