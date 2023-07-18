//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.

List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "The Raven and Other Poems",
        Price = 30.00M,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "What We Lost In The Swamp",
        Price = 20.00M,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "Milk and Honey",
        Price = 15.00M,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "Bugle",
        Price = 300.00M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Trumpet",
        Price = 200.00M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Trombone",
        Price = 150.00M,
        ProductTypeId = 1
    }
};

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 

List<ProductType> productTypes = new List<ProductType>()
{
    new ProductType()
    {
        Title = "Brass",
        Id = 1,
    },
    new ProductType()
    {
        Title = "Poem",
        Id = 2,
    }
};

//put your greeting here

string welcome = "Welcome to Brass and Poem!";
Console.WriteLine(welcome);

//implement your loop here

DisplayMenu();

void DisplayMenu()
{
    string choice = null;
    while (choice != "5")
    {
        Console.WriteLine(@"Please choose an option:
                                1. Display All Products
                                2. Delete a Product
                                3. Add a new Product
                                4. Update Product Properties
                                5. Exit");
        choice = Console.ReadLine();
        if (choice == "5")
        {
            Console.WriteLine("Thank you, come again!");
        }
        else if (choice == "1")
        {
            DisplayAllProducts(products, productTypes);
        }
        else if (choice == "2") 
        {
            DeleteProduct(products, productTypes);        
        }
        else if (choice == "3")
        {
            AddProduct(products, productTypes);
        }
        else if (choice == "4")
        {
            UpdateProduct(products, productTypes);
        }
    };

}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }
