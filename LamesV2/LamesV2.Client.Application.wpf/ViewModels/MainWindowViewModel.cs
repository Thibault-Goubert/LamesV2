using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamesV2.Client.Application.wpf.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager=regionManager;
        }

        #region Private DelegateCommand
        private DelegateCommand _navigateToViewACommand = null; 
        #endregion

        #region Public DelegateCommand
        public DelegateCommand NavigateToViewACommand => _navigateToViewACommand ?? (_navigateToViewACommand = new DelegateCommand(NavigateToViewA));
        #endregion

        #region Methods
        private void NavigateToViewA()
        {
            NavigateTo("ViewA");
        }
        #endregion

        #region Generic Methods
        private void NavigateTo(string v)
        {
            if (string.IsNullOrEmpty(v))
            {
                throw new ArgumentNullException($"{v} does not exist!");
            }
            _regionManager.RequestNavigate(RegionNames.MainWindowMainRegion, v);
        }
        #endregion
    }
}
