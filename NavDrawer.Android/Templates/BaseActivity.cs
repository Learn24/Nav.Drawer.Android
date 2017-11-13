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
using Android.Support.V4.Widget;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget;
using NavDrawer.Android.Contents.Fragments;
using Xamarin.Forms;
using Android.Webkit;
using XamarinContext = Xamarin.Forms;
using Android.Support.V4.View;
using graphics = Android.Graphics;
using JoanZapata.XamarinIconify.Fonts;

namespace NavDrawer.Android.Templates
{
    public abstract class BaseActivity : AppCompatActivity
    {
        public DrawerLayout DrawerLayout;
        public FrameLayout FrameLayout;
        public NavigationView NavigationView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Main_Drawer);
            FindViewIds();
        }
        private void FindViewIds()
        {
            this.DrawerLayout = FindViewById<DrawerLayout>(Resource.Layout.main_drawer);
            this.NavigationView = FindViewById<NavigationView>(Navigation_View);
            this.FrameLayout = FindViewById<FrameLayout>(Main_Frame_Layout);

        }
              
        protected abstract int Main_Drawer { get; }
        protected abstract int Navigation_View { get; }
        protected abstract int Main_Frame_Layout { get; }
        protected abstract int Main_Home_Page { get; }
        
        public void ReplaceFragment(Fragment new_fragment, string title)
        {
            if (new_fragment == null)
                return;
            this.Title = title;
            FragmentTransaction fragmentTx = this.FragmentManager.BeginTransaction();
            fragmentTx.Replace(Resource.Id.main_frame_layout, new_fragment);
            fragmentTx.Commit();
            
        }
        //Override
        //to avoid direct app exit on backpreesed and to show fragment from stack
       
        public override bool OnPrepareOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.main_menu, menu);
            if (menu != null)
            {
                var home = new JoanZapata.XamarinIconify.IconDrawable(this, JoanZapata.XamarinIconify.Fonts.FontAwesomeIcons.fa_refresh.ToString()).color(graphics.Color.Red);
                home.sizeDp(25);
                menu.FindItem(Resource.Id.nav_home).SetVisible(true).SetIcon(home);
                //menu.FindItem(Resource.Id.nav_messages).SetFontIcon(this, FontAwesomeIcons.fa_comment, new RandomColor().ColorDark);
                //menu.FindItem(Resource.Id.nav_friends).SetFontIcon(this, FontAwesomeIcons.fa_users, new RandomColor().ColorDark);
                //menu.FindItem(Resource.Id.nav_discussion).SetFontIcon(this, FontAwesomeIcons.fa_wechat, new RandomColor().ColorDark);
                ////Subitems
                //menu.FindItem(Resource.Id.nav_store).SetFontIcon(this, FontAwesomeIcons.fa_shopping_cart, graphics.Color.Gray);
                //menu.FindItem(Resource.Id.nav_settings).SetFontIcon(this, FontAwesomeIcons.fa_cog, graphics.Color.Gray);
                //menu.FindItem(Resource.Id.nav_about).SetFontIcon(this, FontAwesomeIcons.fa_info, graphics.Color.Gray);
            }
            return base.OnPrepareOptionsMenu(menu);
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.main_action_menu, menu);
            MenuInflater.Inflate(Resource.Menu.main_menu, menu);
            if (menu != null)
            {
                var icon = new JoanZapata.XamarinIconify.IconDrawable(this, JoanZapata.XamarinIconify.Fonts.FontAwesomeIcons.fa_refresh.ToString()).color(graphics.Color.Gray);
                icon.sizeDp(25);
                menu.FindItem(Resource.Id.action_refresh).SetVisible(true).SetIcon(icon);
                menu.FindItem(Resource.Id.action_attach).SetVisible(false);
             
                //var home = new JoanZapata.XamarinIconify.IconDrawable(this, JoanZapata.XamarinIconify.Fonts.FontAwesomeIcons.fa_refresh.ToString()).color(graphics.Color.Red);
                //home.sizeDp(25);
                //menu.FindItem(Resource.Id.nav_home).SetVisible(true).SetIcon(home);
            }
            return base.OnCreateOptionsMenu(menu);
        }
        
       
    }
}
    
