﻿using Northwind.Core.Domain.Abstractions;

namespace Northwind.Core.Domain.Customers;

/// <summary>
/// Represents a customer-address mapping class
/// </summary>
public partial class CustomerAddressMapping : BaseEntity
{
    /// <summary>
    /// Gets or sets the customer identifier
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// Gets or sets the address identifier
    /// </summary>
    public int AddressId { get; set; }
}