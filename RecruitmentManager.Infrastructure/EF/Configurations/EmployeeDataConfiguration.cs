using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Infrastructure.EF.Configurations;

public class EmployeeDataConfiguration
	: IEntityTypeConfiguration<EmployeeData>
{
	public void Configure(EntityTypeBuilder<EmployeeData> builder)
	{
		builder.HasKey(x=>x.EmployeeId);
		builder.HasOne(x => x.Employee)
			.WithOne(x => x.EmployeeData)
			.HasForeignKey<EmployeeData>(x => x.EmployeeId);
	}
}
