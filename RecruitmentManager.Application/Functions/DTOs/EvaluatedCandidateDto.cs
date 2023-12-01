namespace RecruitmentManager.Application.Functions.DTOs;

public class EvaluatedCandidateDto
{

    public Guid CandidateId { get; set; }
    public string FullName { get; set; }
    public double AverageGrade { get; set; }
    private int _position;
    public int Position 
    {
        get 
        {
            return _position;
        }
        set
        {
            if(value <= 0)
            {
                throw new ArgumentOutOfRangeException("Invalue position value!");
            }
            _position = value;
        }
    }
}
