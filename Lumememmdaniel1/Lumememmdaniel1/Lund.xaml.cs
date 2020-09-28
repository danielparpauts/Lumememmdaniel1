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
        BoxView golova, vedro, telo, niz;
        Button btn1;
        public Lund()
        {
            AbsoluteLayout abs = new AbsoluteLayout();
            golova = new BoxView { Color = Color.LightBlue, CornerRadius = 60 };
            AbsoluteLayout.SetLayoutBounds(golova, new Rectangle(0.5, 0.20, 100, 100));
            AbsoluteLayout.SetLayoutFlags(golova, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(golova);
            telo = new BoxView { Color = Color.LightBlue, CornerRadius = 60 };
            AbsoluteLayout.SetLayoutBounds(telo, new Rectangle(0.5, 0.38, 130, 130));
            AbsoluteLayout.SetLayoutFlags(telo, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(telo);
            vedro = new BoxView { Color = Color.Black, CornerRadius = 0 };
            AbsoluteLayout.SetLayoutBounds(vedro, new Rectangle(0.5, 0.10, 60, 60));
            AbsoluteLayout.SetLayoutFlags(vedro, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(vedro);
            niz = new BoxView { Color = Color.LightBlue, CornerRadius = 80 };
            AbsoluteLayout.SetLayoutBounds(niz, new Rectangle(0.5, 0.63, 160, 160));
            AbsoluteLayout.SetLayoutFlags(niz, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(niz);
            btn1 = new Button { Text = "pea" };
            btn1.Clicked += Btn1_Clicked;
            AbsoluteLayout.SetLayoutBounds(btn1, new Rectangle(0.5, 0.8, 100, 100));
            AbsoluteLayout.SetLayoutFlags(btn1, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(btn1);
            Content = abs;
        }

        bool flag = true;
        private void Btn1_Clicked(object sender, EventArgs e)
        {
            if (flag)
            {
                golova.Opacity = 0;
                flag = false;
            }
            else
            {
                golova.Opacity = 1;
                flag = true;
            }

            
        }
    }
}