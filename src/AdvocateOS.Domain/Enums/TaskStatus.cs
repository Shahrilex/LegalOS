using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvocateOS.Domain.Enums;

/// <summary>
/// وضعیت وظیفه
/// </summary>
public enum TaskStatus
{
    /// <summary>
    /// در انتظار
    /// </summary>
    Pending = 1,

    /// <summary>
    /// در حال انجام
    /// </summary>
    InProgress = 2,

    /// <summary>
    /// تکمیل شده
    /// </summary>
    Completed = 3,

    /// <summary>
    /// لغو شده
    /// </summary>
    Cancelled = 4
}