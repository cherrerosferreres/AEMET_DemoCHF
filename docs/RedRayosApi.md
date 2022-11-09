# IO.Swagger.Api.RedRayosApi

All URIs are relative to *https://opendata.aemet.es/opendata*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MapaConLosRayosRegistradosEnPeriodoStandardLtimoElaborado_**](RedRayosApi.md#mapaconlosrayosregistradosenperiodostandardltimoelaborado_) | **GET** /api/red/rayos/mapa | Mapa con los rayos registrados en periodo standard. Último elaborado.


<a name="mapaconlosrayosregistradosenperiodostandardltimoelaborado_"></a>
# **MapaConLosRayosRegistradosEnPeriodoStandardLtimoElaborado_**
> Model200 MapaConLosRayosRegistradosEnPeriodoStandardLtimoElaborado_ ()

Mapa con los rayos registrados en periodo standard. Último elaborado.

Imagen de las descargas caídas en el territorio nacional durante un período de 12 horas.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MapaConLosRayosRegistradosEnPeriodoStandardLtimoElaborado_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RedRayosApi();

            try
            {
                // Mapa con los rayos registrados en periodo standard. Último elaborado.
                Model200 result = apiInstance.MapaConLosRayosRegistradosEnPeriodoStandardLtimoElaborado_();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RedRayosApi.MapaConLosRayosRegistradosEnPeriodoStandardLtimoElaborado_: " + e.Message );
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

