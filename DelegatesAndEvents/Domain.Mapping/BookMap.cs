using Model.Models;

namespace Domain.Mapping
{
    public class BookMap : EntityMap<Book>
    {
        public BookMap()
        {
            Map(x => x.Name).Not.Nullable().Access.ReadOnly();
            Map(x => x.Description).Not.Nullable();
            Map(x => x.PublicationDate).Not.Nullable();
            Map(x => x.Status).Not.Nullable();
            Map(x => x.HowOldIs).Not.Nullable();
            HasMany(x => x.Authors).Cascade.SaveUpdate().Inverse();
        }
    }
}
