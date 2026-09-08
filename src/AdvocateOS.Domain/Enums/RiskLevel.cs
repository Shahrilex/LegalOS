using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvocateOS.Domain.Enums;

/// <summary>
/// سطح ریسک پرونده
/// </summary>
public enum RiskLevel
{
    /// <summary>
    /// پایین (0-40)
    /// </summary>
    Low = 1,

    /// <summary>
    /// متوسط (40-60)
    /// </summary>
    Medium = 2,

    /// <summary>
    /// بالا (60-80)
    /// </summary>
    High = 3,

    /// <summary>
    /// بحرانی (80-100)
    /// </summary>
    Critical = 4
}
