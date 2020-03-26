using System;
using System.Collections.Generic;
using System.Windows.Forms;

// Sony.Vegas if your version below is 13
// Project -> Add reference -> Browse -> VEGAS install folder -> ScriptPortal.Vegas.dll
using ScriptPortal.Vegas;
//using Sony.Vegas;

namespace ShortenExtendMedia
{
	public partial class wndForm : Form
	{
		// setting the global vars so we can send stuff to vegas
		public double ShortenLength;
		public string ShortenTimecode;

		public double ExtendLength;
		public string ExtendTimecode;

		public wndForm()
		{
			InitializeComponent();
			FormBorderStyle = FormBorderStyle.FixedSingle;
			nudShorten.Select();
		}

		private void btnRun_Click(object sender, EventArgs e)
		{
			// setting the global vars so we can send stuff to vegas
			ShortenLength = (double)nudShorten.Value;
			ShortenTimecode = cbShortenTimecode.Text;

			ExtendLength = (double)nudExtend.Value;
			ExtendTimecode = cbExtendTimecode.Text;

			DialogResult = DialogResult.OK;
			// closing the window
			Close();
		}

		// need some help?
		private void btnHelp_Click(object sender, EventArgs e)
		{
			MessageBox.Show("do you seriously need help for this?", "help?", MessageBoxButtons.YesNo);

			MessageBox.Show("- - - - - - - - - - - What can you do? - - - - - - - - - - -\n\n" +
							"> Decreasing the length of the selected objects (Shorten)\n\n" +
							"> Increase the length of the selected objects (Extend)\n\n" +
							"(!) If you change the duration like this,\n" +
							"    the Composite/FX Keyframes will NOT move."
							, "help?", MessageBoxButtons.OK);
		}
	}

	// this is what vegas actually gets
	public class EntryPoint
	{
		public void FromVegas(Vegas myVegas)
		{
			// setting local variables for later
			long ShortenLength;
			string ShortenTimecode;

			long ExtendLength;
			string ExtendTimecode;

			using (wndForm form = new wndForm())
			{
				DialogResult result = form.ShowDialog();
				if (result == DialogResult.OK)
				{
					// get the variables from wndForm on pressing run
					ShortenLength = (long)form.ShortenLength;
					ShortenTimecode = form.ShortenTimecode;

					ExtendLength = (long)form.ExtendLength;
					ExtendTimecode = form.ExtendTimecode;
				}
				else
				{
					return;
				}
			}

			// try catch for safety
			try
			{
				TrackEvent[] selectedEvents = GetSelectedEvents(myVegas.Project);

				foreach (TrackEvent trackEvent in selectedEvents)
				{
					// decrease length of the selected media
					switch (ShortenTimecode)
					{
						case "Frames":
							trackEvent.Length = Timecode.FromFrames(trackEvent.Length.FrameCount - ShortenLength);
							break;
						case "Seconds":
							if (trackEvent.Length >= Timecode.FromSeconds(ShortenLength))
							{
								// shorten e.g.: 600 frame / 60 fps (-> 10sec) - x sec
								trackEvent.Length = Timecode.FromSeconds(trackEvent.Length.FrameCount / trackEvent.Length.FrameRate - ShortenLength);
							}
							break;
						default:
							// Default is "Frames".
							trackEvent.Length = Timecode.FromFrames(trackEvent.Length.FrameCount - ShortenLength);
							break;
					}

					// increase length of the selected media
					switch (ExtendTimecode)
					{
						case "Frames":
							trackEvent.Length = Timecode.FromFrames(trackEvent.Length.FrameCount + ExtendLength);
							break;
						case "Seconds":
							// extend e.g.: 600 frame / 60 fps (-> 10sec) + x sec
							trackEvent.Length = Timecode.FromSeconds(trackEvent.Length.FrameCount / trackEvent.Length.FrameRate + ExtendLength);
							break;
						default:
							// Default is "Frames".
							trackEvent.Length = Timecode.FromFrames(trackEvent.Length.FrameCount + ExtendLength);
							break;
					}
				}
			}
			catch (Exception ex)
			{
				// show error message if any
				MessageBox.Show(ex.Message);
			}
		}

		// getting selected items into a list, from layer 1 left to right to last layer a -> z
		TrackEvent[] GetSelectedEvents(Project project)
		{
			List<TrackEvent> selectedList = new List<TrackEvent>();
			foreach (Track track in project.Tracks)
			{
				foreach (TrackEvent trackEvent in track.Events)
				{
					if (trackEvent.Selected)
					{
						selectedList.Add(trackEvent);
					}
				}
			}
			return selectedList.ToArray();
		}
	}
}
