﻿using LitApp.DAL.Models;
using LitApp.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LitApp.DAL.Repositories
{
    public class ConnectionRepository : IConnectionRepository
    {
        private readonly BlogContext _blogContext;
        public ConnectionRepository(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }
        public async Task CreateConnection(Connections connections)
        {
            await _blogContext.Connections.AddAsync(connections);
            await _blogContext.SaveChangesAsync();
        }

        public async Task DeleteConnection(string ConnectionId)
        {
            var user = await _blogContext.Connections.FirstOrDefaultAsync(x => x.ConnectionId == ConnectionId);
            _blogContext.Connections.Remove(user);
            await _blogContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Connections>> GetAllClients() => await _blogContext.Connections.ToListAsync();

        public async Task<Connections> GetConnectionForUserAsync(int userAccount) => await _blogContext.Connections.FirstOrDefaultAsync(x => x.UserAccount == userAccount);

        public async Task<Connections> GetClientById(int UserId) => await _blogContext.Connections.FirstOrDefaultAsync(x => x.UserAccount == UserId);

        public async Task UpdateConnection(Connections connections)
        {
            _blogContext.Connections.Update(connections);
            await _blogContext.SaveChangesAsync();
        }

        public async Task<Connections> GetConnectionsById(int connectionId) => await _blogContext.Connections.FirstOrDefaultAsync(x => x.Id == connectionId);
    }
}
