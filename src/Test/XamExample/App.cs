using System;
using Xamarin.Forms;

namespace XamExample {
    public class App : Application {
        public App()
        {
            MainPage = new NavigationPage(new ContentPage
            {
                Content = new ScrollView
                {
                    Content = new StackLayout
                    {
                        Children =
                        {
                            new Button
                            {
                                Text = "(XamExample - supplied demo)",
                                Command = new Command(() => MainPage.Navigation.PushAsync(new MyPage()))
                            },
                            new Button
                            {
                                Text = "(XamExample - our modified demo)",
                                Command = new Command(() => MainPage.Navigation.PushAsync(new SimpleDemoPage()))
                            },
                        }
                    }
                }
            });
        }
    }
}
