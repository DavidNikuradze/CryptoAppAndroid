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
    public class CoinsInfo : ICoinsInfo
    {


        public string Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Internal { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public string Algorithm { get; set; }
        public string ProofType { get; set; }
        public double NetHashesPerSecond { get; set; }
        public int BlockNumber { get; set; }
        public int BlockTime { get; set; }
        public double BlockReward { get; set; }
        public int Type { get; set; }
        public string DocumentType { get; set; }
        
    }

    public class ConversionInfo
    {
        public string Conversion { get; set; }
        public string ConversionSymbol { get; set; }
        public string CurrencyFrom { get; set; }
        public string CurrencyTo { get; set; }
        public string Market { get; set; }
        public double Supply { get; set; }
        public double TotalVolume24H { get; set; }
        public double TotalTopTierVolume24H { get; set; }
        public string SubBase { get; set; }
        public List<string> SubsNeeded { get; set; }
        public List<string> RAW { get; set; }
    }

    public class Datum
    {
        public CoinsInfo CoinInfo { get; set; }
        public ConversionInfo ConversionInfo { get; set; }
    }

    public class RateLimit
    {
    }

    public class RootObject
    {
        public string Message { get; set; }
        public int Type { get; set; }
        public List<Datum> Data { get; set; }
        public RateLimit RateLimit { get; set; }
        public bool HasWarning { get; set; }
    }

}
    
