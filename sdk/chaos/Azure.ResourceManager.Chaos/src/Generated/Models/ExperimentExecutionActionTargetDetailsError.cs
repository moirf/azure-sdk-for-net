// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Model that represents the Experiment action target details error model. </summary>
    public partial class ExperimentExecutionActionTargetDetailsError
    {
        /// <summary> Initializes a new instance of ExperimentExecutionActionTargetDetailsError. </summary>
        internal ExperimentExecutionActionTargetDetailsError()
        {
        }

        /// <summary> Initializes a new instance of ExperimentExecutionActionTargetDetailsError. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="message"> The error message. </param>
        internal ExperimentExecutionActionTargetDetailsError(string code, string message)
        {
            Code = code;
            Message = message;
        }

        /// <summary> The error code. </summary>
        public string Code { get; }
        /// <summary> The error message. </summary>
        public string Message { get; }
    }
}
