using Xamarin.Forms;

namespace XLabs.Forms.Controls
{
	using XLabs.Enums;

	/// <summary>
	/// Class ExtendedTextCell.
	/// </summary>
	public class ExtendedTextCell : TextCell
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ExtendedTextCell"/> class.
		/// </summary>
		public ExtendedTextCell()
		{
		}

		/// <summary>
		/// The detail location property
		/// </summary>
		public static readonly BindableProperty DetailLocationProperty = BindableProperty.Create<ExtendedTextCell, TextCellDetailLocation> (p => p.DetailLocation, default(TextCellDetailLocation));

		/// <summary>
		/// Gets or sets the detail location.
		/// </summary>
		/// <value>The detail location.</value>
		public TextCellDetailLocation DetailLocation {
			get { return (TextCellDetailLocation)GetValue (DetailLocationProperty); }
			set { SetValue (DetailLocationProperty, value); }
		}

		/// <summary>
		/// The font size property
		/// </summary>
		public static readonly BindableProperty FontSizeProperty =
			BindableProperty.Create<ExtendedTextCell, double>(
				p => p.FontSize, -1);

		/// <summary>
		/// Gets or sets the size of the font.
		/// </summary>
		/// <value>The size of the font.</value>
		public double FontSize
		{
			get { return (double)GetValue(FontSizeProperty); }
			set { SetValue(FontSizeProperty, value); }
		}

		/// <summary>
		/// The font name android property
		/// </summary>
		public static readonly BindableProperty FontNameAndroidProperty =
			BindableProperty.Create<ExtendedTextCell, string>(
				p => p.FontNameAndroid, string.Empty);

		/// <summary>
		/// Gets or sets the font name android.
		/// </summary>
		/// <value>The font name android.</value>
		public string FontNameAndroid
		{
			get { return (string)GetValue(FontNameAndroidProperty); }
			set { SetValue(FontNameAndroidProperty, value); }
		}

		/// <summary>
		/// The font name ios property
		/// </summary>
		public static readonly BindableProperty FontNameIosProperty =
			BindableProperty.Create<ExtendedTextCell, string>(
				p => p.FontNameIos, string.Empty);

		/// <summary>
		/// Gets or sets the font name ios.
		/// </summary>
		/// <value>The font name ios.</value>
		public string FontNameIos
		{
			get { return (string)GetValue(FontNameIosProperty); }
			set { SetValue(FontNameIosProperty, value); }
		}

		/// <summary>
		/// The font name wp property
		/// </summary>
		public static readonly BindableProperty FontNameWpProperty =
			BindableProperty.Create<ExtendedTextCell, string>(
				p => p.FontNameWp, string.Empty);

		/// <summary>
		/// Gets or sets the font name wp.
		/// </summary>
		/// <value>The font name wp.</value>
		public string FontNameWp
		{
			get { return (string)GetValue(FontNameWpProperty); }
			set { SetValue(FontNameWpProperty, value); }
		}


		/// <summary>
		/// The font name property
		/// </summary>
		public static readonly BindableProperty FontNameProperty =
			BindableProperty.Create<ExtendedTextCell, string>(
				p => p.FontName, string.Empty);

		/// <summary>
		/// Gets or sets the name of the font.
		/// </summary>
		/// <value>The name of the font.</value>
		public string FontName
		{
			get { return (string)GetValue(FontNameProperty); }
			set
			{
				SetValue(FontNameProperty, value);

			}
		}

		/// <summary>
		/// The background color property
		/// </summary>
		public static readonly BindableProperty BackgroundColorProperty =
			BindableProperty.Create<ExtendedTextCell, Color>(p => p.BackgroundColor, Color.Transparent);

		/// <summary>
		/// Gets or sets the color of the background.
		/// </summary>
		/// <value>The color of the background.</value>
		public Color BackgroundColor
		{
			get { return (Color)GetValue(BackgroundColorProperty); }
			set { SetValue(BackgroundColorProperty, value); }
		}

		/// <summary>
		/// The separator color property
		/// </summary>
		public static readonly BindableProperty SeparatorColorProperty =
			BindableProperty.Create<ExtendedTextCell, Color>(p => p.SeparatorColor, Color.FromRgba(199, 199, 204, 255));

		/// <summary>
		/// Gets or sets the color of the separator.
		/// </summary>
		/// <value>The color of the separator.</value>
		public Color SeparatorColor
		{
			get { return (Color)GetValue(SeparatorColorProperty); }
			set { SetValue(SeparatorColorProperty, value); }
		}

		/// <summary>
		/// The separator padding property
		/// </summary>
		public static readonly BindableProperty SeparatorPaddingProperty =
			BindableProperty.Create<ExtendedTextCell, Thickness>(p => p.SeparatorPadding, default(Thickness));

		/// <summary>
		/// Gets or sets the separator padding.
		/// </summary>
		/// <value>The separator padding.</value>
		public Thickness SeparatorPadding
		{
			get { return (Thickness)GetValue(SeparatorPaddingProperty); }
			set { SetValue(SeparatorPaddingProperty, value); }
		}


		/// <summary>
		/// The show separator property
		/// </summary>
		public static readonly BindableProperty ShowSeparatorProperty =
			BindableProperty.Create<ExtendedTextCell, bool>(p => p.ShowSeparator, true);

		/// <summary>
		/// Gets or sets a value indicating whether [show separator].
		/// </summary>
		/// <value><c>true</c> if [show separator]; otherwise, <c>false</c>.</value>
		public bool ShowSeparator
		{
			get { return (bool)GetValue(ShowSeparatorProperty); }
			set { SetValue(ShowSeparatorProperty, value); }
		}

		public static readonly BindableProperty AccessoryTypeProperty = BindableProperty.Create<ExtendedTextCell, TextCellAccessoryType>(p => p.AccessoryType, TextCellAccessoryType.None);

		public TextCellAccessoryType AccessoryType {
			get { return (TextCellAccessoryType)GetValue(AccessoryTypeProperty); }
			set { SetValue(AccessoryTypeProperty, value); }
		}

		/// <summary>
		/// The disclosure image property
		/// </summary>
		public static readonly BindableProperty DisclosureImageProperty =
			BindableProperty.Create<ExtendedTextCell, string>(
				p => p.DisclosureImage, string.Empty);

		/// <summary>
		/// Gets or sets the disclosure image.
		/// </summary>
		/// <value>The disclosure image.</value>
		public string DisclosureImage
		{
			get { return (string)GetValue(DisclosureImageProperty); }
			set { SetValue(DisclosureImageProperty, value); }
		}

		public static readonly BindableProperty ImageProperty = BindableProperty.Create<ExtendedTextCell, string>(p => p.Image, default(string));
		public string Image {
			get { return (string)GetValue(ImageProperty); }
			set { SetValue(ImageProperty, value); }
		}

		/// <summary>
		/// The font size property
		/// </summary>
		public static readonly BindableProperty MinimumScaleFactorProperty =
			BindableProperty.Create<ExtendedTextCell, float>(
				p => p.MinimumScaleFactor, 0.0f);

		/// <summary>
		/// Gets or sets the size of the font.
		/// </summary>
		/// <value>The size of the font.</value>
		public float MinimumScaleFactor
		{
			get { return (float)GetValue(MinimumScaleFactorProperty); }
			set { SetValue(MinimumScaleFactorProperty, value); }
		}
	}
}

