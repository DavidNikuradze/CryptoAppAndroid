using System.Collections.Generic;
using System.Linq;
using Android.Support.V7.Widget;
using Android.Views;
using CryptocBTCApp.ViewHolder;
using App24;
using CryptoComparePCL.Classes.Model;
using FFImageLoading;

namespace CryptocBTCApp.Adapters
{
    public class RecyclerCrypto : RecyclerView.Adapter
    {

      private  List<CryptoComparePCL.Classes.Model.Datum> data;

        private List<CryptoComparePCL.Classes.Model.Crypto> coinsInfos;
        private List<CryptoComparePCL.Classes.Model.Crypto> coinsInfo;

        public RecyclerCrypto(List<Datum> data)
        {
            this.data = data;
        }

        public RecyclerCrypto(List<CryptoComparePCL.Classes.Model.Datum> Data, List<CryptoComparePCL.Classes.Model.Crypto> CoinsInfos)
        {

            this.data = Data;
            this.coinsInfos = CoinsInfos;

           
            
        }
        


        public override int ItemCount => data.Count;

       

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            
            var elem = data.ElementAt(position);
            var coins = coinsInfo.ElementAt(position);


            ItemsView IV = holder as ItemsView;

            IV.CryptoPriceUSD.Text = coins.USD.ToString();
            ImageService.Instance.Initialize();
            IV.CryptoNLong.Text = elem.CoinInfo.FullName;
            IV.CryptoNShort.Text = elem.CoinInfo.Name;



            FFImageLoading.ImageService.Instance.LoadUrl("http://www.cryptocompare.com" + elem.CoinInfo.ImageUrl).Error(ex =>
            {

                System.Console.WriteLine(ex.Message);
            }).Into(IV.ImageIcon);



        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            

            var layoutResult = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.CardCoinsINFO, parent, false);
            var holder = new ItemsView(layoutResult);
            return holder;
        }
    }
}