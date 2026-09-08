using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvocateOS.Domain.Enums;

/// <summary>
/// وضعیت جلسه دادگاه
/// </summary>
public enum HearingStatus
{
    /// <summary>
    /// برنامه‌ریزی شده
    /// </summary>
    Scheduled = 1,

    /// <summary>
    /// تأیید شده
    /// </summary>
    Confirmed = 2,

    /// <summary>
    /// برگزار شده
    /// </summary>
    Held = 3,

    /// <summary>
    /// موکول شده
    /// </summary>
    Postponed = 4,

    /// <summary>
    /// لغو شده
    /// </summary>
    Cancelled = 5
}
