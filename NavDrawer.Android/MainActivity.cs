using Android.App;
using Android.Widget;
using Android.OS;
using NavDrawer.Android.Templates;
using System;
using Android.Content;
using Android.Graphics;
using NavDrawer.Android.Contents.Fragments;
using static Android.Resource;
using Android.Views;
using Android.Webkit;
using Toolbar = Android.Support.V7.Widget;
using Android.Support.V4.Widget;
using Android.Content.PM;
using Android.Support.V4.View;

namespace NavDrawer.Android
{
    [Activity(Label = "NavDrawer.Android", LaunchMode = LaunchMode.SingleTop, Theme = "@style/MyTheme", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : BaseActivity
    {
        private DrawerLayout drawer;
        public static MainActivity Current { get; private set; }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            JoanZapata.XamarinIconify.Iconify
                .with(new JoanZapata.XamarinIconify.Fonts.FontAwesomeModule());
           
            var toolbar = FindViewById<Toolbar.Toolbar>(Resource.Id.refesh_app_bar);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetTitle(Resource.String.ApplicationName);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetDisplayShowHomeEnabled(true);
            SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.ic_menu);
            Current = this;
            this.InitializeEvents();

            //load default home fragment
            if (bundle == null)
            {
                this.ReplaceFragment(new HomeFragment(), "Home");
            }

        }
        protected override int Main_Drawer => Resource.Layout.main_drawer;
        protected override int Navigation_View => Resource.Id.navigation_view;
        protected override int Main_Frame_Layout => Resource.Id.main_frame_layout;
        protected override int Main_Home_Page => Resource.Layout.main_home_page;

        private void InitializeEvents()
        {
            drawer = FindViewById<DrawerLayout>(Resource.Layout.main_drawer);
            this.NavigationView.NavigationItemSelected += (sender, e) =>
              {
                  e.MenuItem.SetChecked(true);
                  switch (e.MenuItem.ItemId)
                  {
                      case Resource.Id.nav_home:
                          this.ReplaceFragment(new HomeFragment(), "Home");
                          break;
                      case Resource.Id.nav_messages:
                          //new fragment
                          break;
                  }
                  this.drawer.CloseDrawer((int)GravityFlags.Start);
              };  
        }
        public override void OnBackPressed()
        {
            if (this.drawer.IsDrawerOpen((int)GravityFlags.Start))
            {
                this.drawer.CloseDrawer((int)GravityFlags.Start);
            }
            else
            {
                if (FragmentManager.BackStackEntryCount != 0)
                {
                    FragmentManager.PopBackStack();

                }
                else
                {
                    base.OnBackPressed();
                }
            }
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.home:
                    this.drawer.OpenDrawer(GravityCompat.Start);
                    return true;              
            }
            return base.OnOptionsItemSelected(item);
        }

    }
}

