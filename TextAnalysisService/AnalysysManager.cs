///////////////////////////////////////////////////////////
//  AnalysysManager.cs
//  Implementation of the Class AnalysysManager
//  Created on:  08/03/2015
//  Author: Diego Fernando Alvarez Andrade Cel: 3103121656
///////////////////////////////////////////////////////////

namespace TextAnalysisService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using TextAnalysisData;
    using TextAnalysisModel;
    using TextAnalysisService.AnalysisChain;

    /// <summary>
    /// Manager to start the chain of responsibility
    /// </summary>
    public class AnalysysManager
    {
        /// <summary>
        /// Initializes the chain of responsability
        /// </summary>
        /// <param name="client"></param>
        public void Initialize(Client client)
        {
            CharCounterExcludingN charCounterExcludingN = new CharCounterExcludingN();
            ParagraphsCounter paragraphsCounter = new ParagraphsCounter();
            PhraseMoreThanFifteenWords phraseMoreThanFifteenWords = new PhraseMoreThanFifteenWords();
            WordEndingWithLowerN wordEndingWithLowerN = new WordEndingWithLowerN();

            charCounterExcludingN.NextAnalyzer = paragraphsCounter;
            paragraphsCounter.NextAnalyzer = phraseMoreThanFifteenWords;
            phraseMoreThanFifteenWords.NextAnalyzer = wordEndingWithLowerN;

            Statistic resultStatistic = new Statistic(client);
            charCounterExcludingN.AnalyzeContent(resultStatistic);

            LogBook lb = LogBook.LogBookIns();
            lb.WriteToDisk(client.Id.ToString(), resultStatistic.ToString());

        }

    }
}