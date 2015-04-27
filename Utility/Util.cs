///////////////////////////////////////////////////////////
//  Util.cs
//  Implementation of the Class Util
//  Created on:  08/03/2015
//  Author: Diego Fernando Alvarez Andrade Cel: 3103121656
///////////////////////////////////////////////////////////

namespace Utility
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class for giving utilities
    /// </summary>
    public class Util
    {
        /// <summary>
        /// Generates a random text based on ValidCharacters appsetting
        /// </summary>
        /// <returns></returns>
        public static string CreateRandomText()
        {
            Random random = new Random();
            int length = 1000;
            string characters = ConfigurationManager.AppSettings["ValidCharacters"];
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            return result.Replace("\\", ".\n\n").ToString();
        }
    }
}
