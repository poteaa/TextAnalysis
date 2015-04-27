///////////////////////////////////////////////////////////
//  AnalysisService.cs
//  Implementation of the Class AnalysisService
//  Created on:  08/03/2015
//  Author: Diego Fernando Alvarez Andrade Cel: 3103121656
///////////////////////////////////////////////////////////

namespace TextAnalysisService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.Text;
    using TextAnalysisModel;

    /// <summary>
    /// Service to analyze data
    /// </summary>
    public class AnalysisService : IAnalysisService
    {
        /// <summary>
        /// Get method test
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string GetData(string text)
        {
            return string.Format("You entered: {0}", text);
        }

        /// <summary>
        /// Analyzes the received data to create statistics
        /// </summary>
        /// <param name="client"></param>
        public void PostData(Client client)
        {
            AnalysysManager manager = new AnalysysManager();
            manager.Initialize(client);
        }
    }
}
