using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Resumification.EntityFrameworkCore;
using Resumification.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Resumification.Web.Tests
{
    [DependsOn(
        typeof(ResumificationWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ResumificationWebTestModule : AbpModule
    {
        public ResumificationWebTestModule(ResumificationEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ResumificationWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ResumificationWebMvcModule).Assembly);
        }
    }
}