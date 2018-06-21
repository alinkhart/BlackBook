﻿using MvvmCross.Platform.IoC;

namespace BlackBook.Core {
    public class CoreApp : MvvmCross.Core.ViewModels.MvxApplication {
        public override void Initialize() {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterNavigationServiceAppStart<ViewModels.FirstViewModel>();
        }
    }
}
