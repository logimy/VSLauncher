using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace VSLauncher
{
    class ParamFile
    {
        //private string paramPath;

        public string ParamPath
        // Get or create clientsettings file;
        {
            get
            {
                //Console.WriteLine("Trying to find parameters file...");
                string defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\VintagestoryData\\clientsettings.json";
                if (File.Exists(defaultPath))
                {
                    string paramFileContent = File.ReadAllText(defaultPath);
                    if (new FileInfo(defaultPath).Length > 0 && Regex.IsMatch(paramFileContent, "  \"stringSettings\": {((.|\n)*)(  })"))
                    {
                        //Console.WriteLine("Parameters file found.\nParameter file is good to use.\nPath is: " + defaultPath);
                        return defaultPath;
                    } else
                    {
                        File.Delete(defaultPath);
                        
                        using (StreamWriter sw = File.CreateText(defaultPath))
                        {
                            sw.WriteLine("{");
                            sw.WriteLine("  \"stringSettings\": {");
                            sw.WriteLine("    \"language\": \"en\",");
                            sw.WriteLine("    \"playername\": \"\",");
                            sw.WriteLine("    \"playeruid\": \"\"");
                            sw.WriteLine("  }");
                            sw.WriteLine("}");
                        }
                        return defaultPath;
                    }
                }
                else
                {
                    //Console.WriteLine("Parameters file not found. Creating file.");
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\VintagestoryData");
                    using (StreamWriter sw = File.CreateText(defaultPath))
                    {
                        sw.WriteLine("{");
                        sw.WriteLine("  \"stringSettings\": {");
                        sw.WriteLine("    \"language\": \"en\",");
                        sw.WriteLine("    \"playername\": \"\",");
                        sw.WriteLine("    \"playeruid\": \"\"");
                        sw.WriteLine("  }");
                        sw.WriteLine("}");
                    }

                    //Console.WriteLine("Parameters file created. Path is: " + defaultPath);
                    return defaultPath;
                }
            }
        }

        public string GetParamUserName()
        {
            string jsonInput = File.ReadAllText(this.ParamPath);
            dynamic jsonDeser = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonInput);
            string currentPlayerName = jsonDeser["stringSettings"]["playername"];
            return currentPlayerName;
        }

        public string GetParamUID()
        {
            string jsonInput = File.ReadAllText(this.ParamPath);
            dynamic jsonDeser = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonInput);
            string currentUID = jsonDeser["stringSettings"]["playeruid"];
            return currentUID;
        }

        public string GetParamLang()
        {
            string jsonInput = File.ReadAllText(this.ParamPath);
            dynamic jsonDeser = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonInput);
            string currentLang = jsonDeser["stringSettings"]["language"];
            return currentLang;
        }


        public void SetParamUserData(string lang, string uName, string uUid)
        {
            string jsonInput = File.ReadAllText(this.ParamPath);
            dynamic jsonDeser = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonInput);
            jsonDeser["stringSettings"]["language"] = lang;
            jsonDeser["stringSettings"]["playername"] = uName;
            jsonDeser["stringSettings"]["playeruid"] = uUid;
            jsonDeser["stringSettings"]["useremail"] = "";
            jsonDeser["stringSettings"]["sessionsignature"] = "";
            jsonDeser["stringSettings"]["sessionkey"] = "";
            jsonDeser["stringSettings"]["mptoken"] = "";
            string jsonOutput = Newtonsoft.Json.JsonConvert.SerializeObject(jsonDeser, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(this.ParamPath, jsonOutput);
        }

        public bool IsParamUserDataUpdated(string lang, string uName, string uUid)
        {
            if (File.Exists(this.ParamPath))
            {
                string ParamFileContents = File.ReadAllText(this.ParamPath);
                if (ParamFileContents.Contains("\"language\": " + "\"" + lang + "\"") && ParamFileContents.Contains("\"playername\": " + "\"" + uName + "\"") && ParamFileContents.Contains("\"playeruid\": " + "\"" + uUid + "\""))
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }



    }
}
