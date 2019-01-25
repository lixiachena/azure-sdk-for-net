// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties for the task that validates a migration between MongoDB data
    /// sources
    /// </summary>
    [Newtonsoft.Json.JsonObject("Validate.MongoDb")]
    public partial class ValidateMongoDbTaskProperties : ProjectTaskProperties
    {
        /// <summary>
        /// Initializes a new instance of the ValidateMongoDbTaskProperties
        /// class.
        /// </summary>
        public ValidateMongoDbTaskProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ValidateMongoDbTaskProperties
        /// class.
        /// </summary>
        /// <param name="errors">Array of errors. This is ignored if
        /// submitted.</param>
        /// <param name="state">The state of the task. This is ignored if
        /// submitted. Possible values include: 'Unknown', 'Queued', 'Running',
        /// 'Canceled', 'Succeeded', 'Failed', 'FailedInputValidation',
        /// 'Faulted'</param>
        /// <param name="commands">Array of command properties.</param>
        /// <param name="clientData">Key value pairs of client data to attach
        /// meta data information to task</param>
        /// <param name="output">An array containing a single
        /// MongoDbMigrationProgress object</param>
        public ValidateMongoDbTaskProperties(IList<ODataError> errors = default(IList<ODataError>), string state = default(string), IList<CommandProperties> commands = default(IList<CommandProperties>), IDictionary<string, string> clientData = default(IDictionary<string, string>), MongoDbMigrationSettings input = default(MongoDbMigrationSettings), IList<MongoDbMigrationProgress> output = default(IList<MongoDbMigrationProgress>))
            : base(errors, state, commands, clientData)
        {
            Input = input;
            Output = output;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "input")]
        public MongoDbMigrationSettings Input { get; set; }

        /// <summary>
        /// Gets an array containing a single MongoDbMigrationProgress object
        /// </summary>
        [JsonProperty(PropertyName = "output")]
        public IList<MongoDbMigrationProgress> Output { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Input != null)
            {
                Input.Validate();
            }
            if (Output != null)
            {
                foreach (var element in Output)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
