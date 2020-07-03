using System;
using System.Collections.Generic;
using System.Text;
using MyFinances.Common.Command;

namespace MyFinances.Database.Command.Commands
{
    public class AddToFavorite : ICommand
    {
        private string payload = string.Empty;
        private readonly ProfileServicesReceiver receiver;

        public AddToFavorite(ProfileServicesReceiver receiver, string assetSymbol)
        {
            payload = assetSymbol;
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.AddFavoriteAssetToList(payload);
        }
    }
}
