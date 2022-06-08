using System;
using System.Linq;
using ConsoleApp7.Models;
namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("plese enter your name");
            string name = Console.ReadLine();
            SampleDB1Context db = new SampleDB1Context();
            Tblsample tblsample = new Tblsample();
             tblsample.Text = name;
             db.Tblsamples.Add(tblsample);
             db.SaveChanges();

         Console.WriteLine("hello word");

           var data = db.Tblsamples;
            Console.WriteLine("values from database");
            foreach (var item in data)
            {
                Console.WriteLine(item.Id + " | " + item.Text);
            }
            Console.WriteLine("Pleae enter id of your name which you want to delete");
               int DeleteItem = Convert.ToInt32(Console.ReadLine());
            Tblsample DeleteObject = db.Tblsamples. Where(x=> x.Id == DeleteItem).FirstOrDefault();
                db.Tblsamples.Remove(DeleteObject);
                   db.SaveChanges();


            Console.WriteLine("Pleae enter id of your name which you want to update");
            int InsertItem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the new name");
            var newName = Console.ReadLine();
            var UpdatteObject = db.Tblsamples.Where(x => x.Id == InsertItem).FirstOrDefault();
            UpdatteObject.Text = newName;
            db.Tblsamples.Update(UpdatteObject);
            db.SaveChanges();

            foreach (var item in data)
            {
                Console.WriteLine(item.Id + " | " + item.Text);
            }
        }
    }
    
}