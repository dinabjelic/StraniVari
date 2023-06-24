﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Base;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class AdministratorService : BaseCrudService<Administrator, AdministratorUpSertRequest, AdministratorUpSertRequest, GetAdministratorDetailsResponse>, IAdministratorService
    {
        private readonly StraniVariDbContext _straniVariDbContext;
        private readonly IPasswordHasher<User> _passwordHasher;
        public AdministratorService(StraniVariDbContext dbContext, IMapper mapper, IPasswordHasher<User> passwordHasher) : base(dbContext, mapper)
        {
            _straniVariDbContext = dbContext;
            _passwordHasher = passwordHasher; 
        }

        public override async Task Insert(AdministratorUpSertRequest addAdministratorRequest)
        {
            var administratorInfo = new User
            {
                FirstName = addAdministratorRequest.FirstName,
                LastName = addAdministratorRequest.LastName,
                UserName = addAdministratorRequest.Username.ToLower(),
                NormalizedUserName = addAdministratorRequest.Username.ToLower(),
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                LockoutEnabled = false,
                AccessFailedCount = 0
            };

            administratorInfo.PasswordHash = _passwordHasher.HashPassword(administratorInfo, addAdministratorRequest.Password);

            await _straniVariDbContext.Users.AddAsync(administratorInfo);

            await _straniVariDbContext.SaveChangesAsync();

            var role = await _straniVariDbContext.Roles.FirstOrDefaultAsync(x => x.Name == Role.Administrator);

            await _straniVariDbContext.UserRoles.AddAsync(new IdentityUserRole<int>
            {
                RoleId = role.Id,
                UserId = administratorInfo.Id
            });

            var newAdministrator = new Administrator
            {
                Id = administratorInfo.Id,
                FirstName = addAdministratorRequest.FirstName,
                LastName = addAdministratorRequest.LastName,
                Address = addAdministratorRequest.Address,
                City = addAdministratorRequest.City,
                DateOfBirth = addAdministratorRequest.DateOfBirth
            };

            await _straniVariDbContext.Administrators.AddAsync(newAdministrator);
            await _straniVariDbContext.SaveChangesAsync();
        }

        public override async Task<GetAdministratorDetailsResponse> GetById(int id)
        {
            var adminDetails = await _straniVariDbContext.Administrators
                .Include(x => x.User)
                .Select(x => new GetAdministratorDetailsResponse
                {
                    Id = x.Id,
                    FirstName = x.FirstName + " " + x.LastName + " " + x.Address + " " + x.City,
                    LastName = x.LastName,
                    Address = x.Address,
                    City = x.City,
                    DateOfBirth = x.DateOfBirth,
                    Username = x.User.UserName
                }).FirstOrDefaultAsync(x => x.Id == id);

            return adminDetails;
        }

        public override async Task Update(int id, AdministratorUpSertRequest updateAdministratorRequest)
        {
            if (updateAdministratorRequest == null)
            {
                throw new ArgumentException("Invalid request");
            }

            var adminFound = await _straniVariDbContext.Administrators.FirstOrDefaultAsync(x => x.Id == id);

            if (adminFound == null)
            {
                throw new ArgumentException("Invalid id");
            }

            var user = await _straniVariDbContext.Users.FirstOrDefaultAsync(x => x.Id == id);

            if (user == null)
            {
                throw new ArgumentException("Invalid id");
            }

            adminFound.FirstName = updateAdministratorRequest.FirstName;
            adminFound.LastName = updateAdministratorRequest.LastName;
            adminFound.Address = updateAdministratorRequest.Address;
            adminFound.City = updateAdministratorRequest.City;
            adminFound.DateOfBirth = updateAdministratorRequest.DateOfBirth;
            adminFound.User.UserName = updateAdministratorRequest.Username;

            user.UserName = updateAdministratorRequest.Username.ToLower();
            user.NormalizedUserName = user.UserName;

            if (!string.IsNullOrWhiteSpace(updateAdministratorRequest.Password))
            {
                user.PasswordHash = _passwordHasher.HashPassword(user, updateAdministratorRequest.Password);
            }

            _straniVariDbContext.Administrators.Update(adminFound);
            await _straniVariDbContext.SaveChangesAsync();
        }

        public override async Task<List<GetAdministratorDetailsResponse>> GetAll()
        {
            var volunteerList = await _straniVariDbContext.Administrators
                .Include(x => x.User)
                .Select(x => new GetAdministratorDetailsResponse
                {
                    Id = x.Id,
                    //FirstName = x.FirstName + " " + x.LastName + " " + x.Address + " " + x.City,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Address = x.Address,
                    City = x.City,
                    DateOfBirth = x.DateOfBirth,
                    Username = x.User.UserName
                }).ToListAsync();

            return volunteerList;
        }
    }
}