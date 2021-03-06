using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace MyWeather.Helpers
{
	public static class Settings
	{
		const string isImperialKey = nameof(isImperialKey);
		static readonly bool isImperialDefault = true;

		const string useCityKey = nameof(useCityKey);
		static readonly bool useCityDefault = true;

		const string cityKey = nameof(cityKey);
		static readonly string cityDefault = "Seattle,USA";

		public static bool IsImperial
		{
			get { return AppSettings.GetValueOrDefault(isImperialKey, isImperialDefault); }
			set { AppSettings.AddOrUpdateValue(isImperialKey, value); }
		}


		public static bool UseCity
		{
			get { return AppSettings.GetValueOrDefault(useCityKey, useCityDefault); }
			set { AppSettings.AddOrUpdateValue(useCityKey, value); }
		}

		public static string City
		{
			get { return AppSettings.GetValueOrDefault(cityKey, cityDefault); }
			set { AppSettings.AddOrUpdateValue(cityKey, value); }
		}

		static ISettings AppSettings => CrossSettings.Current;
	}
}