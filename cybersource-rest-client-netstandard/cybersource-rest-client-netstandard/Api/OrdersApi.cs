/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using CyberSource.Client;
using CyberSource.Model;
using NLog;
using AuthenticationSdk.util;
using CyberSource.Utilities.Tracking;

namespace CyberSource.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOrdersApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create an Order
        /// </summary>
        /// <remarks>
        /// A create order request enables you to send the itemized details along with the order. This API can be used by merchants initiating their transactions with the create order API.  
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createOrderRequest"></param>
        /// <returns>PtsV2CreateOrderPost201Response</returns>
        PtsV2CreateOrderPost201Response CreateOrder (CreateOrderRequest createOrderRequest);

        /// <summary>
        /// Create an Order
        /// </summary>
        /// <remarks>
        /// A create order request enables you to send the itemized details along with the order. This API can be used by merchants initiating their transactions with the create order API.  
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createOrderRequest"></param>
        /// <returns>ApiResponse of PtsV2CreateOrderPost201Response</returns>
        ApiResponse<PtsV2CreateOrderPost201Response> CreateOrderWithHttpInfo (CreateOrderRequest createOrderRequest);
        /// <summary>
        /// Update an Order
        /// </summary>
        /// <remarks>
        /// This API can be used in two flavours - for updating the order as well as saving the order. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID returned from the original create order response.</param>
        /// <param name="updateOrderRequest"></param>
        /// <returns>PtsV2UpdateOrderPatch201Response</returns>
        PtsV2UpdateOrderPatch201Response UpdateOrder (string id, UpdateOrderRequest updateOrderRequest);

        /// <summary>
        /// Update an Order
        /// </summary>
        /// <remarks>
        /// This API can be used in two flavours - for updating the order as well as saving the order. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID returned from the original create order response.</param>
        /// <param name="updateOrderRequest"></param>
        /// <returns>ApiResponse of PtsV2UpdateOrderPatch201Response</returns>
        ApiResponse<PtsV2UpdateOrderPatch201Response> UpdateOrderWithHttpInfo (string id, UpdateOrderRequest updateOrderRequest);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create an Order
        /// </summary>
        /// <remarks>
        /// A create order request enables you to send the itemized details along with the order. This API can be used by merchants initiating their transactions with the create order API.  
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createOrderRequest"></param>
        /// <returns>Task of PtsV2CreateOrderPost201Response</returns>
        System.Threading.Tasks.Task<PtsV2CreateOrderPost201Response> CreateOrderAsync (CreateOrderRequest createOrderRequest);

        /// <summary>
        /// Create an Order
        /// </summary>
        /// <remarks>
        /// A create order request enables you to send the itemized details along with the order. This API can be used by merchants initiating their transactions with the create order API.  
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createOrderRequest"></param>
        /// <returns>Task of ApiResponse (PtsV2CreateOrderPost201Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PtsV2CreateOrderPost201Response>> CreateOrderAsyncWithHttpInfo (CreateOrderRequest createOrderRequest);
        /// <summary>
        /// Update an Order
        /// </summary>
        /// <remarks>
        /// This API can be used in two flavours - for updating the order as well as saving the order. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID returned from the original create order response.</param>
        /// <param name="updateOrderRequest"></param>
        /// <returns>Task of PtsV2UpdateOrderPatch201Response</returns>
        System.Threading.Tasks.Task<PtsV2UpdateOrderPatch201Response> UpdateOrderAsync (string id, UpdateOrderRequest updateOrderRequest);

        /// <summary>
        /// Update an Order
        /// </summary>
        /// <remarks>
        /// This API can be used in two flavours - for updating the order as well as saving the order. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID returned from the original create order response.</param>
        /// <param name="updateOrderRequest"></param>
        /// <returns>Task of ApiResponse (PtsV2UpdateOrderPatch201Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PtsV2UpdateOrderPatch201Response>> UpdateOrderAsyncWithHttpInfo (string id, UpdateOrderRequest updateOrderRequest);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OrdersApi : IOrdersApi
    {
        private static Logger logger;
        private ExceptionFactory _exceptionFactory = (name, response) => null;
        private int? _statusCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrdersApi(string basePath)
        {
            Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                Configuration.ApiClient.Configuration = Configuration;
            }

            if (logger == null)
            {
                logger = LogManager.GetCurrentClassLogger();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OrdersApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                Configuration = Configuration.Default;
            else
                Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            Configuration.ApiClient.Configuration = Configuration;

            if (logger == null)
            {
                logger = LogManager.GetCurrentClassLogger();
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.ApiClient.RestClient.Options.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(string basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    logger.Error("InvalidOperationException : Multicast delegate for ExceptionFactory is unsupported.");
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
        public Dictionary<string, string> DefaultHeader()
        {
            return Configuration.DefaultHeader;
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
            Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Retrieves the status code being set for the most recently executed API request.
        /// </summary>
        /// <returns>Status Code of previous request</returns>
        public int GetStatusCode()
        {
            return this._statusCode == null ? 0 : (int) this._statusCode;
        }

        /// <summary>
        /// Sets the value of status code for the most recently executed API request, in order to be retrieved later.
        /// </summary>
        /// <param name="statusCode">Status Code to be set</param>
        /// <returns></returns>
        public void SetStatusCode(int? statusCode)
        {
            this._statusCode = statusCode;
        }

        /// <summary>
        /// Create an Order A create order request enables you to send the itemized details along with the order. This API can be used by merchants initiating their transactions with the create order API.  
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createOrderRequest"></param>
        /// <returns>PtsV2CreateOrderPost201Response</returns>
        public PtsV2CreateOrderPost201Response CreateOrder (CreateOrderRequest createOrderRequest)
        {
            logger.Debug("CALLING API \"CreateOrder\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<PtsV2CreateOrderPost201Response> localVarResponse = CreateOrderWithHttpInfo(createOrderRequest);
            logger.Debug("CALLING API \"CreateOrder\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create an Order A create order request enables you to send the itemized details along with the order. This API can be used by merchants initiating their transactions with the create order API.  
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createOrderRequest"></param>
        /// <returns>ApiResponse of PtsV2CreateOrderPost201Response</returns>
        public ApiResponse< PtsV2CreateOrderPost201Response > CreateOrderWithHttpInfo (CreateOrderRequest createOrderRequest)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'createOrderRequest' is set
            if (createOrderRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'createOrderRequest' when calling OrdersApi->CreateOrder");
                throw new ApiException(400, "Missing required parameter 'createOrderRequest' when calling OrdersApi->CreateOrder");
            }

            var localVarPath = $"/pts/v2/intents";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/hal+json;charset=utf-8"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (createOrderRequest != null && createOrderRequest.GetType() != typeof(byte[]))
            {
                SdkTracker sdkTracker = new SdkTracker();
                createOrderRequest = (CreateOrderRequest)sdkTracker.InsertDeveloperIdTracker(createOrderRequest, createOrderRequest.GetType().Name, Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj["runEnvironment"], Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj.ContainsKey("defaultDeveloperId")? Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj["defaultDeveloperId"]:"");
                localVarPostBody = Configuration.ApiClient.Serialize(createOrderRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createOrderRequest; // byte array
            }

            if (logUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{logUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateOrder", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<PtsV2CreateOrderPost201Response>(localVarStatusCode,
                localVarResponse.Headers.GroupBy(h => h.Name).ToDictionary(x => x.Key, x => string.Join(", ", x.Select(h => h.Value.ToString()))),
                (PtsV2CreateOrderPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2CreateOrderPost201Response))); // Return statement
        }

        /// <summary>
        /// Create an Order A create order request enables you to send the itemized details along with the order. This API can be used by merchants initiating their transactions with the create order API.  
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createOrderRequest"></param>
        /// <returns>Task of PtsV2CreateOrderPost201Response</returns>
        public async System.Threading.Tasks.Task<PtsV2CreateOrderPost201Response> CreateOrderAsync (CreateOrderRequest createOrderRequest)
        {
            logger.Debug("CALLING API \"CreateOrderAsync\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<PtsV2CreateOrderPost201Response> localVarResponse = await CreateOrderAsyncWithHttpInfo(createOrderRequest);
            logger.Debug("CALLING API \"CreateOrderAsync\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Create an Order A create order request enables you to send the itemized details along with the order. This API can be used by merchants initiating their transactions with the create order API.  
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createOrderRequest"></param>
        /// <returns>Task of ApiResponse (PtsV2CreateOrderPost201Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PtsV2CreateOrderPost201Response>> CreateOrderAsyncWithHttpInfo (CreateOrderRequest createOrderRequest)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'createOrderRequest' is set
            if (createOrderRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'createOrderRequest' when calling OrdersApi->CreateOrder");
                throw new ApiException(400, "Missing required parameter 'createOrderRequest' when calling OrdersApi->CreateOrder");
            }

            var localVarPath = $"/pts/v2/intents";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/hal+json;charset=utf-8"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (createOrderRequest != null && createOrderRequest.GetType() != typeof(byte[]))
            {
                SdkTracker sdkTracker = new SdkTracker();
                createOrderRequest = (CreateOrderRequest)sdkTracker.InsertDeveloperIdTracker(createOrderRequest, createOrderRequest.GetType().Name, Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj["runEnvironment"], Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj.ContainsKey("defaultDeveloperId")? Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj["defaultDeveloperId"]:"");
                localVarPostBody = Configuration.ApiClient.Serialize(createOrderRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createOrderRequest; // byte array
            }

            if (logUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{logUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateOrder", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<PtsV2CreateOrderPost201Response>(localVarStatusCode,
                localVarResponse.Headers.GroupBy(h => h.Name).ToDictionary(x => x.Key, x => string.Join(", ", x.Select(h => h.Value.ToString()))),
                (PtsV2CreateOrderPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2CreateOrderPost201Response))); // Return statement
        }
        /// <summary>
        /// Update an Order This API can be used in two flavours - for updating the order as well as saving the order. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID returned from the original create order response.</param>
        /// <param name="updateOrderRequest"></param>
        /// <returns>PtsV2UpdateOrderPatch201Response</returns>
        public PtsV2UpdateOrderPatch201Response UpdateOrder (string id, UpdateOrderRequest updateOrderRequest)
        {
            logger.Debug("CALLING API \"UpdateOrder\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<PtsV2UpdateOrderPatch201Response> localVarResponse = UpdateOrderWithHttpInfo(id, updateOrderRequest);
            logger.Debug("CALLING API \"UpdateOrder\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update an Order This API can be used in two flavours - for updating the order as well as saving the order. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID returned from the original create order response.</param>
        /// <param name="updateOrderRequest"></param>
        /// <returns>ApiResponse of PtsV2UpdateOrderPatch201Response</returns>
        public ApiResponse< PtsV2UpdateOrderPatch201Response > UpdateOrderWithHttpInfo (string id, UpdateOrderRequest updateOrderRequest)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'id' is set
            if (id == null)
            {
                logger.Error("ApiException : Missing required parameter 'id' when calling OrdersApi->UpdateOrder");
                throw new ApiException(400, "Missing required parameter 'id' when calling OrdersApi->UpdateOrder");
            }
            // verify the required parameter 'updateOrderRequest' is set
            if (updateOrderRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'updateOrderRequest' when calling OrdersApi->UpdateOrder");
                throw new ApiException(400, "Missing required parameter 'updateOrderRequest' when calling OrdersApi->UpdateOrder");
            }

            var localVarPath = $"/pts/v2/intents/{id}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/hal+json;charset=utf-8"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (id != null)
            {
                localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarPathParams)}");
            if (updateOrderRequest != null && updateOrderRequest.GetType() != typeof(byte[]))
            {
                SdkTracker sdkTracker = new SdkTracker();
                updateOrderRequest = (UpdateOrderRequest)sdkTracker.InsertDeveloperIdTracker(updateOrderRequest, updateOrderRequest.GetType().Name, Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj["runEnvironment"], Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj.ContainsKey("defaultDeveloperId")? Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj["defaultDeveloperId"]:"");
                localVarPostBody = Configuration.ApiClient.Serialize(updateOrderRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = updateOrderRequest; // byte array
            }

            if (logUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{logUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateOrder", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<PtsV2UpdateOrderPatch201Response>(localVarStatusCode,
                localVarResponse.Headers.GroupBy(h => h.Name).ToDictionary(x => x.Key, x => string.Join(", ", x.Select(h => h.Value.ToString()))),
                (PtsV2UpdateOrderPatch201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2UpdateOrderPatch201Response))); // Return statement
        }

        /// <summary>
        /// Update an Order This API can be used in two flavours - for updating the order as well as saving the order. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID returned from the original create order response.</param>
        /// <param name="updateOrderRequest"></param>
        /// <returns>Task of PtsV2UpdateOrderPatch201Response</returns>
        public async System.Threading.Tasks.Task<PtsV2UpdateOrderPatch201Response> UpdateOrderAsync (string id, UpdateOrderRequest updateOrderRequest)
        {
            logger.Debug("CALLING API \"UpdateOrderAsync\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<PtsV2UpdateOrderPatch201Response> localVarResponse = await UpdateOrderAsyncWithHttpInfo(id, updateOrderRequest);
            logger.Debug("CALLING API \"UpdateOrderAsync\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Update an Order This API can be used in two flavours - for updating the order as well as saving the order. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID returned from the original create order response.</param>
        /// <param name="updateOrderRequest"></param>
        /// <returns>Task of ApiResponse (PtsV2UpdateOrderPatch201Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PtsV2UpdateOrderPatch201Response>> UpdateOrderAsyncWithHttpInfo (string id, UpdateOrderRequest updateOrderRequest)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'id' is set
            if (id == null)
            {
                logger.Error("ApiException : Missing required parameter 'id' when calling OrdersApi->UpdateOrder");
                throw new ApiException(400, "Missing required parameter 'id' when calling OrdersApi->UpdateOrder");
            }
            // verify the required parameter 'updateOrderRequest' is set
            if (updateOrderRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'updateOrderRequest' when calling OrdersApi->UpdateOrder");
                throw new ApiException(400, "Missing required parameter 'updateOrderRequest' when calling OrdersApi->UpdateOrder");
            }

            var localVarPath = $"/pts/v2/intents/{id}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/hal+json;charset=utf-8"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (id != null)
            {
                localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarPathParams)}");
            if (updateOrderRequest != null && updateOrderRequest.GetType() != typeof(byte[]))
            {
                SdkTracker sdkTracker = new SdkTracker();
                updateOrderRequest = (UpdateOrderRequest)sdkTracker.InsertDeveloperIdTracker(updateOrderRequest, updateOrderRequest.GetType().Name, Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj["runEnvironment"], Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj.ContainsKey("defaultDeveloperId")? Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj["defaultDeveloperId"]:"");
                localVarPostBody = Configuration.ApiClient.Serialize(updateOrderRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = updateOrderRequest; // byte array
            }

            if (logUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{logUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateOrder", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<PtsV2UpdateOrderPatch201Response>(localVarStatusCode,
                localVarResponse.Headers.GroupBy(h => h.Name).ToDictionary(x => x.Key, x => string.Join(", ", x.Select(h => h.Value.ToString()))),
                (PtsV2UpdateOrderPatch201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2UpdateOrderPatch201Response))); // Return statement
        }
    }
}
