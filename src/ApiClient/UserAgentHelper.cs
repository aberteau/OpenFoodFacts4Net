using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFoodFacts4Net.ApiClient
{
    public class UserAgentHelper
    {
        public static String GetUserAgent(string applicationName, string system, string version, string projectUrl)
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (!String.IsNullOrWhiteSpace(applicationName))
                stringBuilder.Append(applicationName);

            if (!String.IsNullOrWhiteSpace(system))
            {
                stringBuilder.AppendIfNotEmpty(" - ");
                stringBuilder.Append(system);
            }

            if (!String.IsNullOrWhiteSpace(version))
            {
                stringBuilder.AppendIfNotEmpty(" - ");
                stringBuilder.Append($"Version {version}");
            }

            if (!String.IsNullOrWhiteSpace(projectUrl))
            {
                stringBuilder.AppendIfNotEmpty(" - ");
                stringBuilder.Append(projectUrl);
            }

            return stringBuilder.ToString();
        }
    }
}
