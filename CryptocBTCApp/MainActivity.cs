using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content.PM;
using System.Collections.Generic;
using CryptoComparePCL.Interface.Model;
using CryptoComparePCL.Classes;
using CryptoComparePCL.Classes.Model;
using System.Reflection;
using CryptocBTCApp.Adapters;
using Android.Support.V7.Widget;
using static Android.Support.V7.Widget.RecyclerView;

namespace CryptocBTCApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/Theme.AppCompat.Light.NoActionBar", MainLauncher = true, ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : AppCompatActivity
    {



        CryptoComparePCL.Classes.Model.RootObject coins { get; set; }
        CryptoComparePCL.Classes.Model.Crypto co { get; set; }






        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            var coin = await GetJsonObject.GetCrypto(Valute: " ", Crypto: " ");





            //RecyclerCrypto Adapter = new RecyclerCrypto(coin.Data);
            //RecyclerView recycler = FindViewById<RecyclerView>(Resource.Id.recyclerView1);
            //recycler.SetLayoutManager(new LinearLayoutManager(this));
            //recycler.SetAdapter(Adapter);



        }
      



    }
}