﻿using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using Toasts.Forms.Plugin.Droid;

using ReactiveUI;

using TelephonySampleApp.Core;

namespace TelephonySampleApp.Droid
{
    [Activity(Label = "Telephony", Icon = "@drawable/icon_white", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsApplicationActivity
    {
        public MainActivity()
        {
            Console.WriteLine("Start");
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Forms.Init(this, bundle);
            ToastNotificatorImplementation.Init(); 
            

            var mainPage = RxApp.SuspensionHost.GetAppState<AppBootstrapper>().CreateMainPage();
            this.SetPage(mainPage);
        }
    }
}