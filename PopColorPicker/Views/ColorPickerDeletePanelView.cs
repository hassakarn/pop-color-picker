using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace PopColorPicker
{
    public class ColorPickerDeletePanelView: UIView
    {
        public ColorPickerDeletePanelView()
            : base()
        {
            BackgroundColor = UIColor.Black.ColorWithAlpha(0.5f);
        }
    }
}

