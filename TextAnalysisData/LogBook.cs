///////////////////////////////////////////////////////////
//  LogBook.cs
//  Implementation of the Class LogBook
//  Created on:  08/03/2015
//  Author: Diego Fernando Alvarez Andrade Cel: 3103121656
///////////////////////////////////////////////////////////

namespace TextAnalysisData
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using TextAnalysisModel;

    /// <summary>
    /// Class to write to the logbook
    /// </summary>
    public class LogBook
    {
        private static LogBook instance;
        private string path;

        private LogBook()
        {
            path = ConfigurationManager.AppSettings["StatisticsPath"];
        }

        public static LogBook LogBookIns()
        {
            if (instance == null)
            {
                instance = new LogBook();
            }
            return instance;
        }
        
        /// <summary>
        /// Writes text to disk
        /// </summary>
        /// <param name="fileName">file to write</param>
        /// <param name="text">text to write</param>
        public void WriteToDisk(string fileName, string text)
        {
            try
            {
                lock (this)
                {
                    File.AppendAllText(string.Format("{0}{1}{2}", path, fileName, ".txt"), text);
                }
            }
            catch (IOException iOEx)
            {
                throw iOEx;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
