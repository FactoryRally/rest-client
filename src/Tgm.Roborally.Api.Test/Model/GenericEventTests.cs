/* 
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: v0.8.0
 * Contact: nbrugger@student.tgm.ac.at
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Model;
using Tgm.Roborally.Api.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Tgm.Roborally.Api.Test
{
    /// <summary>
    ///  Class for testing GenericEvent
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GenericEventTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GenericEvent
        //private GenericEvent instance;

        public GenericEventTests()
        {
            // TODO uncomment below to create an instance of GenericEvent
            //instance = new GenericEvent();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GenericEvent
        /// </summary>
        [Fact]
        public void GenericEventInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" GenericEvent
            //Assert.IsInstanceOfType<GenericEvent> (instance, "variable 'instance' is a GenericEvent");
        }


        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            // TODO unit test for the property 'Data'
        }

    }

}
