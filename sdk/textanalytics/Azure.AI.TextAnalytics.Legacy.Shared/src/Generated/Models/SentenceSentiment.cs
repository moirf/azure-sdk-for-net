// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics.Legacy.Models;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The SentenceSentiment. </summary>
    internal partial class SentenceSentiment
    {
        /// <summary> Initializes a new instance of SentenceSentiment. </summary>
        /// <param name="text"> The sentence text. </param>
        /// <param name="sentiment"> The predicted Sentiment for the sentence. </param>
        /// <param name="confidenceScores"> The sentiment confidence score between 0 and 1 for the sentence for all classes. </param>
        /// <param name="offset"> The sentence offset from the start of the document. </param>
        /// <param name="length"> The length of the sentence. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> or <paramref name="confidenceScores"/> is null. </exception>
        internal SentenceSentiment(string text, SentenceSentimentValue sentiment, SentimentConfidenceScorePerLabel confidenceScores, int offset, int length)
        {
            Argument.AssertNotNull(text, nameof(text));
            Argument.AssertNotNull(confidenceScores, nameof(confidenceScores));

            Text = text;
            Sentiment = sentiment;
            ConfidenceScores = confidenceScores;
            Offset = offset;
            Length = length;
            Targets = new ChangeTrackingList<SentenceTarget>();
            Assessments = new ChangeTrackingList<SentenceAssessment>();
        }

        /// <summary> Initializes a new instance of SentenceSentiment. </summary>
        /// <param name="text"> The sentence text. </param>
        /// <param name="sentiment"> The predicted Sentiment for the sentence. </param>
        /// <param name="confidenceScores"> The sentiment confidence score between 0 and 1 for the sentence for all classes. </param>
        /// <param name="offset"> The sentence offset from the start of the document. </param>
        /// <param name="length"> The length of the sentence. </param>
        /// <param name="targets"> The array of sentence targets for the sentence. </param>
        /// <param name="assessments"> The array of assessments for the sentence. </param>
        internal SentenceSentiment(string text, SentenceSentimentValue sentiment, SentimentConfidenceScorePerLabel confidenceScores, int offset, int length, IReadOnlyList<SentenceTarget> targets, IReadOnlyList<SentenceAssessment> assessments)
        {
            Text = text;
            Sentiment = sentiment;
            ConfidenceScores = confidenceScores;
            Offset = offset;
            Length = length;
            Targets = targets;
            Assessments = assessments;
        }

        /// <summary> The sentence text. </summary>
        public string Text { get; }
        /// <summary> The predicted Sentiment for the sentence. </summary>
        public SentenceSentimentValue Sentiment { get; }
        /// <summary> The sentiment confidence score between 0 and 1 for the sentence for all classes. </summary>
        public SentimentConfidenceScorePerLabel ConfidenceScores { get; }
        /// <summary> The sentence offset from the start of the document. </summary>
        public int Offset { get; }
        /// <summary> The length of the sentence. </summary>
        public int Length { get; }
        /// <summary> The array of sentence targets for the sentence. </summary>
        public IReadOnlyList<SentenceTarget> Targets { get; }
        /// <summary> The array of assessments for the sentence. </summary>
        public IReadOnlyList<SentenceAssessment> Assessments { get; }
    }
}
