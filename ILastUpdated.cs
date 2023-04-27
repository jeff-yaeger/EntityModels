namespace EntityModels
{
    using System;

    public interface ILastUpdated<TKey> : ILastUpdatedDate, ILastUpdatedUserId<TKey> where TKey : IEquatable<TKey>
    {
    }
}