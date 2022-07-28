using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace VendaCap.Data;

/* This is used if database provider does't define
 * IVendaCapDbSchemaMigrator implementation.
 */
public class NullVendaCapDbSchemaMigrator : IVendaCapDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
