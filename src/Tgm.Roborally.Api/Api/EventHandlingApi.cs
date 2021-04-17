/*
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: v2.9.0
 * Contact: nbrugger@student.tgm.ac.at
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Tgm.Roborally.Api.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEventHandlingApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get next event
        /// </summary>
        /// <remarks>
        /// Returns the next unfetched event of the ***any*** type.
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">The id of the game to interact with</param>
        /// <returns>GenericEvent</returns>
        GenericEvent FetchNextEvent(int gameId);

        /// <summary>
        /// Get next event
        /// </summary>
        /// <remarks>
        /// Returns the next unfetched event of the ***any*** type.
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">The id of the game to interact with</param>
        /// <returns>ApiResponse of GenericEvent</returns>
        ApiResponse<GenericEvent> FetchNextEventWithHttpInfo(int gameId);
        /// <summary>
        /// trace event
        /// </summary>
        /// <remarks>
        /// All events needed by the client are accessible here. (Usefull for animations) More about this function is found in the [regarding Github Issue](https://github.com/FactoryRally/game-controller/issues/6)  **This function only returns the type of the event you need to fetch the data seperately** &gt; Read more at [api-usage.md](https://github.com/FactoryRally/game-controller/blob/master/documentation/rest/api-usage.md#events- -updates)
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">The id of the game to interact with</param>
        /// <param name="wait">If true the server will not responde until a event is added to the queue  Rrequires less traffic but might impacts the servers performance or cause timeouts at the client</param>
        /// <param name="batch">If true you will get all past events at once If false the list only contains the oldest unfetched event (optional, default to false)</param>
        /// <returns>List&lt;EventType&gt;</returns>
        List<EventType> TraceEvent(int gameId, bool wait, bool? batch = default(bool?));

        /// <summary>
        /// trace event
        /// </summary>
        /// <remarks>
        /// All events needed by the client are accessible here. (Usefull for animations) More about this function is found in the [regarding Github Issue](https://github.com/FactoryRally/game-controller/issues/6)  **This function only returns the type of the event you need to fetch the data seperately** &gt; Read more at [api-usage.md](https://github.com/FactoryRally/game-controller/blob/master/documentation/rest/api-usage.md#events- -updates)
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">The id of the game to interact with</param>
        /// <param name="wait">If true the server will not responde until a event is added to the queue  Rrequires less traffic but might impacts the servers performance or cause timeouts at the client</param>
        /// <param name="batch">If true you will get all past events at once If false the list only contains the oldest unfetched event (optional, default to false)</param>
        /// <returns>ApiResponse of List&lt;EventType&gt;</returns>
        ApiResponse<List<EventType>> TraceEventWithHttpInfo(int gameId, bool wait, bool? batch = default(bool?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEventHandlingApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get next event
        /// </summary>
        /// <remarks>
        /// Returns the next unfetched event of the ***any*** type.
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">The id of the game to interact with</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GenericEvent</returns>
        System.Threading.Tasks.Task<GenericEvent> FetchNextEventAsync(int gameId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get next event
        /// </summary>
        /// <remarks>
        /// Returns the next unfetched event of the ***any*** type.
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">The id of the game to interact with</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GenericEvent)</returns>
        System.Threading.Tasks.Task<ApiResponse<GenericEvent>> FetchNextEventWithHttpInfoAsync(int gameId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// trace event
        /// </summary>
        /// <remarks>
        /// All events needed by the client are accessible here. (Usefull for animations) More about this function is found in the [regarding Github Issue](https://github.com/FactoryRally/game-controller/issues/6)  **This function only returns the type of the event you need to fetch the data seperately** &gt; Read more at [api-usage.md](https://github.com/FactoryRally/game-controller/blob/master/documentation/rest/api-usage.md#events- -updates)
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">The id of the game to interact with</param>
        /// <param name="wait">If true the server will not responde until a event is added to the queue  Rrequires less traffic but might impacts the servers performance or cause timeouts at the client</param>
        /// <param name="batch">If true you will get all past events at once If false the list only contains the oldest unfetched event (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;EventType&gt;</returns>
        System.Threading.Tasks.Task<List<EventType>> TraceEventAsync(int gameId, bool wait, bool? batch = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// trace event
        /// </summary>
        /// <remarks>
        /// All events needed by the client are accessible here. (Usefull for animations) More about this function is found in the [regarding Github Issue](https://github.com/FactoryRally/game-controller/issues/6)  **This function only returns the type of the event you need to fetch the data seperately** &gt; Read more at [api-usage.md](https://github.com/FactoryRally/game-controller/blob/master/documentation/rest/api-usage.md#events- -updates)
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">The id of the game to interact with</param>
        /// <param name="wait">If true the server will not responde until a event is added to the queue  Rrequires less traffic but might impacts the servers performance or cause timeouts at the client</param>
        /// <param name="batch">If true you will get all past events at once If false the list only contains the oldest unfetched event (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;EventType&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<EventType>>> TraceEventWithHttpInfoAsync(int gameId, bool wait, bool? batch = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEventHandlingApi : IEventHandlingApiSync, IEventHandlingApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class EventHandlingApi : IEventHandlingApi
    {
        private Tgm.Roborally.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventHandlingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EventHandlingApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventHandlingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EventHandlingApi(String basePath)
        {
            this.Configuration = Tgm.Roborally.Api.Client.Configuration.MergeConfigurations(
                Tgm.Roborally.Api.Client.GlobalConfiguration.Instance,
                new Tgm.Roborally.Api.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Tgm.Roborally.Api.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Tgm.Roborally.Api.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Tgm.Roborally.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventHandlingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EventHandlingApi(Tgm.Roborally.Api.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Tgm.Roborally.Api.Client.Configuration.MergeConfigurations(
                Tgm.Roborally.Api.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Tgm.Roborally.Api.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Tgm.Roborally.Api.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Tgm.Roborally.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventHandlingApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public EventHandlingApi(Tgm.Roborally.Api.Client.ISynchronousClient client, Tgm.Roborally.Api.Client.IAsynchronousClient asyncClient, Tgm.Roborally.Api.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Tgm.Roborally.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Tgm.Roborally.Api.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Tgm.Roborally.Api.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Tgm.Roborally.Api.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Tgm.Roborally.Api.Client.ExceptionFactory ExceptionFactory
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
        /// Get next event Returns the next unfetched event of the ***any*** type.
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">The id of the game to interact with</param>
        /// <returns>GenericEvent</returns>
        public GenericEvent FetchNextEvent(int gameId)
        {
            Tgm.Roborally.Api.Client.ApiResponse<GenericEvent> localVarResponse = FetchNextEventWithHttpInfo(gameId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get next event Returns the next unfetched event of the ***any*** type.
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">The id of the game to interact with</param>
        /// <returns>ApiResponse of GenericEvent</returns>
        public Tgm.Roborally.Api.Client.ApiResponse<GenericEvent> FetchNextEventWithHttpInfo(int gameId)
        {
            Tgm.Roborally.Api.Client.RequestOptions localVarRequestOptions = new Tgm.Roborally.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Tgm.Roborally.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Tgm.Roborally.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("game_id", Tgm.Roborally.Api.Client.ClientUtils.ParameterToString(gameId)); // path parameter

            // authentication (player-auth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("pat")))
            {
                localVarRequestOptions.QueryParameters.Add(Tgm.Roborally.Api.Client.ClientUtils.ParameterToMultiMap("", "pat", this.Configuration.GetApiKeyWithPrefix("pat")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<GenericEvent>("/games/{game_id}/events/head", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FetchNextEvent", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get next event Returns the next unfetched event of the ***any*** type.
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">The id of the game to interact with</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GenericEvent</returns>
        public async System.Threading.Tasks.Task<GenericEvent> FetchNextEventAsync(int gameId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Tgm.Roborally.Api.Client.ApiResponse<GenericEvent> localVarResponse = await FetchNextEventWithHttpInfoAsync(gameId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get next event Returns the next unfetched event of the ***any*** type.
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">The id of the game to interact with</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GenericEvent)</returns>
        public async System.Threading.Tasks.Task<Tgm.Roborally.Api.Client.ApiResponse<GenericEvent>> FetchNextEventWithHttpInfoAsync(int gameId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Tgm.Roborally.Api.Client.RequestOptions localVarRequestOptions = new Tgm.Roborally.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Tgm.Roborally.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Tgm.Roborally.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("game_id", Tgm.Roborally.Api.Client.ClientUtils.ParameterToString(gameId)); // path parameter

            // authentication (player-auth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("pat")))
            {
                localVarRequestOptions.QueryParameters.Add(Tgm.Roborally.Api.Client.ClientUtils.ParameterToMultiMap("", "pat", this.Configuration.GetApiKeyWithPrefix("pat")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<GenericEvent>("/games/{game_id}/events/head", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FetchNextEvent", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// trace event All events needed by the client are accessible here. (Usefull for animations) More about this function is found in the [regarding Github Issue](https://github.com/FactoryRally/game-controller/issues/6)  **This function only returns the type of the event you need to fetch the data seperately** &gt; Read more at [api-usage.md](https://github.com/FactoryRally/game-controller/blob/master/documentation/rest/api-usage.md#events- -updates)
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">The id of the game to interact with</param>
        /// <param name="wait">If true the server will not responde until a event is added to the queue  Rrequires less traffic but might impacts the servers performance or cause timeouts at the client</param>
        /// <param name="batch">If true you will get all past events at once If false the list only contains the oldest unfetched event (optional, default to false)</param>
        /// <returns>List&lt;EventType&gt;</returns>
        public List<EventType> TraceEvent(int gameId, bool wait, bool? batch = default(bool?))
        {
            Tgm.Roborally.Api.Client.ApiResponse<List<EventType>> localVarResponse = TraceEventWithHttpInfo(gameId, wait, batch);
            return localVarResponse.Data;
        }

        /// <summary>
        /// trace event All events needed by the client are accessible here. (Usefull for animations) More about this function is found in the [regarding Github Issue](https://github.com/FactoryRally/game-controller/issues/6)  **This function only returns the type of the event you need to fetch the data seperately** &gt; Read more at [api-usage.md](https://github.com/FactoryRally/game-controller/blob/master/documentation/rest/api-usage.md#events- -updates)
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">The id of the game to interact with</param>
        /// <param name="wait">If true the server will not responde until a event is added to the queue  Rrequires less traffic but might impacts the servers performance or cause timeouts at the client</param>
        /// <param name="batch">If true you will get all past events at once If false the list only contains the oldest unfetched event (optional, default to false)</param>
        /// <returns>ApiResponse of List&lt;EventType&gt;</returns>
        public Tgm.Roborally.Api.Client.ApiResponse<List<EventType>> TraceEventWithHttpInfo(int gameId, bool wait, bool? batch = default(bool?))
        {
            Tgm.Roborally.Api.Client.RequestOptions localVarRequestOptions = new Tgm.Roborally.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Tgm.Roborally.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Tgm.Roborally.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("game_id", Tgm.Roborally.Api.Client.ClientUtils.ParameterToString(gameId)); // path parameter
            if (batch != null)
            {
                localVarRequestOptions.QueryParameters.Add(Tgm.Roborally.Api.Client.ClientUtils.ParameterToMultiMap("", "batch", batch));
            }
            localVarRequestOptions.QueryParameters.Add(Tgm.Roborally.Api.Client.ClientUtils.ParameterToMultiMap("", "wait", wait));

            // authentication (player-auth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("pat")))
            {
                localVarRequestOptions.QueryParameters.Add(Tgm.Roborally.Api.Client.ClientUtils.ParameterToMultiMap("", "pat", this.Configuration.GetApiKeyWithPrefix("pat")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<EventType>>("/games/{game_id}/events/type", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TraceEvent", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// trace event All events needed by the client are accessible here. (Usefull for animations) More about this function is found in the [regarding Github Issue](https://github.com/FactoryRally/game-controller/issues/6)  **This function only returns the type of the event you need to fetch the data seperately** &gt; Read more at [api-usage.md](https://github.com/FactoryRally/game-controller/blob/master/documentation/rest/api-usage.md#events- -updates)
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">The id of the game to interact with</param>
        /// <param name="wait">If true the server will not responde until a event is added to the queue  Rrequires less traffic but might impacts the servers performance or cause timeouts at the client</param>
        /// <param name="batch">If true you will get all past events at once If false the list only contains the oldest unfetched event (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;EventType&gt;</returns>
        public async System.Threading.Tasks.Task<List<EventType>> TraceEventAsync(int gameId, bool wait, bool? batch = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Tgm.Roborally.Api.Client.ApiResponse<List<EventType>> localVarResponse = await TraceEventWithHttpInfoAsync(gameId, wait, batch, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// trace event All events needed by the client are accessible here. (Usefull for animations) More about this function is found in the [regarding Github Issue](https://github.com/FactoryRally/game-controller/issues/6)  **This function only returns the type of the event you need to fetch the data seperately** &gt; Read more at [api-usage.md](https://github.com/FactoryRally/game-controller/blob/master/documentation/rest/api-usage.md#events- -updates)
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">The id of the game to interact with</param>
        /// <param name="wait">If true the server will not responde until a event is added to the queue  Rrequires less traffic but might impacts the servers performance or cause timeouts at the client</param>
        /// <param name="batch">If true you will get all past events at once If false the list only contains the oldest unfetched event (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;EventType&gt;)</returns>
        public async System.Threading.Tasks.Task<Tgm.Roborally.Api.Client.ApiResponse<List<EventType>>> TraceEventWithHttpInfoAsync(int gameId, bool wait, bool? batch = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Tgm.Roborally.Api.Client.RequestOptions localVarRequestOptions = new Tgm.Roborally.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Tgm.Roborally.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Tgm.Roborally.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("game_id", Tgm.Roborally.Api.Client.ClientUtils.ParameterToString(gameId)); // path parameter
            if (batch != null)
            {
                localVarRequestOptions.QueryParameters.Add(Tgm.Roborally.Api.Client.ClientUtils.ParameterToMultiMap("", "batch", batch));
            }
            localVarRequestOptions.QueryParameters.Add(Tgm.Roborally.Api.Client.ClientUtils.ParameterToMultiMap("", "wait", wait));

            // authentication (player-auth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("pat")))
            {
                localVarRequestOptions.QueryParameters.Add(Tgm.Roborally.Api.Client.ClientUtils.ParameterToMultiMap("", "pat", this.Configuration.GetApiKeyWithPrefix("pat")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<EventType>>("/games/{game_id}/events/type", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TraceEvent", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
