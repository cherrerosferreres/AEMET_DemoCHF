# IO.Swagger - the C# library for the AEMET OpenData

AEMET OpenData es una API REST desarrollado por AEMET que permite la difusión y la reutilización de la información meteorológica y climatológica de la Agencia, en el sentido indicado en la Ley 18/2015, de 9 de julio, por la que se modifica la Ley 37/2007, de 16 de noviembre, sobre reutilización de la información del sector público. (IMPORTANTE: Para poder realizar peticiones, es necesario introducir en API Key haciendo clic en el círculo rojo de recurso REST).

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 2.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.Swagger.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api_key", "Bearer");

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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://opendata.aemet.es/opendata*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AvisosCapApi* | [**AvisosDeFenmenosMeteorolgicosAdversosArchivo**](docs/AvisosCapApi.md#avisosdefenmenosmeteorolgicosadversosarchivo) | **GET** /api/avisos_cap/archivo/fechaini/{fechaIniStr}/fechafin/{fechaFinStr} | Avisos de Fenómenos Meteorológicos Adversos. Archivo.
*AvisosCapApi* | [**AvisosDeFenmenosMeteorolgicosAdversosLtimo_**](docs/AvisosCapApi.md#avisosdefenmenosmeteorolgicosadversosltimo_) | **GET** /api/avisos_cap/ultimoelaborado/area/{area} | Avisos de Fenómenos Meteorológicos Adversos. Último.
*IndicesIncendiosApi* | [**MapaDeNivelesDeRiesgoEstimadoMeteorolgicoDeIncendiosForestales_**](docs/IndicesIncendiosApi.md#mapadenivelesderiesgoestimadometeorolgicodeincendiosforestales_) | **GET** /api/incendios/mapasriesgo/estimado/area/{area} | Mapa de niveles de riesgo estimado meteorológico de incendios forestales.
*IndicesIncendiosApi* | [**MapaDeNivelesDeRiesgoPrevistoMeteorolgicoDeIncendiosForestales_**](docs/IndicesIncendiosApi.md#mapadenivelesderiesgoprevistometeorolgicodeincendiosforestales_) | **GET** /api/incendios/mapasriesgo/previsto/dia/{dia}/area/{area} | Mapa de niveles de riesgo previsto meteorológico de incendios forestales.
*InformacionSateliteApi* | [**NdiceNormalizadoDeVegetacin_**](docs/InformacionSateliteApi.md#ndicenormalizadodevegetacin_) | **GET** /api/satelites/producto/nvdi | Índice normalizado de vegetación.
*InformacionSateliteApi* | [**TemperaturaDelAguaDelMar_**](docs/InformacionSateliteApi.md#temperaturadelaguadelmar_) | **GET** /api/satelites/producto/sst | Temperatura del agua del mar.
*MaestroApi* | [**GetMunicipioUsingGET**](docs/MaestroApi.md#getmunicipiousingget) | **GET** /api/maestro/municipio/{municipio} | getMunicipio
*MaestroApi* | [**GetMunicipiosUsingGET**](docs/MaestroApi.md#getmunicipiosusingget) | **GET** /api/maestro/municipios | getMunicipios
*MapasYGraficosApi* | [**MapasDeAnlisisLtimaPasada_**](docs/MapasYGraficosApi.md#mapasdeanlisisltimapasada_) | **GET** /api/mapasygraficos/analisis | Mapas de análisis. Última pasada.
*MapasYGraficosApi* | [**MapasSignificativosTiempoActual1**](docs/MapasYGraficosApi.md#mapassignificativostiempoactual1) | **GET** /api/mapasygraficos/mapassignificativos/{ambito}/{dia} | Mapas significativos. Tiempo actual.
*MapasYGraficosApi* | [**MapasSignificativosTiempoActual_**](docs/MapasYGraficosApi.md#mapassignificativostiempoactual_) | **GET** /api/mapasygraficos/mapassignificativos/fecha/{fecha}/{ambito}/{dia} | Mapas significativos. Tiempo actual.
*ObservacionConvencionalApi* | [**DatosDeObservacinTiempoActual1**](docs/ObservacionConvencionalApi.md#datosdeobservacintiempoactual1) | **GET** /api/observacion/convencional/datos/estacion/{idema} | Datos de observación. Tiempo actual.
*ObservacionConvencionalApi* | [**DatosDeObservacinTiempoActual_**](docs/ObservacionConvencionalApi.md#datosdeobservacintiempoactual_) | **GET** /api/observacion/convencional/todas | Datos de observación. Tiempo actual.
*ObservacionConvencionalApi* | [**MensajesDeObservacinLtimoElaborado_**](docs/ObservacionConvencionalApi.md#mensajesdeobservacinltimoelaborado_) | **GET** /api/observacion/convencional/mensajes/tipomensaje/{tipomensaje} | Mensajes de observación. Último elaborado.
*PrediccionMaritimaApi* | [**PrediccinMartimaCostera_**](docs/PrediccionMaritimaApi.md#prediccinmartimacostera_) | **GET** /api/prediccion/maritima/costera/costa/{costa} | Predicción marítima costera.
*PrediccionMaritimaApi* | [**PrediccinMartimaDeAltaMar_**](docs/PrediccionMaritimaApi.md#prediccinmartimadealtamar_) | **GET** /api/prediccion/maritima/altamar/area/{area} | Predicción marítima de alta mar.
*PrediccionesEspecificasApi* | [**InformacionNivologica_**](docs/PrediccionesEspecificasApi.md#informacionnivologica_) | **GET** /api/prediccion/especifica/nivologica/{area} | Información nivológica.
*PrediccionesEspecificasApi* | [**PrediccinDeMontaaTiempoActual_**](docs/PrediccionesEspecificasApi.md#prediccindemontaatiempoactual_) | **GET** /api/prediccion/especifica/montaña/pasada/area/{area}/dia/{dia} | Predicción de montaña. Tiempo actual.
*PrediccionesEspecificasApi* | [**PrediccinDeMontaaTiempoPasado_**](docs/PrediccionesEspecificasApi.md#prediccindemontaatiempopasado_) | **GET** /api/prediccion/especifica/montaña/pasada/area/{area} | Predicción de montaña. Tiempo pasado.
*PrediccionesEspecificasApi* | [**PrediccinDeRadiacinUltravioletaUVI_**](docs/PrediccionesEspecificasApi.md#prediccinderadiacinultravioletauvi_) | **GET** /api/prediccion/especifica/uvi/{dia} | Predicción de radiación ultravioleta (UVI).
*PrediccionesEspecificasApi* | [**PrediccinParaLasPlayasTiempoActual_**](docs/PrediccionesEspecificasApi.md#prediccinparalasplayastiempoactual_) | **GET** /api/prediccion/especifica/playa/{playa} | Predicción para las playas. Tiempo actual.
*PrediccionesEspecificasApi* | [**PrediccinPorMunicipiosDiariaTiempoActual_**](docs/PrediccionesEspecificasApi.md#prediccinpormunicipiosdiariatiempoactual_) | **GET** /api/prediccion/especifica/municipio/diaria/{municipio} | Predicción por municipios diaria. Tiempo actual.
*PrediccionesEspecificasApi* | [**PrediccinPorMunicipiosHorariaTiempoActual_**](docs/PrediccionesEspecificasApi.md#prediccinpormunicipioshorariatiempoactual_) | **GET** /api/prediccion/especifica/municipio/horaria/{municipio} | Predicción por municipios horaria. Tiempo actual.
*PrediccionesNormalizadasTextoApi* | [**PrediccinCCAAHoyArchivo_**](docs/PrediccionesNormalizadasTextoApi.md#prediccinccaahoyarchivo_) | **GET** /api/prediccion/ccaa/hoy/{ccaa}/elaboracion/{fecha} | Predicción CCAA hoy. Archivo.
*PrediccionesNormalizadasTextoApi* | [**PrediccinCCAAHoyTiempoActual_**](docs/PrediccionesNormalizadasTextoApi.md#prediccinccaahoytiempoactual_) | **GET** /api/prediccion/ccaa/hoy/{ccaa} | Predicción CCAA hoy. Tiempo actual.
*PrediccionesNormalizadasTextoApi* | [**PrediccinCCAAMaanaArchivo_**](docs/PrediccionesNormalizadasTextoApi.md#prediccinccaamaanaarchivo_) | **GET** /api/prediccion/ccaa/manana/{ccaa}/elaboracion/{fecha} | Predicción CCAA mañana. Archivo.
*PrediccionesNormalizadasTextoApi* | [**PrediccinCCAAMaanaTiempoActual_**](docs/PrediccionesNormalizadasTextoApi.md#prediccinccaamaanatiempoactual_) | **GET** /api/prediccion/ccaa/manana/{ccaa} | Predicción CCAA mañana. Tiempo actual.
*PrediccionesNormalizadasTextoApi* | [**PrediccinCCAAMedioPlazoArchivo_**](docs/PrediccionesNormalizadasTextoApi.md#prediccinccaamedioplazoarchivo_) | **GET** /api/prediccion/ccaa/medioplazo/{ccaa}/elaboracion/{fecha} | Predicción CCAA medio plazo. Archivo.
*PrediccionesNormalizadasTextoApi* | [**PrediccinCCAAMedioPlazoTiempoActual_**](docs/PrediccionesNormalizadasTextoApi.md#prediccinccaamedioplazotiempoactual_) | **GET** /api/prediccion/ccaa/medioplazo/{ccaa} | Predicción CCAA medio plazo. Tiempo actual.
*PrediccionesNormalizadasTextoApi* | [**PrediccinCCAAPasadoMaanaArchivo_**](docs/PrediccionesNormalizadasTextoApi.md#prediccinccaapasadomaanaarchivo_) | **GET** /api/prediccion/ccaa/pasadomanana/{ccaa}/elaboracion/{fecha} | Predicción CCAA pasado mañana. Archivo.
*PrediccionesNormalizadasTextoApi* | [**PrediccinCCAAPasadoMaanaTiempoActual_**](docs/PrediccionesNormalizadasTextoApi.md#prediccinccaapasadomaanatiempoactual_) | **GET** /api/prediccion/ccaa/pasadomanana/{ccaa} | Predicción CCAA pasado mañana. Tiempo actual.
*PrediccionesNormalizadasTextoApi* | [**PrediccinNacionalHoyArchivo_**](docs/PrediccionesNormalizadasTextoApi.md#prediccinnacionalhoyarchivo_) | **GET** /api/prediccion/nacional/hoy/elaboracion/{fecha} | Predicción nacional hoy. Archivo.
*PrediccionesNormalizadasTextoApi* | [**PrediccinNacionalHoyTiempoActual_**](docs/PrediccionesNormalizadasTextoApi.md#prediccinnacionalhoytiempoactual_) | **GET** /api/prediccion/nacional/hoy | Predicción nacional hoy. Última elaborada.
*PrediccionesNormalizadasTextoApi* | [**PrediccinNacionalMaanaArchivo_**](docs/PrediccionesNormalizadasTextoApi.md#prediccinnacionalmaanaarchivo_) | **GET** /api/prediccion/nacional/manana/elaboracion/{fecha} | Predicción nacional mañana. Archivo.
*PrediccionesNormalizadasTextoApi* | [**PrediccinNacionalMaanaTiempoActual_**](docs/PrediccionesNormalizadasTextoApi.md#prediccinnacionalmaanatiempoactual_) | **GET** /api/prediccion/nacional/manana | Predicción nacional mañana. Tiempo actual.
*PrediccionesNormalizadasTextoApi* | [**PrediccinNacionalMedioPlazoArchivo_**](docs/PrediccionesNormalizadasTextoApi.md#prediccinnacionalmedioplazoarchivo_) | **GET** /api/prediccion/nacional/medioplazo/elaboracion/{fecha} | Predicción nacional medio plazo. Archivo.
*PrediccionesNormalizadasTextoApi* | [**PrediccinNacionalMedioPlazoTiempoActual_**](docs/PrediccionesNormalizadasTextoApi.md#prediccinnacionalmedioplazotiempoactual_) | **GET** /api/prediccion/nacional/medioplazo | Predicción nacional medio plazo. Tiempo actual.
*PrediccionesNormalizadasTextoApi* | [**PrediccinNacionalPasadoMaanaArchivo_**](docs/PrediccionesNormalizadasTextoApi.md#prediccinnacionalpasadomaanaarchivo_) | **GET** /api/prediccion/nacional/pasadomanana/elaboracion/{fecha} | Predicción nacional pasado mañana. Archivo.
*PrediccionesNormalizadasTextoApi* | [**PrediccinNacionalPasadoMaanaTiempoActual_**](docs/PrediccionesNormalizadasTextoApi.md#prediccinnacionalpasadomaanatiempoactual_) | **GET** /api/prediccion/nacional/pasadomanana | Predicción nacional pasado mañana. Tiempo actual.
*PrediccionesNormalizadasTextoApi* | [**PrediccinNacionalTendenciaArchivo_**](docs/PrediccionesNormalizadasTextoApi.md#prediccinnacionaltendenciaarchivo_) | **GET** /api/prediccion/nacional/tendencia/elaboracion/{fecha} | Predicción nacional tendencia. Archivo.
*PrediccionesNormalizadasTextoApi* | [**PrediccinNacionalTendenciaTiempoActual_**](docs/PrediccionesNormalizadasTextoApi.md#prediccinnacionaltendenciatiempoactual_) | **GET** /api/prediccion/nacional/tendencia | Predicción nacional tendencia. Tiempo actual.
*PrediccionesNormalizadasTextoApi* | [**PrediccinProvinciaHoyArchivo_**](docs/PrediccionesNormalizadasTextoApi.md#prediccinprovinciahoyarchivo_) | **GET** /api/prediccion/provincia/hoy/{provincia}/elaboracion/{fecha} | Predicción provincia hoy. Archivo.
*PrediccionesNormalizadasTextoApi* | [**PrediccinProvinciaHoyTiempoActual_**](docs/PrediccionesNormalizadasTextoApi.md#prediccinprovinciahoytiempoactual_) | **GET** /api/prediccion/provincia/hoy/{provincia} | Predicción provincia hoy. Tiempo actual.
*PrediccionesNormalizadasTextoApi* | [**PrediccinProvinciaMaanaArchivo_**](docs/PrediccionesNormalizadasTextoApi.md#prediccinprovinciamaanaarchivo_) | **GET** /api/prediccion/provincia/manana/{provincia}/elaboracion/{fecha} | Predicción provincia mañana. Archivo.
*PrediccionesNormalizadasTextoApi* | [**PrediccinProvinciaMaanaTiempoActual_**](docs/PrediccionesNormalizadasTextoApi.md#prediccinprovinciamaanatiempoactual_) | **GET** /api/prediccion/provincia/manana/{provincia} | Predicción provincia mañana. Tiempo actual.
*ProductosClimatologicosApi* | [**BalanceHdricoNacionalDocumento_**](docs/ProductosClimatologicosApi.md#balancehdriconacionaldocumento_) | **GET** /api/productos/climatologicos/balancehidrico/{anio}/{decena} | Balance hídrico nacional (documento).
*ProductosClimatologicosApi* | [**CapasSHAPEDeEstacionesClimatolgicas_**](docs/ProductosClimatologicosApi.md#capasshapedeestacionesclimatolgicas_) | **GET** /api/productos/climatologicos/capasshape/{tipoestacion} | Capas SHAPE de estaciones climatológicas de AEMET.
*ProductosClimatologicosApi* | [**ResumenMensualClimatolgicoNacionalDocumento_**](docs/ProductosClimatologicosApi.md#resumenmensualclimatolgiconacionaldocumento_) | **GET** /api/productos/climatologicos/resumenclimatologico/nacional/{anio}/{mes} | Resumen mensual climatológico nacional (documento).
*RedRadaresApi* | [**ImagenComposicinNacionalRadaresTiempoActualEstndar_**](docs/RedRadaresApi.md#imagencomposicinnacionalradarestiempoactualestndar_) | **GET** /api/red/radar/nacional | Imagen composición nacional radares. Tiempo actual estándar.
*RedRadaresApi* | [**RadarRegional**](docs/RedRadaresApi.md#radarregional) | **GET** /api/red/radar/regional/{radar} | Imagen gráfica radar regional. Tiempo actual estándar.
*RedRayosApi* | [**MapaConLosRayosRegistradosEnPeriodoStandardLtimoElaborado_**](docs/RedRayosApi.md#mapaconlosrayosregistradosenperiodostandardltimoelaborado_) | **GET** /api/red/rayos/mapa | Mapa con los rayos registrados en periodo standard. Último elaborado.
*RedesEspecialesApi* | [**ContenidoTotalDeOzonoTiempoActual_**](docs/RedesEspecialesApi.md#contenidototaldeozonotiempoactual_) | **GET** /api/red/especial/ozono | Contenido total de ozono. Tiempo actual.
*RedesEspecialesApi* | [**DatosDeContaminacinDeFondoTiempoActual_**](docs/RedesEspecialesApi.md#datosdecontaminacindefondotiempoactual_) | **GET** /api/red/especial/contaminacionfondo/estacion/{nombre_estacion} | Datos de contaminación de fondo. Tiempo actual.
*RedesEspecialesApi* | [**DatosDeRadiacinGlobalDirectaODifusaTiempoActual_**](docs/RedesEspecialesApi.md#datosderadiacinglobaldirectaodifusatiempoactual_) | **GET** /api/red/especial/radiacion | Datos de radiación global, directa o difusa. Tiempo actual.
*RedesEspecialesApi* | [**PerfilesVerticalesDeOzonoTiempoActual_**](docs/RedesEspecialesApi.md#perfilesverticalesdeozonotiempoactual_) | **GET** /api/red/especial/perfilozono/estacion/{estacion} | Perfiles verticales de ozono. Tiempo actual.
*ValoresClimatologicosApi* | [**ClimatologasDiarias1**](docs/ValoresClimatologicosApi.md#climatologasdiarias1) | **GET** /api/valores/climatologicos/diarios/datos/fechaini/{fechaIniStr}/fechafin/{fechaFinStr}/todasestaciones | Climatologías diarias.
*ValoresClimatologicosApi* | [**ClimatologasDiarias_**](docs/ValoresClimatologicosApi.md#climatologasdiarias_) | **GET** /api/valores/climatologicos/diarios/datos/fechaini/{fechaIniStr}/fechafin/{fechaFinStr}/estacion/{idema} | Climatologías diarias.
*ValoresClimatologicosApi* | [**ClimatologasMensualesAnuales_**](docs/ValoresClimatologicosApi.md#climatologasmensualesanuales_) | **GET** /api/valores/climatologicos/mensualesanuales/datos/anioini/{anioIniStr}/aniofin/{anioFinStr}/estacion/{idema} | Climatologías mensuales anuales.
*ValoresClimatologicosApi* | [**ClimatologasNormales19812010_**](docs/ValoresClimatologicosApi.md#climatologasnormales19812010_) | **GET** /api/valores/climatologicos/normales/estacion/{idema} | Climatologías normales (1981-2010).
*ValoresClimatologicosApi* | [**EstacionesPorIndicativo_**](docs/ValoresClimatologicosApi.md#estacionesporindicativo_) | **GET** /api/valores/climatologicos/inventarioestaciones/estaciones/{estaciones} | Estaciones por indicativo.
*ValoresClimatologicosApi* | [**InventarioDeEstacionesValoresClimatolgicos_**](docs/ValoresClimatologicosApi.md#inventariodeestacionesvaloresclimatolgicos_) | **GET** /api/valores/climatologicos/inventarioestaciones/todasestaciones | Inventario de estaciones (valores climatológicos).
*ValoresClimatologicosApi* | [**ValoresExtremos_**](docs/ValoresClimatologicosApi.md#valoresextremos_) | **GET** /api/valores/climatologicos/valoresextremos/parametro/{parametro}/estacion/{idema} | Valores extremos.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Model200](docs/Model200.md)
 - [Model.Model401](docs/Model401.md)
 - [Model.Model404](docs/Model404.md)
 - [Model.Model429](docs/Model429.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="api_key"></a>
### api_key

- **Type**: API key
- **API key parameter name**: api_key
- **Location**: HTTP header

