﻿using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters;
using UIKit;
using XPlatformMenusTabs.iOS.Interfaces;

namespace XPlatformMenusTabs.iOS.Presenter
{
    public class MvxTabPresenter : MvxIosViewPresenter, ITabBarPresenterHost
    {
        public MvxTabPresenter(IUIApplicationDelegate applicationDelegate, UIWindow window) : base(applicationDelegate, window)
        {

        }

        protected override UINavigationController CreateNavigationController(UIViewController viewController)
        {
            var toReturn = base.CreateNavigationController(viewController);
            toReturn.NavigationBarHidden = true;
            return toReturn;
        }

        public ITabBarPresenter TabBarPresenter { get; set; }

        public override void Show(IMvxIosView view)
        {
            if (TabBarPresenter != null && view != TabBarPresenter)
            {
                TabBarPresenter.ShowView(view);
                return;
            }

            base.Show(view);
        }
    }
}
