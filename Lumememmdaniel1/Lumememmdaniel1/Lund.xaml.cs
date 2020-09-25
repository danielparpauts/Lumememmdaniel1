using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumememmdaniel1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lund : ContentPage
    {
        BoxView golova, vedro, telo;
        public Lund()
        {
            AbsoluteLayout abs = new AbsoluteLayout();
            golova = new BoxView { Color = Color.LightBlue, CornerRadius = 50 };
            AbsoluteLayout.SetLayoutBounds(golova, new Rectangle(0.1, 0.2, 300, 300));
            AbsoluteLayout.SetLayoutFlags(golova, AbsoluteLayoutFlags.All);
            abs.Children.Add(golova);
            telo = new BoxView { Color = Color.Red, CornerRadius = 90 };
            AbsoluteLayout.SetLayoutBounds(telo, new Rectangle(0.5, 0.5, 300, 300));
            AbsoluteLayout.SetLayoutFlags(telo, AbsoluteLayoutFlags.All);
            abs.Children.Add(telo);
            vedro = new BoxView { Color = Color.BurlyWood };
            AbsoluteLayout.SetLayoutBounds(vedro, new Rectangle(0.2, 0.1, 300, 300));
            AbsoluteLayout.SetLayoutFlags(vedro, AbsoluteLayoutFlags.All);
            abs.Children.Add(vedro);
        }
    }
}