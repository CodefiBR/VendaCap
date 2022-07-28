using System.Threading.Tasks;

namespace VendaCap.Data;

public interface IVendaCapDbSchemaMigrator
{
    Task MigrateAsync();
}
