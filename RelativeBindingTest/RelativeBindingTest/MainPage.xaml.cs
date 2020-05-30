using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RelativeBindingTest
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public int ImageWidth { get; set; }
        public int ImageHeight { get; set; }

        public List<Person> People { get; set; }

        public MainPage()
        {
            InitializeComponent();

            People = new List<Person>();

            for (int i = 1; i <= 50; i++)
            {
                People.Add(new Person
                {
                    FirstName = $"FirstName{i}",
                    LastName = $"LastName{i}",
                    AvatarUri = $"avatar_men_{i}",
                });
            }

            ImageWidth = 10;
            ImageHeight = 10;

            BindingContext = this;
        }
    }
}
