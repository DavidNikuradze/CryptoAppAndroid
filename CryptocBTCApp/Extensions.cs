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
using FFImageLoading;
using FFImageLoading.Views;

namespace App24
{
   public static class Extensions
    {
        public static void LoadImage(this ImageViewAsync imageView, string url, bool smallPlaceholder = true)
        {
            ImageService.Instance
                .LoadUrl(url)
                .LoadingPlaceholder((!smallPlaceholder) ? "placeholderLarge" : "placeholderMinix", FFImageLoading.Work.ImageSource.CompiledResource)
                .ErrorPlaceholder((!smallPlaceholder) ? "placeholderLarge" : "placeholderMinix", FFImageLoading.Work.ImageSource.CompiledResource)
                .WithCache(FFImageLoading.Cache.CacheType.Disk)
                .DownSample(imageView.Width, imageView.Height, false)
                .DownSampleMode(FFImageLoading.Work.InterpolationMode.High)
                .CacheKey(url)
                .IntoAsync(imageView);
        }
    }
}