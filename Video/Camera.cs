// Motion Detector
//
// Copyright © Andrew Kirillov, 2005
// andrew.kirillov@gmail.com
//
namespace motion
{
	using System;
	using System.Drawing;
	using System.Threading;
	using VideoSource;

	/// <summary>
	/// Camera class
	/// </summary>
	public class Camera
	{
		private IVideoSource	videoSource = null;
		private  static Bitmap	lastFrame = null;

        private static int frames;
		//
		public event EventHandler NewFrame;

		// LastFrame property
		public Bitmap LastFrame
		{
			get { return lastFrame; }
		}
    
		// FramesReceived property
		public int FramesReceived
		{
            get { return frames; }
		}
		// BytesReceived property
		public int BytesReceived
		{
			get { return ( videoSource == null ) ? 0 : videoSource.BytesReceived; }
		}
		// Running property
		public bool Running
		{
			get { return ( videoSource == null ) ? false : videoSource.Running; }
		}
      
        public Camera(IVideoSource source)
        {
            this.videoSource = source;
            videoSource.NewFrame += new CameraEventHandler(video_NewFrame);
        }


		// Start video source
		public void Start( )
		{
			if ( videoSource != null )
			{
				videoSource.Start( );
			}
		}

		// Siganl video source to stop
		public void SignalToStop( )
		{
			if ( videoSource != null )
			{
				videoSource.SignalToStop( );
			}
		}

		// Wait video source for stop
		public void WaitForStop( )
		{
			// lock
			Monitor.Enter( this );

			if ( videoSource != null )
			{
				videoSource.WaitForStop( );
			}
			// unlock
			Monitor.Exit( this );
		}

		// Abort camera
		public void Stop( )
		{
			// lock
			Monitor.Enter( this );

			if ( videoSource != null )
			{
				videoSource.Stop( );
			}
			// unlock
			Monitor.Exit( this );
		}

		// Lock it
		public void Lock( )
		{
			Monitor.Enter( this );
		}

		// Unlock it
		public void Unlock( )
		{
			Monitor.Exit( this );
		}

        private static EventArgs evt;
		// On new frame
		private void video_NewFrame( object sender, CameraEventArgs e )
		{
			try
			{
				// lock
				Monitor.Enter( this );
                lastFrame = e.Bitmap;
                
                // notify client
                if (NewFrame != null)
                {
                    evt = new EventArgs();
                    NewFrame(this, evt);

                    frames++;
                }
			}
			catch ( Exception )
			{
			}
			finally
			{
				// unlock
				Monitor.Exit( this );
			}          
		}
	}
}
