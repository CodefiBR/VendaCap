using System;
using Volo.Abp.Domain.Repositories;

namespace VendaCap.Common;

public interface IPersonRepository : IRepository<Person, Guid>
{
}
