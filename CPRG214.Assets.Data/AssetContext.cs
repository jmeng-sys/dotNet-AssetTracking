using CPRG214.Assets.Domain;
using Microsoft.EntityFrameworkCore;

namespace CPRG214.Assets.Data
{
    public class AssetContext : DbContext
    {
        public AssetContext() : base() { }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Change the connection string here for your computer
            /*optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS; 
                                        Database=ElectronicAssets; 
                                        Trusted_Connection=True;");*/
            optionsBuilder.UseMySQL("Server=us-cdbr-east-06.cleardb.net; Port=3306; DataBase=heroku_f97f052e16a4f15; " +
                                    "Uid=bb6b78f46014d8; Pwd=0a1182ec" );
        }

        // Create a database with informaiton provided
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //seed data created here
            modelBuilder.Entity<Asset>().HasData(
            new Asset
            {
                Id = 1,
                TagNumber = "1A425C",
                Manufacturer = "Dell",
                Model = "Inspiron",
                Description = "Dell Computer",
                AssetTypeId = 1,
                SerialNumber = "525ABCC"
            },
            new Asset
            {
                Id = 2,
                TagNumber = "2A435C",
                Manufacturer = "HP",
                Model = "Pavilion",
                Description = "HP Computer",
                AssetTypeId = 1,
                SerialNumber = "2745ABC"
            },
            new Asset
            {
                Id = 3,
                TagNumber = "2B572C",
                Manufacturer = "Acer",
                Model = "SF314",
                Description = "Acer Computer",
                AssetTypeId = 1,
                SerialNumber = "12B657C"
            },
            new Asset
            {
                Id = 4,
                TagNumber = "1B552M",
                Manufacturer = "Acer",
                Model = "Nitro",
                Description = "Acer Monitor",
                AssetTypeId = 2,
                SerialNumber = "22MF625"
            },
            new Asset
            {
                Id = 5,
                TagNumber = "22C52M",
                Manufacturer = "LG",
                Model = "IPS",
                Description = "LG Monitor",
                AssetTypeId = 2,
                SerialNumber = "25M62J75"
            },
            new Asset
            {
                Id = 6,
                TagNumber = "1R252M",
                Manufacturer = "HP",
                Model = "Ultraslim",
                Description = "HP Monitor",
                AssetTypeId = 2,
                SerialNumber = "65MFL525"
            },
            new Asset
            {
                Id = 7,
                TagNumber = "G25687P",
                Manufacturer = "Avaya",
                Model = "9612G",
                Description = "Avaya Phone",
                AssetTypeId = 3,
                SerialNumber = "55P6F665"
            },
            new Asset
            {
                Id = 8,
                TagNumber = "9FC687P",
                Manufacturer = "Polycom",
                Model = "VVX155",
                Description = "Polycom Phone",
                AssetTypeId = 3,
                SerialNumber = "35P86BK487"
            },
            new Asset
            {
                Id = 9,
                TagNumber = "2CY687P",
                Manufacturer = "Cisco",
                Model = "VoIP",
                Description = "Cisco Phone",
                AssetTypeId = 3,
                SerialNumber = "25P86CF665"
            }
            );
            modelBuilder.Entity<AssetType>().HasData(
            new AssetType
            {
                Id = 1,
                Name = "Computer"
            },
            new AssetType
            {
                Id = 2,
                Name = "Computer Monitor"
            },
            new AssetType
            {
                Id = 3,
                Name = "Phone"
            }
            );
        }
    }
}
