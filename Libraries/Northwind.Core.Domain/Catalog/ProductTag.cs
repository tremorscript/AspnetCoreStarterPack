using Northwind.Core.Domain.Abstractions;
using Northwind.Core.Domain.Localization;
using Northwind.Core.Domain.Seo;

namespace Northwind.Core.Domain.Catalog;

/// <summary>
/// Represents a product tag
/// </summary>
public partial class ProductTag : BaseEntity, ILocalizedEntity, ISlugSupported
{
    /// <summary>
    /// Gets or sets the name
    /// </summary>
    public string Name { get; set; }
}