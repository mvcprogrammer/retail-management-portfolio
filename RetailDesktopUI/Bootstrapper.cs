using Caliburn.Micro;
using RetailDesktopUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RetailDesktopUI
{
    public class Bootstrapper : BootstrapperBase
    {
        private SimpleContainer _simpleContainer = new SimpleContainer();
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            _simpleContainer.Instance(_simpleContainer);
            _simpleContainer
                .Singleton<IWindowManager, WindowManager>()
                .Singleton<IEventAggregator, EventAggregator>();

            GetType().Assembly.GetTypes()
                .Where(t => t.IsClass)
                .Where(t => t.Name.EndsWith("ViewModel"))
                .ToList()
                .ForEach(viewModelType => _simpleContainer.RegisterPerRequest(
                    viewModelType, viewModelType.ToString(), viewModelType));
        }

        protected override void OnStartup(object sender, StartupEventArgs e) => DisplayRootViewFor<ShellViewModel>();
       
        protected override object GetInstance(Type service, string key) => _simpleContainer.GetInstance(service, key);
        
        protected override IEnumerable<object> GetAllInstances(Type service) => _simpleContainer.GetAllInstances(service);
        
        protected override void BuildUp(object instance) =>_simpleContainer.BuildUp(instance);
    }
}
