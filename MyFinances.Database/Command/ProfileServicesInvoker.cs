using System;
using System.Collections.Generic;
using System.Text;
using MyFinances.Common.Command;
using MyFinances.Database.Facades;

namespace MyFinances.Database.Command
{
    public class ProfileServicesInvoker
    {
        private ICommand _command;
        
        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void AddAssetToUserFavorities()
        {
            if (_command is ICommand)
            {
                _command.Execute();
            }
        }

        public void RemoveAssetFromUserFavorities()
        {
            if (_command is ICommand)
            {
                _command.Execute();
            }
        }
    }
}
