using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var documentssource = new List<Document>();
            using (var data = new IntranetDataContext("name=ModelData"))
            {
                int[] d = Common.Documents();
                documentssource = (from doc in data.Documents
                                where d.Contains(doc.document1)
                                select doc).ToList();
                
            }

            using (var data = new IntranetDataContext("name=ModelDataNew"))
            {
                foreach (var item in documentssource)
                {
                    Console.Write(".");
                    data.Entry(item).State = System.Data.Entity.EntityState.Added;
                    data.SaveChanges();

                }
            }
            Console.WriteLine("Done! press any key to quit...");
            Console.ReadLine();
        }
    }
}
