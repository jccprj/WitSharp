﻿namespace WitSharp
{
    /// <summary>Configuration for  Wit client.</summary>
    public class Config
    {
        /// <summary>Your server access token.</summary>
        public string AccessToken { get; set; }
        /// <summary>What kind of event logging do you want?</summary>
        public LogSeverity LogSeverity { get; set; } = LogSeverity.INFO;
    }
    /// <summary>LogSeverity.</summary>
    public enum LogSeverity
    {
        /// <summary>Info with silent exceptions if any.</summary>
        INFO,
        /// <summary>Will throw exceptions.</summary>
        EXCEPTIONS
    }
}