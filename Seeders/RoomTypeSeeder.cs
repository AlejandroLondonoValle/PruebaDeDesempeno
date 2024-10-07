using HotelApiRestFull.Models;
using Microsoft.EntityFrameworkCore;
namespace HotelApiRestFull.Seeders;

public class RoomTypeSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RoomType>().HasData(

            new RoomType
            {
                Id = 1,
                Name = "Habitacion Simple",
                Description = "Una acogedora habitación básica con una cama individual, ideal para viajeros solos."
            },
            new RoomType
            {
                Id = 2,
                Name = "Habitacion Doble",
                Description = "Ofrece flexibilidad con dos camas individuales o una cama doble, perfecta para parejas o amigos."
            },
            new RoomType
            {
                Id = 3,
                Name = "Habitacion Suite",
                Description = "Espaciosa y lujosa, con una cama king size y una sala de estar separada, ideal para quienes buscan confort y exclusividad."
            },
            new RoomType
            {
                Id = 4,
                Name = "Habitacion Familiar",
                Description = "Diseñada para familias, con espacio adicional y varias camas para una estancia cómoda."
            });
    }
}