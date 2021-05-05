using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using System.IO;
using Newtonsoft.Json;

namespace UltimateSearch
{
    class Config
    {
        public static Config ConfigIns = new Config();
        /// <summary>
        /// Gets a string from App.config
        /// </summary>
        /// <param name="website">website name = key in config</param>
        /// <returns>empty search query</returns>
        public static string GetSearchUrl(Websites website)
        {
            return ConfigurationManager.AppSettings.Get(website.ToString());
        }
        /// <summary>
        /// Gets placeholder text for QueryTextBox
        /// </summary>
        /// <returns>placeholder text</returns>
        public static string GetSearchBoxPlaceholder()
        {
            return ConfigurationManager.AppSettings.Get("searchBoxPlaceholder");
        }
        /// <summary>
        /// Indication that user setting has changed in order to prevent unnecessary file saving
        /// </summary>
        public static bool SettingHasChanged = false;

        /// <summary>
        /// file name containg user setting
        /// </summary>
        const string UserSettingFilename = "UserSetting.json";

        /// <summary>
        /// Gets fullpath to user setting file
        /// </summary>
        string GetFullUserSettingPath
        {
            get
            {
                return Path.Combine(System.AppContext.BaseDirectory, UserSettingFilename);
            }
        }

        /// <summary>
        /// supporter websites
        /// </summary>
        public enum Websites
        {
            google,
            youtube,
            wikipedia,
            stackoverflow
        }
        /// <summary>
        /// user setting to search on google
        /// </summary>
        public bool SearchGoogle { get; set; }
        /// <summary>
        /// user setting to search on youtube
        /// </summary>
        public bool SearchYoutube { get; set; }
        /// <summary>
        /// user setting to search on wikipedia
        /// </summary>
        public bool SearchWikipedia { get; set; }
        /// <summary>
        /// user setting to search on stackoverflow
        /// </summary>
        public bool SearchStackoverflow { get; set; }

        /// <summary>
        /// using Newtonsoft creates and saves json string to file
        /// </summary>
        /// <returns>Serialized Config class into json</returns>
        public string SaveConfigToFile()
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(GetFullUserSettingPath, json);
            return json;
        }
        /// <summary>
        /// using Newtonsoft deserialze user setting json file into Config class instance
        /// </summary>
        /// <returns>Config instance with current user setting</returns>
        public Config LoadConfigFromFile()
        {
            try
            {
                return JsonConvert.DeserializeObject<Config>(File.ReadAllText(GetFullUserSettingPath));
            }
            catch
            {
                return new Config();
            }
        }
    }
}
