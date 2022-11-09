# IO.Swagger.Api.PrediccionMaritimaApi

All URIs are relative to *https://opendata.aemet.es/opendata*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PrediccinMartimaCostera_**](PrediccionMaritimaApi.md#prediccinmartimacostera_) | **GET** /api/prediccion/maritima/costera/costa/{costa} | Predicción marítima costera.
[**PrediccinMartimaDeAltaMar_**](PrediccionMaritimaApi.md#prediccinmartimadealtamar_) | **GET** /api/prediccion/maritima/altamar/area/{area} | Predicción marítima de alta mar.


<a name="prediccinmartimacostera_"></a>
# **PrediccinMartimaCostera_**
> Model200 PrediccinMartimaCostera_ (string costa)

Predicción marítima costera.

Predicción para un periodo de 24 horas de las condiciones meteorológicas para la zona costera pasada por parámetro.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinMartimaCostera_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionMaritimaApi();
            var costa = costa_example;  // string |  | Código | Área Costera | |- -- -- -- -- -|- -- -- -- -- -| | 42 | Costa de Andalucía Occidental y Ceuta   | | 47  | Costa de Andalucía Oriental y Melilla   | | 41  | Costa de Asturias, Cantabria y País Vasco  | | 45  | Costa de Cataluña   | | 40  | Costa de Galicia   | | 44  | Costa de Illes Balears   | | 43  | Costa de las Islas Canarias  | | 46  | Costa de Valencia y Murcia

            try
            {
                // Predicción marítima costera.
                Model200 result = apiInstance.PrediccinMartimaCostera_(costa);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionMaritimaApi.PrediccinMartimaCostera_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **costa** | **string**|  | Código | Área Costera | |- -- -- -- -- -|- -- -- -- -- -| | 42 | Costa de Andalucía Occidental y Ceuta   | | 47  | Costa de Andalucía Oriental y Melilla   | | 41  | Costa de Asturias, Cantabria y País Vasco  | | 45  | Costa de Cataluña   | | 40  | Costa de Galicia   | | 44  | Costa de Illes Balears   | | 43  | Costa de las Islas Canarias  | | 46  | Costa de Valencia y Murcia | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prediccinmartimadealtamar_"></a>
# **PrediccinMartimaDeAltaMar_**
> Model200 PrediccinMartimaDeAltaMar_ (string area)

Predicción marítima de alta mar.

Predicción para un periodo de 24 horas de las condiciones meteorológicas para el área marítima pasada por parámetro.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinMartimaDeAltaMar_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionMaritimaApi();
            var area = area_example;  // string |  | Código | Área de Alta Mar | |- -- -- -- -- -|- -- -- -- -- -| | 0 | Océano Atlántico al sur de 35º N   | | 1  | Océano Atlántico al norte de 30º N   | | 2  | Mar Mediterráneo

            try
            {
                // Predicción marítima de alta mar.
                Model200 result = apiInstance.PrediccinMartimaDeAltaMar_(area);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionMaritimaApi.PrediccinMartimaDeAltaMar_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **area** | **string**|  | Código | Área de Alta Mar | |- -- -- -- -- -|- -- -- -- -- -| | 0 | Océano Atlántico al sur de 35º N   | | 1  | Océano Atlántico al norte de 30º N   | | 2  | Mar Mediterráneo | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

