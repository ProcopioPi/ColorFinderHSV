// Motion Detector
//
// Copyright © Andrew Kirillov, 2005
// andrew.kirillov@gmail.com
//
namespace VideoSource
{
	using System;
	using System.Drawing.Imaging;
    using System.Drawing;

	// NewFrame delegate
	public delegate void CameraEventHandler(object sender, CameraEventArgs e);

	/// <summary>
	/// Camera event arguments
	/// </summary>
	public class CameraEventArgs : EventArgs
	{
		private static Bitmap bmp;

		// Constructor
		public CameraEventArgs(Bitmap bmp)
		{
            CameraEventArgs.bmp = bmp;
		}

		// Bitmap property
		public Bitmap Bitmap
		{
			get { return bmp; }
		}
	}
}