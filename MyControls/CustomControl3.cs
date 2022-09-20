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
    public sealed class CustomControl3 : Control
    {
        public CustomControl3()
        {
            this.DefaultStyleKey = typeof(CustomControl3);
        }

        public static readonly DependencyProperty MyProperty3Property = DependencyProperty.Register(
            "MyProperty3",
            typeof(string),
            typeof(CustomControl3),
            new PropertyMetadata(""));
    }
}
