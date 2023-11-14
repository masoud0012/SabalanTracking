using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SabalanTracking.Models;
using SabalanTracking.Models.IdentityEntities;

namespace SabalanTracking.Data
{
    public class TrackingDbContext : IdentityDbContext<ApplicationUser,ApplicationRole,Guid>
    {
        public TrackingDbContext(DbContextOptions<TrackingDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Proces> Processes { get; set; }
        public virtual DbSet<ProcessDetaile> ProcessDetails { get; set; }
        public virtual DbSet<ProcessName> ProcessNames { get; set; }
        public virtual DbSet<ProductCat> ProductCats { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Formulla> Formulas { get; set; }
        public virtual DbSet<FormullaDetails> FormullaDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Tracking tables 
            modelBuilder.Entity<Device>().ToTable("Devices");
            modelBuilder.Entity<Material>().ToTable("Materials");
            modelBuilder.Entity<Person>().ToTable("Persons");
            modelBuilder.Entity<Proces>().ToTable("Processes");
            modelBuilder.Entity<ProcessDetaile>().ToTable("ProcessDetails");
            modelBuilder.Entity<ProcessName>().ToTable("ProcessNames");
            modelBuilder.Entity<ProductCat>().ToTable("ProductCats");
            modelBuilder.Entity<Unit>().ToTable("Units");
            modelBuilder.Entity<Formulla>().ToTable("Formulas");
            modelBuilder.Entity<FormullaDetails>().ToTable("FormullaDetails");
            #endregion
            #region seed Tracking Data
            List<ProductCat>? productCats = new List<ProductCat>()
            {
                new ProductCat(){Id=1,Category="RawMaterial"},
                new ProductCat(){Id=2,Category="FinalProduct"},
                new ProductCat(){Id=3,Category="Semi Final Prodct"}
            };
            if (productCats != null)
            {
                foreach (ProductCat item in productCats)
                {
                    modelBuilder.Entity<ProductCat>().HasData(item);
                }
            }
            List<Unit>? units = new List<Unit>()
            {
                new Unit(){Id=1,Name="کیلوگرم"},
                new Unit(){Id=2,Name="عدد"},
                new Unit(){Id=3,Name="متر"},

            };
            if (units != null)
            {
                foreach (Unit item in units)
                {
                    modelBuilder.Entity<Unit>().HasData(item);
                }
            }
            List<ProcessName>? processNames = new List<ProcessName>()
            {
                  new ProcessName(){Id=1,Name="خرید"},
                new ProcessName(){Id=2,Name="فروش"},
                new ProcessName(){Id=3,Name="برش پارچه"},
                new ProcessName(){Id=4,Name="تزریق پلاستیک"},
                new ProcessName(){Id=5,Name="جوش التراسونیک"},
                new ProcessName(){Id=6,Name="بسته بندی"}


            };
            if (processNames != null)
            {
                foreach (ProcessName item in processNames)
                {
                    modelBuilder.Entity<ProcessName>().HasData(item);
                }
            }

            List<Device>? devices = new List<Device>()
            {
                     new Device(){Id=1,Name="خرید",Description=" "},
                new Device(){Id=2,Name="فروش",Description=" "},
                new Device(){Id=3,Name="دستگاه جوش التراسونیک",Description=" "},
                new Device(){Id=4,Name="دستگاه برش التراسونیک پارچه",Description=" "},
                new Device(){Id=5,Name="دستگاه تزریق شماره مهاباد",Description=" "},
                new Device(){Id=6,Name="دستگاه تزریق شماره عباسی",Description=" "},
                new Device(){Id=7,Name="دستگاه سیلر بسته بندی",Description=" "}

            };
            if (devices != null)
            {
                foreach (Device item in devices)
                {
                    modelBuilder.Entity<Device>().HasData(item);
                }
            }

            List<Person>? people = new List<Person>()
            {
                new Person(){Id=1,Name="عباسی"},
                new Person(){Id=2,Name="پژمان"},
                new Person(){Id=3,Name="مهندس عبدالله پور"},
                new Person(){Id=4,Name="مسعود"},
                new Person(){Id=5,Name="رضا"},
                new Person(){Id=6,Name="اپراتور 1 عباسی"},
                new Person(){Id=7,Name="اپراتور 2 عبداللهی"},
            };
            if (people != null)
            {
                foreach (Person item in people)
                {
                    modelBuilder.Entity<Person>().HasData(item);
                }
            }

            List<Material>? materials = new List<Material>()
            {
                new Material(){Id=1,CatId=2,Name="فیلتر HME",UnitId=2},
                new Material(){Id=2,CatId=2,Name="فیلتر VFE",UnitId=2},
                new Material(){Id=3,CatId=2,Name="فیلتر اسپیرومتری",UnitId=2},

                new Material(){Id=4,CatId=3,Name="فیلتر ویپک HME",UnitId=2},
                new Material(){Id=5,CatId=3,Name="ویپک VFE",UnitId=2},
                new Material(){Id=6,CatId=3,Name="ویپک اسپیرومتری",UnitId=2},
                new Material(){Id=7,CatId=3,Name="بدنه فیلتر اچ ام ای بدون درپوش",UnitId=2},
                new Material(){Id=8,CatId=3,Name="بدنه فیلتر اچ ام ای با درپوش",UnitId=2},
                new Material(){Id=9,CatId=3,Name="درپوش",UnitId=2},
                new Material(){Id=10,CatId=3,Name="بدنه فیلتر آنتی باکتریال با درپوش",UnitId=2},
                new Material(){Id=11,CatId=3,Name="بدنه فیلتر آنتی باکتریال بدون درپوش",UnitId=2},
                new Material(){Id=12,CatId=3,Name="بدنه فیلتر اسپیرومتری شماره 1",UnitId=2},
                new Material(){Id=13,CatId=3,Name="بدنه فیلتر اسپیرومتری شماره 2",UnitId=2},

                new Material(){Id=14,CatId=1,Name="پلی استایرن-PS",UnitId=1},
                new Material(){Id=15,CatId=1,Name="پلی پروپیلن-PP",UnitId=1},
                new Material(){Id=16,CatId=1,Name="PVC",UnitId=1},
                new Material(){Id=17,CatId=1,Name="کاغذ جاذب رطوبت",UnitId=2},
                new Material(){Id=18,CatId=1,Name="ملت بلون",UnitId=3},
                new Material(){Id=19,CatId=1,Name="اسپان باند",UnitId=3}
           };
            if (materials != null)
            {
                foreach (Material item in materials)
                {
                    modelBuilder.Entity<Material>().HasData(item);
                }
            }

            #endregion*/
        }

    }
}
