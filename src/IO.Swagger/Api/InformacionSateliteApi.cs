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
    public interface IInformacionSateliteApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Índice normalizado de vegetación.
        /// </summary>
        /// <remarks>
        /// Esta imagen se realiza con una combinación de los datos del canal visible y del infrarrojo cercano del satélite NOAA-19, que nos da una idea del desarrollo de la vegetación. Esto es así debido a que la vegetación absorbe fuertemente la radiación del canal visible, pero refleja fuertemente la del infrarrojo cercano. Esta imagen se renueva los jueves a última hora y contiene los datos acumulados de la última semana.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Model200</returns>
        Model200 NdiceNormalizadoDeVegetacin_ ();

        /// <summary>
        /// Índice normalizado de vegetación.
        /// </summary>
        /// <remarks>
        /// Esta imagen se realiza con una combinación de los datos del canal visible y del infrarrojo cercano del satélite NOAA-19, que nos da una idea del desarrollo de la vegetación. Esto es así debido a que la vegetación absorbe fuertemente la radiación del canal visible, pero refleja fuertemente la del infrarrojo cercano. Esta imagen se renueva los jueves a última hora y contiene los datos acumulados de la última semana.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Model200</returns>
        ApiResponse<Model200> NdiceNormalizadoDeVegetacin_WithHttpInfo ();
        /// <summary>
        /// Temperatura del agua del mar.
        /// </summary>
        /// <remarks>
        /// Imagen obtenida con una combinación de los datos de los canales infrarrojos del satélite NOAA-19, que nos da la temperatura de la superficie del mar. Esta imagen se renueva todos los días a última hora y contiene los datos acumulados de los últimos siete días.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Model200</returns>
        Model200 TemperaturaDelAguaDelMar_ ();

        /// <summary>
        /// Temperatura del agua del mar.
        /// </summary>
        /// <remarks>
        /// Imagen obtenida con una combinación de los datos de los canales infrarrojos del satélite NOAA-19, que nos da la temperatura de la superficie del mar. Esta imagen se renueva todos los días a última hora y contiene los datos acumulados de los últimos siete días.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Model200</returns>
        ApiResponse<Model200> TemperaturaDelAguaDelMar_WithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Índice normalizado de vegetación.
        /// </summary>
        /// <remarks>
        /// Esta imagen se realiza con una combinación de los datos del canal visible y del infrarrojo cercano del satélite NOAA-19, que nos da una idea del desarrollo de la vegetación. Esto es así debido a que la vegetación absorbe fuertemente la radiación del canal visible, pero refleja fuertemente la del infrarrojo cercano. Esta imagen se renueva los jueves a última hora y contiene los datos acumulados de la última semana.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Model200</returns>
        System.Threading.Tasks.Task<Model200> NdiceNormalizadoDeVegetacin_Async ();

        /// <summary>
        /// Índice normalizado de vegetación.
        /// </summary>
        /// <remarks>
        /// Esta imagen se realiza con una combinación de los datos del canal visible y del infrarrojo cercano del satélite NOAA-19, que nos da una idea del desarrollo de la vegetación. Esto es así debido a que la vegetación absorbe fuertemente la radiación del canal visible, pero refleja fuertemente la del infrarrojo cercano. Esta imagen se renueva los jueves a última hora y contiene los datos acumulados de la última semana.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Model200)</returns>
        System.Threading.Tasks.Task<ApiResponse<Model200>> NdiceNormalizadoDeVegetacin_AsyncWithHttpInfo ();
        /// <summary>
        /// Temperatura del agua del mar.
        /// </summary>
        /// <remarks>
        /// Imagen obtenida con una combinación de los datos de los canales infrarrojos del satélite NOAA-19, que nos da la temperatura de la superficie del mar. Esta imagen se renueva todos los días a última hora y contiene los datos acumulados de los últimos siete días.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Model200</returns>
        System.Threading.Tasks.Task<Model200> TemperaturaDelAguaDelMar_Async ();

        /// <summary>
        /// Temperatura del agua del mar.
        /// </summary>
        /// <remarks>
        /// Imagen obtenida con una combinación de los datos de los canales infrarrojos del satélite NOAA-19, que nos da la temperatura de la superficie del mar. Esta imagen se renueva todos los días a última hora y contiene los datos acumulados de los últimos siete días.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Model200)</returns>
        System.Threading.Tasks.Task<ApiResponse<Model200>> TemperaturaDelAguaDelMar_AsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InformacionSateliteApi : IInformacionSateliteApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InformacionSateliteApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InformacionSateliteApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InformacionSateliteApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InformacionSateliteApi(IO.Swagger.Client.Configuration configuration = null)
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
        /// Índice normalizado de vegetación. Esta imagen se realiza con una combinación de los datos del canal visible y del infrarrojo cercano del satélite NOAA-19, que nos da una idea del desarrollo de la vegetación. Esto es así debido a que la vegetación absorbe fuertemente la radiación del canal visible, pero refleja fuertemente la del infrarrojo cercano. Esta imagen se renueva los jueves a última hora y contiene los datos acumulados de la última semana.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Model200</returns>
        public Model200 NdiceNormalizadoDeVegetacin_ ()
        {
             ApiResponse<Model200> localVarResponse = NdiceNormalizadoDeVegetacin_WithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Índice normalizado de vegetación. Esta imagen se realiza con una combinación de los datos del canal visible y del infrarrojo cercano del satélite NOAA-19, que nos da una idea del desarrollo de la vegetación. Esto es así debido a que la vegetación absorbe fuertemente la radiación del canal visible, pero refleja fuertemente la del infrarrojo cercano. Esta imagen se renueva los jueves a última hora y contiene los datos acumulados de la última semana.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Model200</returns>
        public ApiResponse< Model200 > NdiceNormalizadoDeVegetacin_WithHttpInfo ()
        {

            var localVarPath = "/api/satelites/producto/nvdi";
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
                Exception exception = ExceptionFactory("NdiceNormalizadoDeVegetacin_", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Model200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Model200) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Model200)));
        }

        /// <summary>
        /// Índice normalizado de vegetación. Esta imagen se realiza con una combinación de los datos del canal visible y del infrarrojo cercano del satélite NOAA-19, que nos da una idea del desarrollo de la vegetación. Esto es así debido a que la vegetación absorbe fuertemente la radiación del canal visible, pero refleja fuertemente la del infrarrojo cercano. Esta imagen se renueva los jueves a última hora y contiene los datos acumulados de la última semana.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Model200</returns>
        public async System.Threading.Tasks.Task<Model200> NdiceNormalizadoDeVegetacin_Async ()
        {
             ApiResponse<Model200> localVarResponse = await NdiceNormalizadoDeVegetacin_AsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Índice normalizado de vegetación. Esta imagen se realiza con una combinación de los datos del canal visible y del infrarrojo cercano del satélite NOAA-19, que nos da una idea del desarrollo de la vegetación. Esto es así debido a que la vegetación absorbe fuertemente la radiación del canal visible, pero refleja fuertemente la del infrarrojo cercano. Esta imagen se renueva los jueves a última hora y contiene los datos acumulados de la última semana.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Model200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Model200>> NdiceNormalizadoDeVegetacin_AsyncWithHttpInfo ()
        {

            var localVarPath = "/api/satelites/producto/nvdi";
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
                Exception exception = ExceptionFactory("NdiceNormalizadoDeVegetacin_", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Model200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Model200) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Model200)));
        }

        /// <summary>
        /// Temperatura del agua del mar. Imagen obtenida con una combinación de los datos de los canales infrarrojos del satélite NOAA-19, que nos da la temperatura de la superficie del mar. Esta imagen se renueva todos los días a última hora y contiene los datos acumulados de los últimos siete días.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Model200</returns>
        public Model200 TemperaturaDelAguaDelMar_ ()
        {
             ApiResponse<Model200> localVarResponse = TemperaturaDelAguaDelMar_WithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Temperatura del agua del mar. Imagen obtenida con una combinación de los datos de los canales infrarrojos del satélite NOAA-19, que nos da la temperatura de la superficie del mar. Esta imagen se renueva todos los días a última hora y contiene los datos acumulados de los últimos siete días.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Model200</returns>
        public ApiResponse< Model200 > TemperaturaDelAguaDelMar_WithHttpInfo ()
        {

            var localVarPath = "/api/satelites/producto/sst";
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
                Exception exception = ExceptionFactory("TemperaturaDelAguaDelMar_", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Model200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Model200) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Model200)));
        }

        /// <summary>
        /// Temperatura del agua del mar. Imagen obtenida con una combinación de los datos de los canales infrarrojos del satélite NOAA-19, que nos da la temperatura de la superficie del mar. Esta imagen se renueva todos los días a última hora y contiene los datos acumulados de los últimos siete días.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Model200</returns>
        public async System.Threading.Tasks.Task<Model200> TemperaturaDelAguaDelMar_Async ()
        {
             ApiResponse<Model200> localVarResponse = await TemperaturaDelAguaDelMar_AsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Temperatura del agua del mar. Imagen obtenida con una combinación de los datos de los canales infrarrojos del satélite NOAA-19, que nos da la temperatura de la superficie del mar. Esta imagen se renueva todos los días a última hora y contiene los datos acumulados de los últimos siete días.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Model200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Model200>> TemperaturaDelAguaDelMar_AsyncWithHttpInfo ()
        {

            var localVarPath = "/api/satelites/producto/sst";
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
                Exception exception = ExceptionFactory("TemperaturaDelAguaDelMar_", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Model200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Model200) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Model200)));
        }

    }
}
