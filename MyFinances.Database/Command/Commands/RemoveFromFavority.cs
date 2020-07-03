using System;
using System.Collections.Generic;
using System.Text;
using MyFinances.Database.Command;

namespace MyFinances.Common.Command.Commands
{
    public class RemoveFromFavority : ICommand
    {
        private string payload = string.Empty;
        private readonly ProfileServicesReceiver receiver;

        public RemoveFromFavority(ProfileServicesReceiver receiver, string assetSymbol)
        {
            payload = assetSymbol;
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.RemoveFavoriteAssetToList(payload);
        }
    }
}
