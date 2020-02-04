using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using COMP4911WebAPI.Helpers;
using COMP4911WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Protocols;
using Microsoft.IdentityModel.Tokens;

namespace COMP4911WebAPI.Repository
{
    public class CredentialRepository : IDataRepository<Credential>
    {
        private readonly ApplicationDbContext _credentialContext;
        private readonly AppSettings _appSettings;

        public CredentialRepository(ApplicationDbContext context, IOptions<AppSettings> appSettings)
        {
            this._credentialContext = context;
            this._appSettings = appSettings.Value;
        }

        public async Task<Credential> Authenticate(string username, string password)
        {
            Debug.Write("inside CredRepo Authenticate... username is: " + username + ", password is: " + password);

            if (_credentialContext.Credentials.SingleOrDefault(x => x.CredentialId.Equals(username)) == null)
            {
                return null;
            }
            byte[] salt = _credentialContext.Credentials.SingleOrDefault(x => x.CredentialId.Equals(username)).Salt;
            string hashedPassword = PasswordHasher.HashPassword(password, salt);

            var credential =  await _credentialContext.Credentials.SingleOrDefaultAsync(x =>
                x.CredentialId.Equals(username) && x.Password.Equals(hashedPassword));
            if (credential == null)
            {
                Debug.WriteLine("user is null??");
                return null;
            }

            var claim = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, credential.CredentialId)
            };
            var signinKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_appSettings.Secret));

            int expiryInMinutes = Convert.ToInt32("50");

            var token = new JwtSecurityToken(
                expires: DateTime.UtcNow.AddMinutes(expiryInMinutes),
                signingCredentials: new SigningCredentials(signinKey, SecurityAlgorithms.HmacSha256Signature)
            );
            var tokenHandler = new JwtSecurityTokenHandler();
            credential.Token = tokenHandler.WriteToken(token);
            //// authentication successful so generate jwt token
            //var tokenHandler = new JwtSecurityTokenHandler();
            ////var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            //var key = Encoding.ASCII.GetBytes("THIS IS USED TO SIGN AND VERIFY JWT TOKENS");
            //var tokenDescriptor = new SecurityTokenDescriptor
            //{
            //    Subject = new ClaimsIdentity(new Claim[]
            //    {
            //        new Claim(ClaimTypes.Name, user.CredentialId.ToString())
            //    }),
            //    Expires = DateTime.UtcNow.AddDays(7),
            //    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            //};
            //var token = tokenHandler.CreateToken(tokenDescriptor);
            //user.Token = tokenHandler.WriteToken(token);

            // remove password before returning
            credential.Password = null;

            return credential;
        }

        public async Task<bool> CheckIfExists(Credential entity)
        {
            bool exists = await _credentialContext.Credentials.AnyAsync(c => c.CredentialId.Equals(entity.CredentialId));
            Debug.WriteLine("exists is: " + exists);
            return exists;
        }

        public async Task<Credential> GetLastId()
        {
            Credential cred = _credentialContext.Credentials.OrderBy(c =>c.CredentialId).LastOrDefault();
            Debug.WriteLine(cred.ToString());

            return cred;
        } 

        public async Task<bool> Add(Credential entity)
        {
            bool success;

            byte[] salt = PasswordHasher.GenerateSalt();
            string hashedPass = PasswordHasher.HashPassword(entity.Password, salt);

            entity.Salt = salt;
            entity.Password = hashedPass;

            if (_credentialContext.Credentials.Any(p => p.CredentialId == entity.CredentialId) == false)
            {
                System.Diagnostics.Debug.WriteLine("record doesnt exist, adding credential...");
                _credentialContext.Credentials.Add(entity);
                success = true;
            }
            else
            {
                System.Diagnostics.Debug.Write("record already exists, updating credential...");
                Credential existingCredential = _credentialContext.Credentials.FirstOrDefault(p => p.CredentialId == entity.CredentialId);
                await this.Update(entity);
                success = false;
            }

            await _credentialContext.SaveChangesAsync();
            _credentialContext.Entry(entity).State = EntityState.Detached;

            return success;
        }

        public async Task Delete(Credential entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Credential> Get(int id)
        {
            return await _credentialContext.Credentials.FindAsync(id);
        }

        //Do not delete this. We might need this later.
        //public async Task<Credential> Get(string id)
        //{
        //    return await _credentialContext.Credentials.FindAsync(id);
        //}

        public async Task<IEnumerable<Credential>> GetAll()
        {
            return await _credentialContext.Credentials.ToListAsync();
        }

        public async Task Update(Credential entity)
        {
            //_credentialContext.Entry(dbEntity).CurrentValues.SetValues(entity);
            System.Diagnostics.Debug.Write("Updated credentials...");
        }
    }
}
