using System;
using ProductManagement.Framework;
using ProductManagement.Views;

namespace ProductManagement.ViewModels
{
    public class ApplicationViewModel : BaseViewModel
    {
        public DelegateCommand AboutCommand { get; }
        public DelegateCommand ExitCommand { get; }

        public ApplicationViewModel()
        {
            AboutCommand = new DelegateCommand( x => OnAboutCommandExecute());
            ExitCommand = new DelegateCommand(x=> OnExitCommandExecute());
        }

        private void OnExitCommandExecute()
        {
            Environment.Exit(0);
        }

        private void OnAboutCommandExecute()
        {
           var aboutView = new AboutView();
            aboutView.ShowDialog();
        }
    }
}
