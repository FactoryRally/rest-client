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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Model;

namespace Tgm.Roborally.Api.Test
{
    /// <summary>
    ///  Class for testing RobotsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RobotsApiTests : IDisposable
    {
        private RobotsApi instance;

        public RobotsApiTests()
        {
            instance = new RobotsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RobotsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' RobotsApi
            //Assert.IsType(typeof(RobotsApi), instance, "instance is a RobotsApi");
        }

        
        /// <summary>
        /// Test ClearRegisters
        /// </summary>
        [Fact]
        public void ClearRegistersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int gameId = null;
            //int robotId = null;
            //instance.ClearRegisters(gameId, robotId);
            
        }
        
        /// <summary>
        /// Test ClearUpgrades
        /// </summary>
        [Fact]
        public void ClearUpgradesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int gameId = null;
            //int robotId = null;
            //instance.ClearUpgrades(gameId, robotId);
            
        }
        
        /// <summary>
        /// Test DoEntityAction
        /// </summary>
        [Fact]
        public void DoEntityActionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int gameId = null;
            //string robotId = null;
            //EntityAction entityAction = null;
            //instance.DoEntityAction(gameId, robotId, entityAction);
            
        }
        
        /// <summary>
        /// Test GetActionStack
        /// </summary>
        [Fact]
        public void GetActionStackTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int gameId = null;
            //string robotId = null;
            //var response = instance.GetActionStack(gameId, robotId);
            //Assert.IsType<List<EntityAction>> (response, "response is List<EntityAction>");
        }
        
        /// <summary>
        /// Test GetInstalledUpgrades
        /// </summary>
        [Fact]
        public void GetInstalledUpgradesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int gameId = null;
            //int robotId = null;
            //var response = instance.GetInstalledUpgrades(gameId, robotId);
            //Assert.IsType<List<int>> (response, "response is List<int>");
        }
        
        /// <summary>
        /// Test GetPossibleActions
        /// </summary>
        [Fact]
        public void GetPossibleActionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int gameId = null;
            //string robotId = null;
            //var response = instance.GetPossibleActions(gameId, robotId);
            //Assert.IsType<List<EntityEventOportunity>> (response, "response is List<EntityEventOportunity>");
        }
        
        /// <summary>
        /// Test GetRegisterContent
        /// </summary>
        [Fact]
        public void GetRegisterContentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int gameId = null;
            //int robotId = null;
            //int register = null;
            //var response = instance.GetRegisterContent(gameId, robotId, register);
            //Assert.IsType<RobotCommand> (response, "response is RobotCommand");
        }
        
        /// <summary>
        /// Test GetRegisters
        /// </summary>
        [Fact]
        public void GetRegistersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int gameId = null;
            //int robotId = null;
            //var response = instance.GetRegisters(gameId, robotId);
            //Assert.IsType<List<RobotCommand>> (response, "response is List<RobotCommand>");
        }
        
        /// <summary>
        /// Test GetRobotStats
        /// </summary>
        [Fact]
        public void GetRobotStatsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int gameId = null;
            //string robotId = null;
            //var response = instance.GetRobotStats(gameId, robotId);
            //Assert.IsType<RobotInfo> (response, "response is RobotInfo");
        }
        
        /// <summary>
        /// Test GetRobots
        /// </summary>
        [Fact]
        public void GetRobotsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int gameId = null;
            //var response = instance.GetRobots(gameId);
            //Assert.IsType<List<int>> (response, "response is List<int>");
        }
        
        /// <summary>
        /// Test RemoveRobotUpgrade
        /// </summary>
        [Fact]
        public void RemoveRobotUpgradeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int gameId = null;
            //int robotId = null;
            //int? upgrade = null;
            //instance.RemoveRobotUpgrade(gameId, robotId, upgrade);
            
        }
        
        /// <summary>
        /// Test SetRegister
        /// </summary>
        [Fact]
        public void SetRegisterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int gameId = null;
            //int robotId = null;
            //int register = null;
            //int statementId = null;
            //instance.SetRegister(gameId, robotId, register, statementId);
            
        }
        
    }

}
