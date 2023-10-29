namespace RecruitmentManager.Subtitles;

public interface ISubtitles
{
	string PhoneNumber { get; }
	string AdminForm { get; }
	string Email { get; }
	string FirstName { get; }
	string LastName { get; }
	string NewPassword { get; }
	string Password { get; }
	char PasswordSym { get; }
	string RepeatNewPassword { get; }
	string RepeatPassword { get; }
}