namespace Mijalski.EntityFrameworkCore.Generics
{
    public abstract class Entity<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
    }
}