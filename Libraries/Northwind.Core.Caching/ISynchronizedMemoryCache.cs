﻿using Microsoft.Extensions.Caching.Memory;

namespace Northwind.Core.Caching;

/// <summary>
/// Represents a local in-memory cache with distributed synchronization
/// </summary>
public partial interface ISynchronizedMemoryCache : IMemoryCache
{
}