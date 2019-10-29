using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CryptoComparePCL.Classes.Model;
using CryptoComparePCL.Interface.Model;
using Newtonsoft.Json;

namespace CryptoComparePCL.Classes
{
    public static class GetJsonObject
    {
     
        public static async Task<Crypto> GetCrypto(string Valute, string Crypto)
        {
            using (HttpClient http = new HttpClient())
            {
                string json = await http.GetStringAsync($"https://min-api.cryptocompare.com/data/price?fsym={Crypto}&tsyms={Valute}");
                
                return await Task.Run(() => JsonConvert.DeserializeObject<Crypto>(json));
            }
        }

        //public static async Task<RootObject> GetCryptos(String USD)
        //{
        //    using (HttpClient http = new HttpClient())
        //    {
        //        string jJson = await http.GetStringAsync($"https://min-api.cryptocompare.com/data/price?fsym=BTC&tsyms=USD,EUR&e=Coinbase&extraParams=USD");

        //        return await Task.Run(() => JsonConvert.DeserializeObject<RootObject>(jJson));

        //    }

        //}



    }
}