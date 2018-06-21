using BlackBook.Forms.Setup;
using BlackBook.Setup;
using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;
using UIKit;

namespace BlackBook.iOS.Setup {
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxFormsApplicationDelegate<Setup, App, FormsApp> {
        
        public override bool FinishedLaunching(UIApplication app, NSDictionary options) {

            return base.FinishedLaunching(app, options);
        }
    }
}
