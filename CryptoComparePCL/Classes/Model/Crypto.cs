using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CryptoComparePCL.Interface.Model;


namespace CryptoComparePCL.Classes.Model
{
    public class Crypto : ICrypto
    {
        public double USD { get; set; }
        public double JPY { get; set; }
        public double EUR { get; set; }
        public double GEL { get; set; }
        public double RUB { get; set; }


        public int picture { get; set; }
        public string CryptoNLong { get; set; }
        public string CryptoNShort { get; set; }
        public List<Datum> Data { get; set; }

    }
 
    public class CryproRoot
    {
        public double USD { get; set; }
        public double EUR { get; set; }
    }
}