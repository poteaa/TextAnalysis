///////////////////////////////////////////////////////////
//  ConnectionManager.cs
//  Implementation of the Class ConnectionManager
//  Created on:  08/03/2015
//  Author: Diego Fernando Alvarez Andrade Cel: 3103121656
///////////////////////////////////////////////////////////

namespace TextAnalysisFormsClient.Comunication
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using RestSharp;

    public class ConnectionManager
    {
        private static ConnectionManager instance;
        private string url;

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        private ConnectionManager()
        {
            url = ConfigurationManager.AppSettings["RestAddress"];
        }

        public static ConnectionManager Inst()
        {
            if (instance == null)
            {
                instance = new ConnectionManager();
            }
             
            return instance;
        }
    }
}
