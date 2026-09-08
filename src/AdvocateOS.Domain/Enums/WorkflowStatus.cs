using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvocateOS.Domain.Enums;

/// <summary>
/// وضعیت گردش کار
/// </summary>
public enum WorkflowStatus
{
    /// <summary>
    /// فعال
    /// </summary>
    Active = 1,

    /// <summary>
    /// در انتظار
    /// </summary>
    Pending = 2,

    /// <summary>
    /// تکمیل شده
    /// </summary>
    Completed = 3,

    /// <summary>
    /// لغو شده
    /// </summary>
    Cancelled = 4
}
