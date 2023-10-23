using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Infrastructure.EF.Configurations;

public class RecruitmentStageEntityConfiguration
	: IEntityTypeConfiguration<RecruitmentStage>
{
	public void Configure(EntityTypeBuilder<RecruitmentStage> builder)
	{
		builder.HasOne(rs => rs.JobPosting)
			.WithMany(jp => jp.RecruitmentStages)
			.HasForeignKey(rs => rs.JobPostingId)
			.OnDelete(DeleteBehavior.Restrict);
	}
}
