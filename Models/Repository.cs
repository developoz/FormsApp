namespace FormsApp.Models
    {
        public class Repository
        {
            private static readonly List<Product> _products = new();
            private static readonly List<Category> _categories = new();

            static Repository()
            {
                _categories.Add(new Category { CategoryId=1 , Name="Telefon"});
                _categories.Add(new Category { CategoryId=2 , Name="Bilgisayar"});

                _products.Add(new Product { ProductId=1 , Name="İphone 14", Price = 30000 , IsActive = true , Image="1.jpg" , CategoryId=1 });

                _products.Add(new Product { ProductId=2 , Name="İphone 15", Price = 45000 , IsActive = true , Image="2.jpg" , CategoryId=1 });

                _products.Add(new Product { ProductId=3 , Name="İphone 16", Price = 55000 , IsActive = true , Image="3.jpg" , CategoryId=1 });

                _products.Add(new Product { ProductId=4 , Name="İphone 17", Price = 65000 , IsActive = true , Image="4.jpg" , CategoryId=1 });


                _products.Add(new Product { ProductId=5 , Name="Gaming Laptop", Price = 40000 , IsActive = true , Image="5.jpg" , CategoryId=2 });

                _products.Add(new Product { ProductId=6 , Name="İş Laptop", Price = 35000 , IsActive = true , Image="6.jpg" , CategoryId=2 });

            }

            public static List<Product> Products
            {
                get{
                    return _products;
                }
            }

            public static List<Category> Categories
            {
                get{
                    return _categories;
                }
            }

        }
    }