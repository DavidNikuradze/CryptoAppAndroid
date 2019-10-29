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
using CryptocBTCApp.ViewHolder;
using CryptoComparePCL.Classes.Model;

namespace CryptocBTCApp.Adapters
{
    public class ReacyclerViewUSD : RecyclerView.Adapter
    {

         List<CryptoComparePCL.Classes.Model.Crypto> coinsInfos;


        public ReacyclerViewUSD(List<CryptoComparePCL.Classes.Model.Crypto> coins)
        {

            this.coinsInfos = coins;


        }

        public ReacyclerViewUSD(List<Datum> data)
        {
        }

        public override int ItemCount => coinsInfos.Count;





        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var coin = coinsInfos.ElementAt(position);

            ItemsView CoinsInf = holder as ItemsView;

            CoinsInf.CryptoPriceUSD.Text = coin.USD.ToString();

            
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var layoutResult = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.CardCoinsINFO, parent, false);
            var holder = new ItemsView(layoutResult);
            return holder;
        }
    }
}