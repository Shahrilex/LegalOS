using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvocateOS.Domain.Interfaces;

/// <summary>
/// رابط برای موجودیت‌هایی که دارای رویدادهای دامنه هستند
/// </summary>
public interface IHasDomainEvents
{
    IReadOnlyCollection<IDomainEvent> DomainEvents { get; }
    void ClearDomainEvents();
}