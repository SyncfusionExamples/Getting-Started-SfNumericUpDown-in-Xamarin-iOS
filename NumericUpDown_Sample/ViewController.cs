using CoreGraphics;
using Foundation;
using Syncfusion.SfNumericUpDown.iOS;
using System;
using UIKit;

namespace NumericUpDown_Sample
{
    public partial class ViewController : UIViewController
    {
        SfNumericUpDown numericUpDown;
        public ViewController(IntPtr handle) : base(handle)
        {
            numericUpDown = new SfNumericUpDown()
            {
                Value = 50,
                Minimum = 0,
                Maximum = 100,
                StepValue = 10,
                SpinButtonAlignment = SFNumericUpDownSpinButtonAlignment.Both,
                Frame = new CGRect(10, 50, 350, 40),
            };

            this.Add(numericUpDown);
    }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}