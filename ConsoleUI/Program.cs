using Business.Concrete;
using DataAccess.Concrete.EntitFramework;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

ProductTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    foreach (var item in productManager.GetProductDetails())
        Console.WriteLine(item.ProductName + " ----- " + item.CategoryName + " ----- " + item.UnitPrice + " ----- " + item.UnitsInStock);
}