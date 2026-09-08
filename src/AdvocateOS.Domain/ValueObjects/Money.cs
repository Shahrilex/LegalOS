using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvocateOS.Domain.ValueObjects;

/// <summary>
/// Value Object برای مبلغ پول
/// </summary>
public class Money : ValueObject
{
    public decimal Amount { get; private set; }
    public string Currency { get; private set; }

    private Money() { } // For EF Core

    public Money(decimal amount, string currency = "IRR")
    {
        if (amount < 0)
            throw new ArgumentException("مبلغ نمی‌تواند منفی باشد", nameof(amount));

        if (string.IsNullOrWhiteSpace(currency))
            throw new ArgumentException("واحد پولی نمی‌تواند خالی باشد", nameof(currency));

        Amount = amount;
        Currency = currency.ToUpperInvariant();
    }

    public Money Add(Money other)
    {
        if (Currency != other.Currency)
            throw new InvalidOperationException("نمی‌توان مبالغ با واحد پولی متفاوت را جمع کرد");

        return new Money(Amount + other.Amount, Currency);
    }

    public Money Subtract(Money other)
    {
        if (Currency != other.Currency)
            throw new InvalidOperationException("نمی‌توان مبالغ با واحد پولی متفاوت را تفریق کرد");

        return new Money(Amount - other.Amount, Currency);
    }

    public Money Multiply(decimal multiplier)
    {
        return new Money(Amount * multiplier, Currency);
    }

    public static Money Zero(string currency = "IRR") => new Money(0, currency);

    protected override IEnumerable<object?> GetEqualityComponents()
    {
        yield return Amount;
        yield return Currency;
    }

    public override string ToString() => $"{Amount:N0} {Currency}";
}
