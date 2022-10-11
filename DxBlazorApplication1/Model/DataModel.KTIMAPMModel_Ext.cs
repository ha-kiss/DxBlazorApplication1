using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DxBlazorApplication1.Model
{
    public partial class KTIMAPMModel : DbContext
    {
        private DbContextOptionsBuilder? modelOptionsBuilder = null;
        private LogLevel? modelLogLevel = null;

        /// <summary>
        /// Creates a DbContext that will log its diagnostic actions to the debug window
        /// </summary>
        /// <param name="logLevel">The severity level</param>
        public KTIMAPMModel(LogLevel logLevel) : base()
        {
            OnCreated();

            modelLogLevel = logLevel;
        }

        partial void CustomizeConfiguration(ref DbContextOptionsBuilder optionsBuilder)
        {
            modelOptionsBuilder = optionsBuilder;
            if (modelLogLevel != null)
                StartDebug(modelLogLevel.Value);
        }

        /// <summary>
        /// Logs the DbContext diagnostic actions to the debug window
        /// </summary>
        /// <param name="logLevel">The severity level</param>
        public void StartDebug(LogLevel logLevel = LogLevel.Information)
        {
            modelLogLevel = logLevel;

            if (modelOptionsBuilder != null)
                modelOptionsBuilder.LogTo(message => Debug.WriteLine(message), logLevel);
        }

        /// <summary>
        /// Stops the DbContext logs to the debug window
        /// </summary>
        public void StopDebug()
        {
            if (modelOptionsBuilder != null)
                modelOptionsBuilder.LogTo(message => _ = message);
        }

        /// <summary>
        /// Shows the DebugView.LongView debug string in the debug window
        /// </summary>
        public void ShowDebugViewLong()
        {
            Debug.WriteLine(ChangeTracker.DebugView.LongView);
        }
    }
}
