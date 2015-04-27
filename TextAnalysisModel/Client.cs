///////////////////////////////////////////////////////////
//  Client.cs
//  Implementation of the Class Client
//  Created on:  08/03/2015
//  Author: Diego Fernando Alvarez Andrade Cel: 3103121656
///////////////////////////////////////////////////////////

namespace TextAnalysisModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class to model a client
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Client identifier
        /// </summary>
        private int id;
        /// <summary>
        /// Client Name
        /// </summary>
        private string name;
        /// <summary>
        /// Text to send
        /// </summary>
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Client()
        { 
        }

        public Client(int id, string name)
        {
            this.id = id;
            this.name = name;
            text = string.Empty;
        }
    }
}
