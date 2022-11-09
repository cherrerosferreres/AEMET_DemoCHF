# IO.Swagger.Api.PrediccionesNormalizadasTextoApi

All URIs are relative to *https://opendata.aemet.es/opendata*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PrediccinCCAAHoyArchivo_**](PrediccionesNormalizadasTextoApi.md#prediccinccaahoyarchivo_) | **GET** /api/prediccion/ccaa/hoy/{ccaa}/elaboracion/{fecha} | Predicción CCAA hoy. Archivo.
[**PrediccinCCAAHoyTiempoActual_**](PrediccionesNormalizadasTextoApi.md#prediccinccaahoytiempoactual_) | **GET** /api/prediccion/ccaa/hoy/{ccaa} | Predicción CCAA hoy. Tiempo actual.
[**PrediccinCCAAMaanaArchivo_**](PrediccionesNormalizadasTextoApi.md#prediccinccaamaanaarchivo_) | **GET** /api/prediccion/ccaa/manana/{ccaa}/elaboracion/{fecha} | Predicción CCAA mañana. Archivo.
[**PrediccinCCAAMaanaTiempoActual_**](PrediccionesNormalizadasTextoApi.md#prediccinccaamaanatiempoactual_) | **GET** /api/prediccion/ccaa/manana/{ccaa} | Predicción CCAA mañana. Tiempo actual.
[**PrediccinCCAAMedioPlazoArchivo_**](PrediccionesNormalizadasTextoApi.md#prediccinccaamedioplazoarchivo_) | **GET** /api/prediccion/ccaa/medioplazo/{ccaa}/elaboracion/{fecha} | Predicción CCAA medio plazo. Archivo.
[**PrediccinCCAAMedioPlazoTiempoActual_**](PrediccionesNormalizadasTextoApi.md#prediccinccaamedioplazotiempoactual_) | **GET** /api/prediccion/ccaa/medioplazo/{ccaa} | Predicción CCAA medio plazo. Tiempo actual.
[**PrediccinCCAAPasadoMaanaArchivo_**](PrediccionesNormalizadasTextoApi.md#prediccinccaapasadomaanaarchivo_) | **GET** /api/prediccion/ccaa/pasadomanana/{ccaa}/elaboracion/{fecha} | Predicción CCAA pasado mañana. Archivo.
[**PrediccinCCAAPasadoMaanaTiempoActual_**](PrediccionesNormalizadasTextoApi.md#prediccinccaapasadomaanatiempoactual_) | **GET** /api/prediccion/ccaa/pasadomanana/{ccaa} | Predicción CCAA pasado mañana. Tiempo actual.
[**PrediccinNacionalHoyArchivo_**](PrediccionesNormalizadasTextoApi.md#prediccinnacionalhoyarchivo_) | **GET** /api/prediccion/nacional/hoy/elaboracion/{fecha} | Predicción nacional hoy. Archivo.
[**PrediccinNacionalHoyTiempoActual_**](PrediccionesNormalizadasTextoApi.md#prediccinnacionalhoytiempoactual_) | **GET** /api/prediccion/nacional/hoy | Predicción nacional hoy. Última elaborada.
[**PrediccinNacionalMaanaArchivo_**](PrediccionesNormalizadasTextoApi.md#prediccinnacionalmaanaarchivo_) | **GET** /api/prediccion/nacional/manana/elaboracion/{fecha} | Predicción nacional mañana. Archivo.
[**PrediccinNacionalMaanaTiempoActual_**](PrediccionesNormalizadasTextoApi.md#prediccinnacionalmaanatiempoactual_) | **GET** /api/prediccion/nacional/manana | Predicción nacional mañana. Tiempo actual.
[**PrediccinNacionalMedioPlazoArchivo_**](PrediccionesNormalizadasTextoApi.md#prediccinnacionalmedioplazoarchivo_) | **GET** /api/prediccion/nacional/medioplazo/elaboracion/{fecha} | Predicción nacional medio plazo. Archivo.
[**PrediccinNacionalMedioPlazoTiempoActual_**](PrediccionesNormalizadasTextoApi.md#prediccinnacionalmedioplazotiempoactual_) | **GET** /api/prediccion/nacional/medioplazo | Predicción nacional medio plazo. Tiempo actual.
[**PrediccinNacionalPasadoMaanaArchivo_**](PrediccionesNormalizadasTextoApi.md#prediccinnacionalpasadomaanaarchivo_) | **GET** /api/prediccion/nacional/pasadomanana/elaboracion/{fecha} | Predicción nacional pasado mañana. Archivo.
[**PrediccinNacionalPasadoMaanaTiempoActual_**](PrediccionesNormalizadasTextoApi.md#prediccinnacionalpasadomaanatiempoactual_) | **GET** /api/prediccion/nacional/pasadomanana | Predicción nacional pasado mañana. Tiempo actual.
[**PrediccinNacionalTendenciaArchivo_**](PrediccionesNormalizadasTextoApi.md#prediccinnacionaltendenciaarchivo_) | **GET** /api/prediccion/nacional/tendencia/elaboracion/{fecha} | Predicción nacional tendencia. Archivo.
[**PrediccinNacionalTendenciaTiempoActual_**](PrediccionesNormalizadasTextoApi.md#prediccinnacionaltendenciatiempoactual_) | **GET** /api/prediccion/nacional/tendencia | Predicción nacional tendencia. Tiempo actual.
[**PrediccinProvinciaHoyArchivo_**](PrediccionesNormalizadasTextoApi.md#prediccinprovinciahoyarchivo_) | **GET** /api/prediccion/provincia/hoy/{provincia}/elaboracion/{fecha} | Predicción provincia hoy. Archivo.
[**PrediccinProvinciaHoyTiempoActual_**](PrediccionesNormalizadasTextoApi.md#prediccinprovinciahoytiempoactual_) | **GET** /api/prediccion/provincia/hoy/{provincia} | Predicción provincia hoy. Tiempo actual.
[**PrediccinProvinciaMaanaArchivo_**](PrediccionesNormalizadasTextoApi.md#prediccinprovinciamaanaarchivo_) | **GET** /api/prediccion/provincia/manana/{provincia}/elaboracion/{fecha} | Predicción provincia mañana. Archivo.
[**PrediccinProvinciaMaanaTiempoActual_**](PrediccionesNormalizadasTextoApi.md#prediccinprovinciamaanatiempoactual_) | **GET** /api/prediccion/provincia/manana/{provincia} | Predicción provincia mañana. Tiempo actual.


<a name="prediccinccaahoyarchivo_"></a>
# **PrediccinCCAAHoyArchivo_**
> Model200 PrediccinCCAAHoyArchivo_ (string ccaa, string fecha)

Predicción CCAA hoy. Archivo.

Predicción para la comunidad autónoma que se pasa como parámetro (ccaa) con validez para el día de fecha de elaboración que se pasa como parámetro (fecha). Periodicidad de actualización: continuamente.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinCCAAHoyArchivo_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesNormalizadasTextoApi();
            var ccaa = ccaa_example;  // string |  | Código de CCAA | CCAA | |- -- -- -- -- -|- -- -- -- -- -| | and  | Andalucía   | | arn  | Aragón   | | ast  | Astrrias  | | bal  | Ballears, Illes   | | coo  | Canarias   | | can  | Cantabria   | | cle  | Castilla y León   | | clm  | Castilla - La Mancha   | | cat  | Cataluña   | | val  | Comunitat Valenciana   | | ext  | Extremadura   | | gal  | Galicia   | | mad  | Madrid, Comunidad de    | | mur  | Murcia, Región de   | | nav  | Navarra, Comunidad Foral de   | | pva  | País Vasco | | rio  | Rioja, La   
            var fecha = fecha_example;  // string | Día de elaboración (AAAA-MM-DD)

            try
            {
                // Predicción CCAA hoy. Archivo.
                Model200 result = apiInstance.PrediccinCCAAHoyArchivo_(ccaa, fecha);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesNormalizadasTextoApi.PrediccinCCAAHoyArchivo_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ccaa** | **string**|  | Código de CCAA | CCAA | |- -- -- -- -- -|- -- -- -- -- -| | and  | Andalucía   | | arn  | Aragón   | | ast  | Astrrias  | | bal  | Ballears, Illes   | | coo  | Canarias   | | can  | Cantabria   | | cle  | Castilla y León   | | clm  | Castilla - La Mancha   | | cat  | Cataluña   | | val  | Comunitat Valenciana   | | ext  | Extremadura   | | gal  | Galicia   | | mad  | Madrid, Comunidad de    | | mur  | Murcia, Región de   | | nav  | Navarra, Comunidad Foral de   | | pva  | País Vasco | | rio  | Rioja, La    | 
 **fecha** | **string**| Día de elaboración (AAAA-MM-DD) | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prediccinccaahoytiempoactual_"></a>
# **PrediccinCCAAHoyTiempoActual_**
> Model200 PrediccinCCAAHoyTiempoActual_ (string ccaa)

Predicción CCAA hoy. Tiempo actual.

Predicción para la CCAA que se pasa como parámetro con validez para mismo día que la fecha de petición. En el caso de que en la fecha de petición este producto todavía no se hubiera elaborado, se retornará el último elaborado. Actualización continuamente.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinCCAAHoyTiempoActual_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesNormalizadasTextoApi();
            var ccaa = ccaa_example;  // string |  | Código de CCAA | CCAA | |- -- -- -- -- -|- -- -- -- -- -| | and  | Andalucía   | | arn  | Aragón   | | ast  | Asturias  | | bal  | Ballears, Illes   | | coo  | Canarias   | | can  | Cantabria   | | cle  | Castilla y León   | | clm  | Castilla - La Mancha   | | cat  | Cataluña   | | val  | Comunitat Valenciana   | | ext  | Extremadura   | | gal  | Galicia   | | mad  | Madrid, Comunidad de    | | mur  | Murcia, Región de   | | nav  | Navarra, Comunidad Foral de   | | pva  | País Vasco | | rio  | Rioja, La

            try
            {
                // Predicción CCAA hoy. Tiempo actual.
                Model200 result = apiInstance.PrediccinCCAAHoyTiempoActual_(ccaa);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesNormalizadasTextoApi.PrediccinCCAAHoyTiempoActual_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ccaa** | **string**|  | Código de CCAA | CCAA | |- -- -- -- -- -|- -- -- -- -- -| | and  | Andalucía   | | arn  | Aragón   | | ast  | Asturias  | | bal  | Ballears, Illes   | | coo  | Canarias   | | can  | Cantabria   | | cle  | Castilla y León   | | clm  | Castilla - La Mancha   | | cat  | Cataluña   | | val  | Comunitat Valenciana   | | ext  | Extremadura   | | gal  | Galicia   | | mad  | Madrid, Comunidad de    | | mur  | Murcia, Región de   | | nav  | Navarra, Comunidad Foral de   | | pva  | País Vasco | | rio  | Rioja, La | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prediccinccaamaanaarchivo_"></a>
# **PrediccinCCAAMaanaArchivo_**
> Model200 PrediccinCCAAMaanaArchivo_ (string ccaa, string fecha)

Predicción CCAA mañana. Archivo.

Predicción para la comunidad autónoma que se pasa como parámetro (ccaa) con validez para el día siguiente a la fecha de elaboración que se pasa como parámetro (fecha). Periodicidad de actualización. continuamente.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinCCAAMaanaArchivo_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesNormalizadasTextoApi();
            var ccaa = ccaa_example;  // string |  | Código de CCAA | CCAA | |- -- -- -- -- -|- -- -- -- -- -| | and  | Andalucía   | | arn  | Aragón   | | ast  | Astrrias  | | bal  | Ballears, Illes   | | coo  | Canarias   | | can  | Cantabria   | | cle  | Castilla y León   | | clm  | Castilla - La Mancha   | | cat  | Cataluña   | | val  | Comunitat Valenciana   | | ext  | Extremadura   | | gal  | Galicia   | | mad  | Madrid, Comunidad de    | | mur  | Murcia, Región de   | | nav  | Navarra, Comunidad Foral de   | | pva  | País Vasco | | rio  | Rioja, La   
            var fecha = fecha_example;  // string | Día de elaboración (AAAA-MM-DD)

            try
            {
                // Predicción CCAA mañana. Archivo.
                Model200 result = apiInstance.PrediccinCCAAMaanaArchivo_(ccaa, fecha);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesNormalizadasTextoApi.PrediccinCCAAMaanaArchivo_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ccaa** | **string**|  | Código de CCAA | CCAA | |- -- -- -- -- -|- -- -- -- -- -| | and  | Andalucía   | | arn  | Aragón   | | ast  | Astrrias  | | bal  | Ballears, Illes   | | coo  | Canarias   | | can  | Cantabria   | | cle  | Castilla y León   | | clm  | Castilla - La Mancha   | | cat  | Cataluña   | | val  | Comunitat Valenciana   | | ext  | Extremadura   | | gal  | Galicia   | | mad  | Madrid, Comunidad de    | | mur  | Murcia, Región de   | | nav  | Navarra, Comunidad Foral de   | | pva  | País Vasco | | rio  | Rioja, La    | 
 **fecha** | **string**| Día de elaboración (AAAA-MM-DD) | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prediccinccaamaanatiempoactual_"></a>
# **PrediccinCCAAMaanaTiempoActual_**
> Model200 PrediccinCCAAMaanaTiempoActual_ (string ccaa)

Predicción CCAA mañana. Tiempo actual.

Predicción para la comunidad autónoma que se pasa como parámetro para el día siguiente a la fecha de la petición. En el caso de el producto no se hubiera elaborado todavía en la fecha de petición se retornará el último producto elaborado. Periodicidad de actualización: continuamente.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinCCAAMaanaTiempoActual_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesNormalizadasTextoApi();
            var ccaa = ccaa_example;  // string |  | Código de CCAA | CCAA | |- -- -- -- -- -|- -- -- -- -- -| | and  | Andalucía   | | arn  | Aragón   | | ast  | Astrrias  | | bal  | Ballears, Illes   | | coo  | Canarias   | | can  | Cantabria   | | cle  | Castilla y León   | | clm  | Castilla - La Mancha   | | cat  | Cataluña   | | val  | Comunitat Valenciana   | | ext  | Extremadura   | | gal  | Galicia   | | mad  | Madrid, Comunidad de    | | mur  | Murcia, Región de   | | nav  | Navarra, Comunidad Foral de   | | pva  | País Vasco | | rio  | Rioja, La   

            try
            {
                // Predicción CCAA mañana. Tiempo actual.
                Model200 result = apiInstance.PrediccinCCAAMaanaTiempoActual_(ccaa);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesNormalizadasTextoApi.PrediccinCCAAMaanaTiempoActual_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ccaa** | **string**|  | Código de CCAA | CCAA | |- -- -- -- -- -|- -- -- -- -- -| | and  | Andalucía   | | arn  | Aragón   | | ast  | Astrrias  | | bal  | Ballears, Illes   | | coo  | Canarias   | | can  | Cantabria   | | cle  | Castilla y León   | | clm  | Castilla - La Mancha   | | cat  | Cataluña   | | val  | Comunitat Valenciana   | | ext  | Extremadura   | | gal  | Galicia   | | mad  | Madrid, Comunidad de    | | mur  | Murcia, Región de   | | nav  | Navarra, Comunidad Foral de   | | pva  | País Vasco | | rio  | Rioja, La    | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prediccinccaamedioplazoarchivo_"></a>
# **PrediccinCCAAMedioPlazoArchivo_**
> Model200 PrediccinCCAAMedioPlazoArchivo_ (string ccaa, string fecha)

Predicción CCAA medio plazo. Archivo.

Predicción de mediio plazo para la comunidad autónoma que se pasa como parámetro (ccaa) a partir de la fecha de elaboración que se pasa como parámetro (fecha). Periodicidad de actualización: continuamente.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinCCAAMedioPlazoArchivo_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesNormalizadasTextoApi();
            var ccaa = ccaa_example;  // string |  | Código de CCAA | CCAA | |- -- -- -- -- -|- -- -- -- -- -| | and  | Andalucía   | | arn  | Aragón   | | ast  | Astrrias  | | bal  | Ballears, Illes   | | coo  | Canarias   | | can  | Cantabria   | | cle  | Castilla y León   | | clm  | Castilla - La Mancha   | | cat  | Cataluña   | | val  | Comunitat Valenciana   | | ext  | Extremadura   | | gal  | Galicia   | | mad  | Madrid, Comunidad de    | | mur  | Murcia, Región de   | | nav  | Navarra, Comunidad Foral de   | | pva  | País Vasco | | rio  | Rioja, La   
            var fecha = fecha_example;  // string | Día de elaboración (AAAA-MM-DD)

            try
            {
                // Predicción CCAA medio plazo. Archivo.
                Model200 result = apiInstance.PrediccinCCAAMedioPlazoArchivo_(ccaa, fecha);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesNormalizadasTextoApi.PrediccinCCAAMedioPlazoArchivo_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ccaa** | **string**|  | Código de CCAA | CCAA | |- -- -- -- -- -|- -- -- -- -- -| | and  | Andalucía   | | arn  | Aragón   | | ast  | Astrrias  | | bal  | Ballears, Illes   | | coo  | Canarias   | | can  | Cantabria   | | cle  | Castilla y León   | | clm  | Castilla - La Mancha   | | cat  | Cataluña   | | val  | Comunitat Valenciana   | | ext  | Extremadura   | | gal  | Galicia   | | mad  | Madrid, Comunidad de    | | mur  | Murcia, Región de   | | nav  | Navarra, Comunidad Foral de   | | pva  | País Vasco | | rio  | Rioja, La    | 
 **fecha** | **string**| Día de elaboración (AAAA-MM-DD) | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prediccinccaamedioplazotiempoactual_"></a>
# **PrediccinCCAAMedioPlazoTiempoActual_**
> Model200 PrediccinCCAAMedioPlazoTiempoActual_ (string ccaa)

Predicción CCAA medio plazo. Tiempo actual.

Predicción para la comunidad autónoma que se pasa como parámetro (ccaa) y con validez para el medio plazo a partir de la fecha de petición. En el caso de que en el fecha de la petición no se hubiera generado aún el producto, se retornará el última elaborado. Periodicidad de actualización: continuamente.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinCCAAMedioPlazoTiempoActual_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesNormalizadasTextoApi();
            var ccaa = ccaa_example;  // string |  | Código de CCAA | CCAA | |- -- -- -- -- -|- -- -- -- -- -| | and  | Andalucía   | | arn  | Aragón   | | ast  | Astrrias  | | bal  | Ballears, Illes   | | coo  | Canarias   | | can  | Cantabria   | | cle  | Castilla y León   | | clm  | Castilla - La Mancha   | | cat  | Cataluña   | | val  | Comunitat Valenciana   | | ext  | Extremadura   | | gal  | Galicia   | | mad  | Madrid, Comunidad de    | | mur  | Murcia, Región de   | | nav  | Navarra, Comunidad Foral de   | | pva  | País Vasco | | rio  | Rioja, La   

            try
            {
                // Predicción CCAA medio plazo. Tiempo actual.
                Model200 result = apiInstance.PrediccinCCAAMedioPlazoTiempoActual_(ccaa);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesNormalizadasTextoApi.PrediccinCCAAMedioPlazoTiempoActual_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ccaa** | **string**|  | Código de CCAA | CCAA | |- -- -- -- -- -|- -- -- -- -- -| | and  | Andalucía   | | arn  | Aragón   | | ast  | Astrrias  | | bal  | Ballears, Illes   | | coo  | Canarias   | | can  | Cantabria   | | cle  | Castilla y León   | | clm  | Castilla - La Mancha   | | cat  | Cataluña   | | val  | Comunitat Valenciana   | | ext  | Extremadura   | | gal  | Galicia   | | mad  | Madrid, Comunidad de    | | mur  | Murcia, Región de   | | nav  | Navarra, Comunidad Foral de   | | pva  | País Vasco | | rio  | Rioja, La    | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prediccinccaapasadomaanaarchivo_"></a>
# **PrediccinCCAAPasadoMaanaArchivo_**
> Model200 PrediccinCCAAPasadoMaanaArchivo_ (string ccaa, string fecha)

Predicción CCAA pasado mañana. Archivo.

Predicción para la comunidad autónoma que se pasa como parámetro (ccaa) y validez para pasado mañana a partir de la fecha de elaboración que se pasa como parámetro (fecha). Periodicidad de actualización: continuamente.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinCCAAPasadoMaanaArchivo_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesNormalizadasTextoApi();
            var ccaa = ccaa_example;  // string |  | Código de CCAA | CCAA | |- -- -- -- -- -|- -- -- -- -- -| | and  | Andalucía   | | arn  | Aragón   | | ast  | Astrrias  | | bal  | Ballears, Illes   | | coo  | Canarias   | | can  | Cantabria   | | cle  | Castilla y León   | | clm  | Castilla - La Mancha   | | cat  | Cataluña   | | val  | Comunitat Valenciana   | | ext  | Extremadura   | | gal  | Galicia   | | mad  | Madrid, Comunidad de    | | mur  | Murcia, Región de   | | nav  | Navarra, Comunidad Foral de   | | pva  | País Vasco | | rio  | Rioja, La   
            var fecha = fecha_example;  // string | Día de elaboración (AAAA-MM-DD)

            try
            {
                // Predicción CCAA pasado mañana. Archivo.
                Model200 result = apiInstance.PrediccinCCAAPasadoMaanaArchivo_(ccaa, fecha);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesNormalizadasTextoApi.PrediccinCCAAPasadoMaanaArchivo_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ccaa** | **string**|  | Código de CCAA | CCAA | |- -- -- -- -- -|- -- -- -- -- -| | and  | Andalucía   | | arn  | Aragón   | | ast  | Astrrias  | | bal  | Ballears, Illes   | | coo  | Canarias   | | can  | Cantabria   | | cle  | Castilla y León   | | clm  | Castilla - La Mancha   | | cat  | Cataluña   | | val  | Comunitat Valenciana   | | ext  | Extremadura   | | gal  | Galicia   | | mad  | Madrid, Comunidad de    | | mur  | Murcia, Región de   | | nav  | Navarra, Comunidad Foral de   | | pva  | País Vasco | | rio  | Rioja, La    | 
 **fecha** | **string**| Día de elaboración (AAAA-MM-DD) | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prediccinccaapasadomaanatiempoactual_"></a>
# **PrediccinCCAAPasadoMaanaTiempoActual_**
> Model200 PrediccinCCAAPasadoMaanaTiempoActual_ (string ccaa)

Predicción CCAA pasado mañana. Tiempo actual.

Predicción para la comunidad autónoma que se pasa como parámetro (ccaa) y validez para el medio plazo a partir de la fecha de la petición. En el caso de que en la fecha de la petición dicho producto aún no se hubiera generado retornará el último de este tipo que se hubiera generado.  Periodicidad de actualización: continuamente.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinCCAAPasadoMaanaTiempoActual_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesNormalizadasTextoApi();
            var ccaa = ccaa_example;  // string |  | Código de CCAA | CCAA | |- -- -- -- -- -|- -- -- -- -- -| | and  | Andalucía   | | arn  | Aragón   | | ast  | Astrrias  | | bal  | Ballears, Illes   | | coo  | Canarias   | | can  | Cantabria   | | cle  | Castilla y León   | | clm  | Castilla - La Mancha   | | cat  | Cataluña   | | val  | Comunitat Valenciana   | | ext  | Extremadura   | | gal  | Galicia   | | mad  | Madrid, Comunidad de    | | mur  | Murcia, Región de   | | nav  | Navarra, Comunidad Foral de   | | pva  | País Vasco | | rio  | Rioja, La   

            try
            {
                // Predicción CCAA pasado mañana. Tiempo actual.
                Model200 result = apiInstance.PrediccinCCAAPasadoMaanaTiempoActual_(ccaa);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesNormalizadasTextoApi.PrediccinCCAAPasadoMaanaTiempoActual_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ccaa** | **string**|  | Código de CCAA | CCAA | |- -- -- -- -- -|- -- -- -- -- -| | and  | Andalucía   | | arn  | Aragón   | | ast  | Astrrias  | | bal  | Ballears, Illes   | | coo  | Canarias   | | can  | Cantabria   | | cle  | Castilla y León   | | clm  | Castilla - La Mancha   | | cat  | Cataluña   | | val  | Comunitat Valenciana   | | ext  | Extremadura   | | gal  | Galicia   | | mad  | Madrid, Comunidad de    | | mur  | Murcia, Región de   | | nav  | Navarra, Comunidad Foral de   | | pva  | País Vasco | | rio  | Rioja, La    | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prediccinnacionalhoyarchivo_"></a>
# **PrediccinNacionalHoyArchivo_**
> Model200 PrediccinNacionalHoyArchivo_ (string fecha)

Predicción nacional hoy. Archivo.

Predicción nacional para el día correspondiente a la fecha que se pasa como parámetro en en formato texto. Actualización diaria. Hay días en los que este producto no se realiza. En ese caso se devuelve un 404 producto no existente.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinNacionalHoyArchivo_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesNormalizadasTextoApi();
            var fecha = fecha_example;  // string | Fecha en formato (AAAA-MM-DD)

            try
            {
                // Predicción nacional hoy. Archivo.
                Model200 result = apiInstance.PrediccinNacionalHoyArchivo_(fecha);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesNormalizadasTextoApi.PrediccinNacionalHoyArchivo_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fecha** | **string**| Fecha en formato (AAAA-MM-DD) | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prediccinnacionalhoytiempoactual_"></a>
# **PrediccinNacionalHoyTiempoActual_**
> Model200 PrediccinNacionalHoyTiempoActual_ ()

Predicción nacional hoy. Última elaborada.

Predicción nacional para el día actual a la fecha de elaboración en formato texto. Actualización diaria. Hay días en los que este producto no se realiza. En ese caso se devuelve la predicción nacional última que se elaboró.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinNacionalHoyTiempoActual_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesNormalizadasTextoApi();

            try
            {
                // Predicción nacional hoy. Última elaborada.
                Model200 result = apiInstance.PrediccinNacionalHoyTiempoActual_();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesNormalizadasTextoApi.PrediccinNacionalHoyTiempoActual_: " + e.Message );
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

<a name="prediccinnacionalmaanaarchivo_"></a>
# **PrediccinNacionalMaanaArchivo_**
> Model200 PrediccinNacionalMaanaArchivo_ (string fecha)

Predicción nacional mañana. Archivo.

Predicción nacional para el día siguiente a la fecha de elaboración. En este caso la fecha de elaboración es la fecha que se pasa como parámetro. Actualización diaria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinNacionalMaanaArchivo_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesNormalizadasTextoApi();
            var fecha = fecha_example;  // string | Día (AAAA-MM-DD)

            try
            {
                // Predicción nacional mañana. Archivo.
                Model200 result = apiInstance.PrediccinNacionalMaanaArchivo_(fecha);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesNormalizadasTextoApi.PrediccinNacionalMaanaArchivo_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fecha** | **string**| Día (AAAA-MM-DD) | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prediccinnacionalmaanatiempoactual_"></a>
# **PrediccinNacionalMaanaTiempoActual_**
> Model200 PrediccinNacionalMaanaTiempoActual_ ()

Predicción nacional mañana. Tiempo actual.

Predicción nacional para el día siguiente a la fecha de elaboración. En este caso la fecha de elaboración es el día actual. Actualización diaria. En el caso de que en el día actual  todavía no se haya elaborado se devolverá el último producto de predicción nacional para mañana elaborado.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinNacionalMaanaTiempoActual_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesNormalizadasTextoApi();

            try
            {
                // Predicción nacional mañana. Tiempo actual.
                Model200 result = apiInstance.PrediccinNacionalMaanaTiempoActual_();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesNormalizadasTextoApi.PrediccinNacionalMaanaTiempoActual_: " + e.Message );
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

<a name="prediccinnacionalmedioplazoarchivo_"></a>
# **PrediccinNacionalMedioPlazoArchivo_**
> Model200 PrediccinNacionalMedioPlazoArchivo_ (string fecha)

Predicción nacional medio plazo. Archivo.

Predicción nacional para el medio plazo siguiente a la fecha de elaboración. En este caso, la fecha de elaboración es la fecha que se pasa como parámetro. Actualización diaria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinNacionalMedioPlazoArchivo_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesNormalizadasTextoApi();
            var fecha = fecha_example;  // string | Día (AAAA-MM-DD)

            try
            {
                // Predicción nacional medio plazo. Archivo.
                Model200 result = apiInstance.PrediccinNacionalMedioPlazoArchivo_(fecha);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesNormalizadasTextoApi.PrediccinNacionalMedioPlazoArchivo_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fecha** | **string**| Día (AAAA-MM-DD) | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prediccinnacionalmedioplazotiempoactual_"></a>
# **PrediccinNacionalMedioPlazoTiempoActual_**
> Model200 PrediccinNacionalMedioPlazoTiempoActual_ ()

Predicción nacional medio plazo. Tiempo actual.

Predicción nacional para medio plazo siguiente a la fecha de elaboración. En este caso la fecha de elaboración es el día actual. Actualización diaria. En el caso de que en el día actual  todavía no se haya elaborado se devolverá el último producto de predicción nacional para medio plazo elaborado.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinNacionalMedioPlazoTiempoActual_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesNormalizadasTextoApi();

            try
            {
                // Predicción nacional medio plazo. Tiempo actual.
                Model200 result = apiInstance.PrediccinNacionalMedioPlazoTiempoActual_();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesNormalizadasTextoApi.PrediccinNacionalMedioPlazoTiempoActual_: " + e.Message );
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

<a name="prediccinnacionalpasadomaanaarchivo_"></a>
# **PrediccinNacionalPasadoMaanaArchivo_**
> Model200 PrediccinNacionalPasadoMaanaArchivo_ (string fecha)

Predicción nacional pasado mañana. Archivo.

Predicción nacional para pasado mañana siguiente a la fecha de elaboración. En este caso, la fecha de elaboración es la fecha que se pasa como parámetro. Actualización diaria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinNacionalPasadoMaanaArchivo_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesNormalizadasTextoApi();
            var fecha = fecha_example;  // string | Día (AAAA-MM-DD)

            try
            {
                // Predicción nacional pasado mañana. Archivo.
                Model200 result = apiInstance.PrediccinNacionalPasadoMaanaArchivo_(fecha);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesNormalizadasTextoApi.PrediccinNacionalPasadoMaanaArchivo_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fecha** | **string**| Día (AAAA-MM-DD) | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prediccinnacionalpasadomaanatiempoactual_"></a>
# **PrediccinNacionalPasadoMaanaTiempoActual_**
> Model200 PrediccinNacionalPasadoMaanaTiempoActual_ ()

Predicción nacional pasado mañana. Tiempo actual.

Predicción nacional para pasado mañana siguiente a la fecha de elaboración. En este caso la fecha de elaboración es el día actual. Actualización diaria. En el caso de que en el día actual  todavía no se haya elaborado se devolverá el último producto de predicción nacional para pasado mañana elaborado.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinNacionalPasadoMaanaTiempoActual_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesNormalizadasTextoApi();

            try
            {
                // Predicción nacional pasado mañana. Tiempo actual.
                Model200 result = apiInstance.PrediccinNacionalPasadoMaanaTiempoActual_();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesNormalizadasTextoApi.PrediccinNacionalPasadoMaanaTiempoActual_: " + e.Message );
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

<a name="prediccinnacionaltendenciaarchivo_"></a>
# **PrediccinNacionalTendenciaArchivo_**
> Model200 PrediccinNacionalTendenciaArchivo_ (string fecha)

Predicción nacional tendencia. Archivo.

Predicción nacional para tendencia siguiente a la fecha de elaboración. En este caso, la fecha de elaboración es la fecha que se pasa como parámetro. Actualización diaria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinNacionalTendenciaArchivo_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesNormalizadasTextoApi();
            var fecha = fecha_example;  // string | Día (AAAA-MM-DD)

            try
            {
                // Predicción nacional tendencia. Archivo.
                Model200 result = apiInstance.PrediccinNacionalTendenciaArchivo_(fecha);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesNormalizadasTextoApi.PrediccinNacionalTendenciaArchivo_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fecha** | **string**| Día (AAAA-MM-DD) | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prediccinnacionaltendenciatiempoactual_"></a>
# **PrediccinNacionalTendenciaTiempoActual_**
> Model200 PrediccinNacionalTendenciaTiempoActual_ ()

Predicción nacional tendencia. Tiempo actual.

Predicción nacional para tendencia siguiente a la fecha de elaboración. En este caso la fecha de elaboración es el día actual. Actualización diaria. En el caso de que en el día actual  todavía no se haya elaborado se devolverá el último producto de predicción nacional para tendencia elaborado.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinNacionalTendenciaTiempoActual_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesNormalizadasTextoApi();

            try
            {
                // Predicción nacional tendencia. Tiempo actual.
                Model200 result = apiInstance.PrediccinNacionalTendenciaTiempoActual_();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesNormalizadasTextoApi.PrediccinNacionalTendenciaTiempoActual_: " + e.Message );
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

<a name="prediccinprovinciahoyarchivo_"></a>
# **PrediccinProvinciaHoyArchivo_**
> Model200 PrediccinProvinciaHoyArchivo_ (string provincia, string fecha)

Predicción provincia hoy. Archivo.

Predicción del día siguiente a la fecha que se pasa como parámetro para la provincia que se pasa como parámetro. Actualización continua y fija a las 14:00 Hora Oficial Peninsular del día que se pasa como parámetro.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinProvinciaHoyArchivo_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesNormalizadasTextoApi();
            var provincia = provincia_example;  // string |  | Código Provincia | Provincia | |- -- -- -- -- -|- -- -- -- -- -| | 01  | Araba/Álaba   | | 01  | Araba/Álava   | | 02  | Albacete   | | 03  | Alacant/Alicante  | | 04  | Almería   | | 33  | Asturias   | | 05  | Ávila   | | 06  | Badajoz   | | 07  | Illes Ballears   | | 08  | Barcelona   | | 48  | Bizkaia   | | 09  | Burgos   | | 10  | Cáceres   | | 11  | Cádiz   | | 39  | Cantabria   | | 12  | Castelló/Castellón   | | 51  | Ceuta   | | 13  | Ciudad Real   | | 14  | Córdoba   | | 15  | A Coruña   | | 16  | Cuenca   | | 17  | Girona   | | 18  | Granada   | | 19  | Guadalajara   | | 20  | Gipuzkoa   | | 21  | Huelva   | | 22  | Huesca   | | 23  | Jaén   | | 24  | León   | | 25  | Lleida   | | 27  | Lugo   | | 28  | Madrid   | | 29  | Málaga   | | 52  | Melilla   | | 30  | Murcia   | | 31  | Navarra   | | 32  | Oursense   | | 34  | Palencia   | | 35  | Las Palmas   | | 36  | Pontevedra   | | 26  | La Rioja   | | 37  | Salamanca   | | 38  | Santa Cruz de Tenerife   | | 40  | Segovia   | | 41  | Sevilla   | | 42  | Soria   | | 43  | Tarragona   | | 44  | Teruel   | | 45  | Toledo   | | 46  | València/Valencia   | | 47  | Valladolid   | | 49  | Zamora   | | 50  | Zaragoza   | | 
            var fecha = fecha_example;  // string | Día de elaboración (AAAA-MM-DD)

            try
            {
                // Predicción provincia hoy. Archivo.
                Model200 result = apiInstance.PrediccinProvinciaHoyArchivo_(provincia, fecha);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesNormalizadasTextoApi.PrediccinProvinciaHoyArchivo_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **provincia** | **string**|  | Código Provincia | Provincia | |- -- -- -- -- -|- -- -- -- -- -| | 01  | Araba/Álaba   | | 01  | Araba/Álava   | | 02  | Albacete   | | 03  | Alacant/Alicante  | | 04  | Almería   | | 33  | Asturias   | | 05  | Ávila   | | 06  | Badajoz   | | 07  | Illes Ballears   | | 08  | Barcelona   | | 48  | Bizkaia   | | 09  | Burgos   | | 10  | Cáceres   | | 11  | Cádiz   | | 39  | Cantabria   | | 12  | Castelló/Castellón   | | 51  | Ceuta   | | 13  | Ciudad Real   | | 14  | Córdoba   | | 15  | A Coruña   | | 16  | Cuenca   | | 17  | Girona   | | 18  | Granada   | | 19  | Guadalajara   | | 20  | Gipuzkoa   | | 21  | Huelva   | | 22  | Huesca   | | 23  | Jaén   | | 24  | León   | | 25  | Lleida   | | 27  | Lugo   | | 28  | Madrid   | | 29  | Málaga   | | 52  | Melilla   | | 30  | Murcia   | | 31  | Navarra   | | 32  | Oursense   | | 34  | Palencia   | | 35  | Las Palmas   | | 36  | Pontevedra   | | 26  | La Rioja   | | 37  | Salamanca   | | 38  | Santa Cruz de Tenerife   | | 40  | Segovia   | | 41  | Sevilla   | | 42  | Soria   | | 43  | Tarragona   | | 44  | Teruel   | | 45  | Toledo   | | 46  | València/Valencia   | | 47  | Valladolid   | | 49  | Zamora   | | 50  | Zaragoza   | |  | 
 **fecha** | **string**| Día de elaboración (AAAA-MM-DD) | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prediccinprovinciahoytiempoactual_"></a>
# **PrediccinProvinciaHoyTiempoActual_**
> Model200 PrediccinProvinciaHoyTiempoActual_ (string provincia)

Predicción provincia hoy. Tiempo actual.

Predicción del día actual para la provincia que se pasa como parámetro. En el caso de que este producto no se haya elaborado todavía en el día actual, se retorna el último elaborado. Actualización continua y fija a las 14:00 Hora Oficial Peninsular.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinProvinciaHoyTiempoActual_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesNormalizadasTextoApi();
            var provincia = provincia_example;  // string |  | Código Provincia | Provincia | |- -- -- -- -- -|- -- -- -- -- -| | 01  | Araba/Álaba   | | 01  | Araba/Álava   | | 02  | Albacete   | | 03  | Alacant/Alicante  | | 04  | Almería   | | 33  | Asturias   | | 05  | Ávila   | | 06  | Badajoz   | | 07  | Illes Ballears   | | 08  | Barcelona   | | 48  | Bizkaia   | | 09  | Burgos   | | 10  | Cáceres   | | 11  | Cádiz   | | 39  | Cantabria   | | 12  | Castelló/Castellón   | | 51  | Ceuta   | | 13  | Ciudad Real   | | 14  | Córdoba   | | 15  | A Coruña   | | 16  | Cuenca   | | 17  | Girona   | | 18  | Granada   | | 19  | Guadalajara   | | 20  | Gipuzkoa   | | 21  | Huelva   | | 22  | Huesca   | | 23  | Jaén   | | 24  | León   | | 25  | Lleida   | | 27  | Lugo   | | 28  | Madrid   | | 29  | Málaga   | | 52  | Melilla   | | 30  | Murcia   | | 31  | Navarra   | | 32  | Oursense   | | 34  | Palencia   | | 35  | Las Palmas   | | 36  | Pontevedra   | | 26  | La Rioja   | | 37  | Salamanca   | | 38  | Santa Cruz de Tenerife   | | 40  | Segovia   | | 41  | Sevilla   | | 42  | Soria   | | 43  | Tarragona   | | 44  | Teruel   | | 45  | Toledo   | | 46  | València/Valencia   | | 47  | Valladolid   | | 49  | Zamora   | | 50  | Zaragoza   | | 

            try
            {
                // Predicción provincia hoy. Tiempo actual.
                Model200 result = apiInstance.PrediccinProvinciaHoyTiempoActual_(provincia);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesNormalizadasTextoApi.PrediccinProvinciaHoyTiempoActual_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **provincia** | **string**|  | Código Provincia | Provincia | |- -- -- -- -- -|- -- -- -- -- -| | 01  | Araba/Álaba   | | 01  | Araba/Álava   | | 02  | Albacete   | | 03  | Alacant/Alicante  | | 04  | Almería   | | 33  | Asturias   | | 05  | Ávila   | | 06  | Badajoz   | | 07  | Illes Ballears   | | 08  | Barcelona   | | 48  | Bizkaia   | | 09  | Burgos   | | 10  | Cáceres   | | 11  | Cádiz   | | 39  | Cantabria   | | 12  | Castelló/Castellón   | | 51  | Ceuta   | | 13  | Ciudad Real   | | 14  | Córdoba   | | 15  | A Coruña   | | 16  | Cuenca   | | 17  | Girona   | | 18  | Granada   | | 19  | Guadalajara   | | 20  | Gipuzkoa   | | 21  | Huelva   | | 22  | Huesca   | | 23  | Jaén   | | 24  | León   | | 25  | Lleida   | | 27  | Lugo   | | 28  | Madrid   | | 29  | Málaga   | | 52  | Melilla   | | 30  | Murcia   | | 31  | Navarra   | | 32  | Oursense   | | 34  | Palencia   | | 35  | Las Palmas   | | 36  | Pontevedra   | | 26  | La Rioja   | | 37  | Salamanca   | | 38  | Santa Cruz de Tenerife   | | 40  | Segovia   | | 41  | Sevilla   | | 42  | Soria   | | 43  | Tarragona   | | 44  | Teruel   | | 45  | Toledo   | | 46  | València/Valencia   | | 47  | Valladolid   | | 49  | Zamora   | | 50  | Zaragoza   | |  | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prediccinprovinciamaanaarchivo_"></a>
# **PrediccinProvinciaMaanaArchivo_**
> Model200 PrediccinProvinciaMaanaArchivo_ (string provincia, string fecha)

Predicción provincia mañana. Archivo.

Predicción del día siguiente a la fecha que se pasa como parámetro para la provincia que se pasa como parámetro. Actualización continua y fija a las 14:00 Hora Oficial Peninsular del día que se pasa como parámetro.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinProvinciaMaanaArchivo_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesNormalizadasTextoApi();
            var provincia = provincia_example;  // string |  | Código Provincia | Provincia | |- -- -- -- -- -|- -- -- -- -- -| | 01  | Araba/Álaba   | | 01  | Araba/Álava   | | 02  | Albacete   | | 03  | Alacant/Alicante  | | 04  | Almería   | | 33  | Asturias   | | 05  | Ávila   | | 06  | Badajoz   | | 07  | Illes Ballears   | | 08  | Barcelona   | | 48  | Bizkaia   | | 09  | Burgos   | | 10  | Cáceres   | | 11  | Cádiz   | | 39  | Cantabria   | | 12  | Castelló/Castellón   | | 51  | Ceuta   | | 13  | Ciudad Real   | | 14  | Córdoba   | | 15  | A Coruña   | | 16  | Cuenca   | | 17  | Girona   | | 18  | Granada   | | 19  | Guadalajara   | | 20  | Gipuzkoa   | | 21  | Huelva   | | 22  | Huesca   | | 23  | Jaén   | | 24  | León   | | 25  | Lleida   | | 27  | Lugo   | | 28  | Madrid   | | 29  | Málaga   | | 52  | Melilla   | | 30  | Murcia   | | 31  | Navarra   | | 32  | Oursense   | | 34  | Palencia   | | 35  | Las Palmas   | | 36  | Pontevedra   | | 26  | La Rioja   | | 37  | Salamanca   | | 38  | Santa Cruz de Tenerife   | | 40  | Segovia   | | 41  | Sevilla   | | 42  | Soria   | | 43  | Tarragona   | | 44  | Teruel   | | 45  | Toledo   | | 46  | València/Valencia   | | 47  | Valladolid   | | 49  | Zamora   | | 50  | Zaragoza   | | 
            var fecha = fecha_example;  // string | Día de elaboración (AAAA-MM-DD)

            try
            {
                // Predicción provincia mañana. Archivo.
                Model200 result = apiInstance.PrediccinProvinciaMaanaArchivo_(provincia, fecha);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesNormalizadasTextoApi.PrediccinProvinciaMaanaArchivo_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **provincia** | **string**|  | Código Provincia | Provincia | |- -- -- -- -- -|- -- -- -- -- -| | 01  | Araba/Álaba   | | 01  | Araba/Álava   | | 02  | Albacete   | | 03  | Alacant/Alicante  | | 04  | Almería   | | 33  | Asturias   | | 05  | Ávila   | | 06  | Badajoz   | | 07  | Illes Ballears   | | 08  | Barcelona   | | 48  | Bizkaia   | | 09  | Burgos   | | 10  | Cáceres   | | 11  | Cádiz   | | 39  | Cantabria   | | 12  | Castelló/Castellón   | | 51  | Ceuta   | | 13  | Ciudad Real   | | 14  | Córdoba   | | 15  | A Coruña   | | 16  | Cuenca   | | 17  | Girona   | | 18  | Granada   | | 19  | Guadalajara   | | 20  | Gipuzkoa   | | 21  | Huelva   | | 22  | Huesca   | | 23  | Jaén   | | 24  | León   | | 25  | Lleida   | | 27  | Lugo   | | 28  | Madrid   | | 29  | Málaga   | | 52  | Melilla   | | 30  | Murcia   | | 31  | Navarra   | | 32  | Oursense   | | 34  | Palencia   | | 35  | Las Palmas   | | 36  | Pontevedra   | | 26  | La Rioja   | | 37  | Salamanca   | | 38  | Santa Cruz de Tenerife   | | 40  | Segovia   | | 41  | Sevilla   | | 42  | Soria   | | 43  | Tarragona   | | 44  | Teruel   | | 45  | Toledo   | | 46  | València/Valencia   | | 47  | Valladolid   | | 49  | Zamora   | | 50  | Zaragoza   | |  | 
 **fecha** | **string**| Día de elaboración (AAAA-MM-DD) | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prediccinprovinciamaanatiempoactual_"></a>
# **PrediccinProvinciaMaanaTiempoActual_**
> Model200 PrediccinProvinciaMaanaTiempoActual_ (string provincia)

Predicción provincia mañana. Tiempo actual.

Predicción del día siguiente para la provincia que se pasa como parámetro. En el caso de que este producto no se haya elaborado todavía en el día actual, se retorna el último elaborado. Actualización continua y fija a las 14:00 Hora Oficial Peninsular.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrediccinProvinciaMaanaTiempoActual_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new PrediccionesNormalizadasTextoApi();
            var provincia = provincia_example;  // string |  | Código Provincia | Provincia | |- -- -- -- -- -|- -- -- -- -- -| | 01  | Araba/Álaba   | | 01  | Araba/Álava   | | 02  | Albacete   | | 03  | Alacant/Alicante  | | 04  | Almería   | | 33  | Asturias   | | 05  | Ávila   | | 06  | Badajoz   | | 07  | Illes Ballears   | | 08  | Barcelona   | | 48  | Bizkaia   | | 09  | Burgos   | | 10  | Cáceres   | | 11  | Cádiz   | | 39  | Cantabria   | | 12  | Castelló/Castellón   | | 51  | Ceuta   | | 13  | Ciudad Real   | | 14  | Córdoba   | | 15  | A Coruña   | | 16  | Cuenca   | | 17  | Girona   | | 18  | Granada   | | 19  | Guadalajara   | | 20  | Gipuzkoa   | | 21  | Huelva   | | 22  | Huesca   | | 23  | Jaén   | | 24  | León   | | 25  | Lleida   | | 27  | Lugo   | | 28  | Madrid   | | 29  | Málaga   | | 52  | Melilla   | | 30  | Murcia   | | 31  | Navarra   | | 32  | Oursense   | | 34  | Palencia   | | 35  | Las Palmas   | | 36  | Pontevedra   | | 26  | La Rioja   | | 37  | Salamanca   | | 38  | Santa Cruz de Tenerife   | | 40  | Segovia   | | 41  | Sevilla   | | 42  | Soria   | | 43  | Tarragona   | | 44  | Teruel   | | 45  | Toledo   | | 46  | València/Valencia   | | 47  | Valladolid   | | 49  | Zamora   | | 50  | Zaragoza   | | 

            try
            {
                // Predicción provincia mañana. Tiempo actual.
                Model200 result = apiInstance.PrediccinProvinciaMaanaTiempoActual_(provincia);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrediccionesNormalizadasTextoApi.PrediccinProvinciaMaanaTiempoActual_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **provincia** | **string**|  | Código Provincia | Provincia | |- -- -- -- -- -|- -- -- -- -- -| | 01  | Araba/Álaba   | | 01  | Araba/Álava   | | 02  | Albacete   | | 03  | Alacant/Alicante  | | 04  | Almería   | | 33  | Asturias   | | 05  | Ávila   | | 06  | Badajoz   | | 07  | Illes Ballears   | | 08  | Barcelona   | | 48  | Bizkaia   | | 09  | Burgos   | | 10  | Cáceres   | | 11  | Cádiz   | | 39  | Cantabria   | | 12  | Castelló/Castellón   | | 51  | Ceuta   | | 13  | Ciudad Real   | | 14  | Córdoba   | | 15  | A Coruña   | | 16  | Cuenca   | | 17  | Girona   | | 18  | Granada   | | 19  | Guadalajara   | | 20  | Gipuzkoa   | | 21  | Huelva   | | 22  | Huesca   | | 23  | Jaén   | | 24  | León   | | 25  | Lleida   | | 27  | Lugo   | | 28  | Madrid   | | 29  | Málaga   | | 52  | Melilla   | | 30  | Murcia   | | 31  | Navarra   | | 32  | Oursense   | | 34  | Palencia   | | 35  | Las Palmas   | | 36  | Pontevedra   | | 26  | La Rioja   | | 37  | Salamanca   | | 38  | Santa Cruz de Tenerife   | | 40  | Segovia   | | 41  | Sevilla   | | 42  | Soria   | | 43  | Tarragona   | | 44  | Teruel   | | 45  | Toledo   | | 46  | València/Valencia   | | 47  | Valladolid   | | 49  | Zamora   | | 50  | Zaragoza   | |  | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

