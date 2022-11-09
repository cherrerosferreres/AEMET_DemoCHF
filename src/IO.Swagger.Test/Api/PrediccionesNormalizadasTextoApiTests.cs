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
    ///  Class for testing PrediccionesNormalizadasTextoApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PrediccionesNormalizadasTextoApiTests
    {
        private PrediccionesNormalizadasTextoApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PrediccionesNormalizadasTextoApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PrediccionesNormalizadasTextoApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PrediccionesNormalizadasTextoApi
            //Assert.IsInstanceOfType(typeof(PrediccionesNormalizadasTextoApi), instance, "instance is a PrediccionesNormalizadasTextoApi");
        }

        
        /// <summary>
        /// Test PrediccinCCAAHoyArchivo_
        /// </summary>
        [Test]
        public void PrediccinCCAAHoyArchivo_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ccaa = null;
            //string fecha = null;
            //var response = instance.PrediccinCCAAHoyArchivo_(ccaa, fecha);
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
        /// <summary>
        /// Test PrediccinCCAAHoyTiempoActual_
        /// </summary>
        [Test]
        public void PrediccinCCAAHoyTiempoActual_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ccaa = null;
            //var response = instance.PrediccinCCAAHoyTiempoActual_(ccaa);
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
        /// <summary>
        /// Test PrediccinCCAAMaanaArchivo_
        /// </summary>
        [Test]
        public void PrediccinCCAAMaanaArchivo_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ccaa = null;
            //string fecha = null;
            //var response = instance.PrediccinCCAAMaanaArchivo_(ccaa, fecha);
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
        /// <summary>
        /// Test PrediccinCCAAMaanaTiempoActual_
        /// </summary>
        [Test]
        public void PrediccinCCAAMaanaTiempoActual_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ccaa = null;
            //var response = instance.PrediccinCCAAMaanaTiempoActual_(ccaa);
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
        /// <summary>
        /// Test PrediccinCCAAMedioPlazoArchivo_
        /// </summary>
        [Test]
        public void PrediccinCCAAMedioPlazoArchivo_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ccaa = null;
            //string fecha = null;
            //var response = instance.PrediccinCCAAMedioPlazoArchivo_(ccaa, fecha);
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
        /// <summary>
        /// Test PrediccinCCAAMedioPlazoTiempoActual_
        /// </summary>
        [Test]
        public void PrediccinCCAAMedioPlazoTiempoActual_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ccaa = null;
            //var response = instance.PrediccinCCAAMedioPlazoTiempoActual_(ccaa);
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
        /// <summary>
        /// Test PrediccinCCAAPasadoMaanaArchivo_
        /// </summary>
        [Test]
        public void PrediccinCCAAPasadoMaanaArchivo_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ccaa = null;
            //string fecha = null;
            //var response = instance.PrediccinCCAAPasadoMaanaArchivo_(ccaa, fecha);
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
        /// <summary>
        /// Test PrediccinCCAAPasadoMaanaTiempoActual_
        /// </summary>
        [Test]
        public void PrediccinCCAAPasadoMaanaTiempoActual_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ccaa = null;
            //var response = instance.PrediccinCCAAPasadoMaanaTiempoActual_(ccaa);
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
        /// <summary>
        /// Test PrediccinNacionalHoyArchivo_
        /// </summary>
        [Test]
        public void PrediccinNacionalHoyArchivo_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fecha = null;
            //var response = instance.PrediccinNacionalHoyArchivo_(fecha);
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
        /// <summary>
        /// Test PrediccinNacionalHoyTiempoActual_
        /// </summary>
        [Test]
        public void PrediccinNacionalHoyTiempoActual_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.PrediccinNacionalHoyTiempoActual_();
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
        /// <summary>
        /// Test PrediccinNacionalMaanaArchivo_
        /// </summary>
        [Test]
        public void PrediccinNacionalMaanaArchivo_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fecha = null;
            //var response = instance.PrediccinNacionalMaanaArchivo_(fecha);
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
        /// <summary>
        /// Test PrediccinNacionalMaanaTiempoActual_
        /// </summary>
        [Test]
        public void PrediccinNacionalMaanaTiempoActual_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.PrediccinNacionalMaanaTiempoActual_();
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
        /// <summary>
        /// Test PrediccinNacionalMedioPlazoArchivo_
        /// </summary>
        [Test]
        public void PrediccinNacionalMedioPlazoArchivo_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fecha = null;
            //var response = instance.PrediccinNacionalMedioPlazoArchivo_(fecha);
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
        /// <summary>
        /// Test PrediccinNacionalMedioPlazoTiempoActual_
        /// </summary>
        [Test]
        public void PrediccinNacionalMedioPlazoTiempoActual_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.PrediccinNacionalMedioPlazoTiempoActual_();
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
        /// <summary>
        /// Test PrediccinNacionalPasadoMaanaArchivo_
        /// </summary>
        [Test]
        public void PrediccinNacionalPasadoMaanaArchivo_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fecha = null;
            //var response = instance.PrediccinNacionalPasadoMaanaArchivo_(fecha);
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
        /// <summary>
        /// Test PrediccinNacionalPasadoMaanaTiempoActual_
        /// </summary>
        [Test]
        public void PrediccinNacionalPasadoMaanaTiempoActual_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.PrediccinNacionalPasadoMaanaTiempoActual_();
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
        /// <summary>
        /// Test PrediccinNacionalTendenciaArchivo_
        /// </summary>
        [Test]
        public void PrediccinNacionalTendenciaArchivo_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fecha = null;
            //var response = instance.PrediccinNacionalTendenciaArchivo_(fecha);
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
        /// <summary>
        /// Test PrediccinNacionalTendenciaTiempoActual_
        /// </summary>
        [Test]
        public void PrediccinNacionalTendenciaTiempoActual_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.PrediccinNacionalTendenciaTiempoActual_();
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
        /// <summary>
        /// Test PrediccinProvinciaHoyArchivo_
        /// </summary>
        [Test]
        public void PrediccinProvinciaHoyArchivo_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string provincia = null;
            //string fecha = null;
            //var response = instance.PrediccinProvinciaHoyArchivo_(provincia, fecha);
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
        /// <summary>
        /// Test PrediccinProvinciaHoyTiempoActual_
        /// </summary>
        [Test]
        public void PrediccinProvinciaHoyTiempoActual_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string provincia = null;
            //var response = instance.PrediccinProvinciaHoyTiempoActual_(provincia);
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
        /// <summary>
        /// Test PrediccinProvinciaMaanaArchivo_
        /// </summary>
        [Test]
        public void PrediccinProvinciaMaanaArchivo_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string provincia = null;
            //string fecha = null;
            //var response = instance.PrediccinProvinciaMaanaArchivo_(provincia, fecha);
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
        /// <summary>
        /// Test PrediccinProvinciaMaanaTiempoActual_
        /// </summary>
        [Test]
        public void PrediccinProvinciaMaanaTiempoActual_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string provincia = null;
            //var response = instance.PrediccinProvinciaMaanaTiempoActual_(provincia);
            //Assert.IsInstanceOf<Model200> (response, "response is Model200");
        }
        
    }

}