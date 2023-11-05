using System.Drawing.Imaging;

namespace RecruitmentManager.FileHandling;

public class ProfilePictureGetter : IProfilePictureGetter
{
	public byte[]? GetBytes()
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "Images JPG and PNG (*.jpg;*.png)|*.jpg;*.png";
		openFileDialog.Title = "Choose profile image!";
		openFileDialog.Multiselect = false;
		byte[]? imageData = null;
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			string imagePath = openFileDialog.FileName;
			string extension = Path.GetExtension(imagePath).ToLower();
			if (extension == ".jpg" || extension == ".png")
			{
				ImageFormat imageFormat = extension == ".jpg"
					? ImageFormat.Jpeg : ImageFormat.Png;
				using var image = new Bitmap(imagePath);
				using var ms = new MemoryStream();
				image.Save(ms, imageFormat);
				imageData = ms.ToArray();

			}
		}
		return imageData;
	}
}