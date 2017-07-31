﻿using Microsoft.Practices.Unity;
using Prism.Unity;
using System.Windows;
using DataAccessLayer;
using KarveCar.View;
using KarveCommon.Services;
using Prism.Modularity;

namespace KarveCar
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void ConfigureModuleCatalog()
        {
            ModuleCatalog catalog = (ModuleCatalog)ModuleCatalog;
            catalog.AddModule(typeof(ToolBarModule.ToolBarModule));
        }

        /// <summary>
        ///  This register a services.
        /// </summary>
        protected override void ConfigureContainer()
        {
            // The dal service is used to access to the database
            Container.RegisterType<IDalLocator, DalLocator>( new ContainerControlledLifetimeManager());
            // The carekeeper or undo service is used to store the last action and do/redo an action
            Container.RegisterType<ICareKeeperService, CareKeeper>( new ContainerControlledLifetimeManager());
            // the configuraion service is used to do all the global actions: saving the app config, exiting, etc.
             base.ConfigureContainer();
        }

        protected override void InitializeShell()
        {
            // The main window and configuration services shall be injected just here because in the configure container are not yet 
            // available.
            object[] values = new object[1];
            values[0] = Application.Current.MainWindow;
            InjectionConstructor injectionConstructor = new InjectionConstructor(values);
            Container.RegisterType<IConfigurationService, ConfigurationService>(injectionConstructor);
            Application.Current.MainWindow.Show();
        }
    }

}