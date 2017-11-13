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
using JoanZapata.XamarinIconify.Fonts;
using graphics = Android.Graphics;


namespace NavDrawer.Android.Templates
{
    public static class CommonExtensions
    {
        #region Get Random Item from List
        public static T PickRandom<T>(this IEnumerable<T> source)
        {
            return source.PickRandom(1).Single();
        }

        public static IEnumerable<T> PickRandom<T>(this IEnumerable<T> source, int count)
        {
            return source.Shuffle().Take(count);
        }

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            return source.OrderBy(x => Guid.NewGuid());
        }
        #endregion
        public static IMenuItem SetFontIcon(this IMenuItem menuitem , Context context,  FontAwesomeIcons fontIcon, graphics.Color color, int size = 25)
        {
            var icon = new JoanZapata.XamarinIconify.IconDrawable(context, fontIcon.ToString()).color(color);
            icon.sizeDp(size);
            icon.sizePx(size);
            menuitem.SetIcon(icon);
            return menuitem;
        }
    }

}