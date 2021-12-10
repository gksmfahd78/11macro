using System;
using System.Net;

using OpenQA.Selenium.Chrome;


namespace macro
{
    class Cookie
    {
        public CookieCollection getCookie(ChromeDriver driver)
        {
            CookieCollection cookieCollection = new CookieCollection();
            foreach(OpenQA.Selenium.Cookie qsc in driver.Manage().Cookies.AllCookies)
            {
                System.Net.Cookie cookie = new System.Net.Cookie();
                cookie.Name = qsc.Name;
                cookie.Value = qsc.Value;
                cookie.Domain = qsc.Domain;
                cookieCollection.Add(cookie);
            }

            return cookieCollection;
        }
    }
}
