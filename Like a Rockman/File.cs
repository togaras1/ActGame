﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Like_a_Rockman
{
    class FileIO
    {
        /// <summary>
        /// ファイルの読み込み
        /// </summary>
        /// <param name="FileName">読み込むファイル名</param>
        /// <returns>ファイルの行ごとの内容</returns>
        public static string[] TextLoad(string FileName)
        {
            if (File.Exists(FileName))
            {
                ArrayList list = new ArrayList();

                using (var read = new StreamReader(FileName, Encoding.GetEncoding("Shift_JIS")))
                {
                    string line;

                    while ((line = read.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }

                string[] str = new string[list.Count];

                for (int i = 0; i < list.Count; i++)
                    str[i] = list[i].ToString();

                return str;
            }
            else
            {
                return null;
            }
        }

        public static bool TextOutput(string FileName, string Content)
        {
            using (var str = new StreamWriter(FileName, false, Encoding.GetEncoding("Shift_JIS")))
            {
                str.WriteLine(Content);
                return true;
            }
        }
    }
}
