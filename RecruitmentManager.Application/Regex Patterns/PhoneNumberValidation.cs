using System.Text.RegularExpressions;

namespace RecruitmentManager.Application.Regex_Patterns;

public class PhoneNumberValidation
{
	private const string pattern = "\\+\\d{2}\\d{9}";
	public bool IsValid(string phoneNumber)
	{
		var result = Regex.IsMatch(phoneNumber, pattern);
		return result;
	}
}
