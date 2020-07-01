using System;
using System.Collections.Generic;
using System.Text;
using MyFinances.Database.Models;

namespace MyFinances.Database.Facades
{
    public interface IProfileFcd
    {
        void AddFavoriteAsset(string assetIdentifier);
        void RemoveFavouriteAsset(string assetIdentifier);
        IList<FavoriteAsset> GetFavoritiesAssets();
    }
}
