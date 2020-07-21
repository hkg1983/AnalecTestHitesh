using Prism.Ioc;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Analec.Service;
using CommonServiceLocator;
using Prism.Modularity;
using System.IO;

namespace AnalecTestHitesh
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        //protected override void OnStartup(StartupEventArgs e)
        //{
        //    base.OnStartup(e);

        //    BootStrapper bootStrapper = new BootStrapper();
        //    bootStrapper.Run();
        //}
        private ModuleCatalog _ModuleCatalog;
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IStudentService, StudentService>();
           
        }

        protected override Window CreateShell()
        {
            return ServiceLocator.Current.GetInstance<MainWindow>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<StudentComponent.StudentComponent>();
        }

        //protected override  IModuleCatalog CreateModuleCatalog()
        //{
        //    string catalogPath;
        //    catalogPath = GetApplicationPath() + "ComponentCatalog.xaml";
        //    _ModuleCatalog = Prism.Modularity.ModuleCatalog.CreateFromXaml(File.OpenRead(catalogPath));
        //    return _ModuleCatalog;
        //}

        //private string GetApplicationPath()
        //{
        //    var assembly = System.Reflection.Assembly.GetEntryAssembly();
        //    return Path.GetDirectoryName(assembly.Location) + @"\";
        //}
    }
}
