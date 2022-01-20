using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Module_4HW3.ServerSettings;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Module_4HW3
{
    internal class Program
    {
        static  async Task Main(string[] args)
        {
           
            string str = "Server=DESKTOP-3OAE4IJ\\SQLEXPRESS;Database=str;Trusted_Connection=True;";
            var path = new ServerSettings.Path() { ServerPath = "Server=DESKTOP-3OAE4IJ\\SQLEXPRESS;Database=Module;Trusted_Connection=True;" };
            path.SerializePath(path);
            string a = await path.GetPathAsync("config.json");
        
            var optionBuilde = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionBuilde.UseSqlServer(str).Options;
            using (ApplicationContext context = new ApplicationContext(options))
            {
                context.Offices.Add(new Office() { Location="dsa", Title="sad"});
                context.SaveChanges();

            }
          
        }
    }
}
