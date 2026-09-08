using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvocateOS.Domain.Enums;

/// <summary>
/// روش پرداخت
/// </summary>
public enum PaymentMethod
{
    /// <summary>
    /// نقدی
    /// </summary>
    Cash = 1,

    /// <summary>
    /// چک
    /// </summary>
    Check = 2,

    /// <summary>
    /// کارت به کارت
    /// </summary>
    CardToCard = 3,

    /// <summary>
    /// انتقال بانکی
    /// </summary>
    BankTransfer = 4,

    /// <summary>
    /// پرداخت الکترونیک
    /// </summary>
    Electronic = 5,

    /// <summary>
    /// سایر
    /// </summary>
    Other = 99
}
