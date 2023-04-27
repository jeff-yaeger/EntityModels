namespace EntityModels
{
    using System;

    public interface ILastUpdatedUserId<TKey> where TKey : IEquatable<TKey>
    {
        TKey LastUpdatedUserId { get; set; }
    }
}