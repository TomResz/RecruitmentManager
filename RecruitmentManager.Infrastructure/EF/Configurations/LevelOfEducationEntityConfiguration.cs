using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecruitmentManager.Domain.Entities.Candidate_Elements;

namespace RecruitmentManager.Infrastructure.EF.Configurations;

public class LevelOfEducationEntityConfiguration
	: IEntityTypeConfiguration<LevelOfEducation>
{
	public void Configure(EntityTypeBuilder<LevelOfEducation> builder)
	{
		builder.Property(x => x.Id)
			.ValueGeneratedNever();

		builder.HasMany(x => x.Educations)
			.WithOne(x => x.LevelOfEducation)
			.HasForeignKey(x=>x.LevelOfEducationId)
			.OnDelete(DeleteBehavior.Restrict);
	}
}
