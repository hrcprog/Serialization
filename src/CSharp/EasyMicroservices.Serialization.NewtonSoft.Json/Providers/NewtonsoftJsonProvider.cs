﻿using System;
using EasyMicroservices.Serialization.Interfaces;
using EasyMicroservices.Serialization.Providers;
using Newtonsoft.Json;

namespace EasyMicroservices.Serialization.Newtonsoft.Json.Providers
{
    /// <summary>
    /// use NewtonsoftJson package as text serialization provider 
    /// </summary>
    public class NewtonsoftJsonProvider : TextSerializationBaseProvider
    {
        /// <summary>
        /// Deserialize from string
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public override T Deserialize<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }
        /// <summary>
        /// Serialize to string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override string Serialize<T>(T value)
        {
            return JsonConvert.SerializeObject(value);
        }
    }
}
