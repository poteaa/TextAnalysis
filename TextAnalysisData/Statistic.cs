///////////////////////////////////////////////////////////
//  Statistic.cs
//  Implementation of the Class Statistic
//  Created on:  08/03/2015
//  Author: Diego Fernando Alvarez Andrade Cel: 3103121656
///////////////////////////////////////////////////////////

namespace TextAnalysisData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TextAnalysisModel;

    /// <summary>
    /// Class to resume the results of the text analysis
    /// </summary>
    public class Statistic
    {
        private int wordsEndingWithLowerN;
        private int phraseMoreThanFifteen;
        private int paragraphsCount;
        private int charCountExcludingN;
        private Client client;

        public int WordsEndingWithLowerN
        {
            get { return wordsEndingWithLowerN; }
            set { wordsEndingWithLowerN = value; }
        }

        public int PhraseMoreThanFifteen
        {
            get { return phraseMoreThanFifteen; }
            set { phraseMoreThanFifteen = value; }
        }

        public int ParagraphsCount
        {
            get { return paragraphsCount; }
            set { paragraphsCount = value; }
        }

        public int CharCountExcludingN
        {
            get { return charCountExcludingN; }
            set { charCountExcludingN = value; }
        }

        public Client Client
        {
            get { return client; }
            set { client = value; }
        }

        public Statistic(Client client)
        {
            this.client = client;
        }

        public override string ToString()
        {
            StringBuilder allText = new StringBuilder();
            allText.Append("\n************************************************************************************************************************************************************************************");
            allText.AppendFormat("\nCLIENT ID: {0}\nCLIENT NAME: {1}\n\nText:\n\n{2}\n\nSTATISTICS:\n", client.Id, client.Name, client.Text);
            allText.AppendFormat("\n\tWords ending with n : {0}\n\tPhrase with more than fifteen words : {1}\n\tParagraphs count : {2}\n\tChar countExcluding N and n :{3}\n",
                this.WordsEndingWithLowerN, this.PhraseMoreThanFifteen, this.ParagraphsCount, this.CharCountExcludingN);
            allText.Append("\n************************************************************************************************************************************************************************************");

            return allText.ToString();
        }

    }
}
