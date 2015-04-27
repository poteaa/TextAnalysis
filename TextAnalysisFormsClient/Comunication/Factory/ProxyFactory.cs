///////////////////////////////////////////////////////////
//  ProxyFactory.cs
//  Implementation of the Class ProxyFactory
//  Created on:  08/03/2015
//  Author: Diego Fernando Alvarez Andrade Cel: 3103121656
///////////////////////////////////////////////////////////

namespace TextAnalysisFormsClient.Comunication.Factory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ProxyFactory
    {
        public Proxy CreateProxy(string newProxyType)
        {
            Proxy proxy = null;
            switch (newProxyType)
            {
                case "REST": proxy = new TextAnalysisFormsClient.Comunication.Rest.ProxyRest();
                    break;
                case "WCF": proxy = new TextAnalysisFormsClient.Comunication.WCF.ProxyWCF();
                    break;
                case "WS": proxy = new TextAnalysisFormsClient.Comunication.WS.ProxyWS(); 
                    break;
                default: proxy = new TextAnalysisFormsClient.Comunication.Rest.ProxyRest();
                    break;
            }
            return proxy;
        }
    }
}
