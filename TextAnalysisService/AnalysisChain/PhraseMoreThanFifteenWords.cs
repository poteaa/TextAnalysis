///////////////////////////////////////////////////////////
//  PhraseMoreThanFifteenWords.cs
//  Implementation of the Class PhraseMoreThanFifteenWords
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
    /// Class for counting phrases that have more then fifteen words in a text
    /// </summary>
    public class PhraseMoreThanFifteenWords : Analysis
    {
        /// <summary>
        /// Analyzes the content of a text
        /// </summary>
        /// <param name="statistic">statistics object to fill with the results</param>
        public override void AnalyzeContent(Statistic statistic)
        {
            string[] phrases = { ". ", ".\n" };
            List<string> splittedChars = statistic.Client.Text.Split(phrases, StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] words = { " ", "\n" };
            statistic.PhraseMoreThanFifteen = splittedChars.Where(elem => elem.Split(words, StringSplitOptions.RemoveEmptyEntries).Count() > 15).Count();

            if (NextAnalyzer != null)
            {
                NextAnalyzer.AnalyzeContent(statistic);
            }
        }
    }
}