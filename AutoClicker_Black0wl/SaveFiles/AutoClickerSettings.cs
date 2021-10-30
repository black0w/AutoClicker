using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace AutoClicker_Black0wl.SaveFiles
{
    public static class AutoClickerGlobalSettings
    {
        public static void SaveToFile(string _start_stop_btn, bool _holdButton, List<Coords> _coords = null, string _scan_button = "")
        {
            var autoClickerSettings = new AutoClickerSettings()
            { start_stop_btn = _start_stop_btn, holdButton = _holdButton, coords = _coords, scan_button = _scan_button };

            var result = ReadFromJson();

            if (result.coords != null && _coords == null)
                autoClickerSettings.coords = result.coords;

            if (result.scan_button != null && _scan_button == "")
                autoClickerSettings.scan_button = result.scan_button;

            var jsonToWrite = JsonConvert.SerializeObject(autoClickerSettings, Formatting.Indented);

            using (var writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\settings.json"))
            {
                writer.Write(jsonToWrite);
            }
        }

        public static void SaveAllToFile(string _start_stop_btn, bool _holdButton, List<Coords> _coords = null, string _scan_button = "F1")
        {
            var autoClickerSettings = new AutoClickerSettings()
            { start_stop_btn = _start_stop_btn, holdButton = _holdButton, coords = _coords, scan_button = _scan_button };

            var jsonToWrite = JsonConvert.SerializeObject(autoClickerSettings, Formatting.Indented);

            using (var writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\settings.json"))
            {
                writer.Write(jsonToWrite);
            }
        }

        public static AutoClickerSettings ReadFromJson()
        {
            try
            {
                string jsonFromFile;
                using (var reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"\settings.json"))
                {
                    jsonFromFile = reader.ReadToEnd();
                }
                var result = JsonConvert.DeserializeObject<AutoClickerSettings>(jsonFromFile);

                return result;

            }
            catch (Exception ex)
            {
               
                return new AutoClickerSettings();
            }
        }
    }

    public class AutoClickerSettings
    {
        public string start_stop_btn { get; set; }
        public bool holdButton { get; set; }
        public string scan_button { get; set; }
        public List<Coords> coords { get; set; }
    }

    public class Coords
    {
        public string Name { get; set; }
        public List<Point> Points { get; set; }

    }
}
