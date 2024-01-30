using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OfpLauncher.Lib
{
    internal static class HppManager
    {
        public static void ChangeAspectRatio(string aspect, FileInfo file)
        {
            if (Constants.Aspects.ContainsKey(aspect))
            {
                if (file.Exists)
                {
                    try
                    {
                        var rStream = new StreamReader(file.OpenRead());
                        var hpp = new StringBuilder();
                        string line;

                        while ((line = rStream.ReadLine()) != null)
                        {
                            line = line.Replace("\r\n", "");
                            var p = line.Split(' ');
                            if (p.Length > 1)
                            {
                                if (p[0] == "#define" && p[1].Length >= 12 && p[1].Substring(0, 12) == "aspect_ratio")
                                {
                                    p[1] = $"aspect_ratio_{aspect.Replace(':', '_')}";
                                    hpp.AppendLine(string.Join(" ", p));
                                    continue;
                                }
                            }
                            hpp.AppendLine(line);
                        }
                        rStream.Close();

                        var wStream = new StreamWriter(file.OpenWrite());
                        wStream.Write(hpp.ToString());
                        wStream.Flush();
                        wStream.Close();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"작업 도중에 에러가 발생하였습니다: {ex.Message}");
                    }
                }
                else
                {
                    throw new Exception("파일이 존재하지 않는 것 같습니다.");
                }
            }
            else
            {
                throw new Exception("지원하지 않는 화면비입니다.");
            }
        }
    }
}
