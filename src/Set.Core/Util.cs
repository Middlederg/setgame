using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Set.Core
{
    public static class Util
    {
        public static string Simplify(this string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return string.Empty;
            return value.Trim().ToLowerInvariant()
                .Replace("á", "a")
                .Replace("é", "e")
                .Replace("í", "i")
                .Replace("ó", "o")
                .Replace("ú", "u");
        }
    }
}