using System;

namespace PictureKey
{
	public struct FilePasswordPair{
		public String fileName;
		public String password;

		public FilePasswordPair(String fileName, String password){
			this.fileName = fileName;
			this.password = password;
		}
	}

	public struct CarrierImage{
		//file name of the clean image
		public String sourceFileName;
		//file name to save the new image
		public String resultFileName;
		//width * height
		public long countPixels;
		//produce colorful (false) or grayscale noise (true) for this picture
		public bool useGrayscale;
		//how many bytes will be hidden in this image - this field is set by CryptUtility.HideOrExtract()
		public long messageBytesToHide;

		public CarrierImage(String sourceFileName, String resultFileName, long countPixels, bool useGrayscale){
			this.sourceFileName = sourceFileName;
			this.resultFileName = resultFileName;
			this.countPixels = countPixels;
			this.useGrayscale = useGrayscale;
			this.messageBytesToHide = 0;
		}
	}
}
