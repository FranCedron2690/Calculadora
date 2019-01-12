using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Windows.Devices.Sensors;
using Windows.Graphics.Display;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace Calculadora
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.SizeChanged += Page_SizeChanged;
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Debug.WriteLine(e.NewSize.Width + " ," + e.NewSize.Height);

            //Landscape
            if (e.NewSize.Width > e.NewSize.Height)
            {
                Debug.WriteLine("Landscape");
            }
            else //Portrait
            {
                Debug.WriteLine("Portrait");
            }

            //Otra forma de obtener la orientación de la pantalla
            /*DisplayInformation displayInfo = DisplayInformation.GetForCurrentView();
            DisplayInformation.AutoRotationPreferences = DisplayOrientations.Portrait;

            switch (displayInfo.CurrentOrientation)
            {
                case DisplayOrientations.Landscape:
                    Debug.WriteLine("Landscape");
                    break;
                case DisplayOrientations.Portrait:
                    Debug.WriteLine("Portrait");
                    break;
                case DisplayOrientations.LandscapeFlipped:
                    Debug.WriteLine("LandscapeFlipped");
                    break;
                case DisplayOrientations.PortraitFlipped:
                    Debug.WriteLine("PortraitFlipped");
                    break;
            }*/
        }
    }
}
