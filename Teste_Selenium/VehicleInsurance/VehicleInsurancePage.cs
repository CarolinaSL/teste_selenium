using Teste_Selenium.Config;

namespace Teste_Selenium.VehicleInsurance
{
    public class VehicleInsurancePage : PageObjectModel
    {
        public VehicleInsurancePage(SeleniumHelper helper) : base(helper) { }

        public void AcessarPaginaSeguroCarro()
        {
            Helper.IrParaUrl("http://sampleapp.tricentis.com/101/app.php");
        }

        public bool VerificarAcessoPaginaInicial(string textoEsperado)
        {
            var textoRecebido = Helper.ObterTextoElementoPorId("entervehicledata");
            if (textoRecebido.Contains(textoEsperado)) return true;

            return false;
        }

        public bool VerificarAcessoAba(string textoEsperado, string id)
        {
            var textoRecebido = Helper.ObterTextoElementoPorId("enterinsurantdata");
            if (textoRecebido.Contains(textoEsperado)) return true;

            return false;
        }

        public void PreencherDadosVeiculo()
        {
            Helper.PreencherDropDownPorId("make", "Honda");
            Helper.PreencherDropDownPorId("model", "Scooter");
            Helper.PreencherTextBoxPorId("cylindercapacity", "1000");
            Helper.PreencherTextBoxPorId("engineperformance", "1000");
            Helper.PreencherTextBoxPorId("dateofmanufacture", "01/01/2010");
            Helper.PreencherDropDownPorId("numberofseats", "3");
            Helper.PreencherDropDownPorId("fuel", "Petrol");
            Helper.PreencherTextBoxPorId("payload", "300");
            Helper.PreencherTextBoxPorId("totalweight", "500");
            Helper.PreencherTextBoxPorId("listprice", "30000");
            Helper.PreencherTextBoxPorId("annualmileage", "20000");
        }

        public void PreencherInsurantData()
        {
            Helper.PreencherTextBoxPorId("firstname", "Carolina");
            Helper.PreencherTextBoxPorId("lastname", "Louzada");
            Helper.PreencherTextBoxPorId("birthdate", "03/05/1995");

            Helper.PreencherDropDownPorId("country", "Brazil");

            Helper.PreencherTextBoxPorId("zipcode", "49095220");

            Helper.PreencherDropDownPorId("occupation", "Employee");

            Helper.ClicarPorIdComAction("other");

        }

        public void PreencherProductData()
        {
            Helper.PreencherTextBoxPorId("startdate", "01/01/2021");

            Helper.PreencherDropDownPorId("insurancesum", "3000000");
            Helper.PreencherDropDownPorId("meritrating", "Bonus 2");
            Helper.PreencherDropDownPorId("damageinsurance", "Partial Coverage");

            Helper.ClicarPorIdComAction("EuroProtection");

            Helper.PreencherDropDownPorId("courtesycar", "Yes");


        }

        public void PreencherQuote()
        {
            Helper.PreencherTextBoxPorId("email", "mawik67278@tawtar.com");
            Helper.PreencherTextBoxPorId("username", "usernameTeste");
            Helper.PreencherTextBoxPorId("password", "Teste123");
            Helper.PreencherTextBoxPorId("confirmpassword", "Teste123");

        }
        public void EnviarEmail()
        {
            Helper.ClicarBotaoPorId("sendemail");
        }

        public bool VerificarMensagemSucesso()
        {
            var texto = Helper.ObterTextoPorXPath("/html/body/div[4]/h2");

            if (texto.Contains("sucess")) return true;

            Helper.ClicarPorXPath("/html/body/div[4]/div[7]/div/button");

            return false;
        }

        public void EscolherPreco()
        {
            Helper.ClicarPorIdComAction("selectgold");
        }

        public void IrParaAbaInsuranceData()
        {
            Helper.ClicarBotaoPorId("nextenterinsurantdata");
        }
        public void IrParaAbaProductData()
        {
            Helper.ClicarBotaoPorId("nextenterproductdata");
        }

        public void IrParaAbaPriceOption()
        {
            Helper.ClicarBotaoPorId("nextselectpriceoption");

        }

        public void IrParaAbaSendQuote()
        {
            Helper.ClicarBotaoPorId("nextsendquote");

        }

    }
}
