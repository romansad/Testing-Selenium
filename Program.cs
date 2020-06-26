using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SELENIUMTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://vpsamvc.azurewebsites.net");
            webDriver.Navigate().GoToUrl("https://vpsamvc.azurewebsites.net/Account/Login");
            //login insert user
            webDriver.FindElement(By.Id("Legajo")).SendKeys("202003");
            //login insert Pass
            webDriver.FindElement(By.Id("Password")).SendKeys("Vpsa$11");
            //login Click 
            webDriver.FindElement(By.ClassName("btn")).Submit();
        
            //Carga de Trabajos en Denuncia.
            webDriver.Navigate().GoToUrl("https://vpsamvc.azurewebsites.net/Denuncias/Details/1");
            //Agregar Trabajo
           webDriver.FindElement(By.ClassName("btn-info")).Click();
            //Carga de texto de Trabajo 
            Thread.Sleep(2000);
            webDriver.FindElement(By.TagName("textarea")).SendKeys("Testing Automatizado Carga de Trabajo de Prueba");
            //Empleado
            SelectElement selector = new SelectElement(webDriver.FindElement(By.Name("UserId")));
            selector.SelectByIndex(3);
            
            //"Estado Denuncia"
                SelectElement selector2 = new SelectElement(webDriver.FindElement(By.Name("EstadoDenunciaId")));
            selector2.SelectByIndex(2);

            //  Guardar "SaveButton"
                webDriver.FindElement(By.Id("SaveButton")).Click();


        }

    }
    }

