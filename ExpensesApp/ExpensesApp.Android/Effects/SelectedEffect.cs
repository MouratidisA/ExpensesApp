using ExpensesApp.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("ARG")]
[assembly: ExportEffect(typeof(SelectedEffect), "SelectedEffect")]
namespace ExpensesApp.Droid.Effects
{
   public class SelectedEffect : PlatformEffect
    {
        public SelectedEffect()
        {
            
        }

        protected override void OnAttached()
        {
       
        }

        protected override void OnDetached()
        {
       
        }
    }
}