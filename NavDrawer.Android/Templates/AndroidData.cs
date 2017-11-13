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
using Xamarin.Forms;
using Android.Content.PM;
using AndroidContext = Android.App;
namespace NavDrawer.Android.Templates
{
    public class AndroidData
    {
        static AndroidInfo AndroidInfo = new AndroidInfo();
        public static void SaveSetting(string key, string value)
        {
            var prefs = AndroidContext.Application.Context.GetSharedPreferences(AndroidInfo.ApplicationName.Trim(), FileCreationMode.Private);
            var prefEditor = prefs.Edit();
            prefEditor.PutString(key, value);
            prefEditor.Commit();
        }
        public static string GetSetting(string key, string defValue = null)
        {
            var prefs = AndroidContext.Application.Context.GetSharedPreferences(AndroidInfo.ApplicationName.Trim(), FileCreationMode.Private);
            var settingValue = prefs.GetString(key, defValue);
            return settingValue;
        }

    }
}