using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using IdentityServer4.Extensions;
using MyFinances.Database.Context;
using MyFinances.Database.Facades;
using Microsoft.AspNetCore.Http;
using MyFinances.Common.Exceptions;
using MyFinances.Database.Models;

namespace MyFinances.Database.Services
{
    public class ProfileServices : IProfileFcd
    {
        private readonly MyFinancesContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private string userIdentifier;

        public ProfileServices(MyFinancesContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            userIdentifier =_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public void AddFavoriteAsset(string assetIdentifier)
        { 
           if (assetIdentifier.IsNullOrEmpty()) throw new FavouriteAssetException();

           var newAsset = new FavoriteAsset()
           {
               AssetId = assetIdentifier,
               UserId = userIdentifier,
           };

           _context.FavoriteAssets.Add(newAsset);
           _context.SaveChanges();
        }

        public void RemoveFavouriteAsset(string assetIdentifier)
        {
            if (assetIdentifier.IsNullOrEmpty()) throw new FavouriteAssetException();

            var resultToRemove = _context.FavoriteAssets
                .Single(x => x.AssetId == assetIdentifier && x.UserId == userIdentifier);

            _context.FavoriteAssets.Remove(resultToRemove);
            _context.SaveChanges();
        }

        public IList<string> GetFavoritiesAssets()
        {
            var result = _context.FavoriteAssets
                .Where(x => x.UserId == userIdentifier).Select(x=>x.AssetId).ToList();

            return result;
        }
    }
}
