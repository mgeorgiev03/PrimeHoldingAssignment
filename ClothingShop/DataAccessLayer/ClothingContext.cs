using BusinessLayer;

namespace DataAccessLayer
{
    // clothing context was used to easily change data in the database during testing
    // now is obsolete
    public class ClothingContext
    {
        private readonly Context context;
        public ClothingContext(Context context)
        {
            this.context = context;
        }

        public void Create(Clothing clothing)
        {
            context.Clothes.Add(clothing);
            context.SaveChanges();
        }

        public Clothing? Read(string key)
        {
            return context.Clothes.Find(key);
        }

        public ICollection<Clothing>? ReadAll()
        {
            return context.Clothes as ICollection<Clothing>;
        }

        public void Update(Clothing clothing)
        {
            Clothing? clothingInDb = context.Clothes.Find(clothing.Name);
            context.Entry(clothingInDb).CurrentValues.SetValues(clothing);
            context.SaveChanges();
        }

        public void Delete(string key)
        {
            context.Clothes.Remove(context.Clothes.Find(key));
            context.SaveChanges();
        }
    }
}
