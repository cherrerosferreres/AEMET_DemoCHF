# IO.Swagger.Api.RedesEspecialesApi

All URIs are relative to *https://opendata.aemet.es/opendata*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ContenidoTotalDeOzonoTiempoActual_**](RedesEspecialesApi.md#contenidototaldeozonotiempoactual_) | **GET** /api/red/especial/ozono | Contenido total de ozono. Tiempo actual.
[**DatosDeContaminacinDeFondoTiempoActual_**](RedesEspecialesApi.md#datosdecontaminacindefondotiempoactual_) | **GET** /api/red/especial/contaminacionfondo/estacion/{nombre_estacion} | Datos de contaminación de fondo. Tiempo actual.
[**DatosDeRadiacinGlobalDirectaODifusaTiempoActual_**](RedesEspecialesApi.md#datosderadiacinglobaldirectaodifusatiempoactual_) | **GET** /api/red/especial/radiacion | Datos de radiación global, directa o difusa. Tiempo actual.
[**PerfilesVerticalesDeOzonoTiempoActual_**](RedesEspecialesApi.md#perfilesverticalesdeozonotiempoactual_) | **GET** /api/red/especial/perfilozono/estacion/{estacion} | Perfiles verticales de ozono. Tiempo actual.


<a name="contenidototaldeozonotiempoactual_"></a>
# **ContenidoTotalDeOzonoTiempoActual_**
> Model200 ContenidoTotalDeOzonoTiempoActual_ ()

Contenido total de ozono. Tiempo actual.

Dato medio diario de contenido total de ozono. Cada 24 h (actualmente, en fines de semana, festivos y vacaciones no se genera por la falta de personal en el Centro Radiométrico Nacional).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContenidoTotalDeOzonoTiempoActual_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RedesEspecialesApi();

            try
            {
                // Contenido total de ozono. Tiempo actual.
                Model200 result = apiInstance.ContenidoTotalDeOzonoTiempoActual_();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RedesEspecialesApi.ContenidoTotalDeOzonoTiempoActual_: " + e.Message );
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

<a name="datosdecontaminacindefondotiempoactual_"></a>
# **DatosDeContaminacinDeFondoTiempoActual_**
> Model200 DatosDeContaminacinDeFondoTiempoActual_ (string nombreEstacion)

Datos de contaminación de fondo. Tiempo actual.

Ficheros diarios con datos diezminutales de la estación de la red de contaminación de fondo EMEP/VAG/CAMP pasada por parámetro, de temperatura, presión, humedad, viento (dirección y velocidad), radiación global, precipitación y 4 componentes químicos: O3,SO2,NO,NO2 y PM10. Los datos se encuentran en formato FINN (propio del Ministerio de Medio Ambiente). Periodicidad: cada hora.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DatosDeContaminacinDeFondoTiempoActual_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RedesEspecialesApi();
            var nombreEstacion = nombreEstacion_example;  // string |  | Código | Estación de la Red EMEP | |- -- -- -- -- -|- -- -- -- -- -| | 11  | Barcarrota (Badajoz)   | | 10  | Cabo de Creus (Girona)   | | 09  | Campisábalos (Guadalajara)   | | 17  | Doñana (Huelva)  | | 14  | Els Torms (Lleida)   | | 06  | Mahón (Illes Balears)   | | 08  | Niembro-Llanes (Asturias)   | | 05  | Noia (A Coruña)   | | 16  | O Saviñao (Lugo)   | | 13  | Peñausende (Zamora)   | | 01  | San Pablo de los Montes (Toledo)   | | 07  | Víznar (Granada)   | | 12  | Zarra (Valencia) 

            try
            {
                // Datos de contaminación de fondo. Tiempo actual.
                Model200 result = apiInstance.DatosDeContaminacinDeFondoTiempoActual_(nombreEstacion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RedesEspecialesApi.DatosDeContaminacinDeFondoTiempoActual_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nombreEstacion** | **string**|  | Código | Estación de la Red EMEP | |- -- -- -- -- -|- -- -- -- -- -| | 11  | Barcarrota (Badajoz)   | | 10  | Cabo de Creus (Girona)   | | 09  | Campisábalos (Guadalajara)   | | 17  | Doñana (Huelva)  | | 14  | Els Torms (Lleida)   | | 06  | Mahón (Illes Balears)   | | 08  | Niembro-Llanes (Asturias)   | | 05  | Noia (A Coruña)   | | 16  | O Saviñao (Lugo)   | | 13  | Peñausende (Zamora)   | | 01  | San Pablo de los Montes (Toledo)   | | 07  | Víznar (Granada)   | | 12  | Zarra (Valencia)  | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datosderadiacinglobaldirectaodifusatiempoactual_"></a>
# **DatosDeRadiacinGlobalDirectaODifusaTiempoActual_**
> Model200 DatosDeRadiacinGlobalDirectaODifusaTiempoActual_ ()

Datos de radiación global, directa o difusa. Tiempo actual.

Datos horarios (HORA SOLAR VERDADERA) acumulados de radiación  global, directa, difusa e infrarroja, y datos semihorarios  (HORA SOLAR VERDADERA) acumulados de radiación ultravioleta eritemática.Datos diarios acumulados  de radiación global, directa, difusa, ultravioleta eritemática e infrarroja. Periodicidad: Cada 24h (actualmente en fines de semana, festivos y vacaciones, no se genera por la ausencia de personal en el Centro Radiométrico Nacional).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DatosDeRadiacinGlobalDirectaODifusaTiempoActual_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RedesEspecialesApi();

            try
            {
                // Datos de radiación global, directa o difusa. Tiempo actual.
                Model200 result = apiInstance.DatosDeRadiacinGlobalDirectaODifusaTiempoActual_();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RedesEspecialesApi.DatosDeRadiacinGlobalDirectaODifusaTiempoActual_: " + e.Message );
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

<a name="perfilesverticalesdeozonotiempoactual_"></a>
# **PerfilesVerticalesDeOzonoTiempoActual_**
> Model200 PerfilesVerticalesDeOzonoTiempoActual_ (string estacion)

Perfiles verticales de ozono. Tiempo actual.

Perfil Vertical de Ozono de la estación pasada por parámetro. Periodicidad: cada 7 días.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PerfilesVerticalesDeOzonoTiempoActual_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new RedesEspecialesApi();
            var estacion = estacion_example;  // string |  | Código | Estación | |- -- -- -- -- -|- -- -- -- -- -| | canarias  | Izaña   | | peninsula  | Madrid   

            try
            {
                // Perfiles verticales de ozono. Tiempo actual.
                Model200 result = apiInstance.PerfilesVerticalesDeOzonoTiempoActual_(estacion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RedesEspecialesApi.PerfilesVerticalesDeOzonoTiempoActual_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **estacion** | **string**|  | Código | Estación | |- -- -- -- -- -|- -- -- -- -- -| | canarias  | Izaña   | | peninsula  | Madrid    | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

