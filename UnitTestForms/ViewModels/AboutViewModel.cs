using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace UnitTestForms.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {

        public bool TestMe { get; set; }
        public  String TestMeString { get; set; }
        public AboutViewModel()
        {
            Title = "About";
            TestMeString = "Try";

            OpenWebCommand = new Command(() =>
            {
                TestMe = true;

           //     Device.OpenUri(new Uri("https://xamarin.com/platform"));
            });

            TestMeFalseCommand = new Command(() =>
            {
                TestMeString = "Try this";
            });
        }

        public ICommand OpenWebCommand { get; }

        public ICommand TestMeFalseCommand { get; }
    }
}