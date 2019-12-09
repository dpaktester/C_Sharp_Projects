using System;

using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using VeevaCRMAutomationPOM.Base;


namespace VeevaCRMAutomationPOM.Extensions
{
    public static class WebElementExtensions
    {
        public static SelectElement ddl1;
        //To Get a Drop-Down Value selected from UI
        public static string GetSelectedDropDown(this IWebElement element)
        {
             ddl1 = new SelectElement(element);
            return ddl1.AllSelectedOptions.First().ToString();
        }

        

        //To Get a Drop-Down One by one Value selected from UI
        public static void GetSelectedDropDownOneByOne(this IWebElement element)
        {
            IList<string> temp = new List<string>();
             ddl1 = new SelectElement(element);

            IList<IWebElement> oSize = ddl1.Options;
            int iListSize = oSize.Count;
            for (int i = 0; i < iListSize; i++)
            {
                // Storing the value of the option	
                string sValue = ddl1.Options.ElementAt(i).Text;
                temp.Add(sValue);
            }
            //string options_in_Drop_Down = "";
            for (int i = 0; i < temp.Count; i++)
            {
                //ddl1.Options.ElementAt(i);  
                // DriverContext.Driver.WaitForPageLoaded();
                DriverContext.Driver.SwitchTo().DefaultContent();
                DriverContext.Driver.SwitchTo().Frame("itarget");
                ddl1.SelectByText(temp[i]);
            }

           /*  ddl1 = new SelectElement(element);
            int size = ddl1.Options.Count;
            for (int i = 0; i < size; i++)
            {
                DriverContext.Driver.WaitForPageLoaded();
                ddl1.SelectByIndex(i);
                 DriverContext.Driver.WaitForPageLoaded();
            }*/
        }
       /* public static void GetSelectedDropDowns(this IWebElement element)
        {
             ddl1 = new SelectElement(element);
            int options = ddl1.Options.Count;
            
            for (int i = 0; i < options; i++)
            {
                ddl1.SelectByIndex(i);
            }
        }*/



        //To Get All the Selected Dropdown list from UI
        public static IList<string> GetSelectedListOptions(this IWebElement element)
        {
            IList<string> temp = new List<string>();
             ddl1 = new SelectElement(element);
          
            IList<IWebElement> oSize = ddl1.Options;

            int iListSize = oSize.Count;
            // Setting up the loop to print all the options
            for (int i = 0; i < iListSize; i++)
            {
                // Storing the value of the option	
                string sValue = ddl1.Options.ElementAt(i).Text;
                temp.Add(sValue);
            }
                return temp;
        }

        //Hovering over a particular element
        public static void Hover(IWebElement element)
        {
            Actions action = new Actions(DriverContext.Driver);
            action.MoveToElement(element).Perform();
        }

        //Select Drop Down List from UI
        public static void SelectDropDownList(this IWebElement element, string Index)
        {
            SelectElement ddl = new SelectElement(element);
            ddl.SelectByText(Index);
        }

        //Select Drop Down List from UI
        public static void SelectDropDownList1(this IWebElement element, int Index)
        {
            SelectElement ddl = new SelectElement(element);
            ddl.SelectByIndex(Index);
        }
        public static void SelectDropDownList1byText(this IWebElement element, string value)
        {
            SelectElement ddl = new SelectElement(element);
            ddl.SelectByText(value);
        }


        //To Verify selected element is Present or not
        public static void AssertElementPresent(this IWebElement element)
        {
            if (!IsElementPresnet(element))
            {
                throw new System.Exception(string.Format("Element Not Present Exception"));
            }
        }

        //Content of the method created in AssertElementPresent Method
        private static bool IsElementPresnet(IWebElement element)
        {
            try
            {
                bool ele = element.Displayed;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
