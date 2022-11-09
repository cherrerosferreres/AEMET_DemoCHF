# IO.Swagger.Api.IndicesIncendiosApi

All URIs are relative to *https://opendata.aemet.es/opendata*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MapaDeNivelesDeRiesgoEstimadoMeteorolgicoDeIncendiosForestales_**](IndicesIncendiosApi.md#mapadenivelesderiesgoestimadometeorolgicodeincendiosforestales_) | **GET** /api/incendios/mapasriesgo/estimado/area/{area} | Mapa de niveles de riesgo estimado meteorológico de incendios forestales.
[**MapaDeNivelesDeRiesgoPrevistoMeteorolgicoDeIncendiosForestales_**](IndicesIncendiosApi.md#mapadenivelesderiesgoprevistometeorolgicodeincendiosforestales_) | **GET** /api/incendios/mapasriesgo/previsto/dia/{dia}/area/{area} | Mapa de niveles de riesgo previsto meteorológico de incendios forestales.


<a name="mapadenivelesderiesgoestimadometeorolgicodeincendiosforestales_"></a>
# **MapaDeNivelesDeRiesgoEstimadoMeteorolgicoDeIncendiosForestales_**
> Model200 MapaDeNivelesDeRiesgoEstimadoMeteorolgicoDeIncendiosForestales_ (string area)

Mapa de niveles de riesgo estimado meteorológico de incendios forestales.

Último mapa elaborado de niveles de riesgo estimado meteorológico de incendios forestales para el área pasada por parámetro.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MapaDeNivelesDeRiesgoEstimadoMeteorolgicoDeIncendiosForestales_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new IndicesIncendiosApi();
            var area = area_example;  // string |  | Código | Área | |- -- -- -- -- -|- -- -- -- -- -| | p  | Península   | | b  | Baleares   | | c  | Canarias   

            try
            {
                // Mapa de niveles de riesgo estimado meteorológico de incendios forestales.
                Model200 result = apiInstance.MapaDeNivelesDeRiesgoEstimadoMeteorolgicoDeIncendiosForestales_(area);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndicesIncendiosApi.MapaDeNivelesDeRiesgoEstimadoMeteorolgicoDeIncendiosForestales_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **area** | **string**|  | Código | Área | |- -- -- -- -- -|- -- -- -- -- -| | p  | Península   | | b  | Baleares   | | c  | Canarias    | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mapadenivelesderiesgoprevistometeorolgicodeincendiosforestales_"></a>
# **MapaDeNivelesDeRiesgoPrevistoMeteorolgicoDeIncendiosForestales_**
> Model200 MapaDeNivelesDeRiesgoPrevistoMeteorolgicoDeIncendiosForestales_ (string dia, string area)

Mapa de niveles de riesgo previsto meteorológico de incendios forestales.

Mapa elaborado de niveles de riesgo estimado meteorológico de incendios forestales para el día y el área pasados por parámetro.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MapaDeNivelesDeRiesgoPrevistoMeteorolgicoDeIncendiosForestales_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new IndicesIncendiosApi();
            var dia = dia_example;  // string |  | Código | Día | |- -- -- -- -- -|- -- -- -- -- -| | 1  | Mañana   | | 2  | Pasado Mañana   | | 3  | Dentro de 3 días   
            var area = area_example;  // string |  | Código | Área | |- -- -- -- -- -|- -- -- -- -- -| | p  | Península   | | b  | Baleares   | | c  | Canarias   

            try
            {
                // Mapa de niveles de riesgo previsto meteorológico de incendios forestales.
                Model200 result = apiInstance.MapaDeNivelesDeRiesgoPrevistoMeteorolgicoDeIncendiosForestales_(dia, area);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndicesIncendiosApi.MapaDeNivelesDeRiesgoPrevistoMeteorolgicoDeIncendiosForestales_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dia** | **string**|  | Código | Día | |- -- -- -- -- -|- -- -- -- -- -| | 1  | Mañana   | | 2  | Pasado Mañana   | | 3  | Dentro de 3 días    | 
 **area** | **string**|  | Código | Área | |- -- -- -- -- -|- -- -- -- -- -| | p  | Península   | | b  | Baleares   | | c  | Canarias    | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

