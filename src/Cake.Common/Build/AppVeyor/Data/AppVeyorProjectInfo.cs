﻿using Cake.Core;

namespace Cake.Common.Build.AppVeyor.Data
{
    /// <summary>
    /// Provides AppVeyor project information for a current build.
    /// </summary>
    public sealed class AppVeyorProjectInfo : AppVeyorInfo
    {
        /// <summary>
        /// Gets the AppVeyor unique project ID.
        /// </summary>
        /// <value>
        /// The AppVeyor unique project ID.
        /// </value>
        public string Id
        {
            get { return GetEnvironmentString("APPVEYOR_PROJECT_ID"); }
        }

        /// <summary>
        /// Gets the project name.
        /// </summary>
        /// <value>
        /// The project name.
        /// </value>
        public string Name
        {
            get { return GetEnvironmentString("APPVEYOR_PROJECT_NAME"); }
        }

        /// <summary>
        /// Gets the project slug (as seen in project details URL).
        /// </summary>
        /// <value>
        /// The project slug (as seen in project details URL).
        /// </value>
        public string Slug
        {
            get { return GetEnvironmentString("APPVEYOR_PROJECT_SLUG"); }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppVeyorProjectInfo"/> class.
        /// </summary>
        /// <param name="environment">The environment.</param>
        public AppVeyorProjectInfo(ICakeEnvironment environment)
            : base(environment)
        {
        }
    }
}