# IO.Swagger.Api.MaestroApi

All URIs are relative to *https://opendata.aemet.es/opendata*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMunicipioUsingGET**](MaestroApi.md#getmunicipiousingget) | **GET** /api/maestro/municipio/{municipio} | getMunicipio
[**GetMunicipiosUsingGET**](MaestroApi.md#getmunicipiosusingget) | **GET** /api/maestro/municipios | getMunicipios


<a name="getmunicipiousingget"></a>
# **GetMunicipioUsingGET**
> Model200 GetMunicipioUsingGET (string municipio)

getMunicipio

Retorna información específica del municipio de España que se le pasa como parámetro.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMunicipioUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new MaestroApi();
            var municipio = municipio_example;  // string | Municipio

            try
            {
                // getMunicipio
                Model200 result = apiInstance.GetMunicipioUsingGET(municipio);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MaestroApi.GetMunicipioUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **municipio** | **string**| Municipio | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmunicipiosusingget"></a>
# **GetMunicipiosUsingGET**
> Model200 GetMunicipiosUsingGET ()

getMunicipios

Retorna todos los municipios de España. Este servicio es útil para obtener información para utilizar otros elementos de AEMET OpenData, como por ejemplo, la predicción de municipios para 7 días o por  horas ya que nos retorna el id del municipio que necesitamos.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMunicipiosUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new MaestroApi();

            try
            {
                // getMunicipios
                Model200 result = apiInstance.GetMunicipiosUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MaestroApi.GetMunicipiosUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

