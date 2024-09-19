using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Resumification.Authorization;

namespace Resumification
{
    [DependsOn(
        typeof(ResumificationCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ResumificationApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ResumificationAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ResumificationApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
