using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvocateOS.Domain.Enums;

/// <summary>
/// انواع پرونده حقوقی
/// </summary>
public enum CaseType
{
    /// <summary>
    /// حقوقی
    /// </summary>
    Civil = 1,

    /// <summary>
    /// کیفری
    /// </summary>
    Criminal = 2,

    /// <summary>
    /// خانواده
    /// </summary>
    Family = 3,

    /// <summary>
    /// تجاری
    /// </summary>
    Commercial = 4,

    /// <summary>
    /// اداری
    /// </summary>
    Administrative = 5,

    /// <summary>
    /// کار
    /// </summary>
    Labor = 6,

    /// <summary>
    /// ثبتی
    /// </summary>
    Registration = 7,

    /// <summary>
    /// سایر
    /// </summary>
    Other = 99
}