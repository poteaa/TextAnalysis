///////////////////////////////////////////////////////////
//  Analysis.cs
//  Implementation of the Class Analysis
//  Created on:  08/03/2015
//  Author: Diego Fernando Alvarez Andrade Cel: 3103121656
///////////////////////////////////////////////////////////

namespace TextAnalysisService.AnalysisChain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using TextAnalysisData;

    /// <summary>
    /// Base class to implement chain of responsibility
    /// </summary>
    public abstract class Analysis
    {
        private Analysis nextAnalyzer;

        public Analysis NextAnalyzer
        {
            get { return nextAnalyzer; }
            set { nextAnalyzer = value; }
        }

        /// <summary>
        /// Analyzes the content of a text
        /// </summary>
        /// <param name="statistic">statistics object to fill with the results</param>
        public abstract void AnalyzeContent(Statistic statistic);
    }
}