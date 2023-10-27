namespace RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Queries;

//public record WorkerViewDTO(
//	Guid Id,
//	string Email,
//	string FullName);
public class WorkerViewDTO
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string FullName { get; set; }
    public string Role { get; set; }
    public WorkerViewDTO()
    {
        
    }
    public WorkerViewDTO(Guid Id,string Email,string FullName,string Role)
    {
        this.Id = Id;
        this.Email = Email;
        this.FullName = FullName;
        this.Role = Role;
    }
}
