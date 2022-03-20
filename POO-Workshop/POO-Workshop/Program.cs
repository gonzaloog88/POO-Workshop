// See https://aka.ms/new-console-template for more information
using POO_Workshop;

Console.WriteLine("PRODUCTS");
Console.WriteLine("========");


Product product1 = new FixedPriceProduct()
{
    Description = "Vino Gato Negro",
    Id = 1010,
    Price = 46000M,
    Tax = 0.19F
};
Console.WriteLine(product1);

Product product2 = new FixedPriceProduct()
{
    Description = "Pan Bimbo Artesanal",
    Id = 2020,
    Price = 1560M,
    Tax = 0.19F
};
Console.WriteLine(product2);