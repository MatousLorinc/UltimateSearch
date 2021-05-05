using System;
using System.Diagnostics;

namespace OpenUrl
{
    public class Browser
    {
        /// <summary>
        /// Starts new process and open new tab in default browser
        /// </summary>
        /// <param name="url">website link opened in browser</param>
        /// <returns></returns>
        public static Process StartNewBrowserProcess(string url)
        {
            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = url;
            process.Start();
            return process;
        }
    }
}
