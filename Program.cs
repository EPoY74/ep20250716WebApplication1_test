using HttpClietnTestApp.Models;

namespace HttpClietnTestApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int id = 1;
            List<Person> users = new List<Person>
            {
                new() { Id = id++, Name = "Nom", Age = 37 },
                new() {Id = id++, Name = "Bob", Age = 41 },
                new() { Id = id++, Name = "Sam", Age = 24 },
            };  
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/api/users/", () => users);
            app.MapGet("/api/users/{id}", (int id) =>
            {
                Person? user = users.FirstOrDefault(u => u.Id == id);
                if (user == null) return Results.NotFound(new { message = "Пользователь не найден." });
                return Results.Json(user);
            });

            

            app.Run();
        }
    }
}
