using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvocateOS.Domain.Enums;

/// <summary>
/// اولویت وظیفه
/// </summary>
public enum TaskPriority
{
    /// <summary>
    /// پایین
    /// </summary>
    Low = 1,

    /// <summary>
    /// متوسط
    /// </summary>
    Medium = 2,

    /// <summary>
    /// بالا
    /// </summary>
    High = 3,

    /// <summary>
    /// فوری
    /// </summary>
    Urgent = 4
}