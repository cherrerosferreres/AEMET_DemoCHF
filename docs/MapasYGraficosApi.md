# IO.Swagger.Api.MapasYGraficosApi

All URIs are relative to *https://opendata.aemet.es/opendata*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MapasDeAnlisisLtimaPasada_**](MapasYGraficosApi.md#mapasdeanlisisltimapasada_) | **GET** /api/mapasygraficos/analisis | Mapas de análisis. Última pasada.
[**MapasSignificativosTiempoActual1**](MapasYGraficosApi.md#mapassignificativostiempoactual1) | **GET** /api/mapasygraficos/mapassignificativos/{ambito}/{dia} | Mapas significativos. Tiempo actual.
[**MapasSignificativosTiempoActual_**](MapasYGraficosApi.md#mapassignificativostiempoactual_) | **GET** /api/mapasygraficos/mapassignificativos/fecha/{fecha}/{ambito}/{dia} | Mapas significativos. Tiempo actual.


<a name="mapasdeanlisisltimapasada_"></a>
# **MapasDeAnlisisLtimaPasada_**
> Model200 MapasDeAnlisisLtimaPasada_ ()

Mapas de análisis. Última pasada.

Estos mapas muestran la configuración de la presión en superficie usando isobaras (lineas de igual presión), áreas de alta (A, a) y baja (B, b) presión y los frentes en Europa y el Atlántico Norte.El mapa de análisis presenta el estado de la atmósfera a la hora correspondiente y los fenómenos más relevantes observados en España. Periodicidad de actualización: cada 12 horas (00, 12).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MapasDeAnlisisLtimaPasada_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new MapasYGraficosApi();

            try
            {
                // Mapas de análisis. Última pasada.
                Model200 result = apiInstance.MapasDeAnlisisLtimaPasada_();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MapasYGraficosApi.MapasDeAnlisisLtimaPasada_: " + e.Message );
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

<a name="mapassignificativostiempoactual1"></a>
# **MapasSignificativosTiempoActual1**
> Model200 MapasSignificativosTiempoActual1 (string ambito, string dia)

Mapas significativos. Tiempo actual.

Mapas significativos de ámbito nacional o CCAA, para el día actual (D+0),  al día siguiente (D+1) o a los dos días (D+2), en el periodo horario de (00_12) ó (12-24).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MapasSignificativosTiempoActual1Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new MapasYGraficosApi();
            var ambito = ambito_example;  // string |  | Código | Ámbito | |- -- -- -- -- -|- -- -- -- -- -| | esp  | España| | and  | Andalucía   | | arn  | Aragón   | | ast  | Asturias  | | bal  | Ballears, Illes   | | coo  | Canarias   | | can  | Cantabria   | | cle  | Castilla y León   | | clm  | Castilla - La Mancha   | | cat  | Cataluña   | | val  | Comunitat Valenciana   | | ext  | Extremadura   | | gal  | Galicia   | | mad  | Madrid, Comunidad de    | | mur  | Murcia, Región de   | | nav  | Navarra, Comunidad Foral de   | | pva  | País Vasco | | rio  | Rioja, La
            var dia = dia_example;  // string |  | Código de día | Día | |- -- -- -- -- -|- -- -- -- -- -| | a | D+0 (00-12)  | | b  | D+0 (00-12)   | |  c | D+1 (00-12)  | | d  | D+1 (12-24) | | e  | D+2 (00-12) | | f  | D+2 (12-24)

            try
            {
                // Mapas significativos. Tiempo actual.
                Model200 result = apiInstance.MapasSignificativosTiempoActual1(ambito, dia);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MapasYGraficosApi.MapasSignificativosTiempoActual1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ambito** | **string**|  | Código | Ámbito | |- -- -- -- -- -|- -- -- -- -- -| | esp  | España| | and  | Andalucía   | | arn  | Aragón   | | ast  | Asturias  | | bal  | Ballears, Illes   | | coo  | Canarias   | | can  | Cantabria   | | cle  | Castilla y León   | | clm  | Castilla - La Mancha   | | cat  | Cataluña   | | val  | Comunitat Valenciana   | | ext  | Extremadura   | | gal  | Galicia   | | mad  | Madrid, Comunidad de    | | mur  | Murcia, Región de   | | nav  | Navarra, Comunidad Foral de   | | pva  | País Vasco | | rio  | Rioja, La | 
 **dia** | **string**|  | Código de día | Día | |- -- -- -- -- -|- -- -- -- -- -| | a | D+0 (00-12)  | | b  | D+0 (00-12)   | |  c | D+1 (00-12)  | | d  | D+1 (12-24) | | e  | D+2 (00-12) | | f  | D+2 (12-24) | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mapassignificativostiempoactual_"></a>
# **MapasSignificativosTiempoActual_**
> Model200 MapasSignificativosTiempoActual_ (string fecha, string ambito, string dia)

Mapas significativos. Tiempo actual.

Mapas significativos de ámbito nacional o CCAA, para una fecha dada y ese mismo día (D+0),  al día siguiente (D+1) o a los dos días (D+2), en el periodo horario de (00_12) ó (12-24).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MapasSignificativosTiempoActual_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new MapasYGraficosApi();
            var fecha = fecha_example;  // string | Fecha de elaboración (AAAA-MM-DD)
            var ambito = ambito_example;  // string |  | Código | Ámbito | |- -- -- -- -- -|- -- -- -- -- -| | esp  | España| | and  | Andalucía   | | arn  | Aragón   | | ast  | Asturias  | | bal  | Ballears, Illes   | | coo  | Canarias   | | can  | Cantabria   | | cle  | Castilla y León   | | clm  | Castilla - La Mancha   | | cat  | Cataluña   | | val  | Comunitat Valenciana   | | ext  | Extremadura   | | gal  | Galicia   | | mad  | Madrid, Comunidad de    | | mur  | Murcia, Región de   | | nav  | Navarra, Comunidad Foral de   | | pva  | País Vasco | | rio  | Rioja, La
            var dia = dia_example;  // string |  | Código de día | Día | |- -- -- -- -- -|- -- -- -- -- -| | a | D+0 (00-12)  | | b  | D+0 (00-12)   | |  c | D+1 (00-12)  | | d  | D+1 (12-24) | | e  | D+2 (00-12) | | f  | D+2 (12-24)

            try
            {
                // Mapas significativos. Tiempo actual.
                Model200 result = apiInstance.MapasSignificativosTiempoActual_(fecha, ambito, dia);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MapasYGraficosApi.MapasSignificativosTiempoActual_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fecha** | **string**| Fecha de elaboración (AAAA-MM-DD) | 
 **ambito** | **string**|  | Código | Ámbito | |- -- -- -- -- -|- -- -- -- -- -| | esp  | España| | and  | Andalucía   | | arn  | Aragón   | | ast  | Asturias  | | bal  | Ballears, Illes   | | coo  | Canarias   | | can  | Cantabria   | | cle  | Castilla y León   | | clm  | Castilla - La Mancha   | | cat  | Cataluña   | | val  | Comunitat Valenciana   | | ext  | Extremadura   | | gal  | Galicia   | | mad  | Madrid, Comunidad de    | | mur  | Murcia, Región de   | | nav  | Navarra, Comunidad Foral de   | | pva  | País Vasco | | rio  | Rioja, La | 
 **dia** | **string**|  | Código de día | Día | |- -- -- -- -- -|- -- -- -- -- -| | a | D+0 (00-12)  | | b  | D+0 (00-12)   | |  c | D+1 (00-12)  | | d  | D+1 (12-24) | | e  | D+2 (00-12) | | f  | D+2 (12-24) | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

