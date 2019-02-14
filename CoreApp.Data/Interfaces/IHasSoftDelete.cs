namespace CoreApp.Data.Interfaces
{
    public interface IHasSoftDelete
    {
        bool IsDeleted { get; set; }
    }
}