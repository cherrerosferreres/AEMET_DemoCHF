# IO.Swagger.Api.RedRadaresApi

All URIs are relative to *https://opendata.aemet.es/opendata*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ImagenComposicinNacionalRadaresTiempoActualEstndar_**](RedRadaresApi.md#imagencomposicinnacionalradarestiempoactualestndar_) | **GET** /api/red/radar/nacional | Imagen composición nacional radares. Tiempo actual estándar.
[**RadarRegional**](RedRadaresApi.md#radarregional) | **GET** /api/red/radar/regional/{radar} | Imagen gráfica radar regional. Tiempo actual estándar.


<a name="imagencomposicinnacionalradarestiempoactualestndar_"></a>
# **ImagenComposicinNacionalRadaresTiempoActualEstndar_**
> Model200 ImagenComposicinNacionalRadaresTiempoActualEstndar_ ()

Imagen composición nacional radares. Tiempo actual estándar.

Imagen composición nacional radares. Tiempo actual estándar. Periodicidad: 30 minutos.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImagenComposicinNacionalRadaresTiempoActualEstndar_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RedRadaresApi();

            try
            {
                // Imagen composición nacional radares. Tiempo actual estándar.
                Model200 result = apiInstance.ImagenComposicinNacionalRadaresTiempoActualEstndar_();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RedRadaresApi.ImagenComposicinNacionalRadaresTiempoActualEstndar_: " + e.Message );
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

<a name="radarregional"></a>
# **RadarRegional**
> Model200 RadarRegional (string radar)

Imagen gráfica radar regional. Tiempo actual estándar.

Imagen del radar regional de la región pasada por parámetro. Tiempo actual estándar. Periodicidad: 10 minutos.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RadarRegionalExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RedRadaresApi();
            var radar = radar_example;  // string |  | Código | Radar | |- -- -- -- -- -|- -- -- -- -- -| | am  | Almería   | | sa  | Asturias   | | pm  | Illes Balears   | | ba  | Barcelona  | | cc  | Cáceres   | | co  | A Coruña   | | ma  | Madrid   | | ml  | Málaga   | | mu  | Murcia   | | vd  | Palencia   | | ca  | Las Palmas   | | se  | Sevilla   | | va  | Valencia   | | ss  | Vizcaya   | | za  | Zaragoza   

            try
            {
                // Imagen gráfica radar regional. Tiempo actual estándar.
                Model200 result = apiInstance.RadarRegional(radar);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RedRadaresApi.RadarRegional: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **radar** | **string**|  | Código | Radar | |- -- -- -- -- -|- -- -- -- -- -| | am  | Almería   | | sa  | Asturias   | | pm  | Illes Balears   | | ba  | Barcelona  | | cc  | Cáceres   | | co  | A Coruña   | | ma  | Madrid   | | ml  | Málaga   | | mu  | Murcia   | | vd  | Palencia   | | ca  | Las Palmas   | | se  | Sevilla   | | va  | Valencia   | | ss  | Vizcaya   | | za  | Zaragoza    | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

