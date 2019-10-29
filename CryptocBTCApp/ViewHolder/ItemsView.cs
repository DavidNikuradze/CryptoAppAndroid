using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using FFImageLoading.Views;

namespace CryptocBTCApp.ViewHolder
{
    public class ItemsView : RecyclerView.ViewHolder
    {
        public ImageView ImageIcon { get; set; }
        public TextView CryptoNLong { get; set; }
        public TextView CryptoNShort { get; set; }
        public TextView CryptoPriceUSD { get; set; }
        public TextView CryptoPriceBTC { get; set; }




        public ItemsView(View view) : base (view)
        {
            ImageIcon = view.FindViewById<ImageView>(Resource.Id.CryptoIconView);

            CryptoNLong = view.FindViewById<TextView>(Resource.Id.CryptoNameLong);
            
            CryptoNShort = view.FindViewById<TextView>(Resource.Id.CryptoNameShort);

            CryptoPriceUSD = view.FindViewById<TextView>(Resource.Id.PriceCryptoToUSD);

            CryptoPriceBTC = view.FindViewById<TextView>(Resource.Id.PriceUSDtoCrypto);
        }
    }

    
}