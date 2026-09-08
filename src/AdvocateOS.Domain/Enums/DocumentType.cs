using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvocateOS.Domain.Enums;

/// <summary>
/// انواع اسناد حقوقی
/// </summary>
public enum DocumentType
{
    /// <summary>
    /// دادخواست
    /// </summary>
    Petition = 1,

    /// <summary>
    /// الیحه
    /// </summary>
    Statement = 2,

    /// <summary>
    /// لایحه دفاعیه
    /// </summary>
    DefenseBrief = 3,

    /// <summary>
    /// قرارداد
    /// </summary>
    Contract = 4,

    /// <summary>
    /// وکالتنامه
    /// </summary>
    PowerOfAttorney = 5,

    /// <summary>
    /// مفاصاحساب
    /// </summary>
    Settlement = 6,

    /// <summary>
    /// رأی/حکم
    /// </summary>
    Judgment = 7,

    /// <summary>
    /// قرار
    /// </summary>
    CourtOrder = 8,

    /// <summary>
    /// اجرائیه
    /// </summary>
    ExecutionOrder = 9,

    /// <summary>
    /// شکایت
    /// </summary>
    Complaint = 10,

    /// <summary>
    /// صورتجلسه
    /// </summary>
    Minutes = 11,

    /// <summary>
    /// مدارک هویتی
    /// </summary>
    IdentityDocuments = 12,

    /// <summary>
    /// مستندات مالی
    /// </summary>
    FinancialDocuments = 13,

    /// <summary>
    /// سایر
    /// </summary>
    Other = 99
}
