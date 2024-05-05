# criativei_server.Api.UsersApi

All URIs are relative to *http://localhost:8081/criativei/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**NewUsers**](UsersApi.md#newusers) | **POST** /users | Users |

<a id="newusers"></a>
# **NewUsers**
> List&lt;UserModel&gt; NewUsers (List<UserRequest> userRequest)

Users

Insert new users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using criativei_server.Api;
using criativei_server.Client;
using criativei_server.Model;

namespace Example
{
    public class NewUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8081/criativei/v1";
            var apiInstance = new UsersApi(config);
            var userRequest = new List<UserRequest>(); // List<UserRequest> | User data

            try
            {
                // Users
                List<UserModel> result = apiInstance.NewUsers(userRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.NewUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Users
    ApiResponse<List<UserModel>> response = apiInstance.NewUsersWithHttpInfo(userRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.NewUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userRequest** | [**List&lt;UserRequest&gt;**](UserRequest.md) | User data |  |

### Return type

[**List&lt;UserModel&gt;**](UserModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | User data |  -  |
| **207** | **Multiple Status**  Multiple status can indicate existing errors in the list, if the operation is successful, the status is not returned on the object, but the object&#39;s data.  |  -  |
| **400** | **Client Error**  |  -  |
| **417** | **Expectation Failed**  Exception failed indicates an error in all operations.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

