using Android.Content;
using Android.Support.V4.Content.Res;
using EbookStore.Mobile.Droid;
using EbookStore.Mobile.Views.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(RoundedEntry), typeof(RoundedEntryRenderer))]
namespace EbookStore.Mobile.Droid
{
    class RoundedEntryRenderer : EntryRenderer
    {
        public RoundedEntryRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(Control != null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.White);
                Control.SetBackground(ResourcesCompat.GetDrawable(Resources, Resource.Drawable.edit_text_style, null));
            }
        }
    }
}