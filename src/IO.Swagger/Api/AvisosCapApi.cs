/* 
 * AEMET OpenData
 *
 * AEMET OpenData es una API REST desarrollado por AEMET que permite la difusión y la reutilización de la información meteorológica y climatológica de la Agencia, en el sentido indicado en la Ley 18/2015, de 9 de julio, por la que se modifica la Ley 37/2007, de 16 de noviembre, sobre reutilización de la información del sector público. (IMPORTANTE: Para poder realizar peticiones, es necesario introducir en API Key haciendo clic en el círculo rojo de recurso REST).
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAvisosCapApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Avisos de Fenómenos Meteorológicos Adversos. Archivo.
        /// </summary>
        /// <remarks>
        ///  Avisos de Fenómenos Meteorológicos adversos para el rango de fechas seleccionado (datos desde 18/06/2018).
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fechaIniStr">Fecha Inicial (AAAA-MM-DDTHH:MM:SSUTC)</param>
        /// <param name="fechaFinStr">Fecha Final (AAAA-MM-DDTHH:MM:SSUTC)</param>
        /// <returns>Model200</returns>
        Model200 AvisosDeFenmenosMeteorolgicosAdversosArchivo (string fechaIniStr, string fechaFinStr);

        /// <summary>
        /// Avisos de Fenómenos Meteorológicos Adversos. Archivo.
        /// </summary>
        /// <remarks>
        ///  Avisos de Fenómenos Meteorológicos adversos para el rango de fechas seleccionado (datos desde 18/06/2018).
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fechaIniStr">Fecha Inicial (AAAA-MM-DDTHH:MM:SSUTC)</param>
        /// <param name="fechaFinStr">Fecha Final (AAAA-MM-DDTHH:MM:SSUTC)</param>
        /// <returns>ApiResponse of Model200</returns>
        ApiResponse<Model200> AvisosDeFenmenosMeteorolgicosAdversosArchivoWithHttpInfo (string fechaIniStr, string fechaFinStr);
        /// <summary>
        /// Avisos de Fenómenos Meteorológicos Adversos. Último.
        /// </summary>
        /// <remarks>
        ///  Últimos Avisos de Fenómenos Meteorológicos adversos elaborado para el área seleccionada.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="area"> | Código | Área | |- -- -- -- -- -|- -- -- -- -- -| | esp  | España| | 61  | Andalucía   | | 62  | Aragón   | | 63  | Asturias, Principado de  | | 64  | Ballears, Illes   | | 78  | Ceuta   | | 65  | Canarias   | | 66  | Cantabria   | | 67  | Castilla y León   | | 68  | Castilla - La Mancha   | | 69  | Cataluña   | | 77  | Comunitat Valenciana   | | 70  | Extremadura   | | 71  | Galicia   | | 72  | Madrid, Comunidad de    | | 79  | Melilla   | | 73  | Murcia, Región de   | | 74  | Navarra, Comunidad Foral de   | | 75  | País Vasco | | 76  | Rioja, La</param>
        /// <returns>Model200</returns>
        Model200 AvisosDeFenmenosMeteorolgicosAdversosLtimo_ (string area);

        /// <summary>
        /// Avisos de Fenómenos Meteorológicos Adversos. Último.
        /// </summary>
        /// <remarks>
        ///  Últimos Avisos de Fenómenos Meteorológicos adversos elaborado para el área seleccionada.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="area"> | Código | Área | |- -- -- -- -- -|- -- -- -- -- -| | esp  | España| | 61  | Andalucía   | | 62  | Aragón   | | 63  | Asturias, Principado de  | | 64  | Ballears, Illes   | | 78  | Ceuta   | | 65  | Canarias   | | 66  | Cantabria   | | 67  | Castilla y León   | | 68  | Castilla - La Mancha   | | 69  | Cataluña   | | 77  | Comunitat Valenciana   | | 70  | Extremadura   | | 71  | Galicia   | | 72  | Madrid, Comunidad de    | | 79  | Melilla   | | 73  | Murcia, Región de   | | 74  | Navarra, Comunidad Foral de   | | 75  | País Vasco | | 76  | Rioja, La</param>
        /// <returns>ApiResponse of Model200</returns>
        ApiResponse<Model200> AvisosDeFenmenosMeteorolgicosAdversosLtimo_WithHttpInfo (string area);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Avisos de Fenómenos Meteorológicos Adversos. Archivo.
        /// </summary>
        /// <remarks>
        ///  Avisos de Fenómenos Meteorológicos adversos para el rango de fechas seleccionado (datos desde 18/06/2018).
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fechaIniStr">Fecha Inicial (AAAA-MM-DDTHH:MM:SSUTC)</param>
        /// <param name="fechaFinStr">Fecha Final (AAAA-MM-DDTHH:MM:SSUTC)</param>
        /// <returns>Task of Model200</returns>
        System.Threading.Tasks.Task<Model200> AvisosDeFenmenosMeteorolgicosAdversosArchivoAsync (string fechaIniStr, string fechaFinStr);

        /// <summary>
        /// Avisos de Fenómenos Meteorológicos Adversos. Archivo.
        /// </summary>
        /// <remarks>
        ///  Avisos de Fenómenos Meteorológicos adversos para el rango de fechas seleccionado (datos desde 18/06/2018).
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fechaIniStr">Fecha Inicial (AAAA-MM-DDTHH:MM:SSUTC)</param>
        /// <param name="fechaFinStr">Fecha Final (AAAA-MM-DDTHH:MM:SSUTC)</param>
        /// <returns>Task of ApiResponse (Model200)</returns>
        System.Threading.Tasks.Task<ApiResponse<Model200>> AvisosDeFenmenosMeteorolgicosAdversosArchivoAsyncWithHttpInfo (string fechaIniStr, string fechaFinStr);
        /// <summary>
        /// Avisos de Fenómenos Meteorológicos Adversos. Último.
        /// </summary>
        /// <remarks>
        ///  Últimos Avisos de Fenómenos Meteorológicos adversos elaborado para el área seleccionada.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="area"> | Código | Área | |- -- -- -- -- -|- -- -- -- -- -| | esp  | España| | 61  | Andalucía   | | 62  | Aragón   | | 63  | Asturias, Principado de  | | 64  | Ballears, Illes   | | 78  | Ceuta   | | 65  | Canarias   | | 66  | Cantabria   | | 67  | Castilla y León   | | 68  | Castilla - La Mancha   | | 69  | Cataluña   | | 77  | Comunitat Valenciana   | | 70  | Extremadura   | | 71  | Galicia   | | 72  | Madrid, Comunidad de    | | 79  | Melilla   | | 73  | Murcia, Región de   | | 74  | Navarra, Comunidad Foral de   | | 75  | País Vasco | | 76  | Rioja, La</param>
        /// <returns>Task of Model200</returns>
        System.Threading.Tasks.Task<Model200> AvisosDeFenmenosMeteorolgicosAdversosLtimo_Async (string area);

        /// <summary>
        /// Avisos de Fenómenos Meteorológicos Adversos. Último.
        /// </summary>
        /// <remarks>
        ///  Últimos Avisos de Fenómenos Meteorológicos adversos elaborado para el área seleccionada.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="area"> | Código | Área | |- -- -- -- -- -|- -- -- -- -- -| | esp  | España| | 61  | Andalucía   | | 62  | Aragón   | | 63  | Asturias, Principado de  | | 64  | Ballears, Illes   | | 78  | Ceuta   | | 65  | Canarias   | | 66  | Cantabria   | | 67  | Castilla y León   | | 68  | Castilla - La Mancha   | | 69  | Cataluña   | | 77  | Comunitat Valenciana   | | 70  | Extremadura   | | 71  | Galicia   | | 72  | Madrid, Comunidad de    | | 79  | Melilla   | | 73  | Murcia, Región de   | | 74  | Navarra, Comunidad Foral de   | | 75  | País Vasco | | 76  | Rioja, La</param>
        /// <returns>Task of ApiResponse (Model200)</returns>
        System.Threading.Tasks.Task<ApiResponse<Model200>> AvisosDeFenmenosMeteorolgicosAdversosLtimo_AsyncWithHttpInfo (string area);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AvisosCapApi : IAvisosCapApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AvisosCapApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AvisosCapApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvisosCapApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AvisosCapApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Avisos de Fenómenos Meteorológicos Adversos. Archivo.  Avisos de Fenómenos Meteorológicos adversos para el rango de fechas seleccionado (datos desde 18/06/2018).
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fechaIniStr">Fecha Inicial (AAAA-MM-DDTHH:MM:SSUTC)</param>
        /// <param name="fechaFinStr">Fecha Final (AAAA-MM-DDTHH:MM:SSUTC)</param>
        /// <returns>Model200</returns>
        public Model200 AvisosDeFenmenosMeteorolgicosAdversosArchivo (string fechaIniStr, string fechaFinStr)
        {
             ApiResponse<Model200> localVarResponse = AvisosDeFenmenosMeteorolgicosAdversosArchivoWithHttpInfo(fechaIniStr, fechaFinStr);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Avisos de Fenómenos Meteorológicos Adversos. Archivo.  Avisos de Fenómenos Meteorológicos adversos para el rango de fechas seleccionado (datos desde 18/06/2018).
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fechaIniStr">Fecha Inicial (AAAA-MM-DDTHH:MM:SSUTC)</param>
        /// <param name="fechaFinStr">Fecha Final (AAAA-MM-DDTHH:MM:SSUTC)</param>
        /// <returns>ApiResponse of Model200</returns>
        public ApiResponse< Model200 > AvisosDeFenmenosMeteorolgicosAdversosArchivoWithHttpInfo (string fechaIniStr, string fechaFinStr)
        {
            // verify the required parameter 'fechaIniStr' is set
            if (fechaIniStr == null)
                throw new ApiException(400, "Missing required parameter 'fechaIniStr' when calling AvisosCapApi->AvisosDeFenmenosMeteorolgicosAdversosArchivo");
            // verify the required parameter 'fechaFinStr' is set
            if (fechaFinStr == null)
                throw new ApiException(400, "Missing required parameter 'fechaFinStr' when calling AvisosCapApi->AvisosDeFenmenosMeteorolgicosAdversosArchivo");

            var localVarPath = "/api/avisos_cap/archivo/fechaini/{fechaIniStr}/fechafin/{fechaFinStr}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fechaIniStr != null) localVarPathParams.Add("fechaIniStr", this.Configuration.ApiClient.ParameterToString(fechaIniStr)); // path parameter
            if (fechaFinStr != null) localVarPathParams.Add("fechaFinStr", this.Configuration.ApiClient.ParameterToString(fechaFinStr)); // path parameter

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = this.Configuration.GetApiKeyWithPrefix("api_key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AvisosDeFenmenosMeteorolgicosAdversosArchivo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Model200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Model200) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Model200)));
        }

        /// <summary>
        /// Avisos de Fenómenos Meteorológicos Adversos. Archivo.  Avisos de Fenómenos Meteorológicos adversos para el rango de fechas seleccionado (datos desde 18/06/2018).
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fechaIniStr">Fecha Inicial (AAAA-MM-DDTHH:MM:SSUTC)</param>
        /// <param name="fechaFinStr">Fecha Final (AAAA-MM-DDTHH:MM:SSUTC)</param>
        /// <returns>Task of Model200</returns>
        public async System.Threading.Tasks.Task<Model200> AvisosDeFenmenosMeteorolgicosAdversosArchivoAsync (string fechaIniStr, string fechaFinStr)
        {
             ApiResponse<Model200> localVarResponse = await AvisosDeFenmenosMeteorolgicosAdversosArchivoAsyncWithHttpInfo(fechaIniStr, fechaFinStr);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Avisos de Fenómenos Meteorológicos Adversos. Archivo.  Avisos de Fenómenos Meteorológicos adversos para el rango de fechas seleccionado (datos desde 18/06/2018).
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fechaIniStr">Fecha Inicial (AAAA-MM-DDTHH:MM:SSUTC)</param>
        /// <param name="fechaFinStr">Fecha Final (AAAA-MM-DDTHH:MM:SSUTC)</param>
        /// <returns>Task of ApiResponse (Model200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Model200>> AvisosDeFenmenosMeteorolgicosAdversosArchivoAsyncWithHttpInfo (string fechaIniStr, string fechaFinStr)
        {
            // verify the required parameter 'fechaIniStr' is set
            if (fechaIniStr == null)
                throw new ApiException(400, "Missing required parameter 'fechaIniStr' when calling AvisosCapApi->AvisosDeFenmenosMeteorolgicosAdversosArchivo");
            // verify the required parameter 'fechaFinStr' is set
            if (fechaFinStr == null)
                throw new ApiException(400, "Missing required parameter 'fechaFinStr' when calling AvisosCapApi->AvisosDeFenmenosMeteorolgicosAdversosArchivo");

            var localVarPath = "/api/avisos_cap/archivo/fechaini/{fechaIniStr}/fechafin/{fechaFinStr}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fechaIniStr != null) localVarPathParams.Add("fechaIniStr", this.Configuration.ApiClient.ParameterToString(fechaIniStr)); // path parameter
            if (fechaFinStr != null) localVarPathParams.Add("fechaFinStr", this.Configuration.ApiClient.ParameterToString(fechaFinStr)); // path parameter

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = this.Configuration.GetApiKeyWithPrefix("api_key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AvisosDeFenmenosMeteorolgicosAdversosArchivo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Model200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Model200) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Model200)));
        }

        /// <summary>
        /// Avisos de Fenómenos Meteorológicos Adversos. Último.  Últimos Avisos de Fenómenos Meteorológicos adversos elaborado para el área seleccionada.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="area"> | Código | Área | |- -- -- -- -- -|- -- -- -- -- -| | esp  | España| | 61  | Andalucía   | | 62  | Aragón   | | 63  | Asturias, Principado de  | | 64  | Ballears, Illes   | | 78  | Ceuta   | | 65  | Canarias   | | 66  | Cantabria   | | 67  | Castilla y León   | | 68  | Castilla - La Mancha   | | 69  | Cataluña   | | 77  | Comunitat Valenciana   | | 70  | Extremadura   | | 71  | Galicia   | | 72  | Madrid, Comunidad de    | | 79  | Melilla   | | 73  | Murcia, Región de   | | 74  | Navarra, Comunidad Foral de   | | 75  | País Vasco | | 76  | Rioja, La</param>
        /// <returns>Model200</returns>
        public Model200 AvisosDeFenmenosMeteorolgicosAdversosLtimo_ (string area)
        {
             ApiResponse<Model200> localVarResponse = AvisosDeFenmenosMeteorolgicosAdversosLtimo_WithHttpInfo(area);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Avisos de Fenómenos Meteorológicos Adversos. Último.  Últimos Avisos de Fenómenos Meteorológicos adversos elaborado para el área seleccionada.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="area"> | Código | Área | |- -- -- -- -- -|- -- -- -- -- -| | esp  | España| | 61  | Andalucía   | | 62  | Aragón   | | 63  | Asturias, Principado de  | | 64  | Ballears, Illes   | | 78  | Ceuta   | | 65  | Canarias   | | 66  | Cantabria   | | 67  | Castilla y León   | | 68  | Castilla - La Mancha   | | 69  | Cataluña   | | 77  | Comunitat Valenciana   | | 70  | Extremadura   | | 71  | Galicia   | | 72  | Madrid, Comunidad de    | | 79  | Melilla   | | 73  | Murcia, Región de   | | 74  | Navarra, Comunidad Foral de   | | 75  | País Vasco | | 76  | Rioja, La</param>
        /// <returns>ApiResponse of Model200</returns>
        public ApiResponse< Model200 > AvisosDeFenmenosMeteorolgicosAdversosLtimo_WithHttpInfo (string area)
        {
            // verify the required parameter 'area' is set
            if (area == null)
                throw new ApiException(400, "Missing required parameter 'area' when calling AvisosCapApi->AvisosDeFenmenosMeteorolgicosAdversosLtimo_");

            var localVarPath = "/api/avisos_cap/ultimoelaborado/area/{area}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (area != null) localVarPathParams.Add("area", this.Configuration.ApiClient.ParameterToString(area)); // path parameter

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = this.Configuration.GetApiKeyWithPrefix("api_key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AvisosDeFenmenosMeteorolgicosAdversosLtimo_", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Model200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Model200) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Model200)));
        }

        /// <summary>
        /// Avisos de Fenómenos Meteorológicos Adversos. Último.  Últimos Avisos de Fenómenos Meteorológicos adversos elaborado para el área seleccionada.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="area"> | Código | Área | |- -- -- -- -- -|- -- -- -- -- -| | esp  | España| | 61  | Andalucía   | | 62  | Aragón   | | 63  | Asturias, Principado de  | | 64  | Ballears, Illes   | | 78  | Ceuta   | | 65  | Canarias   | | 66  | Cantabria   | | 67  | Castilla y León   | | 68  | Castilla - La Mancha   | | 69  | Cataluña   | | 77  | Comunitat Valenciana   | | 70  | Extremadura   | | 71  | Galicia   | | 72  | Madrid, Comunidad de    | | 79  | Melilla   | | 73  | Murcia, Región de   | | 74  | Navarra, Comunidad Foral de   | | 75  | País Vasco | | 76  | Rioja, La</param>
        /// <returns>Task of Model200</returns>
        public async System.Threading.Tasks.Task<Model200> AvisosDeFenmenosMeteorolgicosAdversosLtimo_Async (string area)
        {
             ApiResponse<Model200> localVarResponse = await AvisosDeFenmenosMeteorolgicosAdversosLtimo_AsyncWithHttpInfo(area);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Avisos de Fenómenos Meteorológicos Adversos. Último.  Últimos Avisos de Fenómenos Meteorológicos adversos elaborado para el área seleccionada.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="area"> | Código | Área | |- -- -- -- -- -|- -- -- -- -- -| | esp  | España| | 61  | Andalucía   | | 62  | Aragón   | | 63  | Asturias, Principado de  | | 64  | Ballears, Illes   | | 78  | Ceuta   | | 65  | Canarias   | | 66  | Cantabria   | | 67  | Castilla y León   | | 68  | Castilla - La Mancha   | | 69  | Cataluña   | | 77  | Comunitat Valenciana   | | 70  | Extremadura   | | 71  | Galicia   | | 72  | Madrid, Comunidad de    | | 79  | Melilla   | | 73  | Murcia, Región de   | | 74  | Navarra, Comunidad Foral de   | | 75  | País Vasco | | 76  | Rioja, La</param>
        /// <returns>Task of ApiResponse (Model200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Model200>> AvisosDeFenmenosMeteorolgicosAdversosLtimo_AsyncWithHttpInfo (string area)
        {
            // verify the required parameter 'area' is set
            if (area == null)
                throw new ApiException(400, "Missing required parameter 'area' when calling AvisosCapApi->AvisosDeFenmenosMeteorolgicosAdversosLtimo_");

            var localVarPath = "/api/avisos_cap/ultimoelaborado/area/{area}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (area != null) localVarPathParams.Add("area", this.Configuration.ApiClient.ParameterToString(area)); // path parameter

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = this.Configuration.GetApiKeyWithPrefix("api_key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AvisosDeFenmenosMeteorolgicosAdversosLtimo_", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Model200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Model200) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Model200)));
        }

    }
}