# IO.Swagger.Api.ValoresClimatologicosApi

All URIs are relative to *https://opendata.aemet.es/opendata*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ClimatologasDiarias1**](ValoresClimatologicosApi.md#climatologasdiarias1) | **GET** /api/valores/climatologicos/diarios/datos/fechaini/{fechaIniStr}/fechafin/{fechaFinStr}/todasestaciones | Climatologías diarias.
[**ClimatologasDiarias_**](ValoresClimatologicosApi.md#climatologasdiarias_) | **GET** /api/valores/climatologicos/diarios/datos/fechaini/{fechaIniStr}/fechafin/{fechaFinStr}/estacion/{idema} | Climatologías diarias.
[**ClimatologasMensualesAnuales_**](ValoresClimatologicosApi.md#climatologasmensualesanuales_) | **GET** /api/valores/climatologicos/mensualesanuales/datos/anioini/{anioIniStr}/aniofin/{anioFinStr}/estacion/{idema} | Climatologías mensuales anuales.
[**ClimatologasNormales19812010_**](ValoresClimatologicosApi.md#climatologasnormales19812010_) | **GET** /api/valores/climatologicos/normales/estacion/{idema} | Climatologías normales (1981-2010).
[**EstacionesPorIndicativo_**](ValoresClimatologicosApi.md#estacionesporindicativo_) | **GET** /api/valores/climatologicos/inventarioestaciones/estaciones/{estaciones} | Estaciones por indicativo.
[**InventarioDeEstacionesValoresClimatolgicos_**](ValoresClimatologicosApi.md#inventariodeestacionesvaloresclimatolgicos_) | **GET** /api/valores/climatologicos/inventarioestaciones/todasestaciones | Inventario de estaciones (valores climatológicos).
[**ValoresExtremos_**](ValoresClimatologicosApi.md#valoresextremos_) | **GET** /api/valores/climatologicos/valoresextremos/parametro/{parametro}/estacion/{idema} | Valores extremos.


<a name="climatologasdiarias1"></a>
# **ClimatologasDiarias1**
> Model200 ClimatologasDiarias1 (string fechaIniStr, string fechaFinStr)

Climatologías diarias.

Valores climatológicos de todas las estaciones para el rango de fechas seleccionado. Periodicidad: 1 vez al día.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ClimatologasDiarias1Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ValoresClimatologicosApi();
            var fechaIniStr = fechaIniStr_example;  // string | Fecha Inicial (AAAA-MM-DDTHH:MM:SSUTC)
            var fechaFinStr = fechaFinStr_example;  // string | Fecha Final (AAAA-MM-DDTHH:MM:SSUTC)

            try
            {
                // Climatologías diarias.
                Model200 result = apiInstance.ClimatologasDiarias1(fechaIniStr, fechaFinStr);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValoresClimatologicosApi.ClimatologasDiarias1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fechaIniStr** | **string**| Fecha Inicial (AAAA-MM-DDTHH:MM:SSUTC) | 
 **fechaFinStr** | **string**| Fecha Final (AAAA-MM-DDTHH:MM:SSUTC) | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="climatologasdiarias_"></a>
# **ClimatologasDiarias_**
> Model200 ClimatologasDiarias_ (string fechaIniStr, string fechaFinStr, string idema)

Climatologías diarias.

Valores climatológicos para el rango de fechas y la estación seleccionada. Periodicidad: 1 vez al día.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ClimatologasDiarias_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ValoresClimatologicosApi();
            var fechaIniStr = fechaIniStr_example;  // string | Fecha Inicial (AAAA-MM-DDTHH:MM:SSUTC)
            var fechaFinStr = fechaFinStr_example;  // string | Fecha Final (AAAA-MM-DDTHH:MM:SSUTC)
            var idema = idema_example;  // string | Indicativo climatológico de la EMA. Puede introducir varios indicativos separados por comas (,)

            try
            {
                // Climatologías diarias.
                Model200 result = apiInstance.ClimatologasDiarias_(fechaIniStr, fechaFinStr, idema);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValoresClimatologicosApi.ClimatologasDiarias_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fechaIniStr** | **string**| Fecha Inicial (AAAA-MM-DDTHH:MM:SSUTC) | 
 **fechaFinStr** | **string**| Fecha Final (AAAA-MM-DDTHH:MM:SSUTC) | 
 **idema** | **string**| Indicativo climatológico de la EMA. Puede introducir varios indicativos separados por comas (,) | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="climatologasmensualesanuales_"></a>
# **ClimatologasMensualesAnuales_**
> Model200 ClimatologasMensualesAnuales_ (string anioIniStr, string anioFinStr, string idema)

Climatologías mensuales anuales.

Valores medios mensuales y anuales de los datos climatológicos para la estación y el periodo de años pasados por parámetro. Periodicidad: 1 vez al día.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ClimatologasMensualesAnuales_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ValoresClimatologicosApi();
            var anioIniStr = anioIniStr_example;  // string | Año Inicial (AAAA)
            var anioFinStr = anioFinStr_example;  // string | Año Final (AAAA)
            var idema = idema_example;  // string | Indicativo climatológico de la EMA

            try
            {
                // Climatologías mensuales anuales.
                Model200 result = apiInstance.ClimatologasMensualesAnuales_(anioIniStr, anioFinStr, idema);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValoresClimatologicosApi.ClimatologasMensualesAnuales_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **anioIniStr** | **string**| Año Inicial (AAAA) | 
 **anioFinStr** | **string**| Año Final (AAAA) | 
 **idema** | **string**| Indicativo climatológico de la EMA | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="climatologasnormales19812010_"></a>
# **ClimatologasNormales19812010_**
> Model200 ClimatologasNormales19812010_ (string idema)

Climatologías normales (1981-2010).

Valores climatológicos normales (periodo 1981-2010) para la estación pasada por parámetro. Periodicidad: 1 vez al día.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ClimatologasNormales19812010_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ValoresClimatologicosApi();
            var idema = idema_example;  // string | Indicativo climatológico de la EMA

            try
            {
                // Climatologías normales (1981-2010).
                Model200 result = apiInstance.ClimatologasNormales19812010_(idema);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValoresClimatologicosApi.ClimatologasNormales19812010_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idema** | **string**| Indicativo climatológico de la EMA | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="estacionesporindicativo_"></a>
# **EstacionesPorIndicativo_**
> Model200 EstacionesPorIndicativo_ (string estaciones)

Estaciones por indicativo.

Características de la estación climatológica pasada por parámetro.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EstacionesPorIndicativo_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ValoresClimatologicosApi();
            var estaciones = estaciones_example;  // string | Listado de indicativos climatológicos (id1,id2,id3,...,idn)

            try
            {
                // Estaciones por indicativo.
                Model200 result = apiInstance.EstacionesPorIndicativo_(estaciones);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValoresClimatologicosApi.EstacionesPorIndicativo_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **estaciones** | **string**| Listado de indicativos climatológicos (id1,id2,id3,...,idn) | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventariodeestacionesvaloresclimatolgicos_"></a>
# **InventarioDeEstacionesValoresClimatolgicos_**
> Model200 InventarioDeEstacionesValoresClimatolgicos_ ()

Inventario de estaciones (valores climatológicos).

Inventario con las características de todas las estaciones climatológicas. Periodicidad: 1 vez al día.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InventarioDeEstacionesValoresClimatolgicos_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ValoresClimatologicosApi();

            try
            {
                // Inventario de estaciones (valores climatológicos).
                Model200 result = apiInstance.InventarioDeEstacionesValoresClimatolgicos_();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValoresClimatologicosApi.InventarioDeEstacionesValoresClimatolgicos_: " + e.Message );
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

<a name="valoresextremos_"></a>
# **ValoresExtremos_**
> Model200 ValoresExtremos_ (string parametro, string idema)

Valores extremos.

Valores extremos para la estación y la variable (precipitación, temperatura y viento) pasadas por parámetro. Periodicidad: 1 vez al día.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ValoresExtremos_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ValoresClimatologicosApi();
            var parametro = parametro_example;  // string |  | Código | Parámetro Meteorológico | |- -- -- -- -- -|- -- -- -- -- -| | P  | Precipitación   | | T  | Temperatura   | | V  | Viento 
            var idema = idema_example;  // string | Indicativo climatológico de la EMA

            try
            {
                // Valores extremos.
                Model200 result = apiInstance.ValoresExtremos_(parametro, idema);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValoresClimatologicosApi.ValoresExtremos_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parametro** | **string**|  | Código | Parámetro Meteorológico | |- -- -- -- -- -|- -- -- -- -- -| | P  | Precipitación   | | T  | Temperatura   | | V  | Viento  | 
 **idema** | **string**| Indicativo climatológico de la EMA | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

