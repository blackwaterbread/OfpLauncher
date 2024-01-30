using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfpLauncher.Lib
{
    internal static class Constants
    {
        public static string CurrentPath = Application.StartupPath;
        public static string ConfigPath = CurrentPath + "/configs.json";
        public static string WindowedX = "1280";
        public static string WindowedY = "720";

        public static Dictionary<string, string> GetAspectValues(string aspect)
        {
            Dictionary<string, string> value;
            if (Aspects.TryGetValue(aspect, out value))
            {
                return value;
            }
            else
            {
                return Aspects["16:9"];
            }
        }

        public static readonly Dictionary<string, Dictionary<string, string>> Aspects = new Dictionary<string, Dictionary<string, string>>()
        {
            {
                // 4:3, Default
                "5:4",
                new Dictionary<string, string>() {
                    { "fovTop", "0.750000;" },
                    { "fovLeft", "1.000000;" },
                    { "uiTopLeftX", "0.000000;" },
                    { "uiTopLeftY", "0.000000;" },
                    { "uiBottomRightX", "1.000000;" },
                    { "uiBottomRightY", "1.000000;" },
                }
            },
            {
                "16:9",
                new Dictionary<string, string>() {
                    { "fovTop", "0.750000;" },
                    { "fovLeft", "1.333333;" },
                    { "uiTopLeftX", "0.125000;" },
                    { "uiTopLeftY", "0.000000;" },
                    { "uiBottomRightX", "0.875000;" },
                    { "uiBottomRightY", "1.000000;" },
                }
            },
            {
                "15:9",
                new Dictionary<string, string>() {
                    { "fovTop", "0.750000;" },
                    { "fovLeft", "1.250000;" },
                    { "uiTopLeftX", "0.100000;" },
                    { "uiTopLeftY", "0.000000;" },
                    { "uiBottomRightX", "0.900000;" },
                    { "uiBottomRightY", "1.000000;" },
                }
            },
            {
                "16:10",
                new Dictionary<string, string>() {
                    { "fovTop", "0.750000;" },
                    { "fovLeft", "1.200000;" },
                    { "uiTopLeftX", "0.083333;" },
                    { "uiTopLeftY", "0.000000;" },
                    { "uiBottomRightX", "0.916667;" },
                    { "uiBottomRightY", "1.000000;" },
                }
            },
            {
                "21:9",
                new Dictionary<string, string>() {
                    { "fovTop", "0.750000;" },
                    { "fovLeft", "1.777778;" },
                    { "uiTopLeftX", "0.218750;" },
                    { "uiTopLeftY", "0.000000;" },
                    { "uiBottomRightX", "0.781250;" },
                    { "uiBottomRightY", "1.000000;" },
                }
            },
        };
    }
}
