using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using MarketService;

namespace MarketService {
    [ServiceContract]
    public interface IMarketService {
        [OperationContract]
        [WebGet(UriTemplate = "/GetProducts", ResponseFormat = WebMessageFormat.Json)]
        List<ProductDTO> GetProducts();

        [OperationContract]
        [WebInvoke(UriTemplate = "/CreateProduct", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Response CreateProduct(ProductDTO product);

        [OperationContract]
        [WebInvoke(UriTemplate = "/UpdateProduct", Method = "PUT", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Response UpdateProduct(ProductDTO product);

        [OperationContract]
        [WebInvoke(UriTemplate = "/DeleteProduct", Method = "DELETE", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Response DeleteProduct(string id);
    }
}
