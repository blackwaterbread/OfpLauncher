using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OfpLauncher.Lib
{
    public class CfgManager
    {
        public class OfpConfig
        {
            public OfpConfig(Dictionary<string, string> Configs, string Classes)
            {
                this.Configs = Configs;
                this.Classes = Classes;
            }

            public Dictionary<string, string> Configs;
            public string Classes;
        }

        public static void Write(OfpConfig config, FileInfo file)
        {
            try
            {
                var wStream = new StreamWriter(file.OpenWrite());
                var cfg = new StringBuilder();
                foreach (var v in config.Configs)
                {
                    cfg.AppendLine($"{v.Key}={v.Value}");
                }
                cfg.AppendLine(config.Classes);
                wStream.Write(cfg.ToString());
                wStream.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"파일을 쓰는 도중에 에러가 발생하였습니다: {ex.Message}");
            }
        }

        public static OfpConfig Read(FileInfo file)
        {
            var configDict = new Dictionary<string, string>();
            var classes = new StringBuilder();

            if (file.Exists)
            {
                try
                {
                    var rStream = new StreamReader(file.OpenRead());
                    var nCfg = new StringBuilder();
                    var inClass = false;
                    var cDepth = 0;
                    string line;
                    while ((line = rStream.ReadLine()) != null)
                    {
                        // 원래는 class 파싱도 세세하게 처리해야하는데, 이 툴에선 화면비만 바꾸는게 목적이니까 대강 처리했음
                        line = line.Replace("\r\n", "").Trim();
                        if (String.IsNullOrEmpty(line)) continue;
                        if (inClass)
                        {
                            if (line.Length >= 5 && line.Substring(0, 5) == "class") cDepth++;
                            var taps = (line == "{" || line == "};" || line.Length >= 5 && line.Substring(0, 5) == "class") ? new string('\t', cDepth - 1) : new string('\t', cDepth);
                            if (line.Length >= 2 && line.Substring(0, 2) == "};") cDepth--;
                            if (cDepth == 0)
                            {
                                inClass = false;
                                cDepth = 1;
                            }
                            classes.AppendLine($"{taps}{line}");
                        }

                        else if (line.Length >= 5 && line.Substring(0, 5) == "class")
                        {
                            classes.AppendLine(line);
                            inClass = true;
                            cDepth = 1;
                            continue;
                        }

                        else
                        {
                            var kv = line.Split('=');
                            configDict.Add(kv[0], kv[1]);
                        }
                    }
                    rStream.Close();
                    return new OfpConfig(configDict, classes.ToString());
                }
                catch (Exception ex)
                {
                    throw new Exception($"파일을 읽는 도중에 에러가 발생하였습니다: {ex.Message}");
                }
            }
            else
            {
                throw new Exception("파일이 존재하지 않는 것 같습니다.");
            }
        }
    }
}