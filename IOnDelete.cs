namespace EntityModels
{
    using System;

    public interface IOnDelete<TKey> where TKey : IEquatable<TKey>
    {
        void OnDelete(TKey id, params object[] objects);
    }
}