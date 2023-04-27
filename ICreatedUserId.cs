namespace EntityModels
{
    using System;

    public interface ICreatedUserId<TKey> where TKey : IEquatable<TKey>
    {
        TKey CreatedUserId { get; set; }
    }
}