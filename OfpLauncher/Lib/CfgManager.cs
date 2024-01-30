using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OfpLauncher.Lib
{
    internal static class CfgManager
    {
        public static void ChangeAspectRatio(string aspect, FileInfo file)
        {
            var aspectValue = Lib.Constants.GetAspectValues(aspect);
            if (file.Exists)
            {
                try
                {
                    var rStream = new StreamReader(file.OpenRead());
                    var cfg = new StringBuilder();
                    string line;

                    while ((line = rStream.ReadLine()) != null)
                    {
                        line = line.Replace("\r\n", "");
                        var p = line.Split('=');
                        if (p.Length > 1)
                        {
                            if (aspectValue.ContainsKey(p[0]))
                            {
                                cfg.AppendLine($"{p[0]}={aspectValue[p[0]]}");
                                continue;
                            }
                        }
                        cfg.AppendLine(line);
                    }
                    rStream.Close();

                    var wStream = new StreamWriter(file.OpenWrite());
                    wStream.Write(cfg.ToString());
                    wStream.Flush();
                    wStream.Close();
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