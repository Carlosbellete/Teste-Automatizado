using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    class BuscaCep : Begin
    {
        [Test]
        public void Test1()
        {
            driver.FindElement(By.Id("endereco")).SendKeys("58415285");
        }
    }
}
