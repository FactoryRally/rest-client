/* 
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: v0.8.0
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
    public interface IUpgradesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Buy Upgrade
        /// </summary>
        /// <remarks>
        /// Buy this Upgrade from the shop. ### Note If your robot allready owns 3 Upgrades you have to use the &#x60;exchange&#x60; parameter. This is the ID of the Upgrade to replace with the bought one
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <param name="upgrade"></param>
        /// <param name="exchange"> (optional)</param>
        /// <returns></returns>
        void BuyUpgrade (int gameId, int upgrade, int? exchange = default(int?));

        /// <summary>
        /// Buy Upgrade
        /// </summary>
        /// <remarks>
        /// Buy this Upgrade from the shop. ### Note If your robot allready owns 3 Upgrades you have to use the &#x60;exchange&#x60; parameter. This is the ID of the Upgrade to replace with the bought one
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <param name="upgrade"></param>
        /// <param name="exchange"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> BuyUpgradeWithHttpInfo (int gameId, int upgrade, int? exchange = default(int?));
        /// <summary>
        /// get all Upgrades
        /// </summary>
        /// <remarks>
        /// Returns a list of all Upgrade IDs
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <returns>List&lt;int&gt;</returns>
        List<int> GetAllUpgradeIDs (int gameId);

        /// <summary>
        /// get all Upgrades
        /// </summary>
        /// <remarks>
        /// Returns a list of all Upgrade IDs
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <returns>ApiResponse of List&lt;int&gt;</returns>
        ApiResponse<List<int>> GetAllUpgradeIDsWithHttpInfo (int gameId);
        /// <summary>
        /// Get upgrade information
        /// </summary>
        /// <remarks>
        /// Get detailed information about the Upgrade
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <param name="upgradeId"></param>
        /// <returns>Upgrade</returns>
        Upgrade GetUpgradeInformation (int gameId, int upgradeId);

        /// <summary>
        /// Get upgrade information
        /// </summary>
        /// <remarks>
        /// Get detailed information about the Upgrade
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <param name="upgradeId"></param>
        /// <returns>ApiResponse of Upgrade</returns>
        ApiResponse<Upgrade> GetUpgradeInformationWithHttpInfo (int gameId, int upgradeId);
        /// <summary>
        /// Get upgrade shop
        /// </summary>
        /// <remarks>
        /// Retuns a list of all cards in the upgrade shop
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <returns>UpgradeShop</returns>
        UpgradeShop GetUpgradeShop (int gameId);

        /// <summary>
        /// Get upgrade shop
        /// </summary>
        /// <remarks>
        /// Retuns a list of all cards in the upgrade shop
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <returns>ApiResponse of UpgradeShop</returns>
        ApiResponse<UpgradeShop> GetUpgradeShopWithHttpInfo (int gameId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUpgradesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Buy Upgrade
        /// </summary>
        /// <remarks>
        /// Buy this Upgrade from the shop. ### Note If your robot allready owns 3 Upgrades you have to use the &#x60;exchange&#x60; parameter. This is the ID of the Upgrade to replace with the bought one
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <param name="upgrade"></param>
        /// <param name="exchange"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task BuyUpgradeAsync (int gameId, int upgrade, int? exchange = default(int?));

        /// <summary>
        /// Buy Upgrade
        /// </summary>
        /// <remarks>
        /// Buy this Upgrade from the shop. ### Note If your robot allready owns 3 Upgrades you have to use the &#x60;exchange&#x60; parameter. This is the ID of the Upgrade to replace with the bought one
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <param name="upgrade"></param>
        /// <param name="exchange"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> BuyUpgradeAsyncWithHttpInfo (int gameId, int upgrade, int? exchange = default(int?));
        /// <summary>
        /// get all Upgrades
        /// </summary>
        /// <remarks>
        /// Returns a list of all Upgrade IDs
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <returns>Task of List&lt;int&gt;</returns>
        System.Threading.Tasks.Task<List<int>> GetAllUpgradeIDsAsync (int gameId);

        /// <summary>
        /// get all Upgrades
        /// </summary>
        /// <remarks>
        /// Returns a list of all Upgrade IDs
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <returns>Task of ApiResponse (List&lt;int&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<int>>> GetAllUpgradeIDsAsyncWithHttpInfo (int gameId);
        /// <summary>
        /// Get upgrade information
        /// </summary>
        /// <remarks>
        /// Get detailed information about the Upgrade
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <param name="upgradeId"></param>
        /// <returns>Task of Upgrade</returns>
        System.Threading.Tasks.Task<Upgrade> GetUpgradeInformationAsync (int gameId, int upgradeId);

        /// <summary>
        /// Get upgrade information
        /// </summary>
        /// <remarks>
        /// Get detailed information about the Upgrade
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <param name="upgradeId"></param>
        /// <returns>Task of ApiResponse (Upgrade)</returns>
        System.Threading.Tasks.Task<ApiResponse<Upgrade>> GetUpgradeInformationAsyncWithHttpInfo (int gameId, int upgradeId);
        /// <summary>
        /// Get upgrade shop
        /// </summary>
        /// <remarks>
        /// Retuns a list of all cards in the upgrade shop
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <returns>Task of UpgradeShop</returns>
        System.Threading.Tasks.Task<UpgradeShop> GetUpgradeShopAsync (int gameId);

        /// <summary>
        /// Get upgrade shop
        /// </summary>
        /// <remarks>
        /// Retuns a list of all cards in the upgrade shop
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <returns>Task of ApiResponse (UpgradeShop)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpgradeShop>> GetUpgradeShopAsyncWithHttpInfo (int gameId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUpgradesApi : IUpgradesApiSync, IUpgradesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UpgradesApi : IUpgradesApi
    {
        private Tgm.Roborally.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UpgradesApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UpgradesApi(String basePath)
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
        /// Initializes a new instance of the <see cref="UpgradesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UpgradesApi(Tgm.Roborally.Api.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="UpgradesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public UpgradesApi(Tgm.Roborally.Api.Client.ISynchronousClient client,Tgm.Roborally.Api.Client.IAsynchronousClient asyncClient, Tgm.Roborally.Api.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

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
        public Tgm.Roborally.Api.Client.IReadableConfiguration Configuration {get; set;}

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
        /// Buy Upgrade Buy this Upgrade from the shop. ### Note If your robot allready owns 3 Upgrades you have to use the &#x60;exchange&#x60; parameter. This is the ID of the Upgrade to replace with the bought one
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <param name="upgrade"></param>
        /// <param name="exchange"> (optional)</param>
        /// <returns></returns>
        public void BuyUpgrade (int gameId, int upgrade, int? exchange = default(int?))
        {
             BuyUpgradeWithHttpInfo(gameId, upgrade, exchange);
        }

        /// <summary>
        /// Buy Upgrade Buy this Upgrade from the shop. ### Note If your robot allready owns 3 Upgrades you have to use the &#x60;exchange&#x60; parameter. This is the ID of the Upgrade to replace with the bought one
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <param name="upgrade"></param>
        /// <param name="exchange"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Tgm.Roborally.Api.Client.ApiResponse<Object> BuyUpgradeWithHttpInfo (int gameId, int upgrade, int? exchange = default(int?))
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
            localVarRequestOptions.QueryParameters.Add(Tgm.Roborally.Api.Client.ClientUtils.ParameterToMultiMap("", "upgrade", upgrade));
            if (exchange != null)
            {
                localVarRequestOptions.QueryParameters.Add(Tgm.Roborally.Api.Client.ClientUtils.ParameterToMultiMap("", "exchange", exchange));
            }

            // authentication (player-auth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("pat")))
            {
                localVarRequestOptions.QueryParameters.Add(Tgm.Roborally.Api.Client.ClientUtils.ParameterToMultiMap("", "pat", this.Configuration.GetApiKeyWithPrefix("pat")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Patch<Object>("/games/{game_id}/upgrades/shop", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BuyUpgrade", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Buy Upgrade Buy this Upgrade from the shop. ### Note If your robot allready owns 3 Upgrades you have to use the &#x60;exchange&#x60; parameter. This is the ID of the Upgrade to replace with the bought one
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <param name="upgrade"></param>
        /// <param name="exchange"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task BuyUpgradeAsync (int gameId, int upgrade, int? exchange = default(int?))
        {
             await BuyUpgradeAsyncWithHttpInfo(gameId, upgrade, exchange);

        }

        /// <summary>
        /// Buy Upgrade Buy this Upgrade from the shop. ### Note If your robot allready owns 3 Upgrades you have to use the &#x60;exchange&#x60; parameter. This is the ID of the Upgrade to replace with the bought one
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <param name="upgrade"></param>
        /// <param name="exchange"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Tgm.Roborally.Api.Client.ApiResponse<Object>> BuyUpgradeAsyncWithHttpInfo (int gameId, int upgrade, int? exchange = default(int?))
        {

            Tgm.Roborally.Api.Client.RequestOptions localVarRequestOptions = new Tgm.Roborally.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.PathParameters.Add("game_id", Tgm.Roborally.Api.Client.ClientUtils.ParameterToString(gameId)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Tgm.Roborally.Api.Client.ClientUtils.ParameterToMultiMap("", "upgrade", upgrade));
            if (exchange != null)
            {
                localVarRequestOptions.QueryParameters.Add(Tgm.Roborally.Api.Client.ClientUtils.ParameterToMultiMap("", "exchange", exchange));
            }

            // authentication (player-auth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("pat")))
            {
                localVarRequestOptions.QueryParameters.Add(Tgm.Roborally.Api.Client.ClientUtils.ParameterToMultiMap("", "pat", this.Configuration.GetApiKeyWithPrefix("pat")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PatchAsync<Object>("/games/{game_id}/upgrades/shop", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BuyUpgrade", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get all Upgrades Returns a list of all Upgrade IDs
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <returns>List&lt;int&gt;</returns>
        public List<int> GetAllUpgradeIDs (int gameId)
        {
             Tgm.Roborally.Api.Client.ApiResponse<List<int>> localVarResponse = GetAllUpgradeIDsWithHttpInfo(gameId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// get all Upgrades Returns a list of all Upgrade IDs
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <returns>ApiResponse of List&lt;int&gt;</returns>
        public Tgm.Roborally.Api.Client.ApiResponse< List<int> > GetAllUpgradeIDsWithHttpInfo (int gameId)
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
            var localVarResponse = this.Client.Get< List<int> >("/games/{game_id}/upgrades/", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAllUpgradeIDs", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// get all Upgrades Returns a list of all Upgrade IDs
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <returns>Task of List&lt;int&gt;</returns>
        public async System.Threading.Tasks.Task<List<int>> GetAllUpgradeIDsAsync (int gameId)
        {
             Tgm.Roborally.Api.Client.ApiResponse<List<int>> localVarResponse = await GetAllUpgradeIDsAsyncWithHttpInfo(gameId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// get all Upgrades Returns a list of all Upgrade IDs
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <returns>Task of ApiResponse (List&lt;int&gt;)</returns>
        public async System.Threading.Tasks.Task<Tgm.Roborally.Api.Client.ApiResponse<List<int>>> GetAllUpgradeIDsAsyncWithHttpInfo (int gameId)
        {

            Tgm.Roborally.Api.Client.RequestOptions localVarRequestOptions = new Tgm.Roborally.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.PathParameters.Add("game_id", Tgm.Roborally.Api.Client.ClientUtils.ParameterToString(gameId)); // path parameter

            // authentication (player-auth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("pat")))
            {
                localVarRequestOptions.QueryParameters.Add(Tgm.Roborally.Api.Client.ClientUtils.ParameterToMultiMap("", "pat", this.Configuration.GetApiKeyWithPrefix("pat")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<int>>("/games/{game_id}/upgrades/", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAllUpgradeIDs", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get upgrade information Get detailed information about the Upgrade
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <param name="upgradeId"></param>
        /// <returns>Upgrade</returns>
        public Upgrade GetUpgradeInformation (int gameId, int upgradeId)
        {
             Tgm.Roborally.Api.Client.ApiResponse<Upgrade> localVarResponse = GetUpgradeInformationWithHttpInfo(gameId, upgradeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get upgrade information Get detailed information about the Upgrade
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <param name="upgradeId"></param>
        /// <returns>ApiResponse of Upgrade</returns>
        public Tgm.Roborally.Api.Client.ApiResponse< Upgrade > GetUpgradeInformationWithHttpInfo (int gameId, int upgradeId)
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
            localVarRequestOptions.PathParameters.Add("upgrade_id", Tgm.Roborally.Api.Client.ClientUtils.ParameterToString(upgradeId)); // path parameter

            // authentication (player-auth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("pat")))
            {
                localVarRequestOptions.QueryParameters.Add(Tgm.Roborally.Api.Client.ClientUtils.ParameterToMultiMap("", "pat", this.Configuration.GetApiKeyWithPrefix("pat")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< Upgrade >("/games/{game_id}/upgrades/{upgrade_id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetUpgradeInformation", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get upgrade information Get detailed information about the Upgrade
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <param name="upgradeId"></param>
        /// <returns>Task of Upgrade</returns>
        public async System.Threading.Tasks.Task<Upgrade> GetUpgradeInformationAsync (int gameId, int upgradeId)
        {
             Tgm.Roborally.Api.Client.ApiResponse<Upgrade> localVarResponse = await GetUpgradeInformationAsyncWithHttpInfo(gameId, upgradeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get upgrade information Get detailed information about the Upgrade
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <param name="upgradeId"></param>
        /// <returns>Task of ApiResponse (Upgrade)</returns>
        public async System.Threading.Tasks.Task<Tgm.Roborally.Api.Client.ApiResponse<Upgrade>> GetUpgradeInformationAsyncWithHttpInfo (int gameId, int upgradeId)
        {

            Tgm.Roborally.Api.Client.RequestOptions localVarRequestOptions = new Tgm.Roborally.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.PathParameters.Add("game_id", Tgm.Roborally.Api.Client.ClientUtils.ParameterToString(gameId)); // path parameter
            localVarRequestOptions.PathParameters.Add("upgrade_id", Tgm.Roborally.Api.Client.ClientUtils.ParameterToString(upgradeId)); // path parameter

            // authentication (player-auth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("pat")))
            {
                localVarRequestOptions.QueryParameters.Add(Tgm.Roborally.Api.Client.ClientUtils.ParameterToMultiMap("", "pat", this.Configuration.GetApiKeyWithPrefix("pat")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Upgrade>("/games/{game_id}/upgrades/{upgrade_id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetUpgradeInformation", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get upgrade shop Retuns a list of all cards in the upgrade shop
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <returns>UpgradeShop</returns>
        public UpgradeShop GetUpgradeShop (int gameId)
        {
             Tgm.Roborally.Api.Client.ApiResponse<UpgradeShop> localVarResponse = GetUpgradeShopWithHttpInfo(gameId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get upgrade shop Retuns a list of all cards in the upgrade shop
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <returns>ApiResponse of UpgradeShop</returns>
        public Tgm.Roborally.Api.Client.ApiResponse< UpgradeShop > GetUpgradeShopWithHttpInfo (int gameId)
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
            var localVarResponse = this.Client.Get< UpgradeShop >("/games/{game_id}/upgrades/shop", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetUpgradeShop", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get upgrade shop Retuns a list of all cards in the upgrade shop
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <returns>Task of UpgradeShop</returns>
        public async System.Threading.Tasks.Task<UpgradeShop> GetUpgradeShopAsync (int gameId)
        {
             Tgm.Roborally.Api.Client.ApiResponse<UpgradeShop> localVarResponse = await GetUpgradeShopAsyncWithHttpInfo(gameId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get upgrade shop Retuns a list of all cards in the upgrade shop
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <returns>Task of ApiResponse (UpgradeShop)</returns>
        public async System.Threading.Tasks.Task<Tgm.Roborally.Api.Client.ApiResponse<UpgradeShop>> GetUpgradeShopAsyncWithHttpInfo (int gameId)
        {

            Tgm.Roborally.Api.Client.RequestOptions localVarRequestOptions = new Tgm.Roborally.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.PathParameters.Add("game_id", Tgm.Roborally.Api.Client.ClientUtils.ParameterToString(gameId)); // path parameter

            // authentication (player-auth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("pat")))
            {
                localVarRequestOptions.QueryParameters.Add(Tgm.Roborally.Api.Client.ClientUtils.ParameterToMultiMap("", "pat", this.Configuration.GetApiKeyWithPrefix("pat")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<UpgradeShop>("/games/{game_id}/upgrades/shop", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetUpgradeShop", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
