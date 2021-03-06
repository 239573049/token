using token.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace token.DbMigrator;

/// <summary>
/// 
/// </summary>
[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TokenEntityFrameworkCoreModule)
)]
public class TokenDbMigratorModule : AbpModule
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
    }
}