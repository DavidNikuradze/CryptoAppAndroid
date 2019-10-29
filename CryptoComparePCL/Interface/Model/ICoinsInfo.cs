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
    public interface ICoinsInfo
    {
         string Id { get; set; }
         string Name { get; set; }
         string FullName { get; set; }
         string Internal { get; set; }
         string ImageUrl { get; set; }
         string Url { get; set; }
         string Algorithm { get; set; }
         string ProofType { get; set; }
         double NetHashesPerSecond { get; set; }
         int BlockNumber { get; set; }
         int BlockTime { get; set; }
         double BlockReward { get; set; }
         int Type { get; set; }
         string DocumentType { get; set; }
    }
}