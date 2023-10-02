using AutoMapper;
using BancoFinandina.Domain;
using BancoFinandina.Persistence.Database;
using BancoFinandina.Service.Queries.DTOs;
using BancoFinandina.Service.Queries.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BancoFinandina.Service.Queries
{
    public class BancoFinandinaQueryService : IBancoFinandinaQueryService
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public BancoFinandinaQueryService(IMapper mapper, ApplicationDbContext applicationDbContext)
        {
            _mapper = mapper;
            _context = applicationDbContext;
        }
        public void AddUser(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            _context.Add(user);
        }
        public async Task<IEnumerable<UserDto>> GetUsersAsync()
        {
            return _mapper.Map<List<UserDto>>(await _context.Users.AsNoTracking().ToListAsync());
        }
        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}