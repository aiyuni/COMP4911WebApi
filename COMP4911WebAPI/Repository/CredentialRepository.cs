using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP4911WebAPI.Repository
{
    public class CredentialRepository : IDataRepository<Credential>
    {
        private readonly ApplicationDbContext _credentialContext;

        public CredentialRepository(ApplicationDbContext context)
        {
            this._credentialContext = context;
        }

        public async Task Add(Credential entity)
        {
            if (_credentialContext.Credentials.Any(p => p.CredentialId == entity.CredentialId) == false)
            {
                System.Diagnostics.Debug.WriteLine("record doesnt exist, adding credential...");
                _credentialContext.Credentials.Add(entity);
            }
            else
            {
                System.Diagnostics.Debug.Write("record already exists, updating credential...");
                Credential existingCredential = _credentialContext.Credentials.FirstOrDefault(p => p.CredentialId == entity.CredentialId);
                this.Update(existingCredential, entity);
            }

            await _credentialContext.SaveChangesAsync();
            _credentialContext.Entry(entity).State = EntityState.Detached;
        }

        public async Task Delete(Credential entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Credential> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Credential>> GetAll()
        {
            return await _credentialContext.Credentials.ToListAsync();
        }

        public async Task Update(Credential dbEntity, Credential entity)
        {
            _credentialContext.Entry(dbEntity).CurrentValues.SetValues(entity);
            System.Diagnostics.Debug.Write("Updated credentials...");
        }
    }
}
