using System;
using System.Collections.Generic;
using System.Text;
using MyFinances.Database.Facades;

namespace MyFinances.Database.Services
{
    public class ProfileServices : IProfileFcd
    {
        public void AddFavouriteAsset(int userId, int assetId)
        {
            throw new NotImplementedException();
        }

        public void RemoveFavouriteAsset(int userId, int assetId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<int> GetFavoritiesAssets(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
