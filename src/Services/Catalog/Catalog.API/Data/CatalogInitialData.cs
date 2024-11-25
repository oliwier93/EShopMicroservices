using Marten.Schema;

namespace Catalog.API.Data;

public class CatalogInitialData : IInitialData
{
    public async Task Populate(IDocumentStore store, CancellationToken cancellation)
    {
        using var session = store.LightweightSession();

        if (await session.Query<Product>().AnyAsync())
            return;
        
        // Marten UPSERT will cater for existing records
        session.Store<Product>(GetPreconfiguredProducts());
        await session.SaveChangesAsync();
    }

    private static IEnumerable<Product> GetPreconfiguredProducts() => new List<Product>
    {
        new Product
        {
            Id = new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff61"),
            Name = "Iphone X",
            Description = "The iPhone X represents a significant evolution in smartphone technology, introducing a near bezel-less OLED display, Face ID for advanced security, and powerful performance with the A11 Bionic chip. This model sets a new standard for premium devices with its sleek design and groundbreaking features.",
            ImageFile = "product-iphone-1.png",
            Price = 950.00M,
            Category = ["Smart Phone", "Electronics"]
        },
        new Product
        {
            Id = new Guid("b61c2c70-7833-4f9b-b1f8-f7986d2d6ed1"),
            Name = "MacBook Pro 14-inch",
            Description = "The MacBook Pro 14-inch delivers professional-grade performance with its M1 Pro chip, vibrant Liquid Retina XDR display, and an elegant design optimized for productivity.",
            ImageFile = "product-macbook-pro-14.png",
            Price = 1999.00M,
            Category = ["Laptop", "Electronics"]
        },
        new Product
        {
            Id = new Guid("a35c4876-b285-4b91-baba-3c5b1e2f7473"),
            Name = "Sony WH-1000XM4",
            Description = "Experience the ultimate in sound quality and noise cancellation with the Sony WH-1000XM4 headphones, designed for comfort and superior audio.",
            ImageFile = "product-sony-wh-1000xm4.png",
            Price = 350.00M,
            Category = ["Headphones", "Electronics"]
        },
        new Product
        {
            Id = new Guid("f4e784f1-35c7-41b5-b2df-5e1540e17e62"),
            Name = "Apple Watch Series 7",
            Description = "Stay connected and track your health with the Apple Watch Series 7, featuring a larger, more durable display and advanced fitness tools.",
            ImageFile = "product-apple-watch-series-7.png",
            Price = 399.00M,
            Category = ["Smart Watch", "Wearable"]
        },
        new Product
        {
            Id = new Guid("2939c275-7d95-4e3b-b890-01f7b19c5c44"),
            Name = "Dell XPS 15",
            Description = "The Dell XPS 15 offers a perfect blend of performance and portability with its sleek design, powerful processor, and stunning 4K display.",
            ImageFile = "product-dell-xps-15.png",
            Price = 1499.00M,
            Category = ["Laptop", "Electronics"]
        },
        new Product
        {
            Id = new Guid("dca7c2e6-85a7-482e-81b9-22f1c03e556b"),
            Name = "Google Nest Hub 2nd Gen",
            Description = "The Google Nest Hub 2nd Gen is your ultimate smart home assistant, featuring voice control, seamless integration with other devices, and sleep tracking capabilities.",
            ImageFile = "product-google-nest-hub.png",
            Price = 99.00M,
            Category = ["Smart Home", "Electronics"]
        },
        new Product
        {
            Id = new Guid("5c6c8f8d-987f-41fb-bf91-9f6d74bfc569"),
            Name = "Canon EOS R6",
            Description = "The Canon EOS R6 offers unmatched image quality and versatility for both photographers and videographers, equipped with a 20MP sensor and advanced stabilization.",
            ImageFile = "product-canon-eos-r6.png",
            Price = 2499.00M,
            Category = ["Camera", "Photography"]
        },
        new Product
        {
            Id = new Guid("b4e5a9c7-bde6-47ef-9308-9265c3b7b041"),
            Name = "Nintendo Switch OLED",
            Description = "The Nintendo Switch OLED takes gaming on the go to the next level with its vibrant 7-inch display, enhanced audio, and improved dock for seamless connectivity.",
            ImageFile = "product-nintendo-switch-oled.png",
            Price = 349.00M,
            Category = ["Gaming Console", "Entertainment"]
        },
        new Product
        {
            Id = new Guid("d65e9fcb-1bde-47f1-b2f8-7985dcd2b98e"),
            Name = "Dyson V15 Detect",
            Description = "The Dyson V15 Detect revolutionizes cleaning with its laser-guided technology and powerful suction, ensuring your floors are spotless.",
            ImageFile = "product-dyson-v15-detect.png",
            Price = 699.00M,
            Category = ["Vacuum Cleaner", "Home Appliance"]
        }
    };
}