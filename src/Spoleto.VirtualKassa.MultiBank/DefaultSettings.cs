﻿using System.Text;

namespace Spoleto.VirtualKassa.MultiBank
{
    /// <summary>
    /// The default settings for the project.
    /// </summary>
    public static class DefaultSettings
    {
        public const string ContentType = ContentTypes.ApplicationJson;
        public const string Charset = "utf-8";
        public static readonly Encoding Encoding = Encoding.GetEncoding(Charset);
    }
}
