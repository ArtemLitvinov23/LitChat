﻿using LitChat.DAL.Models;
using System.Linq;
using System.Threading.Tasks;

namespace LitChat.DAL.Repositories.Interfaces
{
    public interface IFavoritesRepository
    {
        IQueryable<FavoritesList> GetAllFavoriteUser();
        Task<FavoritesList> GetFavoriteUserById(int id);
        Task AddUserToFavorite(FavoritesList user);
        Task RemoveUserFromFavorite(int id);
    }
}
