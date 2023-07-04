using AutoMapper;
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
    public class VolunteerService: BaseCrudService<Volunteer, VolunteerUpSertRequest, VolunteerUpSertRequest, GetVolunteerDetailsResposne>, IVolunteerService
    {
        private readonly StraniVariDbContext _straniVariDbContext;
        private readonly IPasswordHasher<User> _passwordHasher;

        public VolunteerService
        (
            StraniVariDbContext straniVariDbContext,
            IMapper mapper,
            IPasswordHasher<User> passwordHasher
        ) : base(straniVariDbContext, mapper)
        {
            _straniVariDbContext = straniVariDbContext;
            _passwordHasher = passwordHasher;
        }

        public override async Task Insert(VolunteerUpSertRequest addVolunteerRequest)
        {
            var volunteerInfo = new User
            {
                FirstName = addVolunteerRequest.FirstName,
                LastName = addVolunteerRequest.LastName,
                UserName = addVolunteerRequest.Username.ToLower(),
                NormalizedUserName = addVolunteerRequest.Username.ToLower(),
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                LockoutEnabled = false,
                AccessFailedCount = 0
            };

            volunteerInfo.PasswordHash = _passwordHasher.HashPassword(volunteerInfo, addVolunteerRequest.Password);
            var existst =await _straniVariDbContext.Users.AnyAsync(x => x.UserName == volunteerInfo.UserName);

            if (existst)
            {
                throw new InvalidOperationException("Username taken!");
            }

            await _straniVariDbContext.Users.AddAsync(volunteerInfo);

            await _straniVariDbContext.SaveChangesAsync();

            var role = await _straniVariDbContext.Roles.FirstOrDefaultAsync(x => x.Name == Role.RegularUser);

            await _straniVariDbContext.UserRoles.AddAsync(new IdentityUserRole<int>
            {
                RoleId = role.Id,
                UserId = volunteerInfo.Id
            });

            var newVolunteer = new Volunteer
            {
                Id = volunteerInfo.Id,
                FirstName = addVolunteerRequest.FirstName,
                LastName = addVolunteerRequest.LastName,
                Address = addVolunteerRequest.Address,
                City = addVolunteerRequest.City,
                DateOfBirth = addVolunteerRequest.DateOfBirth,
                StartDateOfVolunteering = addVolunteerRequest.StartDateOfVolunteering,
            };

            await _straniVariDbContext.Volunteers.AddAsync(newVolunteer);
            await _straniVariDbContext.SaveChangesAsync();
        }

        public override async Task<GetVolunteerDetailsResposne> GetById(int id)
        {
            var volunteerDetails = await _straniVariDbContext.Volunteers
                .Include(x => x.User)
                .Select(x => new GetVolunteerDetailsResposne
                {
                    Id = x.Id,
                    FirstName = x.FirstName + " " + x.LastName + " " + x.Address + " " + x.City,
                    LastName = x.LastName,
                    Address = x.Address,
                    City = x.City,
                    DateOfBirth = x.DateOfBirth,
                    StartDateOfVolunteering = x.StartDateOfVolunteering,
                    Username = x.User.UserName
                }).FirstOrDefaultAsync(x => x.Id == id);

            return volunteerDetails;
        }

        public override async Task Update(int id, VolunteerUpSertRequest updateVolunteerRequest)
        {
            if (updateVolunteerRequest == null)
            {
                throw new ArgumentException("Invalid request");
            }

            var volunteerFound = await _straniVariDbContext.Volunteers.FirstOrDefaultAsync(x => x.Id == id);

            if(volunteerFound==null)
            {
                throw new ArgumentException("Invalid id");
            }

            var user = await _straniVariDbContext.Users.FirstOrDefaultAsync(x => x.Id == id);

            if(user == null)
            {
                throw new ArgumentException("Invalid id");
            }

            if (volunteerFound.User.UserName != updateVolunteerRequest.Username)
            {
                var usernameExists = await _straniVariDbContext.Users
                    .AnyAsync(x => x.Id != id && x.UserName == updateVolunteerRequest.Username);

                if (usernameExists)
                {
                    throw new InvalidOperationException("Username taken!");
                }
            }

            volunteerFound.FirstName = updateVolunteerRequest.FirstName;
            volunteerFound.LastName = updateVolunteerRequest.LastName;
            volunteerFound.Address = updateVolunteerRequest.Address;
            volunteerFound.City = updateVolunteerRequest.City;
            volunteerFound.DateOfBirth = updateVolunteerRequest.DateOfBirth;
            volunteerFound.StartDateOfVolunteering = updateVolunteerRequest.StartDateOfVolunteering;
            volunteerFound.User.UserName = updateVolunteerRequest.Username;

            user.UserName = updateVolunteerRequest.Username.ToLower();
            user.NormalizedUserName = user.UserName;

            if (!string.IsNullOrWhiteSpace(updateVolunteerRequest.Password))
            {
                user.PasswordHash = _passwordHasher.HashPassword(user, updateVolunteerRequest.Password);
            }

            _straniVariDbContext.Volunteers.Update(volunteerFound);
            await _straniVariDbContext.SaveChangesAsync();
        }

        public override async Task<List<GetVolunteerDetailsResposne>> GetAll()
        {
            var volunteerList = await _straniVariDbContext.Volunteers
                .Include(x => x.User)
                .Select(x => new GetVolunteerDetailsResposne
                {
                    Id = x.Id,
                    //FirstName = x.FirstName + " " + x.LastName + " " + x.Address + " " + x.City,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Address = x.Address,
                    City = x.City,
                    DateOfBirth = x.DateOfBirth,
                    StartDateOfVolunteering = x.StartDateOfVolunteering,
                    Username = x.User.UserName
                }).ToListAsync();

            return volunteerList;
        }

        public async Task<List<GetVolunteerDetailsResposne>> GetFilteredUsers(string searchTerm)
        {
            var filteredData = await _straniVariDbContext.Volunteers.Select(x=> new GetVolunteerDetailsResposne
            {
                Id = x.Id, 
                City = x.City, 
                Address = x.Address, 
                DateOfBirth = x.DateOfBirth, 
                FirstName= x.FirstName, 
                LastName= x.LastName 
            }).ToListAsync();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                filteredData = filteredData.Where(x => (x.FirstName + " " + x.LastName).ToLower().Contains(searchTerm.ToLower())).ToList();
            }

            return filteredData;
        }
    }
}
