using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace dynamicField.PL
{

    public class Ankit_PracticeEntities11 : DbContext
    {
        public Ankit_PracticeEntities11()
            :base("name=Ankit_1")
        {
            var vr = pl_model.ToList();
        }

        public virtual DbSet<PL_model> pl_model { get; set; }
        public virtual DbSet<PL_SecondClass> PL_SecondClasss { get; set; }
        public virtual DbSet<PL_ThirdClass> PL_ThirdClass { get; set; }

    }

    public class PL_model
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string mobno { get; set; }
    }

    public class PL_SecondClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string mobno { get; set; }
    }

    public class PL_ThirdClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string mobno { get; set; }
    }
}