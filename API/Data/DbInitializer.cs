using API.Entities;

namespace API.Data
{
    // static, moze da se koristi klasa bez poziva instance
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Brašno-danubius",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 55,
                    PictureUrl = "/images/products/brasno-danubius.png",
                    Brand = "Danubius",
                    Type = "Brasno",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Griz Začin C",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 120,
                    PictureUrl = "/images/products/brasno-griz.png",
                    Brand = "ZacinC",
                    Type = "Brasno",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Brašno Kikindsko",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 133,
                    PictureUrl = "/images/products/brasno-kikindski.png",
                    Brand = "Kikindsko",
                    Type = "Brasno",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Brašno Mlinar",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 155,
                    PictureUrl = "/images/products/brasno-mlinar.png",
                    Brand = "Žitab",
                    Type = "Brasno",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Brašno Senćansko",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 221,
                    PictureUrl = "/images/products/brasno-sentella.png",
                    Brand = "Senella",
                    Type = "Brasno",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Puding C Banana",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 35,
                    PictureUrl = "/images/products/puding-c-banana.png",
                    Brand = "ZacinC",
                    Type = "Puding",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Puding C Jagoda",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 43,
                    PictureUrl = "/images/products/puding-c-jagoda.png",
                    Brand = "ZacinC",
                    Type = "Puding",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Puding C Slatka Pavlaka",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 8000,
                    PictureUrl = "/images/products/puding-c-slatka.png",
                    Brand = "ZacinC",
                    Type = "Puding",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Puding C Vanila",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 28,
                    PictureUrl = "/images/products/puding-c-vanila.png",
                    Brand = "ZacinC",
                    Type = "Puding",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "DrOetker puding narandza",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 120,
                    PictureUrl = "/images/products/puding-dr-oetker1.png",
                    Brand = "DrOetker",
                    Type = "Puding",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "DrOetker puding breskva",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 135,
                    PictureUrl = "/images/products/puding-dr-oetker2.png",
                    Brand = "DrOetker",
                    Type = "Puding",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "DrOetker Puding Original",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 75,
                    PictureUrl = "/images/products/puding-dr-oetker3.png",
                    Brand = "DrOetker",
                    Type = "Puding",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Šećer ZačinC",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 88,
                    PictureUrl = "/images/products/secer-c.png",
                    Brand = "ZacinC",
                    Type = "Secer",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Šećer Crvenka",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 77,
                    PictureUrl = "/images/products/secer-crvenka.png",
                    Brand = "Crvenka",
                    Type = "Secer",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Šećer Sunoko",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 67,
                    PictureUrl = "/images/products/secer-sunoko.png",
                    Brand = "Sunoko",
                    Type = "Secer",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Šećer u prahu Sunoko",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 55,
                    PictureUrl = "/images/products/secer-u-prahu-sunoko.png",
                    Brand = "Sunoko",
                    Type = "Secer",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Jabukovo Sirće",
                    Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                    Price = 225,
                    PictureUrl = "/images/products/jabukovo-sirce.png",
                    Brand = "Nektar",
                    Type = "Sirce",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Alkoholno Sirće",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 187,
                    PictureUrl = "/images/products/alkoholno-sirce.png",
                    Brand = "KPlus",
                    Type = "Sirce",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Limunov Sok",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 124,
                    PictureUrl = "/images/products/limunov-sok.png",
                    Brand = "Limmi",
                    Type = "Sirce",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Vinsko Sirće",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 299,
                    PictureUrl = "/images/products/vinsko-sirce.png",
                    Brand = "Aleksic",
                    Type = "Sirce",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Šlag C Fantastiko",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 120,
                    PictureUrl = "/images/products/slag-c-fantastico.png",
                    Brand = "ZacinC",
                    Type = "Slag",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Šlag Dr Oetker pena",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 221,
                    PictureUrl = "/images/products/slag-dr-oetker.png",
                    Brand = "DrOetker",
                    Type = "Slag",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Šlag C krem",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 144,
                    PictureUrl = "/images/products/slag-krem-c-beli.png",
                    Brand = "ZacinC",
                    Type = "Slag",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Šlag Meggle",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 399,
                    PictureUrl = "/images/products/slag-meggle.png",
                    Brand = "Meggle",
                    Type = "Slag",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Tuzlanska So",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 99,
                    PictureUrl = "/images/products/so-tuzlanska.png",
                    Brand = "Tuzlanska",
                    Type = "So",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Morska So",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 139,
                    PictureUrl = "/images/products/morska-so.png",
                    Brand = "Morska",
                    Type = "So",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Barilla Bavette",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 355,
                    PictureUrl = "/images/products/barilla-bavette.png",
                    Brand = "Barilla",
                    Type = "Testenina",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Barilla Farfalle",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 399,
                    PictureUrl = "/images/products/barilla-farfalle.png",
                    Brand = "Barilla",
                    Type = "Testenina",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Barilla Pene",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 379,
                    PictureUrl = "/images/products/barilla-pene.png",
                    Brand = "Barilla",
                    Type = "Testenina",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Barilla Spaghetti",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 499,
                    PictureUrl = "/images/products/barilla-spaghetti.png",
                    Brand = "Barilla",
                    Type = "Testenina",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Castello Elicoidali",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 699,
                    PictureUrl = "/images/products/castello-elicoidali.png",
                    Brand = "Castello",
                    Type = "Testenina",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Castello Penne",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 559,
                    PictureUrl = "/images/products/castello-penne.png",
                    Brand = "Castello",
                    Type = "Testenina",
                    QuantityInStock = 100
                },
                new Product               
                {
                    Name = "Castello Tagliatelle",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 899,
                    PictureUrl = "/images/products/castello-tagliatelle.png",
                    Brand = "Castello",
                    Type = "Testenina",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Danubius Gnocchi",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 299,
                    PictureUrl = "/images/products/danubius-gnocchi.png",
                    Brand = "Danubius",
                    Type = "Testenina",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Danubius Penne",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 399,
                    PictureUrl = "/images/products/danubius-penne.png",
                    Brand = "Danubius",
                    Type = "Testenina",
                    QuantityInStock = 100
                },

                new Product              
                {
                    Name = "Maslinovo Ulje Monini",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 155,
                    PictureUrl = "/images/products/maslinovo-ulje-monini.png",
                    Brand = "Monini",
                    Type = "Ulje",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Suncokretovo Ulje Dijamant",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 279,
                    PictureUrl = "/images/products/ulje-dijamant.png",
                    Brand = "Danubius",
                    Type = "Testenina",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Palmino Ulje Dijamant",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 349,
                    PictureUrl = "/images/products/ulje-dijamant-m.png",
                    Brand = "Dijamant",
                    Type = "Ulje",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Suncokretovo Ulje Iskon",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 210,
                    PictureUrl = "/images/products/ulje-iskon.png",
                    Brand = "Iskon",
                    Type = "Ulje",
                    QuantityInStock = 100
                },
                // MLECNI PROIZVODI
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                new Product              
                {
                    Name = "Jogurt Balans",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 199,
                    PictureUrl = "/images/products/jogurt-balans1.png",
                    Brand = "Balans",
                    Type = "Jogurt",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Jogurt Bello",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 249,
                    PictureUrl = "/images/products/jogurt-bello.png",
                    Brand = "Bello",
                    Type = "Jogurt",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Jogurt Dukat",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 199,
                    PictureUrl = "/images/products/jogurt-dukat.png",
                    Brand = "Dukat",
                    Type = "Jogurt",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Dukatos",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 188,
                    PictureUrl = "/images/products/jogurt-grcki3.png",
                    Brand = "Dukatos",
                    Type = "Jogurt",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Grekos Običan",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 175,
                    PictureUrl = "/images/products/jogurt-grcki4.png",
                    Brand = "Grekos",
                    Type = "Jogurt",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Grekos Jagoda",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 192,
                    PictureUrl = "/images/products/jogurt-grcki5.png",
                    Brand = "Grekos",
                    Type = "Jogurt",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Grekos Višnja",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 192,
                    PictureUrl = "/images/products/jogurt-grcki6.png",
                    Brand = "Grekos",
                    Type = "Jogurt",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Jogurt Moja Kravica",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 222,
                    PictureUrl = "/images/products/jogurt-kravica.png",
                    Brand = "Moja Kravica",
                    Type = "Jogurt",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Kiselo Mleko Balans",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 169,
                    PictureUrl = "/images/products/kiselo-mleko-balans.png",
                    Brand = "Balans",
                    Type = "Kiselo Mleko",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Kiselo Mleko Dukat",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 149,
                    PictureUrl = "/images/products/kiselo-mleko-dukat.png",
                    Brand = "Dukat",
                    Type = "Kiselo Mleko",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Kiselo Mleko Imlek",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 184,
                    PictureUrl = "/images/products/kiselo-mleko-imlek.png",
                    Brand = "Imlek",
                    Type = "Kiselo Mleko",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Kiselo Mleko Meggle",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 210,
                    PictureUrl = "/images/products/kiselo-mleko-meggle.png",
                    Brand = "Meggle",
                    Type = "Kiselo Mleko",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Kiselo Mleko Zdravo",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 155,
                    PictureUrl = "/images/products/kiselo-mleko-zdravo.png",
                    Brand = "Mlekara Subotica",
                    Type = "Kiselo Mleko",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Mleko Alpsko 3.5% jako",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 186,
                    PictureUrl = "/images/products/mleko-alpsko.png",
                    Brand = "ALPSKO",
                    Type = "Mleko",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Mleko Bello 3.5%",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 155,
                    PictureUrl = "/images/products/mleko-bello.png",
                    Brand = "Bello",
                    Type = "Mleko",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Punomasno mleko Dukat",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 166,
                    PictureUrl = "/images/products/mleko-dukat.png",
                    Brand = "Dukat",
                    Type = "Mleko",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Mleko Moja kravica 2.8%",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 155,
                    PictureUrl = "/images/products/mleko-imlek.png",
                    Brand = "Imlek",
                    Type = "Mleko",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Mleko Moja Kravica 3.2%",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 189,
                    PictureUrl = "/images/products/mleko-imlek-32.png",
                    Brand = "Imlek",
                    Type = "Mleko",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Mleko Imlek Bello",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 279,
                    PictureUrl = "/images/products/mleko-imlek-bello.png",
                    Brand = "Bello",
                    Type = "Mleko",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Mleko Implek 3.2%",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 177,
                    PictureUrl = "/images/products/mleko-imlek-punomasno.png",
                    Brand = "Imlek",
                    Type = "Mleko",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Punomasno Mleko Imlek",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 155,
                    PictureUrl = "/images/products/mleko-imlek-s.png",
                    Brand = "Imlek",
                    Type = "Mleko",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Mleko Moja Kravica Junior",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 199,
                    PictureUrl = "/images/products/mleko-junior.png",
                    Brand = "Moja Kravica",
                    Type = "Mleko",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Mleko Meggle 2.8%",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 189,
                    PictureUrl = "/images/products/mleko-meggle.png",
                    Brand = "Meggle",
                    Type = "Mleko",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Punomasno Mleko Mlekara Subotica",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 155,
                    PictureUrl = "/images/products/mleko-subotica.png",
                    Brand = "Mlekara Subotica",
                    Type = "Mleko",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Mleko Meggle 3.2%",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 160,
                    PictureUrl = "/images/products/mleko-meggle-32.png",
                    Brand = "Meggle",
                    Type = "Mleko",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Beli Sir Grekos 500g",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 699,
                    PictureUrl = "/images/products/beli-sir-grekos-500g.png",
                    Brand = "Grekos",
                    Type = "Sir",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Beli Mladi Sir Perfetta",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 399,
                    PictureUrl = "/images/products/beli-sir-perfetta-500g.png",
                    Brand = "Perfetta",
                    Type = "Sir",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Cheddar Sir Paladin",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 1290,
                    PictureUrl = "/images/products/cheddar-paladin.png",
                    Brand = "Paladin",
                    Type = "Sir",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Edam Kačkavalj 500g",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 900,
                    PictureUrl = "/images/products/edam-president.png",
                    Brand = "President",
                    Type = "Sir",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Somborska Feta President",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 669,
                    PictureUrl = "/images/products/feta-president-500g.png",
                    Brand = "President",
                    Type = "Sir",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Gauda Belje",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 750,
                    PictureUrl = "/images/products/gauda-belje.png",
                    Brand = "Belje",
                    Type = "Gauda",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Imlek Irski Sir Kolut",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 160,
                    PictureUrl = "/images/products/iriski-sir.png",
                    Brand = "Imlek",
                    Type = "Sir",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "CALABRIA Parmezan",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 122,
                    PictureUrl = "/images/products/parmezan-40g.png",
                    Brand = "Calabria",
                    Type = "Sir",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Trapist Biser",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 333,
                    PictureUrl = "/images/products/trapist-biser.png",
                    Brand = "Biser",
                    Type = "Sir",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Dukat Voćni Jogurt Jagoda",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 199,
                    PictureUrl = "/images/products/vocni-jogurt-dukat-jagoda.png",
                    Brand = "Dukat",
                    Type = "Voćni Jogurt",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Dukat Voćni Jogurt Šumsko Voće",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 220,
                    PictureUrl = "/images/products/vocni-jogurt-dukat-sumsko.png",
                    Brand = "Dukat",
                    Type = "Voćni Jogurt",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Dukat Voćni Jogurt Višnja",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 239,
                    PictureUrl = "/images/products/vocni-jogurt-dukat-visnja.png",
                    Brand = "Dukat",
                    Type = "Voćni Jogurt",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Vonćni Jogurt Zdravo Jagoda",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 240,
                    PictureUrl = "/images/products/vocni-jogurt-jagoda.png",
                    Brand = "Mlekara Subotica",
                    Type = "Voćni Jogurt",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Vonćni Jogurt Zdravo Šumsko Voće",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 220,
                    PictureUrl = "/images/products/vocni-jogurt-zdravo-sumsko.png",
                    Brand = "Mlekara Subotica",
                    Type = "Voćni Jogurt",
                    QuantityInStock = 100
                },
            // VOCE I POVRCE
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                new Product              
                {
                    Name = "Čeri Paradajz",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 299,
                    PictureUrl = "/images/products/cherry.png",
                    Brand = "NIIR nase domaće",
                    Type = "Povrće",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Cvekla crvena",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 89,
                    PictureUrl = "/images/products/cvekla.png",
                    Brand = "NIIR nase domaće",
                    Type = "Povrće",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Karfiol",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 149,
                    PictureUrl = "/images/products/karfiol.png",
                    Brand = "NIIR nase domaće",
                    Type = "Povrće",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Krastavac",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 199,
                    PictureUrl = "/images/products/krastavac.png",
                    Brand = "NIIR nase domaće",
                    Type = "Povrće",
                    QuantityInStock = 100
                },
               new Product              
                {
                    Name = "Mladi Kupus",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 49,
                    PictureUrl = "/images/products/kupus.png",
                    Brand = "NIIR nase domaće",
                    Type = "Povrće",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Beli Luk",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 269,
                    PictureUrl = "/images/products/luk.png",
                    Brand = "NIIR nase domaće",
                    Type = "Povrće",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Paprika Žuta",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 239,
                    PictureUrl = "/images/products/paprika1.png",
                    Brand = "NIIR nase domaće",
                    Type = "Povrće",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Paprika Crvena",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 219,
                    PictureUrl = "/images/products/paprika2.png",
                    Brand = "NIIR nase domaće",
                    Type = "Povrće",
                    QuantityInStock = 100
                },
                new Product              
                {
                    Name = "Paradajz",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 299,
                    PictureUrl = "/images/products/paradajz.png",
                    Brand = "NIIR nase domaće",
                    Type = "Povrće",
                    QuantityInStock = 100
                },                
                new Product              
                {
                    Name = "Pasulj Beli",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 349,
                    PictureUrl = "/images/products/pasulj-beli.png",
                    Brand = "NIIR nase domaće",
                    Type = "Povrće",
                    QuantityInStock = 100
                },                
                new Product              
                {
                    Name = "Plavi Patlidzan",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 299,
                    PictureUrl = "/images/products/patlidzan.png",
                    Brand = "NIIR nase domaće",
                    Type = "Povrće",
                    QuantityInStock = 100
                },                
                new Product              
                {
                    Name = "Zreli Praziluk",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 199,
                    PictureUrl = "/images/products/praziluk.png",
                    Brand = "NIIR nase domaće",
                    Type = "Povrće",
                    QuantityInStock = 100
                },                
                new Product              
                {
                    Name = "Šampinjoni",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 159,
                    PictureUrl = "/images/products/sampnjoni.png",
                    Brand = "NIIR nase domaće",
                    Type = "Povrće",
                    QuantityInStock = 100
                },                
                new Product              
                {
                    Name = "Šargarepa",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 119,
                    PictureUrl = "/images/products/sargarepa.png",
                    Brand = "NIIR nase domaće",
                    Type = "Povrće",
                    QuantityInStock = 100
                },                
                new Product              
                {
                    Name = "Zelena Salata",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 129,
                    PictureUrl = "/images/products/zelenas.png",
                    Brand = "NIIR nase domaće",
                    Type = "Povrće",
                    QuantityInStock = 100
                },                
                new Product              
                {
                    Name = "Ananas",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 299,
                    PictureUrl = "/images/products/ananas.png",
                    Brand = "NIIR nase domaće",
                    Type = "Voće",
                    QuantityInStock = 100
                },   
                new Product              
                {
                    Name = "Avokado",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 229,
                    PictureUrl = "/images/products/avokado.png",
                    Brand = "NIIR nase domaće",
                    Type = "Voće",
                    QuantityInStock = 100
                },   
                new Product              
                {
                    Name = "Banane",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 199,
                    PictureUrl = "/images/products/banane.png",
                    Brand = "NIIR nase domaće",
                    Type = "Voće",
                    QuantityInStock = 100
                },                                   
                new Product              
                {
                    Name = "Crveni Grejpfrut",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 169,
                    PictureUrl = "/images/products/grejp-crveni.png",
                    Brand = "NIIR nase domaće",
                    Type = "Voće",
                    QuantityInStock = 100
                },   
                new Product              
                {
                    Name = "Jabuka Ajdared",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 220,
                    PictureUrl = "/images/products/jabuke-ajdared.png",
                    Brand = "NIIR nase domaće",
                    Type = "99",
                    QuantityInStock = 100
                },   
                new Product              
                {
                    Name = "Jabuka Zeleni Delišes",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 119,
                    PictureUrl = "/images/products/jabuke-delises.png",
                    Brand = "NIIR nase domaće",
                    Type = "Voće",
                    QuantityInStock = 100
                },   
                new Product              
                {
                    Name = "Jabuka Greni Smit",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 179,
                    PictureUrl = "/images/products/jabuke-greni.png",
                    Brand = "NIIR nase domaće",
                    Type = "Voće",
                    QuantityInStock = 100
                },   
                new Product              
                {
                    Name = "Kivi",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 229,
                    PictureUrl = "/images/products/kivi.png",
                    Brand = "NIIR nase domaće",
                    Type = "Voće",
                    QuantityInStock = 100
                },   
                new Product              
                {
                    Name = "Kruška",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 199,
                    PictureUrl = "/images/products/kruske.png",
                    Brand = "NIIR nase domaće",
                    Type = "Voće",
                    QuantityInStock = 100
                },   
                new Product              
                {
                    Name = "Limeta",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 399,
                    PictureUrl = "/images/products/limeta.png",
                    Brand = "NIIR nase domaće",
                    Type = "Voće",
                    QuantityInStock = 100
                },   
                new Product              
                {
                    Name = "Limun",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 189,
                    PictureUrl = "/images/products/limun.png",
                    Brand = "NIIR nase domaće",
                    Type = "Voće",
                    QuantityInStock = 100
                },   
                new Product              
                {
                    Name = "Mango",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 199,
                    PictureUrl = "/images/products/mango.png",
                    Brand = "NIIR nase domaće",
                    Type = "Voće",
                    QuantityInStock = 100
                },   
                new Product              
                {
                    Name = "Nektarina",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 179,
                    PictureUrl = "/images/products/nektarina.png",
                    Brand = "NIIR nase domaće",
                    Type = "Voće",
                    QuantityInStock = 100
                },   
                new Product              
                {
                    Name = "Pomelo",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 249,
                    PictureUrl = "/images/products/pomelo.png",
                    Brand = "NIIR nase domaće",
                    Type = "Voće",
                    QuantityInStock = 100
                }, 
        // MESO I RIBA
                new Product              
                {
                    Name = "Budimška Carnex 450g",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 699,
                    PictureUrl = "/images/products/budimska-carnex.png",
                    Brand = "Carnex",
                    Type = "Meso",
                    QuantityInStock = 100
                }, 
                new Product              
                {
                    Name = "Budimška Salama Tanko Rezana 450g",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 679,
                    PictureUrl = "/images/products/budimska-yuhor.png",
                    Brand = "NIIR nase domaće",
                    Type = "Meso",
                    QuantityInStock = 100
                }, 
                new Product              
                {
                    Name = "Ćevapi 300g",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 249,
                    PictureUrl = "/images/products/cevapi.png",
                    Brand = "NIIR nase domaće",
                    Type = "Meso",
                    QuantityInStock = 100
                }, 
                new Product              
                {
                    Name = "Jagnjetina 1kg",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 1099,
                    PictureUrl = "/images/products/jagnjetina.png",
                    Brand = "NIIR nase domaće",
                    Type = "Meso",
                    QuantityInStock = 100
                }, 
                new Product              
                {
                    Name = "Juneća Leđa Sa Kostima 500g",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 899,
                    PictureUrl = "/images/products/juneca-leda-sa-kostima.png",
                    Brand = "NIIR nase domaće",
                    Type = "Meso",
                    QuantityInStock = 100
                }, 
                new Product              
                {
                    Name = "Juneća Rebra 300g",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 499,
                    PictureUrl = "/images/products/juneca-rebra.png",
                    Brand = "NIIR nase domaće",
                    Type = "Meso",
                    QuantityInStock = 100
                }, 
                new Product              
                {
                    Name = "Kulen NEOPLANTA",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 369,
                    PictureUrl = "/images/products/kulen-neoplanta.png",
                    Brand = "Neoplanta",
                    Type = "Meso",
                    QuantityInStock = 100
                }, 
                new Product              
                {
                    Name = "Kulen Topola Domaći 200g",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 389,
                    PictureUrl = "/images/products/kulen-topola.png",
                    Brand = "NIIR nase domaće",
                    Type = "Meso",
                    QuantityInStock = 100
                }, 
                new Product              
                {
                    Name = "Pečenica Domaća",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 399,
                    PictureUrl = "/images/products/pecenica-carnex.png",
                    Brand = "NIIR nase domaće",
                    Type = "Meso",
                    QuantityInStock = 100
                }, 
                new Product              
                {
                    Name = "Pikant Čajna 200g",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 189,
                    PictureUrl = "/images/products/piknik-topola.png",
                    Brand = "NIIR nase domaće",
                    Type = "Meso",
                    QuantityInStock = 100
                }, 
                new Product              
                {
                    Name = "Pljeskavice 100g Komad",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 249,
                    PictureUrl = "/images/products/pljeskavice.png",
                    Brand = "NIIR nase domaće",
                    Type = "Meso",
                    QuantityInStock = 100
                }, 
                new Product              
                {
                    Name = "Roštilj Kobasice 600g",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 459,
                    PictureUrl = "/images/products/rostilj-kobasice.png",
                    Brand = "NIIR nase domaće",
                    Type = "Meso",
                    QuantityInStock = 100
                }, 
                new Product              
                {
                    Name = "Sendvič Salama",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 199,
                    PictureUrl = "/images/products/sendvic-salama-zlatiborac.png",
                    Brand = "Zlatiborac",
                    Type = "Voće",
                    QuantityInStock = 100
                }, 
                new Product              
                {
                    Name = "Svinjska Plećka Bez Kostiju 500g",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 689,
                    PictureUrl = "/images/products/svinjska-plecka-bez-kostiju.png",
                    Brand = "NIIR nase domaće",
                    Type = "Voće",
                    QuantityInStock = 100
                }, 
                new Product              
                {
                    Name = "Svinjski File",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 599,
                    PictureUrl = "/images/products/svinjski-file.png",
                    Brand = "NIIR nase domaće",
                    Type = "Meso",
                    QuantityInStock = 100
                }, 
                new Product              
                {
                    Name = "Svinjski Vrat Sa Kostima 600g",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 701,
                    PictureUrl = "/images/products/svinjski-vrat-sa-kostima.png",
                    Brand = "NIIR nase domaće",
                    Type = "Meso",
                    QuantityInStock = 100
                }, 
                // Slatkisi
                new Product              
                {
                    Name = "7 Days Bake Rolls Pizza",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 169,
                    PictureUrl = "/images/products/7-days-bake-rolls-bran-pizza.png",
                    Brand = "7 Days",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 
                new Product              
                {
                    Name = "7 Days Bake Rolls Salty",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 149,
                    PictureUrl = "/images/products/7-days-bake-rolls-bran-slani.png",
                    Brand = "7 Days",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Biskvit Jaffa Choco Narandza",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 222,
                    PictureUrl = "/images/products/biskit-jaffa-choco.png",
                    Brand = "Crvenka",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Biskvit Nobilce 300g",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 299,
                    PictureUrl = "/images/products/biskvit-banini-noblice.png",
                    Brand = "Banini",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Biskvit Milka Pomorandza",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 329,
                    PictureUrl = "/images/products/biskvit-milka-biskvit-pomorandza.png",
                    Brand = "Milka",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Išleri Swisslion Takovo",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 169,
                    PictureUrl = "/images/products/biskvit-swisslion-isleri.png",
                    Brand = "Swisslion",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Fisher-man Friend Bombone Original",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 98,
                    PictureUrl = "/images/products/bombone-fisherman-extra.png",
                    Brand = "Fisher-man Friend",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Fisher-man Friend Bombone Mint",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 110,
                    PictureUrl = "/images/products/bombone-fisherman-s.png",
                    Brand = "Fisher-man Friend",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Bombone 505 sa crtom",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 129,
                    PictureUrl = "/images/products/bombone-kras-505.png",
                    Brand = "KRAS",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "M&M Kikiriki",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 189,
                    PictureUrl = "/images/products/bombone-m.png",
                    Brand = "M&M",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Bombone Mentos Fruit",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 55,
                    PictureUrl = "/images/products/bombone-mentos-fruit.png",
                    Brand = "Mentos",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Bombone Mentos Grape",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 169,
                    PictureUrl = "/images/products/bombone-mentos-grape.png",
                    Brand = "Mentos",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Bombone Mentos Mint",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 59,
                    PictureUrl = "/images/products/bombone-mentos-mint.png",
                    Brand = "Mentos",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "M&M Čokolada",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 199,
                    PictureUrl = "/images/products/bombone-m-m-s-cokolada.png",
                    Brand = "M&M",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Bombone Pionir Menthol Strong",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 131,
                    PictureUrl = "/images/products/bombone-pionir-menthol-strong.png",
                    Brand = "Pionir",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Bombone Pionir Negro",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 121,
                    PictureUrl = "/images/products/bombone-pionir-negro.png",
                    Brand = "Pionir",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Čips Marbo Domaćinski Feta",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 210,
                    PictureUrl = "/images/products/cips-marbo-chipsy-domacinski-feta.png",
                    Brand = "Marbo",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Čokolada Kinder 100g",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 132,
                    PictureUrl = "/images/products/cokolada-kinder.png",
                    Brand = "KINDER",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Čokolada Milka",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 249,
                    PictureUrl = "/images/products/cokolada-milka.png",
                    Brand = "Milka",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Čokolada Milka Bubbly 100g",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 279,
                    PictureUrl = "/images/products/cokolada-milka-bubbly.png",
                    Brand = "Milka",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Galeb Pionir Čokolada 100g",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 99,
                    PictureUrl = "/images/products/cokolada-pionir.png",
                    Brand = "Pionir",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Čokolada-Schogetten Original",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 239,
                    PictureUrl = "/images/products/cokolada-schogetten.png",
                    Brand = "Schogetten",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Čokolada Schogetten Caramel 100g",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 199,
                    PictureUrl = "/images/products/cokolada-schogetten-careml.png",
                    Brand = "Schogetten",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Čokolada Schogetten Hazelnuts 100g",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 149,
                    PictureUrl = "/images/products/cokolada-schogetten-hazelnuts.png",
                    Brand = "Schogetten",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Čokolada Schogetten Noisettes 100g",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 169,
                    PictureUrl = "/images/products/cokolada-schogetten-noisettes.png",
                    Brand = "Schogetten",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Štark Najlepše Želje 100g",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 200,
                    PictureUrl = "/images/products/cokolada-stark.png",
                    Brand = "Štark",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Keks Bambi Plazma 100g",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 169,
                    PictureUrl = "/images/products/keks-bambi-plazma.png",
                    Brand = "Bambi",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Marbo Chipsy Classic",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 79,
                    PictureUrl = "/images/products/marbo-chipsy-classic.png",
                    Brand = "Marbo",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Marbo Chipsy Rebrasti Pizza",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 162,
                    PictureUrl = "/images/products/marbo-chipsy-rebrasti.png",
                    Brand = "Marbo",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Marbo Chipsy Slani",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 163,
                    PictureUrl = "/images/products/marbo-chipsy-slani.png",
                    Brand = "Marbo",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Marbo Chipsy Tzatziki",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 139,
                    PictureUrl = "/images/products/marbo-chipsy-tzatziki.png",
                    Brand = "Marbo",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Orbit Original",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 55,
                    PictureUrl = "/images/products/zvake-orbit.png",
                    Brand = "Wrigley's",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Orbit Eucaliptus",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 88,
                    PictureUrl = "/images/products/zvake-orbit-eucalyptu.png",
                    Brand = "Wrigley's",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Orbit Green Mint",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 77,
                    PictureUrl = "/images/products/zvake-orbit-green-mint.png",
                    Brand = "Wrigley's",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 

                new Product              
                {
                    Name = "Orbit Winterfrost",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 79,
                    PictureUrl = "/images/products/zvake-orbit-winterfrost.png",
                    Brand = "Wrigley's",
                    Type = "Grickalice",
                    QuantityInStock = 100
                }, 







































            };
            foreach (var product in products)
            {
                context.Products.Add(product);
            }
            
            context.SaveChanges();
    
        }
    }
}