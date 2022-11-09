# IO.Swagger.Api.ObservacionConvencionalApi

All URIs are relative to *https://opendata.aemet.es/opendata*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DatosDeObservacinTiempoActual1**](ObservacionConvencionalApi.md#datosdeobservacintiempoactual1) | **GET** /api/observacion/convencional/datos/estacion/{idema} | Datos de observación. Tiempo actual.
[**DatosDeObservacinTiempoActual_**](ObservacionConvencionalApi.md#datosdeobservacintiempoactual_) | **GET** /api/observacion/convencional/todas | Datos de observación. Tiempo actual.
[**MensajesDeObservacinLtimoElaborado_**](ObservacionConvencionalApi.md#mensajesdeobservacinltimoelaborado_) | **GET** /api/observacion/convencional/mensajes/tipomensaje/{tipomensaje} | Mensajes de observación. Último elaborado.


<a name="datosdeobservacintiempoactual1"></a>
# **DatosDeObservacinTiempoActual1**
> Model200 DatosDeObservacinTiempoActual1 (string idema)

Datos de observación. Tiempo actual.

Datos de observación horarios de las últimas 24 horas de la estación meterológica que se pasa como parámetro (idema). Frecuencia de actualización: continuamente.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DatosDeObservacinTiempoActual1Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ObservacionConvencionalApi();
            var idema = idema_example;  // string | Índicativo climatológico de la EMA

            try
            {
                // Datos de observación. Tiempo actual.
                Model200 result = apiInstance.DatosDeObservacinTiempoActual1(idema);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObservacionConvencionalApi.DatosDeObservacinTiempoActual1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idema** | **string**| Índicativo climatológico de la EMA | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datosdeobservacintiempoactual_"></a>
# **DatosDeObservacinTiempoActual_**
> Model200 DatosDeObservacinTiempoActual_ ()

Datos de observación. Tiempo actual.

Datos de observación horarios de las últimas 24 horas todas las estaciones meteorológicas de las que se han recibido datos en ese período. Frecuencia de actualización: continuamente.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DatosDeObservacinTiempoActual_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ObservacionConvencionalApi();

            try
            {
                // Datos de observación. Tiempo actual.
                Model200 result = apiInstance.DatosDeObservacinTiempoActual_();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObservacionConvencionalApi.DatosDeObservacinTiempoActual_: " + e.Message );
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

<a name="mensajesdeobservacinltimoelaborado_"></a>
# **MensajesDeObservacinLtimoElaborado_**
> Model200 MensajesDeObservacinLtimoElaborado_ (string tipomensaje)

Mensajes de observación. Último elaborado.

Últimos mensajes de observación. Para los SYNOP y TEMP devuelve los mensajes de las últimas 24 horas y para los CLIMAT de los 40 últimos dias. Se pasa como parámetro el tipo de mensaje que se desea (tipomensaje). El resultado de la petición es un fichero en formato tar.gz, que contiene los boletines en formato json y bufr.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MensajesDeObservacinLtimoElaborado_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ObservacionConvencionalApi();
            var tipomensaje = tipomensaje_example;  // string |  | Código | Tipo de Mensaje | |- -- -- -- -- -|- -- -- -- -- -| | climat  | CLIMAT   | | synop  | SYNOP   | | temp  | TEMP  

            try
            {
                // Mensajes de observación. Último elaborado.
                Model200 result = apiInstance.MensajesDeObservacinLtimoElaborado_(tipomensaje);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObservacionConvencionalApi.MensajesDeObservacinLtimoElaborado_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tipomensaje** | **string**|  | Código | Tipo de Mensaje | |- -- -- -- -- -|- -- -- -- -- -| | climat  | CLIMAT   | | synop  | SYNOP   | | temp  | TEMP   | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

