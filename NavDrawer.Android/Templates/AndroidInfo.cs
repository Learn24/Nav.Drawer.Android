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
using Android.Net;
using System.Threading.Tasks;
using Android.Telephony;
using Xamarin.Forms;

namespace NavDrawer.Android.Templates
{
    public class AndroidInfo 
    {
       
        private static bool IsNetworkAvailable()
        {
            bool isNetworkActive;// = false;
            Context context = Xamarin.Forms.Forms.Context;//get the current application context
            ConnectivityManager cm = (ConnectivityManager)context.GetSystemService(Context.ConnectivityService);
            NetworkInfo activeConnection = cm.ActiveNetworkInfo;
            isNetworkActive = (activeConnection != null) && activeConnection.IsConnected;
            return isNetworkActive;
        }

        #region SystemInfo
        public bool IsInternetAvailble
        {
            get { return IsNetworkAvailable(); }
        }
        public  string SystemFamily
        {
            get
            {
                string deviceType = "Mobile";
                var context = Forms.Context;
                var manager = context.GetSystemService(Context.TelephonyService)
                       as TelephonyManager;

                if (manager == null)
                {
                    deviceType = "Unknown";
                }
                else if (manager.PhoneType == PhoneType.None)
                {
                    deviceType = "Tablet";
                }
                else
                {
                    deviceType = "Mobile";
                }
                return deviceType;
            }
        }
        public string SystemVersion
        {
            get
            {
                return Build.VERSION.Release;
            }
        }
        public string SystemArchitecture { get { return Build.CpuAbi; } }
        public string ApplicationName
        {
            get
            {
                var context = Forms.Context;
                return context.PackageManager.GetPackageInfo(context.PackageName, 0).PackageName;
            }
        }
        public string ApplicationVersion
        {
            get
            {
                var context = Forms.Context;
                return context.PackageManager.GetPackageInfo(context.PackageName, 0).VersionName;
            }
        }
        public string DeviceManufacturer
        {
            get
            {
                return Build.Manufacturer;
            }
        }
        public string DeviceModel { get { return Build.Model; } }
        public string DeviceType
        {
            get
            {
                string deviceType = "Mobile";
                var context = Forms.Context;
                var manager = context.GetSystemService(Context.TelephonyService)
                       as TelephonyManager;
                if (manager == null)
                {
                    deviceType = "Unknown";
                }
                else if (manager.PhoneType == PhoneType.None)
                {
                    deviceType = "Tablet";
                }
                else
                {
                    deviceType = "Mobile";
                }
                return deviceType;
            }
        }
        public string FreeSpace()
        {
            var activityManager = (ActivityManager)Forms.Context.GetSystemService(Context.ActivityService);
            ActivityManager.MemoryInfo memInfo = new ActivityManager.MemoryInfo();
            activityManager.GetMemoryInfo(memInfo);
            var free = (memInfo.AvailMem / 1024 / 1024);
            return free.ToString();
        } 
        #endregion
    }
}