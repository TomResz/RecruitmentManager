using DocumentFormat.OpenXml.Vml;

namespace RecruitmentManager.FileHandling;

public class PictureBoxSetter : IPictureBoxSetter
{
	public void Set(byte[]? bytes, PictureBox pictureBox)
	{
		if (bytes is null)
			return;
		using var ms = new MemoryStream(bytes);
		Image profileImage = Image.FromStream(ms);
		pictureBox.Invoke(new Action(() =>
		{
			pictureBox.Image = profileImage;
		}));
	}
}