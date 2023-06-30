using celilcavus.Udemy.EFCoreDatabaseFirst.DAL;

DbContextInitializer.Build();
using (var _context = new AppDbContext())
{
    var getValues = _context.Products.ToList();
    getValues.ForEach(x =>
    {
        Console.WriteLine($"ID : {x.id}  : {x.Name} : {x.Price} : {x.Stock}");
    });
}
