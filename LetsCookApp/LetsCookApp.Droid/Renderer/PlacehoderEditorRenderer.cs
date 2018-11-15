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
using Xamarin.Forms.Platform.Android;
using LetsCookApp.Droid.Renderer;
using LetsCookApp.CustomViews;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(PlaceholderEditor), typeof(PlacehoderEditorRenderer))]
namespace LetsCookApp.Droid.Renderer
{
    public class PlacehoderEditorRenderer : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (Element == null)
                return;

            var element = (PlaceholderEditor)Element;

            Control.Hint = element.Placeholder;
            Control.SetHintTextColor(element.PlaceholderColor.ToAndroid());
        }
    }

}