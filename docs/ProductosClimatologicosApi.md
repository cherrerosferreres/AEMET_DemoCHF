# IO.Swagger.Api.ProductosClimatologicosApi

All URIs are relative to *https://opendata.aemet.es/opendata*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BalanceHdricoNacionalDocumento_**](ProductosClimatologicosApi.md#balancehdriconacionaldocumento_) | **GET** /api/productos/climatologicos/balancehidrico/{anio}/{decena} | Balance hídrico nacional (documento).
[**CapasSHAPEDeEstacionesClimatolgicas_**](ProductosClimatologicosApi.md#capasshapedeestacionesclimatolgicas_) | **GET** /api/productos/climatologicos/capasshape/{tipoestacion} | Capas SHAPE de estaciones climatológicas de AEMET.
[**ResumenMensualClimatolgicoNacionalDocumento_**](ProductosClimatologicosApi.md#resumenmensualclimatolgiconacionaldocumento_) | **GET** /api/productos/climatologicos/resumenclimatologico/nacional/{anio}/{mes} | Resumen mensual climatológico nacional (documento).


<a name="balancehdriconacionaldocumento_"></a>
# **BalanceHdricoNacionalDocumento_**
> Model200 BalanceHdricoNacionalDocumento_ (string anio, string decena)

Balance hídrico nacional (documento).

Se obtiene, para la decema y el año pasados por parámetro, el Boletín Hídrico Nacional que se elabora cada diez días. Se presenta información resumida de forma distribuida para todo el territorio nacional de diferentes variables, en las que se incluye informaciones de la precipitación y la evapotranspiración potencial acumuladas desde el 1 de septiembre.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BalanceHdricoNacionalDocumento_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ProductosClimatologicosApi();
            var anio = anio_example;  // string | Año (AAAA)
            var decena = decena_example;  // string | Decena de 01 (primera decena) a 36 (última decena)

            try
            {
                // Balance hídrico nacional (documento).
                Model200 result = apiInstance.BalanceHdricoNacionalDocumento_(anio, decena);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductosClimatologicosApi.BalanceHdricoNacionalDocumento_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **anio** | **string**| Año (AAAA) | 
 **decena** | **string**| Decena de 01 (primera decena) a 36 (última decena) | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="capasshapedeestacionesclimatolgicas_"></a>
# **CapasSHAPEDeEstacionesClimatolgicas_**
> Model200 CapasSHAPEDeEstacionesClimatolgicas_ (string tipoestacion)

Capas SHAPE de estaciones climatológicas de AEMET.

Capas SHAPE de las distintas estaciones climatológicas de AEMET: automáticas, completas, pluviométricas y termométricas.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CapasSHAPEDeEstacionesClimatolgicas_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ProductosClimatologicosApi();
            var tipoestacion = tipoestacion_example;  // string |  | Código | Tipo de Estación | |- -- -- -- -- -|- -- -- -- -- -| | automaticas  | Estaciones Automáticas   | | completas  | Estaciones Completas   | | pluviometricas  | Estaciones Pluviométricas   | | termometricas  | Estaciones Termométricas   

            try
            {
                // Capas SHAPE de estaciones climatológicas de AEMET.
                Model200 result = apiInstance.CapasSHAPEDeEstacionesClimatolgicas_(tipoestacion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductosClimatologicosApi.CapasSHAPEDeEstacionesClimatolgicas_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tipoestacion** | **string**|  | Código | Tipo de Estación | |- -- -- -- -- -|- -- -- -- -- -| | automaticas  | Estaciones Automáticas   | | completas  | Estaciones Completas   | | pluviometricas  | Estaciones Pluviométricas   | | termometricas  | Estaciones Termométricas    | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resumenmensualclimatolgiconacionaldocumento_"></a>
# **ResumenMensualClimatolgicoNacionalDocumento_**
> Model200 ResumenMensualClimatolgicoNacionalDocumento_ (string anio, string mes)

Resumen mensual climatológico nacional (documento).

Resumen climatológico nacional, para el año y mes pasado por parámetro, sobre el estado del clima y la evolución de las principales variables climáticas, en especial temperatura y precipitación, a nivel mensual, estacional y anual.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ResumenMensualClimatolgicoNacionalDocumento_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ProductosClimatologicosApi();
            var anio = anio_example;  // string | Año (AAAA)
            var mes = mes_example;  // string | Mes (mm)

            try
            {
                // Resumen mensual climatológico nacional (documento).
                Model200 result = apiInstance.ResumenMensualClimatolgicoNacionalDocumento_(anio, mes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductosClimatologicosApi.ResumenMensualClimatolgicoNacionalDocumento_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **anio** | **string**| Año (AAAA) | 
 **mes** | **string**| Mes (mm) | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

