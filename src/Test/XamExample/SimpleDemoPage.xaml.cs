using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamEffects;

namespace XamExample {
    public partial class SimpleDemoPage : ContentPage
    {
        private string _prefix;
        private int _charIdx = 33;

        public void OnTapped(object sender, EventArgs args)
        {
            _prefix = char.ConvertFromUtf32(_charIdx++);
        }

        public SimpleDemoPage() {
            InitializeComponent();

            var c = 0;
            Commands.SetTap(touch, new Command(() => {
                c++;
                text.Text = $"{_prefix} {c}";
            }));
        }
    }
}
