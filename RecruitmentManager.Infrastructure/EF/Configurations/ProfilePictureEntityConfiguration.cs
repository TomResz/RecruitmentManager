using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecruitmentManager.Domain.Entities.Candidate_Elements;

namespace RecruitmentManager.Infrastructure.EF.Configurations;

public class ProfilePictureEntityConfiguration
	: IEntityTypeConfiguration<ProfilePicture>
{
	public void Configure(
		EntityTypeBuilder<ProfilePicture> builder)
	{
		builder.HasKey(x => x.CandidateId);
		builder.HasOne(x => x.Candidate)
			.WithOne(x => x.ProfilePicture)
			.HasForeignKey<ProfilePicture>(x => x.CandidateId);
	}
}