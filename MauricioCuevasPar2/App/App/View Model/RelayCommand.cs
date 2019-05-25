using System;

namespace marenepar2.ViewModels
{
    internal class RelayCommand
    {
        private Action cmdLogin;

        public RelayCommand(Action cmdLogin)
        {
            this.cmdLogin = cmdLogin;
        }
    }
}