using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Domain.Entities.Candidate_Elements;

namespace RecruitmentManager.Infrastructure.EF.Configurations;

public class CandidateDataEntityConfiguration
	: IEntityTypeConfiguration<CandidateData>
{
	public void Configure(EntityTypeBuilder<CandidateData> builder)
	{
		builder.HasKey(e => e.CandidateId);
		builder.HasOne(x => x.Candidate)
			.WithOne(x => x.CandidateData)
			.HasForeignKey<CandidateData>(e => e.CandidateId);
	}
}
