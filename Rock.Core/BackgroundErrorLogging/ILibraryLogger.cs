﻿namespace Rock.BackgroundErrorLogging
{
    /// <summary>
    /// Defines various logging methods for libraries to use.
    /// </summary>
    public interface ILibraryLogger
    {
        /// <summary>
        /// Logs the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        void Log(LibraryLogMessage message);
    }
}