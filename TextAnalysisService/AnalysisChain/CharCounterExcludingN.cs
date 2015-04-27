///////////////////////////////////////////////////////////
//  CharCounterExcludingN.cs
//  Implementation of the Class CharCounterExcludingN
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
    /// Class for counting chars excluding n in a text
    /// </summary>
    public class CharCounterExcludingN : Analysis
    {
        /// <summary>
        /// Analyzes the content of a text
        /// </summary>
        /// <param name="statistic">statistics object to fill with the results</param>
        public override void AnalyzeContent(Statistic statistic)
        {
            string res = new String(statistic.Client.Text.Replace("n", "").Replace("N", "").Distinct().ToArray());
            statistic.CharCountExcludingN = res.Length;

            if (NextAnalyzer != null)
            {
                NextAnalyzer.AnalyzeContent(statistic);
            }
        }
    }
}