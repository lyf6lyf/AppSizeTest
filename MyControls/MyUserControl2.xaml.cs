using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace MyControls
{
    public sealed partial class MyUserControl2 : UserControl
    {
        public MyUserControl2()
        {
            this.InitializeComponent();
        }


        /// <summary>
        /// The DP to store the <see cref="MyProperty"/> property value.
        /// </summary>
        public static readonly DependencyProperty MyPropertyProperty = DependencyProperty.Register(
            nameof(MyProperty),
            typeof(string),
            typeof(MyUserControl2),
            new PropertyMetadata("0"));

        /// <summary>
        /// Documentation.
        /// </summary>
        public string MyProperty
        {
            get => (string)GetValue(MyPropertyProperty);
            set => SetValue(MyPropertyProperty, value);
        }


        public int P0
        {
            get { return (int)GetValue(P0Property); }
            set { SetValue(P0Property, value); }
        }

        // Using a DependencyProperty as the backing store for P0.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P0Property =
            DependencyProperty.Register("P0", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P1
        {
            get { return (int)GetValue(P1Property); }
            set { SetValue(P1Property, value); }
        }

        // Using a DependencyProperty as the backing store for P1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P1Property =
            DependencyProperty.Register("P1", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P2
        {
            get { return (int)GetValue(P2Property); }
            set { SetValue(P2Property, value); }
        }

        // Using a DependencyProperty as the backing store for P2.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P2Property =
            DependencyProperty.Register("P2", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P3
        {
            get { return (int)GetValue(P3Property); }
            set { SetValue(P3Property, value); }
        }

        // Using a DependencyProperty as the backing store for P3.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P3Property =
            DependencyProperty.Register("P3", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P4
        {
            get { return (int)GetValue(P4Property); }
            set { SetValue(P4Property, value); }
        }

        // Using a DependencyProperty as the backing store for P4.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P4Property =
            DependencyProperty.Register("P4", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P5
        {
            get { return (int)GetValue(P5Property); }
            set { SetValue(P5Property, value); }
        }

        // Using a DependencyProperty as the backing store for P5.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P5Property =
            DependencyProperty.Register("P5", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P6
        {
            get { return (int)GetValue(P6Property); }
            set { SetValue(P6Property, value); }
        }

        // Using a DependencyProperty as the backing store for P6.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P6Property =
            DependencyProperty.Register("P6", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P7
        {
            get { return (int)GetValue(P7Property); }
            set { SetValue(P7Property, value); }
        }

        // Using a DependencyProperty as the backing store for P7.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P7Property =
            DependencyProperty.Register("P7", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P8
        {
            get { return (int)GetValue(P8Property); }
            set { SetValue(P8Property, value); }
        }

        // Using a DependencyProperty as the backing store for P8.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P8Property =
            DependencyProperty.Register("P8", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P9
        {
            get { return (int)GetValue(P9Property); }
            set { SetValue(P9Property, value); }
        }

        // Using a DependencyProperty as the backing store for P9.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P9Property =
            DependencyProperty.Register("P9", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P10
        {
            get { return (int)GetValue(P10Property); }
            set { SetValue(P10Property, value); }
        }

        // Using a DependencyProperty as the backing store for P10.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P10Property =
            DependencyProperty.Register("P10", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P11
        {
            get { return (int)GetValue(P11Property); }
            set { SetValue(P11Property, value); }
        }

        // Using a DependencyProperty as the backing store for P11.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P11Property =
            DependencyProperty.Register("P11", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P12
        {
            get { return (int)GetValue(P12Property); }
            set { SetValue(P12Property, value); }
        }

        // Using a DependencyProperty as the backing store for P12.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P12Property =
            DependencyProperty.Register("P12", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P13
        {
            get { return (int)GetValue(P13Property); }
            set { SetValue(P13Property, value); }
        }

        // Using a DependencyProperty as the backing store for P13.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P13Property =
            DependencyProperty.Register("P13", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P14
        {
            get { return (int)GetValue(P14Property); }
            set { SetValue(P14Property, value); }
        }

        // Using a DependencyProperty as the backing store for P14.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P14Property =
            DependencyProperty.Register("P14", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P15
        {
            get { return (int)GetValue(P15Property); }
            set { SetValue(P15Property, value); }
        }

        // Using a DependencyProperty as the backing store for P15.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P15Property =
            DependencyProperty.Register("P15", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P16
        {
            get { return (int)GetValue(P16Property); }
            set { SetValue(P16Property, value); }
        }

        // Using a DependencyProperty as the backing store for P16.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P16Property =
            DependencyProperty.Register("P16", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P17
        {
            get { return (int)GetValue(P17Property); }
            set { SetValue(P17Property, value); }
        }

        // Using a DependencyProperty as the backing store for P17.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P17Property =
            DependencyProperty.Register("P17", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P18
        {
            get { return (int)GetValue(P18Property); }
            set { SetValue(P18Property, value); }
        }

        // Using a DependencyProperty as the backing store for P18.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P18Property =
            DependencyProperty.Register("P18", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P19
        {
            get { return (int)GetValue(P19Property); }
            set { SetValue(P19Property, value); }
        }

        // Using a DependencyProperty as the backing store for P19.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P19Property =
            DependencyProperty.Register("P19", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P20
        {
            get { return (int)GetValue(P20Property); }
            set { SetValue(P20Property, value); }
        }

        // Using a DependencyProperty as the backing store for P20.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P20Property =
            DependencyProperty.Register("P20", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P21
        {
            get { return (int)GetValue(P21Property); }
            set { SetValue(P21Property, value); }
        }

        // Using a DependencyProperty as the backing store for P21.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P21Property =
            DependencyProperty.Register("P21", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P22
        {
            get { return (int)GetValue(P22Property); }
            set { SetValue(P22Property, value); }
        }

        // Using a DependencyProperty as the backing store for P22.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P22Property =
            DependencyProperty.Register("P22", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P23
        {
            get { return (int)GetValue(P23Property); }
            set { SetValue(P23Property, value); }
        }

        // Using a DependencyProperty as the backing store for P23.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P23Property =
            DependencyProperty.Register("P23", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P24
        {
            get { return (int)GetValue(P24Property); }
            set { SetValue(P24Property, value); }
        }

        // Using a DependencyProperty as the backing store for P24.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P24Property =
            DependencyProperty.Register("P24", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P25
        {
            get { return (int)GetValue(P25Property); }
            set { SetValue(P25Property, value); }
        }

        // Using a DependencyProperty as the backing store for P25.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P25Property =
            DependencyProperty.Register("P25", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P26
        {
            get { return (int)GetValue(P26Property); }
            set { SetValue(P26Property, value); }
        }

        // Using a DependencyProperty as the backing store for P26.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P26Property =
            DependencyProperty.Register("P26", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P27
        {
            get { return (int)GetValue(P27Property); }
            set { SetValue(P27Property, value); }
        }

        // Using a DependencyProperty as the backing store for P27.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P27Property =
            DependencyProperty.Register("P27", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P28
        {
            get { return (int)GetValue(P28Property); }
            set { SetValue(P28Property, value); }
        }

        // Using a DependencyProperty as the backing store for P28.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P28Property =
            DependencyProperty.Register("P28", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P29
        {
            get { return (int)GetValue(P29Property); }
            set { SetValue(P29Property, value); }
        }

        // Using a DependencyProperty as the backing store for P29.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P29Property =
            DependencyProperty.Register("P29", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P30
        {
            get { return (int)GetValue(P30Property); }
            set { SetValue(P30Property, value); }
        }

        // Using a DependencyProperty as the backing store for P30.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P30Property =
            DependencyProperty.Register("P30", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P31
        {
            get { return (int)GetValue(P31Property); }
            set { SetValue(P31Property, value); }
        }

        // Using a DependencyProperty as the backing store for P31.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P31Property =
            DependencyProperty.Register("P31", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P32
        {
            get { return (int)GetValue(P32Property); }
            set { SetValue(P32Property, value); }
        }

        // Using a DependencyProperty as the backing store for P32.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P32Property =
            DependencyProperty.Register("P32", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P33
        {
            get { return (int)GetValue(P33Property); }
            set { SetValue(P33Property, value); }
        }

        // Using a DependencyProperty as the backing store for P33.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P33Property =
            DependencyProperty.Register("P33", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P34
        {
            get { return (int)GetValue(P34Property); }
            set { SetValue(P34Property, value); }
        }

        // Using a DependencyProperty as the backing store for P34.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P34Property =
            DependencyProperty.Register("P34", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P35
        {
            get { return (int)GetValue(P35Property); }
            set { SetValue(P35Property, value); }
        }

        // Using a DependencyProperty as the backing store for P35.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P35Property =
            DependencyProperty.Register("P35", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P36
        {
            get { return (int)GetValue(P36Property); }
            set { SetValue(P36Property, value); }
        }

        // Using a DependencyProperty as the backing store for P36.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P36Property =
            DependencyProperty.Register("P36", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P37
        {
            get { return (int)GetValue(P37Property); }
            set { SetValue(P37Property, value); }
        }

        // Using a DependencyProperty as the backing store for P37.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P37Property =
            DependencyProperty.Register("P37", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P38
        {
            get { return (int)GetValue(P38Property); }
            set { SetValue(P38Property, value); }
        }

        // Using a DependencyProperty as the backing store for P38.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P38Property =
            DependencyProperty.Register("P38", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P39
        {
            get { return (int)GetValue(P39Property); }
            set { SetValue(P39Property, value); }
        }

        // Using a DependencyProperty as the backing store for P39.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P39Property =
            DependencyProperty.Register("P39", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P40
        {
            get { return (int)GetValue(P40Property); }
            set { SetValue(P40Property, value); }
        }

        // Using a DependencyProperty as the backing store for P40.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P40Property =
            DependencyProperty.Register("P40", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P41
        {
            get { return (int)GetValue(P41Property); }
            set { SetValue(P41Property, value); }
        }

        // Using a DependencyProperty as the backing store for P41.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P41Property =
            DependencyProperty.Register("P41", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P42
        {
            get { return (int)GetValue(P42Property); }
            set { SetValue(P42Property, value); }
        }

        // Using a DependencyProperty as the backing store for P42.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P42Property =
            DependencyProperty.Register("P42", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P43
        {
            get { return (int)GetValue(P43Property); }
            set { SetValue(P43Property, value); }
        }

        // Using a DependencyProperty as the backing store for P43.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P43Property =
            DependencyProperty.Register("P43", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P44
        {
            get { return (int)GetValue(P44Property); }
            set { SetValue(P44Property, value); }
        }

        // Using a DependencyProperty as the backing store for P44.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P44Property =
            DependencyProperty.Register("P44", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P45
        {
            get { return (int)GetValue(P45Property); }
            set { SetValue(P45Property, value); }
        }

        // Using a DependencyProperty as the backing store for P45.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P45Property =
            DependencyProperty.Register("P45", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P46
        {
            get { return (int)GetValue(P46Property); }
            set { SetValue(P46Property, value); }
        }

        // Using a DependencyProperty as the backing store for P46.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P46Property =
            DependencyProperty.Register("P46", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P47
        {
            get { return (int)GetValue(P47Property); }
            set { SetValue(P47Property, value); }
        }

        // Using a DependencyProperty as the backing store for P47.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P47Property =
            DependencyProperty.Register("P47", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P48
        {
            get { return (int)GetValue(P48Property); }
            set { SetValue(P48Property, value); }
        }

        // Using a DependencyProperty as the backing store for P48.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P48Property =
            DependencyProperty.Register("P48", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P49
        {
            get { return (int)GetValue(P49Property); }
            set { SetValue(P49Property, value); }
        }

        // Using a DependencyProperty as the backing store for P49.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P49Property =
            DependencyProperty.Register("P49", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P50
        {
            get { return (int)GetValue(P50Property); }
            set { SetValue(P50Property, value); }
        }

        // Using a DependencyProperty as the backing store for P50.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P50Property =
            DependencyProperty.Register("P50", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P51
        {
            get { return (int)GetValue(P51Property); }
            set { SetValue(P51Property, value); }
        }

        // Using a DependencyProperty as the backing store for P51.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P51Property =
            DependencyProperty.Register("P51", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P52
        {
            get { return (int)GetValue(P52Property); }
            set { SetValue(P52Property, value); }
        }

        // Using a DependencyProperty as the backing store for P52.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P52Property =
            DependencyProperty.Register("P52", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P53
        {
            get { return (int)GetValue(P53Property); }
            set { SetValue(P53Property, value); }
        }

        // Using a DependencyProperty as the backing store for P53.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P53Property =
            DependencyProperty.Register("P53", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P54
        {
            get { return (int)GetValue(P54Property); }
            set { SetValue(P54Property, value); }
        }

        // Using a DependencyProperty as the backing store for P54.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P54Property =
            DependencyProperty.Register("P54", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P55
        {
            get { return (int)GetValue(P55Property); }
            set { SetValue(P55Property, value); }
        }

        // Using a DependencyProperty as the backing store for P55.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P55Property =
            DependencyProperty.Register("P55", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P56
        {
            get { return (int)GetValue(P56Property); }
            set { SetValue(P56Property, value); }
        }

        // Using a DependencyProperty as the backing store for P56.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P56Property =
            DependencyProperty.Register("P56", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P57
        {
            get { return (int)GetValue(P57Property); }
            set { SetValue(P57Property, value); }
        }

        // Using a DependencyProperty as the backing store for P57.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P57Property =
            DependencyProperty.Register("P57", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P58
        {
            get { return (int)GetValue(P58Property); }
            set { SetValue(P58Property, value); }
        }

        // Using a DependencyProperty as the backing store for P58.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P58Property =
            DependencyProperty.Register("P58", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P59
        {
            get { return (int)GetValue(P59Property); }
            set { SetValue(P59Property, value); }
        }

        // Using a DependencyProperty as the backing store for P59.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P59Property =
            DependencyProperty.Register("P59", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P60
        {
            get { return (int)GetValue(P60Property); }
            set { SetValue(P60Property, value); }
        }

        // Using a DependencyProperty as the backing store for P60.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P60Property =
            DependencyProperty.Register("P60", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P61
        {
            get { return (int)GetValue(P61Property); }
            set { SetValue(P61Property, value); }
        }

        // Using a DependencyProperty as the backing store for P61.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P61Property =
            DependencyProperty.Register("P61", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P62
        {
            get { return (int)GetValue(P62Property); }
            set { SetValue(P62Property, value); }
        }

        // Using a DependencyProperty as the backing store for P62.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P62Property =
            DependencyProperty.Register("P62", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P63
        {
            get { return (int)GetValue(P63Property); }
            set { SetValue(P63Property, value); }
        }

        // Using a DependencyProperty as the backing store for P63.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P63Property =
            DependencyProperty.Register("P63", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P64
        {
            get { return (int)GetValue(P64Property); }
            set { SetValue(P64Property, value); }
        }

        // Using a DependencyProperty as the backing store for P64.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P64Property =
            DependencyProperty.Register("P64", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P65
        {
            get { return (int)GetValue(P65Property); }
            set { SetValue(P65Property, value); }
        }

        // Using a DependencyProperty as the backing store for P65.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P65Property =
            DependencyProperty.Register("P65", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P66
        {
            get { return (int)GetValue(P66Property); }
            set { SetValue(P66Property, value); }
        }

        // Using a DependencyProperty as the backing store for P66.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P66Property =
            DependencyProperty.Register("P66", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P67
        {
            get { return (int)GetValue(P67Property); }
            set { SetValue(P67Property, value); }
        }

        // Using a DependencyProperty as the backing store for P67.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P67Property =
            DependencyProperty.Register("P67", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P68
        {
            get { return (int)GetValue(P68Property); }
            set { SetValue(P68Property, value); }
        }

        // Using a DependencyProperty as the backing store for P68.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P68Property =
            DependencyProperty.Register("P68", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P69
        {
            get { return (int)GetValue(P69Property); }
            set { SetValue(P69Property, value); }
        }

        // Using a DependencyProperty as the backing store for P69.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P69Property =
            DependencyProperty.Register("P69", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P70
        {
            get { return (int)GetValue(P70Property); }
            set { SetValue(P70Property, value); }
        }

        // Using a DependencyProperty as the backing store for P70.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P70Property =
            DependencyProperty.Register("P70", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P71
        {
            get { return (int)GetValue(P71Property); }
            set { SetValue(P71Property, value); }
        }

        // Using a DependencyProperty as the backing store for P71.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P71Property =
            DependencyProperty.Register("P71", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P72
        {
            get { return (int)GetValue(P72Property); }
            set { SetValue(P72Property, value); }
        }

        // Using a DependencyProperty as the backing store for P72.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P72Property =
            DependencyProperty.Register("P72", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P73
        {
            get { return (int)GetValue(P73Property); }
            set { SetValue(P73Property, value); }
        }

        // Using a DependencyProperty as the backing store for P73.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P73Property =
            DependencyProperty.Register("P73", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P74
        {
            get { return (int)GetValue(P74Property); }
            set { SetValue(P74Property, value); }
        }

        // Using a DependencyProperty as the backing store for P74.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P74Property =
            DependencyProperty.Register("P74", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P75
        {
            get { return (int)GetValue(P75Property); }
            set { SetValue(P75Property, value); }
        }

        // Using a DependencyProperty as the backing store for P75.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P75Property =
            DependencyProperty.Register("P75", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P76
        {
            get { return (int)GetValue(P76Property); }
            set { SetValue(P76Property, value); }
        }

        // Using a DependencyProperty as the backing store for P76.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P76Property =
            DependencyProperty.Register("P76", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P77
        {
            get { return (int)GetValue(P77Property); }
            set { SetValue(P77Property, value); }
        }

        // Using a DependencyProperty as the backing store for P77.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P77Property =
            DependencyProperty.Register("P77", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P78
        {
            get { return (int)GetValue(P78Property); }
            set { SetValue(P78Property, value); }
        }

        // Using a DependencyProperty as the backing store for P78.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P78Property =
            DependencyProperty.Register("P78", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P79
        {
            get { return (int)GetValue(P79Property); }
            set { SetValue(P79Property, value); }
        }

        // Using a DependencyProperty as the backing store for P79.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P79Property =
            DependencyProperty.Register("P79", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P80
        {
            get { return (int)GetValue(P80Property); }
            set { SetValue(P80Property, value); }
        }

        // Using a DependencyProperty as the backing store for P80.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P80Property =
            DependencyProperty.Register("P80", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P81
        {
            get { return (int)GetValue(P81Property); }
            set { SetValue(P81Property, value); }
        }

        // Using a DependencyProperty as the backing store for P81.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P81Property =
            DependencyProperty.Register("P81", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P82
        {
            get { return (int)GetValue(P82Property); }
            set { SetValue(P82Property, value); }
        }

        // Using a DependencyProperty as the backing store for P82.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P82Property =
            DependencyProperty.Register("P82", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P83
        {
            get { return (int)GetValue(P83Property); }
            set { SetValue(P83Property, value); }
        }

        // Using a DependencyProperty as the backing store for P83.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P83Property =
            DependencyProperty.Register("P83", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P84
        {
            get { return (int)GetValue(P84Property); }
            set { SetValue(P84Property, value); }
        }

        // Using a DependencyProperty as the backing store for P84.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P84Property =
            DependencyProperty.Register("P84", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P85
        {
            get { return (int)GetValue(P85Property); }
            set { SetValue(P85Property, value); }
        }

        // Using a DependencyProperty as the backing store for P85.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P85Property =
            DependencyProperty.Register("P85", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P86
        {
            get { return (int)GetValue(P86Property); }
            set { SetValue(P86Property, value); }
        }

        // Using a DependencyProperty as the backing store for P86.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P86Property =
            DependencyProperty.Register("P86", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P87
        {
            get { return (int)GetValue(P87Property); }
            set { SetValue(P87Property, value); }
        }

        // Using a DependencyProperty as the backing store for P87.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P87Property =
            DependencyProperty.Register("P87", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P88
        {
            get { return (int)GetValue(P88Property); }
            set { SetValue(P88Property, value); }
        }

        // Using a DependencyProperty as the backing store for P88.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P88Property =
            DependencyProperty.Register("P88", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P89
        {
            get { return (int)GetValue(P89Property); }
            set { SetValue(P89Property, value); }
        }

        // Using a DependencyProperty as the backing store for P89.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P89Property =
            DependencyProperty.Register("P89", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P90
        {
            get { return (int)GetValue(P90Property); }
            set { SetValue(P90Property, value); }
        }

        // Using a DependencyProperty as the backing store for P90.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P90Property =
            DependencyProperty.Register("P90", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P91
        {
            get { return (int)GetValue(P91Property); }
            set { SetValue(P91Property, value); }
        }

        // Using a DependencyProperty as the backing store for P91.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P91Property =
            DependencyProperty.Register("P91", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P92
        {
            get { return (int)GetValue(P92Property); }
            set { SetValue(P92Property, value); }
        }

        // Using a DependencyProperty as the backing store for P92.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P92Property =
            DependencyProperty.Register("P92", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P93
        {
            get { return (int)GetValue(P93Property); }
            set { SetValue(P93Property, value); }
        }

        // Using a DependencyProperty as the backing store for P93.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P93Property =
            DependencyProperty.Register("P93", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P94
        {
            get { return (int)GetValue(P94Property); }
            set { SetValue(P94Property, value); }
        }

        // Using a DependencyProperty as the backing store for P94.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P94Property =
            DependencyProperty.Register("P94", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P95
        {
            get { return (int)GetValue(P95Property); }
            set { SetValue(P95Property, value); }
        }

        // Using a DependencyProperty as the backing store for P95.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P95Property =
            DependencyProperty.Register("P95", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P96
        {
            get { return (int)GetValue(P96Property); }
            set { SetValue(P96Property, value); }
        }

        // Using a DependencyProperty as the backing store for P96.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P96Property =
            DependencyProperty.Register("P96", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P97
        {
            get { return (int)GetValue(P97Property); }
            set { SetValue(P97Property, value); }
        }

        // Using a DependencyProperty as the backing store for P97.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P97Property =
            DependencyProperty.Register("P97", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P98
        {
            get { return (int)GetValue(P98Property); }
            set { SetValue(P98Property, value); }
        }

        // Using a DependencyProperty as the backing store for P98.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P98Property =
            DependencyProperty.Register("P98", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P99
        {
            get { return (int)GetValue(P99Property); }
            set { SetValue(P99Property, value); }
        }

        // Using a DependencyProperty as the backing store for P99.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P99Property =
            DependencyProperty.Register("P99", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));

        public int P100
        {
            get { return (int)GetValue(P100Property); }
            set { SetValue(P100Property, value); }
        }

        // Using a DependencyProperty as the backing store for P100.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty P100Property =
            DependencyProperty.Register("P100", typeof(int), typeof(CustomControl2), new PropertyMetadata(0));
    }
}
