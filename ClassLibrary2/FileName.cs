using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary2
{
    public class FileName
    {
        public string GetFileName(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException("文件路径不能为空。", nameof(filePath));
            }
            return System.IO.Path.GetFileName(filePath);
        }
    }
}
