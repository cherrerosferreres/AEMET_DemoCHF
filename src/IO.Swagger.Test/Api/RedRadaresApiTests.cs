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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing RedRadaresApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class RedRadaresApiTests
    {
        private RedRadaresApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RedRadaresApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RedRadaresApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' RedRadaresApi
            //Assert.IsInstanceOfType(typeof(RedRadaresApi), instance, "instance is a RedRadaresApi");
        }

        
        /// <summary>
        /// Test ImagenComposicinNacionalRadaresTiempoActualEstndar_
        /// </summary>
        [Test]
        public void ImagenComposicinNacionalRadaresTiempoActualEstndar_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ImagenComposicinNacionalRadaresTiempoActualEstndar_();
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
        /// <summary>
        /// Test RadarRegional
        /// </summary>
        [Test]
        public void RadarRegionalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string radar = null;
            //var response = instance.RadarRegional(radar);
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
    }

}