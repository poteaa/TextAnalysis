///////////////////////////////////////////////////////////
//  WordEndingWithLowerN.cs
//  Implementation of the Class WordEndingWithLowerN
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
    /// Class for counting words ending with n
    /// </summary>
    public class WordEndingWithLowerN : Analysis
    {
        /// <summary>
        /// Analyzes the content of a text
        /// </summary>
        /// <param name="statistic">statistics object to fill with the results</param>
        public override void AnalyzeContent(Statistic statistic)
        {
            string[] chars = { " ", ",", ".", "\n" };
            List<string> splittedChars = statistic.Client.Text.Split(chars, StringSplitOptions.RemoveEmptyEntries).ToList();
            statistic.WordsEndingWithLowerN= splittedChars.Where(elem => elem.EndsWith("n")).Count();

            if (NextAnalyzer != null)
            {
                NextAnalyzer.AnalyzeContent(statistic);
            }
        }
    }
}