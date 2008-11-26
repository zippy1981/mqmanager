using Microsoft.Win32;

namespace MQManager.GUI.Settings
{
	/// <summary>
	/// Summary description for SettingsManager.
	/// </summary>
	public class SettingsManager
	{
		public SettingsManager()
		{

		}
		
		public void UpdateSettings(string key, string value)
		{
			RegistryKey reg = Registry.CurrentUser;
			reg = reg.CreateSubKey(@"Software\Digital Focus\MQManager");
			reg.SetValue(key, value);
			reg.Close();
		}

		public string GetSetting(string key)
		{
			RegistryKey reg = Registry.CurrentUser;
			reg = reg.CreateSubKey(@"Software\Digital Focus\MQManager");
			string val = (string)reg.GetValue(key);
			reg.Close();		
			return val;
		}

		public delegate void SettingsListener(string key, string value);

	}
}
