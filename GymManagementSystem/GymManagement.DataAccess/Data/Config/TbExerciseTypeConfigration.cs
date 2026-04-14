using GymManagement.BusinessCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagement.DataAccess.Data.Config
{
    internal class TbExerciseTypeConfigration : IEntityTypeConfiguration<ExerciseType>
    {
        public void Configure(EntityTypeBuilder<ExerciseType> builder)
        {
            builder.ToTable("tbExerciseTypes");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .UseIdentityColumn(1)
                .HasColumnType("tinyint")
                .HasColumnName("ExerciseTypeID");

            builder.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(true)
                .IsRequired(true);

            builder.HasData(LoadData());
        }

        private static ExerciseType[] LoadData()
        {
            return new ExerciseType[]
            {
                new ExerciseType (1,"تمارين الصدر"),
                new ExerciseType (2,"تمارين البطن" ),
                new ExerciseType (3,"تمارين الذراعين"),
                new ExerciseType (4,"تمارين الأرجل")
            };
        }
    }
}
