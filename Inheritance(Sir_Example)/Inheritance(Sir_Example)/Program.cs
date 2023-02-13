


using Inheritance_Sir_Example_;

/*
Camera camera1 = new Camera();
camera1.Name = "Canon";
camera1.Model = "Canon 1200D";
camera1.ZoomCapacity = 75.300;

camera1.ProductInfo();

*/

Electronics electronics = new Electronics("Printer");
electronics.Brand = "Canon";
electronics.Price = 8000;
electronics.Description = "This is a Canon Printer";
Console.WriteLine(electronics.ShortDescription());

Book book = new Book("C#", 300);
book.Author = "Ashraful Alam";
book.Price = 500;
book.Description = "This is a big big description";
Console.WriteLine(book.ShortDescription());

