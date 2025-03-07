// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The SentimentTaskResult. </summary>
    internal partial class SentimentTaskResult
    {
        /// <summary> Initializes a new instance of SentimentTaskResult. </summary>
        internal SentimentTaskResult()
        {
        }

        /// <summary> Initializes a new instance of SentimentTaskResult. </summary>
        /// <param name="results"></param>
        internal SentimentTaskResult(SentimentResponse results)
        {
            Results = results;
        }

        /// <summary> Gets the results. </summary>
        public SentimentResponse Results { get; }
    }
}
