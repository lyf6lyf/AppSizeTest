using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace MyControls
{
    public sealed class CustomControl5 : Control
    {
        public CustomControl5()
        {
            this.DefaultStyleKey = typeof(CustomControl4);
        }


        public static readonly DependencyProperty MyProperty5Property = DependencyProperty.Register(
            "MyProperty5",
            typeof(string),
            typeof(CustomControl4),
            new PropertyMetadata(""));
    }
}
