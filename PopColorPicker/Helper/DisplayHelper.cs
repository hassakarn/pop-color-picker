using System;
using System.Drawing;

using Foundation;
using UIKit;


namespace PopColorPicker
{
    public static class DisplayHelper
    {
        public static bool UserInterfaceIdiomIsPhone
        {
            get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
        }

        public static bool Is4InchDisplay()
        {
            return UIScreen.MainScreen.Bounds.Size.Height >= 568f;
        }
    }
}

