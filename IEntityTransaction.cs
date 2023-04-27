namespace EntityModels
{
    using System;

    public interface IEntityTransaction<TKey> : IOnAdd<TKey>, IOnUpdate<TKey>, IOnDelete<TKey> where TKey : IEquatable<TKey>
    {
    }
}