namespace GetEmDone.Models
{
	public class OnBoardingItem
	{
		string _title;
		string _text;
		string _backgroundSource;
		string _topBackgroundSource;

		public string Title => _title;
        public string Text => _text;
        public string BackgroundSource => _backgroundSource;
        public string TopBackgroundSource => _topBackgroundSource;

		public OnBoardingItem(string title, string text, string backgroundSource, string topBackgroundsource = null)
		{
			_title = title;
			_text = text;
			_backgroundSource = backgroundSource;
			if (!string.IsNullOrWhiteSpace(topBackgroundsource))
			{
				_topBackgroundSource = topBackgroundsource;
			}
        }
	}
}

