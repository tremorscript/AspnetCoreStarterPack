using Northwind.Core.Configuration;

namespace Northwind.Core.Domain.Directory;

/// <summary>
/// Measure settings
/// </summary>
public partial class MeasureSettings : ISettings
{
    /// <summary>
    /// Base dimension identifier
    /// </summary>
    public int BaseDimensionId { get; set; }

    /// <summary>
    /// Base weight identifier
    /// </summary>
    public int BaseWeightId { get; set; }
}