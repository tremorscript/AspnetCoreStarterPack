﻿using Northwind.Core.Domain.Abstractions;
using Northwind.Core.Domain.Localization;

namespace Northwind.Core.Domain.Orders;

/// <summary>
/// Represents a return request action
/// </summary>
public partial class ReturnRequestAction : BaseEntity, ILocalizedEntity
{
    /// <summary>
    /// Gets or sets the name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the display order
    /// </summary>
    public int DisplayOrder { get; set; }
}