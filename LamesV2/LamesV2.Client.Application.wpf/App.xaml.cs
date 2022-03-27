using LamesV2.Client.Application.wpf.Repos;
using LamesV2.Client.Application.wpf.Repos.Interfaces;
using LamesV2.Client.Application.wpf.Services;
using LamesV2.Client.Application.wpf.Services.Interfaces;
using LamesV2.Client.Application.wpf.ViewModels;
using LamesV2.Client.Application.wpf.ViewModels.Interfaces;
using LamesV2.Client.Application.wpf.Views;
using Prism.Ioc;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LamesV2.Client.Application.wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IAnimesService, AnimesService>();
            containerRegistry.Register<IAnimesRepository, AnimesRepository>();

            containerRegistry.RegisterForNavigation<ViewA>();
        }
    }
}
