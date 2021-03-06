﻿// FFXIVAPP.Plugin.Widgets
// PluginException.cs
// 
// © 2013 ZAM Network LLC

using System;
using System.Runtime.Serialization;

namespace FFXIVAPP.Plugin.Widgets
{
    [Serializable]
    public class PluginException : Exception
    {
        public PluginException()
        {
        }

        public PluginException(string message) : base(message)
        {
        }

        public PluginException(string message, Exception inner) : base(message, inner)
        {
        }

        protected PluginException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
