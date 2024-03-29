using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //Usado para criar as migrações
            // var connectionString = "Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=Mysql@123";
            var connectionString = "Server=.\\SQLEXPRESS2017;Database=dbAPI;User Id=sa;Password=Sql@123";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            //optionsBuilder.UseMySql(connectionString);
            optionsBuilder.UseSqlServer(connectionString);
            return new MyContext(optionsBuilder.Options);

        }
    }
}
