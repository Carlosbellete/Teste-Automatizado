using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    public class Begin
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://buscacepinter.correios.com.br/app/endereco/index.php");
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void FimDeTeste()
        {

        }
    }
}