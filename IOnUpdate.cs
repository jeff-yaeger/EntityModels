namespace EntityModels
{
    using System;

    public interface IOnUpdate<TKey> where TKey : IEquatable<TKey>
    {
        void OnUpdate(TKey id, params object[] objects);
    }
}