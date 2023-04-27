namespace EntityModels
{
    using System;

    public interface IOnAdd<TKey> where TKey : IEquatable<TKey>
    {
        void OnAdd(TKey id, params object[] objects);
    }
}