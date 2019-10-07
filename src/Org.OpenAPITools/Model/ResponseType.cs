/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.8.0.20190731.002
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// The type of the response.
    /// </summary>
    /// <value>The type of the response.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ResponseType
    {
        /// <summary>
        /// Enum BadRequest for value: BadRequest
        /// </summary>
        [EnumMember(Value = "BadRequest")]
        BadRequest = 1,

        /// <summary>
        /// Enum Unauthenticated for value: Unauthenticated
        /// </summary>
        [EnumMember(Value = "Unauthenticated")]
        Unauthenticated = 2,

        /// <summary>
        /// Enum Unauthorized for value: Unauthorized
        /// </summary>
        [EnumMember(Value = "Unauthorized")]
        Unauthorized = 3,

        /// <summary>
        /// Enum NotFound for value: NotFound
        /// </summary>
        [EnumMember(Value = "NotFound")]
        NotFound = 4,

        /// <summary>
        /// Enum GatewayDeclined for value: GatewayDeclined
        /// </summary>
        [EnumMember(Value = "GatewayDeclined")]
        GatewayDeclined = 5,

        /// <summary>
        /// Enum EndpointDeclined for value: EndpointDeclined
        /// </summary>
        [EnumMember(Value = "EndpointDeclined")]
        EndpointDeclined = 6,

        /// <summary>
        /// Enum ServerError for value: ServerError
        /// </summary>
        [EnumMember(Value = "ServerError")]
        ServerError = 7,

        /// <summary>
        /// Enum EndpointCommunicationError for value: EndpointCommunicationError
        /// </summary>
        [EnumMember(Value = "EndpointCommunicationError")]
        EndpointCommunicationError = 8,

        /// <summary>
        /// Enum UnsupportedMediaType for value: UnsupportedMediaType
        /// </summary>
        [EnumMember(Value = "UnsupportedMediaType")]
        UnsupportedMediaType = 9

    }

}
