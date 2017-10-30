using WebApp.Controllers;

namespace WebApp
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AppdbContext : DbContext
    {
        // Контекст настроен для использования строки подключения "dbContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "WebApp.dbContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "dbContext" 
        // в файле конфигурации приложения.
        public AppdbContext()
            : base("name=dbContext")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Employee> Employees { get; set; }
         public virtual DbSet<Department> Departments { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}