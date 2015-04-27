///////////////////////////////////////////////////////////
//  ProxyRest.cs
//  Implementation of the Class ProxyRest
//  Created on:  08/03/2015
//  Author: Diego Fernando Alvarez Andrade Cel: 3103121656
///////////////////////////////////////////////////////////

namespace TextAnalysisFormsClient.Comunication.Rest
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using RestSharp;

    /// <summary>
    /// Class for creating the proxy
    /// </summary>
    public class ProxyRest : Proxy
    {
        RestClient client;
        RestRequest request;

        public ProxyRest()
        {
        }

        /// <summary>
        /// Initializes the proxy
        /// </summary>
        /// <param name="method"></param>
        /// <param name="urlSegments"></param>
        public override void Set(Method method, StringDictionary urlSegments = null)
        {
            client = new RestClient(connection.Url);
            UrlSegments = urlSegments;
        }

        private void SetDelete()
        {
            throw new NotImplementedException();
        }

        private void SetPut()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes post comunication
        /// </summary>
        private void SetPost()
        {
            Verb = Method.POST;
            Resource = "data/Add";
            request = new RestRequest(Resource, Verb);
            if (UrlSegments != null)
            {
                foreach (DictionaryEntry de in UrlSegments)
                {
                    request.AddUrlSegment(de.Key.ToString(), de.Value.ToString());
                }
            }
            request.RequestFormat = DataFormat.Json;
        }

        /// <summary>
        /// Initializes get comunication
        /// </summary>
        private void SetGet()
        {
            Verb = Method.GET;
            Resource = "data/{text}";
            request = new RestRequest(Resource, Verb);
            request.RequestFormat = DataFormat.Json;

            if (UrlSegments != null)
            {
                foreach (DictionaryEntry de in UrlSegments)
                {
                    request.AddUrlSegment(de.Key.ToString(), de.Value.ToString());
                }
            }
        }

        /// <summary>
        /// Sends a get request to the rest server
        /// </summary>
        public override void SendGetRequest()
        {
            SetGet();
            var response = client.Execute(request);
        }

        /// <summary>
        /// Sends a post request to the rest server
        /// </summary>
        public override void SendPostRequest()
        {
            SetPost();
            request.AddBody(Body);
            var response = client.Execute(request);
        }

        /// <summary>
        /// Sends an async post request to the rest server
        /// </summary>
        public override void SendPostRequestAsync(Delegate failure = null)
        {
            SetPost();
            request.AddBody(Body);
            client.ExecuteAsync(request, response =>
            {
                if (response.ResponseStatus == ResponseStatus.Completed)
                {
                    ClientForm.solvedPackages++;
                }
                else if (response.ResponseStatus == ResponseStatus.Error)
                {
                    failure.DynamicInvoke();
                }
            });
        }

    }
}
