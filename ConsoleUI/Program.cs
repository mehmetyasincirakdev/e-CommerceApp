using Business.Concrete;
using DataAccess.Concrete.EntitFramework;
using DataAccess.Concrete.EntityFramework;

//ProductTest();
CategoryTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    foreach (var item in productManager.GetProductDetails())
        Console.WriteLine(item.ProductName + " ----- " + item.CategoryName + " ----- " + item.UnitPrice + " ----- " + item.UnitsInStock);
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    var categories = categoryManager.GetById(3);
    Console.WriteLine(categories.CategoryName);
    foreach (var category in categoryManager.GetAll())
        Console.WriteLine(category.CategoryId + "- " + category.CategoryName);
}