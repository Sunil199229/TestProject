using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dynamicField.Views
{
    sealed public class BaseClaas
    {
       public BaseClaas()
        {
            int aa = 10;
        }

        static BaseClaas()
        {
            int aaa = 10;
        }

        public BaseClaas(int a)
        {
            int aaaa = 10;
        }
    }

    public class deriverdClass 
    {
        public deriverdClass()
        {
            int b = 10;
        }

        static deriverdClass()
        {
            int a = 10;           
        }

        public deriverdClass(int a1)
        {
            BaseClaas b11 = new BaseClaas(5);
        }

        
    }
}