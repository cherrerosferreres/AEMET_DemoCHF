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
    ///  Class for testing PrediccionMaritimaApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PrediccionMaritimaApiTests
    {
        private PrediccionMaritimaApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PrediccionMaritimaApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PrediccionMaritimaApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PrediccionMaritimaApi
            //Assert.IsInstanceOfType(typeof(PrediccionMaritimaApi), instance, "instance is a PrediccionMaritimaApi");
        }

        
        /// <summary>
        /// Test PrediccinMartimaCostera_
        /// </summary>
        [Test]
        public void PrediccinMartimaCostera_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string costa = null;
            //var response = instance.PrediccinMartimaCostera_(costa);
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
        /// <summary>
        /// Test PrediccinMartimaDeAltaMar_
        /// </summary>
        [Test]
        public void PrediccinMartimaDeAltaMar_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string area = null;
            //var response = instance.PrediccinMartimaDeAltaMar_(area);
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
    }

}