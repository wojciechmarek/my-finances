using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinances.Database.Facades
{
    public interface IProfileFcd
    {
        void AddFavouriteAsset(int userId, int assetId);
        void RemoveFavouriteAsset(int userId, int assetId);
        IEnumerable<int> GetFavoritiesAssets(int userId);
    }
}
