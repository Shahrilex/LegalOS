using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvocateOS.Domain.Enums;

/// <summary>
/// وضعیت صورتحساب
/// </summary>
public enum InvoiceStatus
{
    /// <summary>
    /// پیش‌نویس
    /// </summary>
    Draft = 1,

    /// <summary>
    /// صادر شده
    /// </summary>
    Issued = 2,

    /// <summary>
    /// ارسال شده
    /// </summary>
    Sent = 3,

    /// <summary>
    /// پرداخت نشده
    /// </summary>
    Unpaid = 4,

    /// <summary>
    /// پرداخت جزئی
    /// </summary>
    PartiallyPaid = 5,

    /// <summary>
    /// پرداخت شده
    /// </summary>
    Paid = 6,

    /// <summary>
    /// سررسید گذشته
    /// </summary>
    Overdue = 7,

    /// <summary>
    /// لغو شده
    /// </summary>
    Cancelled = 8
}
