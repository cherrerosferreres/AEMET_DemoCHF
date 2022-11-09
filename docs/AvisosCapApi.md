# IO.Swagger.Api.AvisosCapApi

All URIs are relative to *https://opendata.aemet.es/opendata*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AvisosDeFenmenosMeteorolgicosAdversosArchivo**](AvisosCapApi.md#avisosdefenmenosmeteorolgicosadversosarchivo) | **GET** /api/avisos_cap/archivo/fechaini/{fechaIniStr}/fechafin/{fechaFinStr} | Avisos de Fenómenos Meteorológicos Adversos. Archivo.
[**AvisosDeFenmenosMeteorolgicosAdversosLtimo_**](AvisosCapApi.md#avisosdefenmenosmeteorolgicosadversosltimo_) | **GET** /api/avisos_cap/ultimoelaborado/area/{area} | Avisos de Fenómenos Meteorológicos Adversos. Último.


<a name="avisosdefenmenosmeteorolgicosadversosarchivo"></a>
# **AvisosDeFenmenosMeteorolgicosAdversosArchivo**
> Model200 AvisosDeFenmenosMeteorolgicosAdversosArchivo (string fechaIniStr, string fechaFinStr)

Avisos de Fenómenos Meteorológicos Adversos. Archivo.

 Avisos de Fenómenos Meteorológicos adversos para el rango de fechas seleccionado (datos desde 18/06/2018).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AvisosDeFenmenosMeteorolgicosAdversosArchivoExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AvisosCapApi();
            var fechaIniStr = fechaIniStr_example;  // string | Fecha Inicial (AAAA-MM-DDTHH:MM:SSUTC)
            var fechaFinStr = fechaFinStr_example;  // string | Fecha Final (AAAA-MM-DDTHH:MM:SSUTC)

            try
            {
                // Avisos de Fenómenos Meteorológicos Adversos. Archivo.
                Model200 result = apiInstance.AvisosDeFenmenosMeteorolgicosAdversosArchivo(fechaIniStr, fechaFinStr);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AvisosCapApi.AvisosDeFenmenosMeteorolgicosAdversosArchivo: " + e.Message );
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

<a name="avisosdefenmenosmeteorolgicosadversosltimo_"></a>
# **AvisosDeFenmenosMeteorolgicosAdversosLtimo_**
> Model200 AvisosDeFenmenosMeteorolgicosAdversosLtimo_ (string area)

Avisos de Fenómenos Meteorológicos Adversos. Último.

 Últimos Avisos de Fenómenos Meteorológicos adversos elaborado para el área seleccionada.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AvisosDeFenmenosMeteorolgicosAdversosLtimo_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new AvisosCapApi();
            var area = area_example;  // string |  | Código | Área | |- -- -- -- -- -|- -- -- -- -- -| | esp  | España| | 61  | Andalucía   | | 62  | Aragón   | | 63  | Asturias, Principado de  | | 64  | Ballears, Illes   | | 78  | Ceuta   | | 65  | Canarias   | | 66  | Cantabria   | | 67  | Castilla y León   | | 68  | Castilla - La Mancha   | | 69  | Cataluña   | | 77  | Comunitat Valenciana   | | 70  | Extremadura   | | 71  | Galicia   | | 72  | Madrid, Comunidad de    | | 79  | Melilla   | | 73  | Murcia, Región de   | | 74  | Navarra, Comunidad Foral de   | | 75  | País Vasco | | 76  | Rioja, La

            try
            {
                // Avisos de Fenómenos Meteorológicos Adversos. Último.
                Model200 result = apiInstance.AvisosDeFenmenosMeteorolgicosAdversosLtimo_(area);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AvisosCapApi.AvisosDeFenmenosMeteorolgicosAdversosLtimo_: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **area** | **string**|  | Código | Área | |- -- -- -- -- -|- -- -- -- -- -| | esp  | España| | 61  | Andalucía   | | 62  | Aragón   | | 63  | Asturias, Principado de  | | 64  | Ballears, Illes   | | 78  | Ceuta   | | 65  | Canarias   | | 66  | Cantabria   | | 67  | Castilla y León   | | 68  | Castilla - La Mancha   | | 69  | Cataluña   | | 77  | Comunitat Valenciana   | | 70  | Extremadura   | | 71  | Galicia   | | 72  | Madrid, Comunidad de    | | 79  | Melilla   | | 73  | Murcia, Región de   | | 74  | Navarra, Comunidad Foral de   | | 75  | País Vasco | | 76  | Rioja, La | 

### Return type

[**Model200**](Model200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

