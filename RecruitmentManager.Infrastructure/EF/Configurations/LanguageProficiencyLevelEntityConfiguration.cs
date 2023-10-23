using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Infrastructure.EF.Configurations;

public class LanguageProficiencyLevelEntityConfiguration
	: IEntityTypeConfiguration<LanguageProficiencyLevel>
{
	public void Configure(EntityTypeBuilder<LanguageProficiencyLevel> builder)
	{
		builder.HasMany(x => x.KnowledgeOfLanguages)
			.WithOne(x => x.LanguageProficiencyLevel)
			.HasForeignKey(x=>x.LanguageProficiencyLevelId)
			.OnDelete(DeleteBehavior.Restrict);

		builder.Property(x => x.Id)
			.ValueGeneratedNever();
	}
}
