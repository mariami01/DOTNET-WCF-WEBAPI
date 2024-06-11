using System.ServiceModel;
using System.ServiceModel.Web;

namespace MovieManagementService.Contracts
{
    [ServiceContract]
    public interface IAuthenticationService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "authenticate", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string AuthenticateUser(string username, string password);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "authenticate/xml", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Xml)]
        string AuthenticateUserXml(string username, string password);
    }
}