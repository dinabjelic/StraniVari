using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class VolunteerService: IVolunteerService
    {
        private readonly StraniVariDbContext _straniVariDbContext;
        private readonly IPasswordHasher<User> _passwordHasher;

        public VolunteerService
        (
            StraniVariDbContext straniVariDbContext,
            IPasswordHasher<User> passwordHasher
        )
        {
            _straniVariDbContext = straniVariDbContext;
            _passwordHasher = passwordHasher;
        }

        public async Task AddVolunteerAsync(VolunteerUpSertRequest addVolunteerRequest)
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

        public async Task DeleteVolunteerAsync(int id)
        {
            var volunteer = await _straniVariDbContext.Volunteers.FirstOrDefaultAsync(x => x.Id == id);

            if (volunteer == null)
            {
                throw new ArgumentException("Invalid id");
            }

            _straniVariDbContext.Volunteers.Remove(volunteer);
            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task<GetVolunteerDetailsResposne> GetVolunteerDetailsAsync(int id)
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

        public async Task UpdateVolunteerAsync(int id, VolunteerUpSertRequest updateVolunteerRequest)
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

            volunteerFound.FirstName = updateVolunteerRequest.FirstName;
            volunteerFound.LastName = updateVolunteerRequest.LastName;
            volunteerFound.Address = updateVolunteerRequest.Address;
            volunteerFound.City = updateVolunteerRequest.City;
            volunteerFound.DateOfBirth = updateVolunteerRequest.DateOfBirth;
            volunteerFound.StartDateOfVolunteering = updateVolunteerRequest.StartDateOfVolunteering;

            user.UserName = updateVolunteerRequest.Username.ToLower();
            user.NormalizedUserName = user.UserName;

            if (!string.IsNullOrWhiteSpace(updateVolunteerRequest.Password))
            {
                user.PasswordHash = _passwordHasher.HashPassword(user, updateVolunteerRequest.Password);
            }

            _straniVariDbContext.Volunteers.Update(volunteerFound);
            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task<List<GetVolunteerDetailsResposne>> VolunteerListAsync()
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
    }
}
