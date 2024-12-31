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

            builder.HasKey(e => e.ExerciseTypeId);

            builder.Property(e => e.ExerciseTypeId)
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
                new ExerciseType { ExerciseTypeId = 1, Name = "تمارين الصدر" },
                new ExerciseType { ExerciseTypeId = 2, Name = "تمارين البطن" },
                new ExerciseType { ExerciseTypeId = 3, Name = "تمارين الذراعين" },
                new ExerciseType { ExerciseTypeId = 4, Name = "تمارين الأرجل" }
            };
        }
    }
}
