﻿using System;
using System.Collections.Generic;
using System.Windows;
using Caliburn.Micro;
using HSMS.Caliburn.App.Helpers;
using HSMS.Caliburn.App.ViewModels;
using MvvmDialogs;

namespace HSMS.Caliburn.App
{
    public class Bootstrapper : BootstrapperBase
    {
        private SimpleContainer _container;

        public Bootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            _container = new SimpleContainer();
            _container.Singleton<IWindowManager, WindowManager>();
            _container.RegisterInstance(typeof(IDialogService), null,
                new DialogService(dialogTypeLocator: new DialogTypeLocator()));
            _container.PerRequest<MainViewModel>();
            _container.PerRequest<UpdateCheckViewModel>();
        }

        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            //DisplayRootViewFor<MainViewModel>();
            DisplayRootViewFor<UpdateCheckViewModel>();
        }
    }
}
