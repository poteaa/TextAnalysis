///////////////////////////////////////////////////////////
//  Proxy.cs
//  Implementation of the Class Proxy
//  Created on:  08/03/2015
//  Author: Diego Fernando Alvarez Andrade Cel: 3103121656
///////////////////////////////////////////////////////////

namespace TextAnalysisFormsClient.Comunication
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using RestSharp;

    public abstract class Proxy
    {
        protected ConnectionManager connection;
        private Method verb;
        private string resource;
        private StringDictionary urlSegments;
        private object body;

        public Method Verb
        {
            get { return verb; }
            set { verb = value; }
        }
        
        public string Resource
        {
            get { return resource; }
            set { resource = value; }
        }

        public StringDictionary UrlSegments
        {
            get { return urlSegments; }
            set { urlSegments = value; }
        }

        public object Body
        {
            get { return body; }
            set { body = value; }
        }
        
        /// <summary>
        /// Initializes the proxy
        /// </summary>
        /// <param name="method"></param>
        /// <param name="urlSegments"></param>
        public Proxy()
        {
            resource = string.Empty;
            body = string.Empty;
            connection = ConnectionManager.Inst();
            UrlSegments = new StringDictionary();
        }

        public virtual void Set(Method verb = Method.GET, StringDictionary segments = null)
        {

        }

        /// <summary>
        /// Sends a generic request to the server
        /// </summary>
        public virtual void SendRequest()
        {

        }

        /// <summary>
        /// Sends a get request to the server
        /// </summary>
        public virtual void SendGetRequest()
        {

        }

        /// <summary>
        /// Sends a post request to the server
        /// </summary>
        public virtual void SendPostRequest()
        {

        }

        /// <summary>
        /// Sends an async post request to the server
        /// </summary>
        public virtual void SendPostRequestAsync(Delegate failure)
        {

        }

        /// <summary>
        /// Sends put request to the server
        /// </summary>
        public virtual void SendPutRequest()
        {

        }

        /// <summary>
        /// Sends delete request to the server
        /// </summary>
        public virtual void SendDeleteRequest()
        {

        }

    }
}
