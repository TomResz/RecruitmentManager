using System.Text.RegularExpressions;

namespace RecruitmentManager.Application.Regex_Patterns;

public class EmailValidation
{
	private const string pattern = "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$";
	public bool IsValid(string email)
	{
		var result = Regex.IsMatch(email, pattern);
		return result;
	}
}
