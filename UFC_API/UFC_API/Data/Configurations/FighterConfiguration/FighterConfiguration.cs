using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UFC_API.Models;

namespace UFC_API.Data.Configurations;

public class FighterConfiguration : IEntityTypeConfiguration<Fighter>
{
    public void Configure(EntityTypeBuilder<Fighter> builder)
    {
        builder.ToTable("Fighters");

        builder.HasKey(f => f.Id);

        builder.Property(f => f.Name).IsRequired().HasMaxLength(100);
        builder.Property(f => f.Nickname).HasMaxLength(100);
        builder.Property(f => f.Age).IsRequired();
        builder.Property(f => f.Weight).IsRequired();
        builder.Property(f => f.Rank).IsRequired();

        builder.HasData(
            new Fighter { Id = 1, Name = "Jon Jones", Nickname = "Bones", Age = 35, Weight = 205, Rank = 1 },
            new Fighter { Id = 2, Name = "Israel Adesanya", Nickname = "The Last Stylebender", Age = 33, Weight = 185, Rank = 2 },
            new Fighter { Id = 3, Name = "Khabib Nurmagomedov", Nickname = "The Eagle", Age = 34, Weight = 155, Rank = 3 },
            new Fighter { Id = 4, Name = "Conor McGregor", Nickname = "Notorious", Age = 34, Weight = 170, Rank = 4 },
            new Fighter { Id = 5, Name = "Stipe Miocic", Nickname = null, Age = 41, Weight = 240, Rank = 5 },
            new Fighter { Id = 6, Name = "Alexander Volkanovski", Nickname = "The Great", Age = 35, Weight = 145, Rank = 6 },
            new Fighter { Id = 7, Name = "Charles Oliveira", Nickname = "Do Bronx", Age = 34, Weight = 155, Rank = 7 },
            new Fighter { Id = 8, Name = "Max Holloway", Nickname = "Blessed", Age = 32, Weight = 145, Rank = 8 },
            new Fighter { Id = 9, Name = "Francis Ngannou", Nickname = "The Predator", Age = 37, Weight = 265, Rank = 9 }
        );
    }
}