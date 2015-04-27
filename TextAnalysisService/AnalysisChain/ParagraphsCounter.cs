///////////////////////////////////////////////////////////
//  ParagraphsCounter.cs
//  Implementation of the Class ParagraphsCounter
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
    /// Class for counting paragraphs in a text 
    /// </summary>
    public class ParagraphsCounter : Analysis
    {
        /// <summary>
        /// Analyzes the content of a text
        /// </summary>
        /// <param name="statistic">statistics object to fill with the results</param>
        public override void AnalyzeContent(Statistic statistic)
        {
            string[] paragraphs = { ".\n" };
            statistic.ParagraphsCount = statistic.Client.Text.Split(paragraphs, StringSplitOptions.RemoveEmptyEntries).ToList().Count;

            if (NextAnalyzer != null)
            {
                NextAnalyzer.AnalyzeContent(statistic);
            }
        }
    }
}