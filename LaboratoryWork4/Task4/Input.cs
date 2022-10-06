using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Input:ApplicationLicense
    {
        private string accessKey1;
        private string accessKey2;
        private ApplicationLicense applicationLicense=new ApplicationLicense();
        public Input(string accessKey1, string accessKey2)
        {

            this.accessKey1 = accessKey1;
            this.accessKey2 = accessKey2;
        }
        public void DefineAccessWithOneKey()
        {
            if (String.IsNullOrEmpty(accessKey1))
            {
                if (accessKey2.Length <= 5)
                {
                    applicationLicense.AllowTrial();
                }
                else
                {
                    applicationLicense.AllowPro();
                }
            }
            else if (String.IsNullOrEmpty(accessKey2))
            {
                if (accessKey1.Length <= 5)
                {
                    applicationLicense.AllowTrial();
                }
                else
                {
                    applicationLicense.AllowPro();
                }
            }
        }
        public void DefineAccess()
        {
            if (String.IsNullOrEmpty(accessKey1) && String.IsNullOrEmpty(accessKey2))
            {
                applicationLicense.AllowCommon();
            }
            else
            {
                if (!String.IsNullOrEmpty(accessKey1) && !String.IsNullOrEmpty(accessKey2))
                {
                    if (Int32.Parse(accessKey1) != 0 && Int32.Parse(accessKey2) != 0)
                    {
                        if ((accessKey1.Length <= 5 && accessKey2.Length > 5 && accessKey2.Length <= 10) || (accessKey2.Length <= 5 && accessKey1.Length > 5 && accessKey1.Length <= 10))
                        {
                            Console.WriteLine("Everything is avaible to you");
                        }
                        else
                        {
                            DefineAccessWithOneKey();
                        }
                    }

                    else
                    {
                        Console.WriteLine("The access key number cannot be null");
                    }
                }

                else
                {
                    DefineAccessWithOneKey();
                }
            }
        }
    }
}
