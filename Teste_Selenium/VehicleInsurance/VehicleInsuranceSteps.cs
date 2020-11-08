using TechTalk.SpecFlow;
using Teste_Selenium.Config;
using Xunit;

namespace Teste_Selenium.VehicleInsurance
{
    [Binding]
    public class VehicleInsuranceSteps
    {
        private readonly SeleniumHelper BrowserHelper;
        private readonly VehicleInsurancePage telaVeiculoSeguro;

        public VehicleInsuranceSteps()
        {
            BrowserHelper = new SeleniumHelper(Browser.Chrome, false);
            telaVeiculoSeguro = new VehicleInsurancePage(BrowserHelper);
        }

        [Given(@"o usuário esteja na página inicial de solicitação do seguro")]
        public void GivenOUsuarioEstejaNaPaginaInicialDeSolicitacaoDoSeguro()
        {
            telaVeiculoSeguro.AcessarPaginaSeguroCarro();

            Assert.True(telaVeiculoSeguro.VerificarAcessoPaginaInicial("Enter Vehicle Data"));

        }

        [Given(@"o usuário preenche informações referentes em cada aba")]
        public void GivenOUsuarioPreencheInformacoesReferentesEmCadaAba()
        {
            telaVeiculoSeguro.PreencherDadosVeiculo();
            telaVeiculoSeguro.IrParaAbaInsuranceData();

            telaVeiculoSeguro.PreencherInsurantData();
            telaVeiculoSeguro.IrParaAbaProductData();

            telaVeiculoSeguro.PreencherProductData();
            telaVeiculoSeguro.IrParaAbaPriceOption();

            telaVeiculoSeguro.EscolherPreco();
            telaVeiculoSeguro.IrParaAbaSendQuote();



        }

        [When(@"o usuário pressionar o botão de enviar")]
        public void WhenOUsuarioPressionarOBotaoDeEnviar()
        {
            telaVeiculoSeguro.EnviarEmail();
        }

        [Then(@"o usuário receberá uma mensagem de sucesso")]
        public void ThenOUsuarioReceberaUmaMensagemDeSucesso()
        {
            var mensagemCorreta = telaVeiculoSeguro.VerificarMensagemSucesso();

            Assert.True(mensagemCorreta, "mensagem não contem string especificada");
        }

    }
}
