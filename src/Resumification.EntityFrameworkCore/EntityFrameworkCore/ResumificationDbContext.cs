using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Resumification.Authorization.Roles;
using Resumification.Authorization.Users;
using Resumification.MultiTenancy;

namespace Resumification.EntityFrameworkCore
{
    public class ResumificationDbContext : AbpZeroDbContext<Tenant, Role, User, ResumificationDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ResumificationDbContext(DbContextOptions<ResumificationDbContext> options)
            : base(options)
        {
        }
    }
}
