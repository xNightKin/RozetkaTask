using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RozetkaAPI.Model
{
    public class RozetkaNotebookContext:DbContext
    {
        public RozetkaNotebookContext(DbContextOptions<RozetkaNotebookContext> options):base(options)
        {

        }

        public DbSet<RozetkaNotebook> RozetkaNotebooks { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RozetkaNotebook>().HasData(
                    new RozetkaNotebook
                    {
                        NotebookID = 1,
                        NotebookManufacture = "Asus",
                        NotebookName = "ROG Strix",
                        NotebookSeries = "G531GT-BQ132",
                        NotebookPrice = 21999,
                        NotebookScreenDiagonal = 15.6,
                        NotebookScreenResolution = "1920x1080",
                        NotebookProcessor = "Intel Core i5-9300H",
                        NotebookRAM = 8,
                        NotebookStorage = "SSD 256 ГБ",
                        NotebookVideoCard = "nVidia GeForce GTX 1650",
                        NotebookWeight = 2.35
                    },
                    new RozetkaNotebook
                    {
                        NotebookID = 2,
                        NotebookManufacture = "Asus",
                        NotebookName = "ROG Strix",
                        NotebookSeries = "G531GT-BQ027",
                        NotebookPrice = 24999,
                        NotebookScreenDiagonal = 15.6,
                        NotebookScreenResolution = "1920x1080",
                        NotebookProcessor = "Intel Core i7-9750H",
                        NotebookRAM = 8,
                        NotebookStorage = "SSD 512 ГБ",
                        NotebookVideoCard = "nVidia GeForce GTX 1650",
                        NotebookWeight = 2.4
                    },
                    new RozetkaNotebook
                    {
                        NotebookID = 3,
                        NotebookManufacture = "HP",
                        NotebookName = "Pavilion Gaming",
                        NotebookSeries = "15-bc504ur",
                        NotebookPrice = 16499,
                        NotebookScreenDiagonal = 15.6,
                        NotebookScreenResolution = "1920x1080",
                        NotebookProcessor = "Intel Core i5-9300H",
                        NotebookRAM = 8,
                        NotebookStorage = "HDD 1 ТБ",
                        NotebookVideoCard = "nVidia GeForce GTX 1050",
                        NotebookWeight = 2.2
                    },
                    new RozetkaNotebook
                    {
                        NotebookID = 4,
                        NotebookManufacture = "Acer",
                        NotebookName = "Aspire 5",
                        NotebookSeries = "A515-54G",
                        NotebookPrice = 15999,
                        NotebookScreenDiagonal = 15.6,
                        NotebookScreenResolution = "1920x1080",
                        NotebookProcessor = "Intel Core i5-8265U",
                        NotebookRAM = 8,
                        NotebookStorage = "SSD 256 ГБ",
                        NotebookVideoCard = "nVidia GeForce MX250",
                        NotebookWeight = 1.8
                    },
                    new RozetkaNotebook
                    {
                        NotebookID = 5,
                        NotebookManufacture = "Lenovo",
                        NotebookName = "IdeaPad",
                        NotebookSeries = "330-15AST",
                        NotebookPrice = 5599,
                        NotebookScreenDiagonal = 15.6,
                        NotebookScreenResolution = "1366x768",
                        NotebookProcessor = "AMD A6-9225",
                        NotebookRAM = 4,
                        NotebookStorage = "HDD 500 ГБ",
                        NotebookVideoCard = "AMD Radeon R4 Graphics",
                        NotebookWeight = 2.2
                    },
                    new RozetkaNotebook
                    {
                        NotebookID = 6,
                        NotebookManufacture = "Asus",
                        NotebookName = "ZenBook 13",
                        NotebookSeries = "UX331FN-EG034T",
                        NotebookPrice = 19999,
                        NotebookScreenDiagonal = 15.6,
                        NotebookScreenResolution = "1920x1080",
                        NotebookProcessor = "Intel Core i5-8265U",
                        NotebookRAM = 8,
                        NotebookStorage = "SSD 512 ГБ",
                        NotebookVideoCard = "nVidia GeForce MX150",
                        NotebookWeight = 1.21
                    },
                    new RozetkaNotebook
                    {
                        NotebookID = 7,
                        NotebookManufacture = "Lenovo",
                        NotebookName = "IdeaPad",
                        NotebookSeries = "330-15ICH",
                        NotebookPrice = 15999,
                        NotebookScreenDiagonal = 15.6,
                        NotebookScreenResolution = "1920x1080",
                        NotebookProcessor = "Intel Core i5-8300H",
                        NotebookRAM = 8,
                        NotebookStorage = "HDD 1 ТБ",
                        NotebookVideoCard = "nVidia GeForce GTX 1050",
                        NotebookWeight = 2.2
                    },
                    new RozetkaNotebook
                    {
                        NotebookID = 8,
                        NotebookManufacture = "HP",
                        NotebookName = "Pavilion Gaming",
                        NotebookSeries = "15-cx0027ua",
                        NotebookPrice = 17999,
                        NotebookScreenDiagonal = 15.6,
                        NotebookScreenResolution = "1920x1080",
                        NotebookProcessor = "Intel Core i5-8300H",
                        NotebookRAM = 8,
                        NotebookStorage = "SSD 256 ГБ",
                        NotebookVideoCard = "nVidia GeForce GTX 1050 Ti",
                        NotebookWeight = 2.2
                    },
                    new RozetkaNotebook
                    {
                        NotebookID = 9,
                        NotebookManufacture = "ASUS",
                        NotebookName = "ZenBook 14",
                        NotebookSeries = "UX433FN-A5409",
                        NotebookPrice = 22999,
                        NotebookScreenDiagonal = 14.0,
                        NotebookScreenResolution = "1920x1080",
                        NotebookProcessor = "Intel Core i5-8265U",
                        NotebookRAM = 8,
                        NotebookStorage = "SSD 256 ГБ",
                        NotebookVideoCard = "nVidia GeForce MX150",
                        NotebookWeight = 1.09
                    },
                    new RozetkaNotebook
                    {
                        NotebookID = 10,
                        NotebookManufacture = "Acer",
                        NotebookName = "Aspire 5",
                        NotebookSeries = "A517-51G-546B",
                        NotebookPrice = 15999,
                        NotebookScreenDiagonal = 17.3,
                        NotebookScreenResolution = "1920x1080",
                        NotebookProcessor = "Intel Core i5-7200U",
                        NotebookRAM = 8,
                        NotebookStorage = "HDD 1 ТБ + SSD 128 ГБ",
                        NotebookVideoCard = "nVidia GeForce MX130",
                        NotebookWeight = 3
                    },
                    new RozetkaNotebook
                    {
                        NotebookID = 11,
                        NotebookManufacture = "HP",
                        NotebookName = "Envy",
                        NotebookSeries = "13-aq0003ur",
                        NotebookPrice = 27699,
                        NotebookScreenDiagonal = 13.3,
                        NotebookScreenResolution = "1920x1080",
                        NotebookProcessor = "Intel Core i5-8265U",
                        NotebookRAM = 8,
                        NotebookStorage = "SSD 256 ГБ",
                        NotebookVideoCard = "nVidia GeForce MX250",
                        NotebookWeight = 1.28
                    },
                    new RozetkaNotebook
                    {
                        NotebookID = 12,
                        NotebookManufacture = "HP",
                        NotebookName = "Spectre x360",
                        NotebookSeries = "Convertible 13",
                        NotebookPrice = 42999,
                        NotebookScreenDiagonal = 13.3,
                        NotebookScreenResolution = "1920x1080",
                        NotebookProcessor = "Intel Core i7-8565U",
                        NotebookRAM = 8,
                        NotebookStorage = "SSD 256 ГБ",
                        NotebookVideoCard = "Intel UHD Graphics 620",
                        NotebookWeight = 1.33
                    },
                    new RozetkaNotebook
                    {
                        NotebookID = 13,
                        NotebookManufacture = "Lenovo",
                        NotebookName = "ThinkPad L13",
                        NotebookSeries = "20R3000ART",
                        NotebookPrice = 27816,
                        NotebookScreenDiagonal = 13.3,
                        NotebookScreenResolution = "1920x1080",
                        NotebookProcessor = "Intel Core i5-10210U",
                        NotebookRAM = 16,
                        NotebookStorage = "SSD 512 ГБ",
                        NotebookVideoCard = "Intel UHD Graphics",
                        NotebookWeight = 1.38
                    },
                    new RozetkaNotebook
                    {
                        NotebookID = 14,
                        NotebookManufacture = "Dell",
                        NotebookName = "Inspiron 17",
                        NotebookSeries = "3793",
                        NotebookPrice = 20799,
                        NotebookScreenDiagonal = 17.3,
                        NotebookScreenResolution = "1920х1080",
                        NotebookProcessor = "Intel Core i5-1035G1",
                        NotebookRAM = 8,
                        NotebookStorage = "SSD 512 ГБ",
                        NotebookVideoCard = "Intel UHD Graphics",
                        NotebookWeight = 2.79
                    },
                    new RozetkaNotebook
                    {
                        NotebookID = 15,
                        NotebookManufacture = "Dell",
                        NotebookName = "Inspiron G3",
                        NotebookSeries = "17 3779",
                        NotebookPrice = 29299,
                        NotebookScreenDiagonal = 17.3,
                        NotebookScreenResolution = "1920х1080",
                        NotebookProcessor = "Intel Core i5-8300H",
                        NotebookRAM = 8,
                        NotebookStorage = "HDD 1 ТБ + SSD 128 ГБ",
                        NotebookVideoCard = "nVidia GeForce GTX 1050 Ti",
                        NotebookWeight = 3.27
                    },
                    new RozetkaNotebook
                    {
                        NotebookID = 16,
                        NotebookManufacture = "MSI",
                        NotebookName = "GF75 Thin",
                        NotebookSeries = "9SD",
                        NotebookPrice = 31999,
                        NotebookScreenDiagonal = 17.3,
                        NotebookScreenResolution = "1920x1080",
                        NotebookProcessor = "Intel Core i5-9300H",
                        NotebookRAM = 8,
                        NotebookStorage = "SSD 512 ГБ",
                        NotebookVideoCard = "nVidia GeForce GTX 1660 Ti",
                        NotebookWeight = 2.3
                    },
                    new RozetkaNotebook
                    {
                        NotebookID = 17,
                        NotebookManufacture = "HP",
                        NotebookName = "Omen",
                        NotebookSeries = "17-cb0003ur",
                        NotebookPrice = 62699,
                        NotebookScreenDiagonal = 17.3,
                        NotebookScreenResolution = "1920x1080",
                        NotebookProcessor = "Intel Core i7-9750H",
                        NotebookRAM = 16,
                        NotebookStorage = "HDD 1 ТБ + SSD 256 ГБ",
                        NotebookVideoCard = "nVidia GeForce RTX 2070",
                        NotebookWeight = 3.31
                    },
                    new RozetkaNotebook
                    {
                        NotebookID = 18,
                        NotebookManufacture = "Acer",
                        NotebookName = "Aspire 7",
                        NotebookSeries = "A717-72G-769H",
                        NotebookPrice = 23999,
                        NotebookScreenDiagonal = 17.3,
                        NotebookScreenResolution = "1920x1080",
                        NotebookProcessor = "Intel Core i7-8750H",
                        NotebookRAM = 8,
                        NotebookStorage = "HDD 1 ТБ",
                        NotebookVideoCard = "nVidia GeForce GTX 1050",
                        NotebookWeight = 3.04
                    },
                    new RozetkaNotebook
                    {
                        NotebookID = 19,
                        NotebookManufacture = "ASUS",
                        NotebookName = "ZenBook 14",
                        NotebookSeries = "UX431FN-AN011T",
                        NotebookPrice = 28999,
                        NotebookScreenDiagonal = 14,
                        NotebookScreenResolution = "1920x1080",
                        NotebookProcessor = "Intel Core i5-8265U",
                        NotebookRAM = 8,
                        NotebookStorage = "SSD 512 ГБ",
                        NotebookVideoCard = "nVidia GeForce MX150",
                        NotebookWeight = 1.39
                    },
                    new RozetkaNotebook
                    {
                        NotebookID = 20,
                        NotebookManufacture = "MSI",
                        NotebookName = "Modern 14",
                        NotebookSeries = "A10M-653XUA",
                        NotebookPrice = 17499,
                        NotebookScreenDiagonal = 14,
                        NotebookScreenResolution = "1920x1080",
                        NotebookProcessor = "Intel Core i5-10210U",
                        NotebookRAM = 8,
                        NotebookStorage = "SSD 256 ГБ",
                        NotebookVideoCard = "Intel UHD Graphics 620",
                        NotebookWeight = 1.18
                    });
        }*/
    }
}
