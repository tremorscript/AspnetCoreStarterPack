﻿using Northwind.Core.Configuration;

namespace Northwind.Core.Domain.Messages;

/// <summary>
/// Email account settings
/// </summary>
public partial class EmailAccountSettings : ISettings
{
    /// <summary>
    /// Gets or sets a store default email account identifier
    /// </summary>
    public int DefaultEmailAccountId { get; set; }
}