namespace EntityModels
{
    public interface ISoftDelete
    {
        bool Active { get; set; }
    }
}