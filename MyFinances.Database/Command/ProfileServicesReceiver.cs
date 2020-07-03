using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using MyFinances.Common.Command;
using MyFinances.Database.Facades;
using MyFinances.Database.Models;

namespace MyFinances.Database.Command
{
    public class ProfileServicesReceiver
    {
        private readonly IProfileFcd _profileFcd;

        public ProfileServicesReceiver(IProfileFcd profileFcd)
        {
            _profileFcd = profileFcd;
        }

        public void AddFavoriteAssetToList(string symbol)
        {
            _profileFcd.AddFavoriteAsset(symbol);
        }

        public void RemoveFavoriteAssetToList(string symbol)
        {
            _profileFcd.RemoveFavouriteAsset(symbol);
        }
    }
}
