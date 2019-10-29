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

namespace CryptoComparePCL.Interface.Model
{
    public interface ICrypto
    {
        double USD { get; set; }
        double JPY { get; set; }
        double EUR { get; set; }
        double GEL { get; set; }
        double RUB { get; set; }


        int picture { get; set; }
        string CryptoNLong { get; set; }
        string CryptoNShort { get; set; }
    }
}