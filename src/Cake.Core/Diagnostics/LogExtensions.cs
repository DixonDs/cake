﻿namespace Cake.Core.Diagnostics
{
    /// <summary>
    /// Contains extension methods for <see cref="ICakeLog"/>.
    /// </summary>
    public static class LogExtensions
    {
        /// <summary>
        /// Writes an error message to the log using the specified format information.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">An array of objects to write using format.</param>
        public static void Error(this ICakeLog log, string format, params object[] args)
        {
            Error(log, Verbosity.Quiet, format, args);
        }

        /// <summary>
        /// Writes an error message to the log using the specified 
        /// verbosity and format information.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="verbosity">The verbosity.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">An array of objects to write using format.</param>
        public static void Error(this ICakeLog log, Verbosity verbosity, string format, params object[] args)
        {
            if (log != null)
            {
                log.Write(verbosity, LogLevel.Error, format, args);
            }
        }

        /// <summary>
        /// Writes an error message to the log using the specified 
        /// verbosity and log message action.
        /// Evaluation message only if verbosity same or more verbose.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="verbosity">The verbosity.</param>
        /// <param name="logAction">The function called for message when logging.</param>
        public static void Error(this ICakeLog log, Verbosity verbosity, LogAction logAction)
        {
            Write(log, verbosity, LogLevel.Error, logAction);
        }

        /// <summary>
        /// Writes an error message to the log using the specified log message action.
        /// Evaluation message only if verbosity same or more verbose.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="logAction">The function called for message when logging.</param>
        public static void Error(this ICakeLog log, LogAction logAction)
        {
            Error(log, Verbosity.Quiet, logAction);
        }

        /// <summary>
        /// Writes a warning message to the log using the specified format information.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">An array of objects to write using format.</param>
        public static void Warning(this ICakeLog log, string format, params object[] args)
        {
            Warning(log, Verbosity.Minimal, format, args);
        }

        /// <summary>
        /// Writes a warning message to the log using the specified 
        /// verbosity and format information.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="verbosity">The verbosity.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">An array of objects to write using format.</param>
        public static void Warning(this ICakeLog log, Verbosity verbosity, string format, params object[] args)
        {
            if (log != null)
            {
                log.Write(verbosity, LogLevel.Warning, format, args);
            }
        }

        /// <summary>
        /// Writes a warning message to the log using the specified log message action.
        /// Evaluation message only if verbosity same or more verbose.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="logAction">The function called for message when logging.</param>
        public static void Warning(this ICakeLog log, LogAction logAction)
        {
            Warning(log, Verbosity.Minimal, logAction);
        }

        /// <summary>
        /// Writes a warning message to the log using the specified 
        /// verbosity and log message action.
        /// Evaluation message only if verbosity same or more verbose.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="verbosity">The verbosity.</param>
        /// <param name="logAction">The function called for message when logging.</param>
        public static void Warning(this ICakeLog log, Verbosity verbosity, LogAction logAction)
        {
            Write(log, verbosity, LogLevel.Warning, logAction);
        }

        /// <summary>
        /// Writes an informational message to the log using the specified format information.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">An array of objects to write using format.</param>
        public static void Information(this ICakeLog log, string format, params object[] args)
        {
            Information(log, Verbosity.Normal, format, args);
        }

        /// <summary>
        /// Writes an informational message to the log using the specified 
        /// verbosity and format information.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="verbosity">The verbosity.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">An array of objects to write using format.</param>
        public static void Information(this ICakeLog log, Verbosity verbosity, string format, params object[] args)
        {
            if (log != null)
            {
                log.Write(verbosity, LogLevel.Information, format, args);
            }
        }

        /// <summary>
        /// Writes an informational message to the log using the specified 
        /// verbosity and log message action.
        /// Evaluation message only if verbosity same or more verbose.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="verbosity">The verbosity.</param>
        /// <param name="logAction">The function called for message when logging.</param>
        public static void Information(this ICakeLog log, Verbosity verbosity, LogAction logAction)
        {
            Write(log, verbosity, LogLevel.Information, logAction);
        }

        /// <summary>
        /// Writes an informational message to the log using the specified log message action.
        /// Evaluation message only if verbosity same or more verbose.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="logAction">The function called for message when logging.</param>
        public static void Information(this ICakeLog log, LogAction logAction)
        {
            Information(log, Verbosity.Normal, logAction);
        }

        /// <summary>
        /// Writes a verbose message to the log using the specified format information.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">An array of objects to write using format.</param>
        public static void Verbose(this ICakeLog log, string format, params object[] args)
        {
            Verbose(log, Verbosity.Verbose, format, args);
        }

        /// <summary>
        /// Writes a verbose message to the log using the specified 
        /// verbosity and format information.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="verbosity">The verbosity.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">An array of objects to write using format.</param>
        public static void Verbose(this ICakeLog log, Verbosity verbosity, string format, params object[] args)
        {
            if (log != null)
            {
                log.Write(verbosity, LogLevel.Verbose, format, args);
            }
        }

        /// <summary>
        /// Writes a verbose message to the log using the specified log message action.
        /// Evaluation message only if verbosity same or more verbose.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="logAction">The function called for message when logging.</param>
        public static void Verbose(this ICakeLog log, LogAction logAction)
        {
            Verbose(log, Verbosity.Verbose, logAction);
        }

        /// <summary>
        /// Writes a verbose message to the log using the specified 
        /// verbosity and log message action.
        /// Evaluation message only if verbosity same or more verbose.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="verbosity">The verbosity.</param>
        /// <param name="logAction">The function called for message when logging.</param>
        public static void Verbose(this ICakeLog log, Verbosity verbosity, LogAction logAction)
        {
            Write(log, verbosity, LogLevel.Verbose, logAction);
        }

        /// <summary>
        /// Writes a debug message to the log using the specified format information.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">An array of objects to write using format.</param>
        public static void Debug(this ICakeLog log, string format, params object[] args)
        {
            Debug(log, Verbosity.Diagnostic, format, args);
        }

        /// <summary>
        /// Writes a debug message to the log using the specified 
        /// verbosity and format information.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="verbosity">The verbosity.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">An array of objects to write using format.</param>
        public static void Debug(this ICakeLog log, Verbosity verbosity, string format, params object[] args)
        {
            if (log != null)
            {
                log.Write(verbosity, LogLevel.Debug, format, args);
            }
        }

        /// <summary>
        /// Writes a debug message to the log using the specified log message action.
        /// Evaluation message only if verbosity same or more verbose.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="logAction">The function called for message when logging.</param>
        public static void Debug(this ICakeLog log, LogAction logAction)
        {
            Debug(log, Verbosity.Diagnostic, logAction);
        }

        /// <summary>
        /// Writes a debug message to the log using the specified 
        /// verbosity and log message action.
        /// Evaluation message only if verbosity same or more verbose.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="verbosity">The verbosity.</param>
        /// <param name="logAction">The function called for message when logging.</param>
        public static void Debug(this ICakeLog log, Verbosity verbosity, LogAction logAction)
        {
            Write(log, verbosity, LogLevel.Debug, logAction);
        }

        /// <summary>
        /// Writes a message to the log using the specified verbosity, loglevel and logAction delegate
        /// Evaluation message only if verbosity same or more verbose.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="verbosity">The verbosity.</param>
        /// <param name="level">The log level.</param>
        /// <param name="logAction">The function called for message when logging.</param>
        public static void Write(this ICakeLog log, Verbosity verbosity, LogLevel level, LogAction logAction)
        {
            if (log == null || logAction == null)
            {
                return;
            }

            if (verbosity > log.Verbosity)
            {
                return;
            }

            LogActionEntry actionEntry = (format, args) => log.Write(verbosity, level, format, args);
            logAction(actionEntry);
        }
    }
}
