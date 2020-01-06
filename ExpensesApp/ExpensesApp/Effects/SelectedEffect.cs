using Xamarin.Forms;

namespace ExpensesApp.Effects
{
    public class SelectedEffect : RoutingEffect
    {
        public SelectedEffect(string effectId) : base("ARG.SelectedEffect")
        {

        }

        public SelectedEffect() : base("ARG.SelectedEffect")
        {
       
        }
    }
}
