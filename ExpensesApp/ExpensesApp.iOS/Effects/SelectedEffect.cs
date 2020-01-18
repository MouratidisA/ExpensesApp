using ExpensesApp.iOS.Effects;
using System;
using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ResolutionGroupName("ARG")]
[assembly: ExportEffect(typeof(SelectedEffect), "SelectedEffect")]
namespace ExpensesApp.iOS.Effects
{
    public class SelectedEffect : PlatformEffect
    {
        private UIColor selectedColor;

        protected override void OnAttached()
        {
            selectedColor = new UIColor(176 / 255, 152 / 255, 164 / 255, 255 / 255);
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            try
            {
                if (args.PropertyName == "IsFocused")
                {
                    if (Control.BackgroundColor != selectedColor)
                    {
                        Control.BackgroundColor = selectedColor;
                    }
                    else
                    {
                        Control.BackgroundColor = UIColor.White;
                    }
                }
            }
            catch (InvalidCastException)
            {
                Control.BackgroundColor = selectedColor;
            }
        }

        protected override void OnDetached()
        {

        }
    }
}