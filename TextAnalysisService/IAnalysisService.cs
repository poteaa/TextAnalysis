///////////////////////////////////////////////////////////
//  IAnalysisService.cs
//  Implementation of the Interface IAnalysisService
//  Created on:  08/03/2015
//  Author: Diego Fernando Alvarez Andrade Cel: 3103121656
///////////////////////////////////////////////////////////

namespace TextAnalysisService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.Text;
    using TextAnalysisModel;

    /// <summary>
    /// Contract for service AnalysisService
    /// </summary>
    [ServiceContract]
    public interface IAnalysisService
    {
        [OperationContract]
        [WebGet(UriTemplate = "data/{text}", ResponseFormat = WebMessageFormat.Json)]
        string GetData(string text);

        [OperationContract]
        [WebInvoke(UriTemplate = "data/Add", ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        void PostData(Client client);
    }
}
