using System.IO;
using modul9_1302210057;
List<String> stars1 = new List<String>();
stars1.Add("Tim Robbins");
stars1.Add("Morgan Freeman");
stars1.Add("Bob Gunton");
stars1.Add("William Sadler");
List<String> stars2 = new List<String>();
stars2.Add("Marlon Brando");
stars2.Add("Al Pacino");
stars2.Add("James Caan");
stars2.Add("Diane Keaton");

List<String> stars3 = new List<String>();
stars3.Add("Christian Bale");
stars3.Add("Heath Ledger");
stars3.Add("Aaron Eckhart");
stars3.Add("Michael Caine");
List<Movie> movies = new List<Movie>();
movies.Add(new Movie(
    "The Shawshank Redemption",
    "Frank Darabont",
    stars1,
    "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion."
)); 
movies.Add(new Movie(
    "The Godfather",
    "Francis Ford Coppola",
    stars2 ,
    "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."
)); movies.Add(new Movie(
    "The Dark Knight",
    "Christopher Nolan",
    stars3 ,
    "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice."
)); 


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapGet("/api/Movies", () =>
{
    return movies;
});
app.MapGet("/api/Movies/{index}", (int index) =>
{
    return movies[index];
}
    );
app.MapPost("api/Movies", (Movie movie) =>

{
    movies.Add(movie);
    return "berhasil";
});

app.MapDelete("api/Movies/{index}", (int index)=>{
    movies.RemoveAt(index);
    return "berhasil dihapus";
});

app.Run();
