using ExpensesApp.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ResolutionGroupName("ARG")]
[assembly: ExportEffect(typeof(SelectedEffect), "SelectedEffect")]
namespace ExpensesApp.UWP.Effects
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

