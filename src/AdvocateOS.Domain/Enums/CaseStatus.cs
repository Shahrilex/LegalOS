using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvocateOS.Domain.Enums;

/// <summary>
/// وضعیت پرونده
/// </summary>
public enum CaseStatus
{
    /// <summary>
    /// پیش‌نویس
    /// </summary>
    Draft = 1,

    /// <summary>
    /// ثبت شده
    /// </summary>
    Filed = 2,

    /// <summary>
    /// در حال رسیدگی
    /// </summary>
    InProgress = 3,

    /// <summary>
    /// معلق
    /// </summary>
    OnHold = 4,

    /// <summary>
    /// منتظر حکم
    /// </summary>
    AwaitingJudgment = 5,

    /// <summary>
    /// صدور حکم
    /// </summary>
    Judged = 6,

    /// <summary>
    /// در مرحله تجدیدنظر
    /// </summary>
    OnAppeal = 7,

    /// <summary>
    /// در مرحله اجرا
    /// </summary>
    InExecution = 8,

    /// <summary>
    /// مختومه
    /// </summary>
    Closed = 9,

    /// <summary>
    /// لغو شده
    /// </summary>
    Cancelled = 10,

    /// <summary>
    /// سازش
    /// </summary>
    Settled = 11
}
