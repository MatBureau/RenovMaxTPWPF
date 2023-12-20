using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenovMaxTP.Utils
{
    public class ConfigManager
    {
        private string filePath;

        public ConfigManager(string filePath)
        {
            this.filePath = filePath;
        }

        public Dictionary<string, string> ReadConfig()
        {
            var data = new Dictionary<string, string>();

            if (File.Exists(filePath))
            {
                foreach (var line in File.ReadAllLines(filePath))
                {
                    if (!string.IsNullOrWhiteSpace(line) && !line.StartsWith(";"))
                    {
                        var parts = line.Split('=', 2);
                        if (parts.Length == 2)
                        {
                            data[parts[0].Trim()] = parts[1].Trim();
                        }
                    }
                }
            }

            return data;
        }

        public void WriteConfig(Dictionary<string, string> data)
        {
            using (var writer = new StreamWriter(filePath, false))
            {
                foreach (var entry in data)
                {
                    writer.WriteLine($"{entry.Key}={entry.Value}");
                }
            }
        }
    }
}


