using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using System.Data;
using System.Data.SqlClient;
using DemoWCFforMVC.Models;

namespace DemoWCFforMVC
{

    [ServiceContract]
    public interface IDemoService
    {
        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Wrapped,RequestFormat=WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,UriTemplate="GetData({name})")]
        string GetData(string name);

        [OperationContract]
        [WebGet(BodyStyle=WebMessageBodyStyle.Wrapped,ResponseFormat=WebMessageFormat.Json,UriTemplate="GetDtls")]
        List<Person> GetDtls();
    }
}
