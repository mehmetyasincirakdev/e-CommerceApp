using Business.Concrete;
using DataAccess.Concrete.EntitFramework;
using DataAccess.Concrete.EntityFramework;

//ProductTest();
CategoryTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    var result = productManager.GetProductDetails();
    foreach (var item in result.Data)
        Console.WriteLine(item.ProductName + " ----- " + item.CategoryName + " ----- " + item.UnitPrice + " ----- " + item.UnitsInStock);
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    var result = categoryManager.GetAll();
    foreach (var category in result.Data)
        Console.WriteLine(category.CategoryId + "- " + category.CategoryName);
}