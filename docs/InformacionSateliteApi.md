# IO.Swagger.Api.InformacionSateliteApi

All URIs are relative to *https://opendata.aemet.es/opendata*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NdiceNormalizadoDeVegetacin_**](InformacionSateliteApi.md#ndicenormalizadodevegetacin_) | **GET** /api/satelites/producto/nvdi | Índice normalizado de vegetación.
[**TemperaturaDelAguaDelMar_**](InformacionSateliteApi.md#temperaturadelaguadelmar_) | **GET** /api/satelites/producto/sst | Temperatura del agua del mar.


<a name="ndicenormalizadodevegetacin_"></a>
# **NdiceNormalizadoDeVegetacin_**
> Model200 NdiceNormalizadoDeVegetacin_ ()

Índice normalizado de vegetación.

Esta imagen se realiza con una combinación de los datos del canal visible y del infrarrojo cercano del satélite NOAA-19, que nos da una idea del desarrollo de la vegetación. Esto es así debido a que la vegetación absorbe fuertemente la radiación del canal visible, pero refleja fuertemente la del infrarrojo cercano. Esta imagen se renueva los jueves a última hora y contiene los datos acumulados de la última semana.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class NdiceNormalizadoDeVegetacin_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InformacionSateliteApi();

            try
            {
                // Índice normalizado de vegetación.
                Model200 result = apiInstance.NdiceNormalizadoDeVegetacin_();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InformacionSateliteApi.NdiceNormalizadoDeVegetacin_: " + e.Message );
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

<a name="temperaturadelaguadelmar_"></a>
# **TemperaturaDelAguaDelMar_**
> Model200 TemperaturaDelAguaDelMar_ ()

Temperatura del agua del mar.

Imagen obtenida con una combinación de los datos de los canales infrarrojos del satélite NOAA-19, que nos da la temperatura de la superficie del mar. Esta imagen se renueva todos los días a última hora y contiene los datos acumulados de los últimos siete días.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TemperaturaDelAguaDelMar_Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new InformacionSateliteApi();

            try
            {
                // Temperatura del agua del mar.
                Model200 result = apiInstance.TemperaturaDelAguaDelMar_();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InformacionSateliteApi.TemperaturaDelAguaDelMar_: " + e.Message );
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

