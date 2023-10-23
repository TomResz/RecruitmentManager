using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Infrastructure.EF.Configurations;

public class RoleEntityConfiguration
	: IEntityTypeConfiguration<Role>
{
	public void Configure(EntityTypeBuilder<Role> builder)
	{
		builder.HasMany(x => x.Employees)
			.WithOne(x => x.Role)
			.HasForeignKey(x=>x.RoleId)
			.OnDelete(DeleteBehavior.Restrict);

		builder.Property(x => x.Id)
			.ValueGeneratedNever();
	}
}
