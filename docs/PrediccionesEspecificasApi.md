# IO.Swagger.Api.PrediccionesEspecificasApi

All URIs are relative to *https://opendata.aemet.es/opendata*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InformacionNivologica_**](PrediccionesEspecificasApi.md#informacionnivologica_) | **GET** /api/prediccion/especifica/nivologica/{area} | Información nivológica.
[**PrediccinDeMontaaTiempoActual_**](PrediccionesEspecificasApi.md#prediccindemontaatiempoactual_) | **GET** /api/prediccion/especifica/montaña/pasada/area/{area}/dia/{dia} | Predicción de montaña. Tiempo actual.
[**PrediccinDeMontaaTiempoPasado_**](PrediccionesEspecificasApi.md#prediccindemontaatiempopasado_) | **GET** /api/prediccion/especifica/montaña/pasada/area/{area} | Predicción de montaña. Tiempo pasado.
[**PrediccinDeRadiacinUltravioletaUVI_**](PrediccionesEspecificasApi.md#prediccinderadiacinultravioletauvi_) | **GET** /api/prediccion/especifica/uvi/{dia} | Predicción de radiación ultravioleta (UVI).
[**PrediccinParaLasPlayasTiempoActual_**](PrediccionesEspecificasApi.md#prediccinparalasplayastiempoactual_) | **GET** /api/prediccion/especifica/playa/{playa} | Predicción para las playas. Tiempo actual.
[**PrediccinPorMunicipiosDiariaTiempoActual_**](PrediccionesEspecificasApi.md#prediccinpormunicipiosdiariatiempoactual_) | **GET** /api/prediccion/especifica/municipio/diaria/{municipio} | Predicción por municipios diaria. Tiempo actual.
[**PrediccinPorMunicipiosHorariaTiempoActual_**](PrediccionesEspecificasApi.md#prediccinpormunicipioshorariatiempoactual_) | **GET** /api/prediccion/especifica/municipio/horaria/{municipio} | Predicción por municipios horaria. Tiempo actual.


<a name="informacionnivologica_"></a>
# **InformacionNivologica_**
> Model200 InformacionNivologica_ (string area)

Información nivológica.

Información nivológica para la zona montañosa que se pasa como parámetro (area).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InformacionNivologica_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesEspecificasApi();
            var area = area_example;  // string |  | Código de  Área Montañosa |  Área Montañosa | |- -- -- -- -- -|- -- -- -- -- -| | 0 | Pirineo Catalán  | | 1  | Pirineo Navarro y Aragonés

            try
            {
                // Información nivológica.
                Model200 result = apiInstance.InformacionNivologica_(area);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesEspecificasApi.InformacionNivologica_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **area** | **string**|  | Código de  Área Montañosa |  Área Montañosa | |- -- -- -- -- -|- -- -- -- -- -| | 0 | Pirineo Catalán  | | 1  | Pirineo Navarro y Aragonés | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prediccindemontaatiempoactual_"></a>
# **PrediccinDeMontaaTiempoActual_**
> Model200 PrediccinDeMontaaTiempoActual_ (string area, string dia)

Predicción de montaña. Tiempo actual.

Predicción meteorológica para la zona montañosa que se pasa como parámetro (area) con validez para el día (día).  Periodicidad de actualización: continuamente.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinDeMontaaTiempoActual_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesEspecificasApi();
            var area = area_example;  // string |  | Código de Área Montañosa | Área Montañosa | |- -- -- -- -- -|- -- -- -- -- -| | peu1 | Picos de Europa   | | nav1  | Pirineo Navarro   | | arn1  | Pirineo Aragonés  | | cat1  | Pirineo Catalán   | | rio1  | Ibérica Riojana   | | arn2  | Ibérica Aragonesa   | | mad2  | Sierras de Guadarrama y Somosierra  | | gre1  | Sierra de Gredos   | | nev1  | Sierra Nevada
            var dia = dia_example;  // string |  | Código de día | Día | |- -- -- -- -- -|- -- -- -- -- -| | 0 | día actual  | | 1  | d+1 (mañana)   | | 2  | d+2 (pasado mañana)  | | 3  | d+3 (siguente a pasado mañana)

            try
            {
                // Predicción de montaña. Tiempo actual.
                Model200 result = apiInstance.PrediccinDeMontaaTiempoActual_(area, dia);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesEspecificasApi.PrediccinDeMontaaTiempoActual_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **area** | **string**|  | Código de Área Montañosa | Área Montañosa | |- -- -- -- -- -|- -- -- -- -- -| | peu1 | Picos de Europa   | | nav1  | Pirineo Navarro   | | arn1  | Pirineo Aragonés  | | cat1  | Pirineo Catalán   | | rio1  | Ibérica Riojana   | | arn2  | Ibérica Aragonesa   | | mad2  | Sierras de Guadarrama y Somosierra  | | gre1  | Sierra de Gredos   | | nev1  | Sierra Nevada | 
 **dia** | **string**|  | Código de día | Día | |- -- -- -- -- -|- -- -- -- -- -| | 0 | día actual  | | 1  | d+1 (mañana)   | | 2  | d+2 (pasado mañana)  | | 3  | d+3 (siguente a pasado mañana) | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prediccindemontaatiempopasado_"></a>
# **PrediccinDeMontaaTiempoPasado_**
> Model200 PrediccinDeMontaaTiempoPasado_ (string area)

Predicción de montaña. Tiempo pasado.

Breve resumen con lo más significativo de las condiciones meteorológicas registradas en la zona de montaña que se pasa como parámetro (area) en las últimas 24-36 horas.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinDeMontaaTiempoPasado_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesEspecificasApi();
            var area = area_example;  // string |  | Código de Área Montañosa | Área Montañosa | |- -- -- -- -- -|- -- -- -- -- -| | peu1 | Picos de Europa   | | nav1  | Pirineo Navarro   | | arn1  | Pirineo Aragonés  | | cat1  | Pirineo Catalán   | | rio1  | Ibérica Riojana   | | arn2  | Ibérica Aragonesa   | | mad2  | Sierras de Guadarrama y Somosierra  | | gre1  | Sierra de Gredos   | | nev1  | Sierra Nevada

            try
            {
                // Predicción de montaña. Tiempo pasado.
                Model200 result = apiInstance.PrediccinDeMontaaTiempoPasado_(area);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesEspecificasApi.PrediccinDeMontaaTiempoPasado_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **area** | **string**|  | Código de Área Montañosa | Área Montañosa | |- -- -- -- -- -|- -- -- -- -- -| | peu1 | Picos de Europa   | | nav1  | Pirineo Navarro   | | arn1  | Pirineo Aragonés  | | cat1  | Pirineo Catalán   | | rio1  | Ibérica Riojana   | | arn2  | Ibérica Aragonesa   | | mad2  | Sierras de Guadarrama y Somosierra  | | gre1  | Sierra de Gredos   | | nev1  | Sierra Nevada | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prediccinderadiacinultravioletauvi_"></a>
# **PrediccinDeRadiacinUltravioletaUVI_**
> Model200 PrediccinDeRadiacinUltravioletaUVI_ (string dia)

Predicción de radiación ultravioleta (UVI).

 Predicción de Índice de radiación UV máximo en condiciones de cielo despejado para el día seleccionado.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinDeRadiacinUltravioletaUVI_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesEspecificasApi();
            var dia = dia_example;  // string |  | Código de día | Día | |- -- -- -- -- -|- -- -- -- -- -| | 0 | día actual  | | 1  | d+1 (mañana)   | | 2  | d+2 (pasado mañana)  | | 3  | d+3 (dentro de 3 días) | | 4  | d+4 (dentro de 4 días)

            try
            {
                // Predicción de radiación ultravioleta (UVI).
                Model200 result = apiInstance.PrediccinDeRadiacinUltravioletaUVI_(dia);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesEspecificasApi.PrediccinDeRadiacinUltravioletaUVI_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dia** | **string**|  | Código de día | Día | |- -- -- -- -- -|- -- -- -- -- -| | 0 | día actual  | | 1  | d+1 (mañana)   | | 2  | d+2 (pasado mañana)  | | 3  | d+3 (dentro de 3 días) | | 4  | d+4 (dentro de 4 días) | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prediccinparalasplayastiempoactual_"></a>
# **PrediccinParaLasPlayasTiempoActual_**
> Model200 PrediccinParaLasPlayasTiempoActual_ (string playa)

Predicción para las playas. Tiempo actual.

La predicción diaria de la playa que se pasa como parámetro. Establece el estado de nubosidad para unas horas determinadas, las 11 y las 17 hora oficial. Se analiza también si se espera precipitación en el entorno de esas horas, entre las 08 y las 14 horas y entre las 14 y 20 horas.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinParaLasPlayasTiempoActual_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesEspecificasApi();
            var playa = playa_example;  // string | Código de playa   http://www.aemet.es/documentos/es/eltiempo/prediccion/playas/Playas_codigos.csv

            try
            {
                // Predicción para las playas. Tiempo actual.
                Model200 result = apiInstance.PrediccinParaLasPlayasTiempoActual_(playa);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesEspecificasApi.PrediccinParaLasPlayasTiempoActual_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **playa** | **string**| Código de playa   http://www.aemet.es/documentos/es/eltiempo/prediccion/playas/Playas_codigos.csv | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prediccinpormunicipiosdiariatiempoactual_"></a>
# **PrediccinPorMunicipiosDiariaTiempoActual_**
> Model200 PrediccinPorMunicipiosDiariaTiempoActual_ (string municipio)

Predicción por municipios diaria. Tiempo actual.

Predicción para el municipio que se pasa como parámetro (municipio). Periodicidad de actualización: continuamente.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinPorMunicipiosDiariaTiempoActual_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesEspecificasApi();
            var municipio = municipio_example;  // string | Código de municipio   http://www.ine.es/daco/daco42/codmun/codmunmapa.htm

            try
            {
                // Predicción por municipios diaria. Tiempo actual.
                Model200 result = apiInstance.PrediccinPorMunicipiosDiariaTiempoActual_(municipio);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesEspecificasApi.PrediccinPorMunicipiosDiariaTiempoActual_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **municipio** | **string**| Código de municipio   http://www.ine.es/daco/daco42/codmun/codmunmapa.htm | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prediccinpormunicipioshorariatiempoactual_"></a>
# **PrediccinPorMunicipiosHorariaTiempoActual_**
> Model200 PrediccinPorMunicipiosHorariaTiempoActual_ (string municipio)

Predicción por municipios horaria. Tiempo actual.

Predicción horaria para el municipio que se pasa como parámetro (municipio). Presenta la información de hora en hora hasta 48 horas.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinPorMunicipiosHorariaTiempoActual_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesEspecificasApi();
            var municipio = municipio_example;  // string | Código de municipio  http://www.ine.es/daco/daco42/codmun/codmunmapa.htm

            try
            {
                // Predicción por municipios horaria. Tiempo actual.
                Model200 result = apiInstance.PrediccinPorMunicipiosHorariaTiempoActual_(municipio);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesEspecificasApi.PrediccinPorMunicipiosHorariaTiempoActual_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **municipio** | **string**| Código de municipio  http://www.ine.es/daco/daco42/codmun/codmunmapa.htm | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

