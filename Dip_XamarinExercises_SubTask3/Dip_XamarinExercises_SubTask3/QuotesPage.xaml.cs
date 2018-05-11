using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Dip_XamarinExercises_SubTask3
{
	public partial class MainPage : ContentPage
	{
		public  MainPage()
		{
			InitializeComponent();

            rand = new Random();
            quote = new string[]
            {
                "'We all pay for life with death, so everything in between should be free.' - Bill Hicks",
                "'I'm not going to lie. I am a psycho. Luckily, I get most of it out on stage.' - Bill Burr",
                "'This movie is like a simulation of what it must be like to completely lose your fucking mind.' - Jay Bauman on Man of Steel",
                "'It's a celebration of excess' - Rich Evans on Man of Steel"
            };

		}
        private void Button_Clicked(object sender, EventArgs e)
        {
            randomquotelabel.Text = RandomQuote();
        }

        private int num;
        private string[] quote;
        private Random rand;

        public string RandomQuote()
        {
            num = rand.Next(1, 4);
            return quote[num];
        }
    }
}
