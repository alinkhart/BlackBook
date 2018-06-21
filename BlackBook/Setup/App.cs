using System;
using BlackBook.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace BlackBook.Setup {
    public class App : MvxApplication {
        
        public App() {
        }

        public override void Initialize() {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<LoginViewModel>();
        }
    }
}
