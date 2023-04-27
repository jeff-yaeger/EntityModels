namespace EntityModels
{
    using System;

    public interface ICreated<TKey> : ICreatedDate, ICreatedUserId<TKey> where TKey : IEquatable<TKey>
    {
    }
}