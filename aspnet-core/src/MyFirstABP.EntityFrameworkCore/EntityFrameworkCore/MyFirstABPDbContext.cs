using Abp.Zero.EntityFrameworkCore;
using MyFirstABP.Authorization.Roles;
using MyFirstABP.Authorization.Users;
using MyFirstABP.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace MyFirstABP.EntityFrameworkCore
{
    public class MyFirstABPDbContext : AbpZeroDbContext<Tenant, Role, User, MyFirstABPDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public MyFirstABPDbContext(DbContextOptions<MyFirstABPDbContext> options)
            : base(options)
        {

        }
    }
}
