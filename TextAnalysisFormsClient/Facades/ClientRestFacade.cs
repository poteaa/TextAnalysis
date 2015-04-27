///////////////////////////////////////////////////////////
//  ClientRestFacade.cs
//  Implementation of the Class ClientRestFacade
//  Created on:  08/03/2015
//  Author: Diego Fernando Alvarez Andrade Cel: 3103121656
///////////////////////////////////////////////////////////

namespace TextAnalysisFormsClient.Facades
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using RestSharp;
    using TextAnalysisFormsClient.Comunication;
    using TextAnalysisFormsClient.Comunication.Factory;
    using TextAnalysisFormsClient.Comunication.Rest;
    using TextAnalysisModel;

    /// <summary>
    /// Facade for rest services
    /// </summary>
    public class ClientRestFacade
    {
        ProxyFactory factory;
        Proxy proxy = null;

        public ClientRestFacade(Method method = Method.GET, StringDictionary segments = null)
        {
            factory = new ProxyFactory();
            string proxyType = ConfigurationManager.AppSettings["ProxyType"];
            proxy = factory.CreateProxy(proxyType);
            proxy.Set(method, segments);
        }

        /// <summary>
        /// Sends a get request to the proxy
        /// </summary>
        /// <param name="values"></param>
        public void SendGetRequest(StringDictionary values)
        {
            proxy.UrlSegments = values;
            proxy.SendGetRequest();
        }

        /// <summary>
        /// Sends a post request to the proxy
        /// </summary>
        /// <param name="content"></param>
        public void SendPostRequest(object content, Delegate failure = null)
        {
            proxy.Body = content;
            proxy.SendPostRequestAsync(failure);
        }
    }
}
