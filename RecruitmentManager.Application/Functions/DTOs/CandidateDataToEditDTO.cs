namespace RecruitmentManager.Application.Functions.DTOs;

public class CandidateDataToEditDTO
{
    public CandidateDataToEditDTO()
    {

    }

    public CandidateDataToEditDTO(
        Guid id,
        string firstName,
        string lastName,
        byte[]? picture,
        string? phoneNumber,
        string email,
        string? city,
        DateTime? dateOfBirth) : this()
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Picture = picture;
        PhoneNumber = phoneNumber;
        Email = email;
        City = city;
        DateOfBirth = dateOfBirth;
    }

    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? City { get; set; }
    public string Email { get; set; }
    public string? PhoneNumber { get; set; }
    public byte[]? Picture { get; set; }
}