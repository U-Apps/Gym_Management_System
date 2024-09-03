using Jym_Management_DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Jym_Management_DataAccessLayer.Data.Config
{
    internal class TbExerciseTypeConfigration : IEntityTypeConfiguration<TbExerciseType>
    {
        public void Configure(EntityTypeBuilder<TbExerciseType> builder)
        {



            builder.HasKey(e => e.ExerciseTypeId);

            builder.Property(e => e.ExerciseTypeId)
                .UseIdentityColumn(1);


            builder.ToTable("tbExerciseTypes");

            builder.Property(e => e.ExerciseTypeId).HasColumnName("ExerciseTypeID");

            builder.Property(e => e.Name).HasMaxLength(50);

        }
    }
}
