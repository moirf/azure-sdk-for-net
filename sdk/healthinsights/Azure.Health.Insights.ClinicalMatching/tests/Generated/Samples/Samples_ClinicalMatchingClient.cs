// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Health.Insights.ClinicalMatching.Samples
{
    public class Samples_ClinicalMatchingClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_MatchTrials()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ClinicalMatchingClient(endpoint, credential);

            var data = new
            {
                patients = new[] {
        new {
            id = "<id>",
        }
    },
            };

            var operation = client.MatchTrials(WaitUntil.Completed, RequestContent.Create(data));

            BinaryData responseData = operation.Value;
            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("expirationDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdateDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_MatchTrials_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ClinicalMatchingClient(endpoint, credential);

            var data = new
            {
                patients = new[] {
        new {
            id = "<id>",
            info = new {
                sex = "female",
                birthDate = "2022-05-10",
                clinicalInfo = new[] {
                    new {
                        system = "<system>",
                        code = "<code>",
                        name = "<name>",
                        value = "<value>",
                    }
                },
            },
            data = new[] {
                new {
                    type = "note",
                    clinicalType = "consultation",
                    id = "<id>",
                    language = "<language>",
                    createdDateTime = "2022-05-10T14:57:31.2311892-04:00",
                    content = new {
                        sourceType = "inline",
                        value = "<value>",
                    },
                }
            },
        }
    },
                configuration = new
                {
                    verbose = true,
                    includeEvidence = true,
                    clinicalTrials = new
                    {
                        customTrials = new[] {
                new {
                    id = "<id>",
                    eligibilityCriteriaText = "<eligibilityCriteriaText>",
                    demographics = new {
                        acceptedSex = "all",
                        acceptedAgeRange = new {
                            minimumAge = new {
                                unit = "years",
                                value = 123.45f,
                            },
                            maximumAge = new {
                                unit = "years",
                                value = 123.45f,
                            },
                        },
                    },
                    metadata = new {
                        phases = new[] {
                            "notApplicable"
                        },
                        studyType = "interventional",
                        recruitmentStatus = "unknownStatus",
                        conditions = new[] {
                            "<String>"
                        },
                        sponsors = new[] {
                            "<String>"
                        },
                        contacts = new[] {
                            new {
                                name = "<name>",
                                email = "<email>",
                                phone = "<phone>",
                            }
                        },
                        facilities = new[] {
                            new {
                                name = "<name>",
                                city = "<city>",
                                state = "<state>",
                                countryOrRegion = "<countryOrRegion>",
                            }
                        },
                    },
                }
            },
                        registryFilters = new[] {
                new {
                    conditions = new[] {
                        "<String>"
                    },
                    studyTypes = new[] {
                        "interventional"
                    },
                    recruitmentStatuses = new[] {
                        "unknownStatus"
                    },
                    sponsors = new[] {
                        "<String>"
                    },
                    phases = new[] {
                        "notApplicable"
                    },
                    purposes = new[] {
                        "notApplicable"
                    },
                    ids = new[] {
                        "<String>"
                    },
                    sources = new[] {
                        "custom"
                    },
                    facilityNames = new[] {
                        "<String>"
                    },
                    facilityLocations = new[] {
                        new {
                            city = "<city>",
                            state = "<state>",
                            countryOrRegion = "<countryOrRegion>",
                        }
                    },
                    facilityAreas = new[] {
                        new {
                            type = "Feature",
                            geometry = new {
                                type = "Point",
                                coordinates = new[] {
                                    123.45f
                                },
                            },
                            properties = new {
                                subType = "Circle",
                                radius = 123.45d,
                            },
                        }
                    },
                }
            },
                    },
                },
            };

            var operation = client.MatchTrials(WaitUntil.Completed, RequestContent.Create(data), "<repeatabilityRequestId>", DateTimeOffset.UtcNow, new RequestContext());

            BinaryData responseData = operation.Value;
            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("expirationDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdateDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("innererror").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("confidenceScore").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("eligibilityCriteriaEvidence").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientDataEvidence").GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientDataEvidence").GetProperty("text").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientDataEvidence").GetProperty("offset").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientDataEvidence").GetProperty("length").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientInfoEvidence").GetProperty("system").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientInfoEvidence").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientInfoEvidence").GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientInfoEvidence").GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("importance").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("phases")[0].ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("studyType").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("recruitmentStatus").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("conditions")[0].ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("sponsors")[0].ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("contacts")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("contacts")[0].GetProperty("email").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("contacts")[0].GetProperty("phone").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("facilities")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("facilities")[0].GetProperty("city").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("facilities")[0].GetProperty("state").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("facilities")[0].GetProperty("countryOrRegion").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("neededClinicalInfo")[0].GetProperty("system").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("neededClinicalInfo")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("neededClinicalInfo")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("neededClinicalInfo")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("neededClinicalInfo")[0].GetProperty("semanticType").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("neededClinicalInfo")[0].GetProperty("category").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("modelVersion").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("knowledgeGraphLastUpdateDate").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_MatchTrials_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ClinicalMatchingClient(endpoint, credential);

            var data = new
            {
                patients = new[] {
        new {
            id = "<id>",
        }
    },
            };

            var operation = await client.MatchTrialsAsync(WaitUntil.Completed, RequestContent.Create(data));

            BinaryData responseData = operation.Value;
            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("expirationDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdateDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_MatchTrials_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ClinicalMatchingClient(endpoint, credential);

            var data = new
            {
                patients = new[] {
        new {
            id = "<id>",
            info = new {
                sex = "female",
                birthDate = "2022-05-10",
                clinicalInfo = new[] {
                    new {
                        system = "<system>",
                        code = "<code>",
                        name = "<name>",
                        value = "<value>",
                    }
                },
            },
            data = new[] {
                new {
                    type = "note",
                    clinicalType = "consultation",
                    id = "<id>",
                    language = "<language>",
                    createdDateTime = "2022-05-10T14:57:31.2311892-04:00",
                    content = new {
                        sourceType = "inline",
                        value = "<value>",
                    },
                }
            },
        }
    },
                configuration = new
                {
                    verbose = true,
                    includeEvidence = true,
                    clinicalTrials = new
                    {
                        customTrials = new[] {
                new {
                    id = "<id>",
                    eligibilityCriteriaText = "<eligibilityCriteriaText>",
                    demographics = new {
                        acceptedSex = "all",
                        acceptedAgeRange = new {
                            minimumAge = new {
                                unit = "years",
                                value = 123.45f,
                            },
                            maximumAge = new {
                                unit = "years",
                                value = 123.45f,
                            },
                        },
                    },
                    metadata = new {
                        phases = new[] {
                            "notApplicable"
                        },
                        studyType = "interventional",
                        recruitmentStatus = "unknownStatus",
                        conditions = new[] {
                            "<String>"
                        },
                        sponsors = new[] {
                            "<String>"
                        },
                        contacts = new[] {
                            new {
                                name = "<name>",
                                email = "<email>",
                                phone = "<phone>",
                            }
                        },
                        facilities = new[] {
                            new {
                                name = "<name>",
                                city = "<city>",
                                state = "<state>",
                                countryOrRegion = "<countryOrRegion>",
                            }
                        },
                    },
                }
            },
                        registryFilters = new[] {
                new {
                    conditions = new[] {
                        "<String>"
                    },
                    studyTypes = new[] {
                        "interventional"
                    },
                    recruitmentStatuses = new[] {
                        "unknownStatus"
                    },
                    sponsors = new[] {
                        "<String>"
                    },
                    phases = new[] {
                        "notApplicable"
                    },
                    purposes = new[] {
                        "notApplicable"
                    },
                    ids = new[] {
                        "<String>"
                    },
                    sources = new[] {
                        "custom"
                    },
                    facilityNames = new[] {
                        "<String>"
                    },
                    facilityLocations = new[] {
                        new {
                            city = "<city>",
                            state = "<state>",
                            countryOrRegion = "<countryOrRegion>",
                        }
                    },
                    facilityAreas = new[] {
                        new {
                            type = "Feature",
                            geometry = new {
                                type = "Point",
                                coordinates = new[] {
                                    123.45f
                                },
                            },
                            properties = new {
                                subType = "Circle",
                                radius = 123.45d,
                            },
                        }
                    },
                }
            },
                    },
                },
            };

            var operation = await client.MatchTrialsAsync(WaitUntil.Completed, RequestContent.Create(data), "<repeatabilityRequestId>", DateTimeOffset.UtcNow, new RequestContext());

            BinaryData responseData = operation.Value;
            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("expirationDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdateDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("innererror").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("confidenceScore").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("eligibilityCriteriaEvidence").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientDataEvidence").GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientDataEvidence").GetProperty("text").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientDataEvidence").GetProperty("offset").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientDataEvidence").GetProperty("length").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientInfoEvidence").GetProperty("system").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientInfoEvidence").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientInfoEvidence").GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientInfoEvidence").GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("importance").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("phases")[0].ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("studyType").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("recruitmentStatus").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("conditions")[0].ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("sponsors")[0].ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("contacts")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("contacts")[0].GetProperty("email").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("contacts")[0].GetProperty("phone").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("facilities")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("facilities")[0].GetProperty("city").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("facilities")[0].GetProperty("state").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("facilities")[0].GetProperty("countryOrRegion").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("neededClinicalInfo")[0].GetProperty("system").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("neededClinicalInfo")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("neededClinicalInfo")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("neededClinicalInfo")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("neededClinicalInfo")[0].GetProperty("semanticType").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("neededClinicalInfo")[0].GetProperty("category").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("modelVersion").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("knowledgeGraphLastUpdateDate").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_MatchTrials_Convenience_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ClinicalMatchingClient(endpoint, credential);

            var trialMatcherData = new TrialMatcherData(new PatientRecord[]
            {
    new PatientRecord("<id>")
{
        Info = new PatientInfo()
{
            Sex = PatientInfoSex.Female,
            BirthDate = DateTimeOffset.UtcNow,
            ClinicalInfo =
{
                new ClinicalCodedElement("<system>", "<code>")
{
                    Name = "<Name>",
                    Value = "<Value>",
                }
            },
        },
        Data =
{
            new PatientDocument(DocumentType.Note, "<id>", new DocumentContent(DocumentContentSourceType.Inline, "<value>"))
{
                ClinicalType = ClinicalDocumentType.Consultation,
                Language = "<Language>",
                CreatedDateTime = DateTimeOffset.UtcNow,
            }
        },
    }
            })
            {
                Configuration = new TrialMatcherModelConfiguration(new ClinicalTrials()
                {
                    CustomTrials =
{
            new ClinicalTrialDetails("<id>", new ClinicalTrialMetadata(new string[]
{
                "<null>"
            })
{
                Phases =
{
                    ClinicalTrialPhase.NotApplicable
                },
                StudyType = ClinicalTrialStudyType.Interventional,
                RecruitmentStatus = ClinicalTrialRecruitmentStatus.UnknownStatus,
                Sponsors =
{
                    "<null>"
                },
                Contacts =
{
                    new ContactDetails()
{
                        Name = "<Name>",
                        Email = "<Email>",
                        Phone = "<Phone>",
                    }
                },
                Facilities =
{
                    new ClinicalTrialResearchFacility("<name>", "<countryOrRegion>")
{
                        City = "<City>",
                        State = "<State>",
                    }
                },
            })
{
                EligibilityCriteriaText = "<EligibilityCriteriaText>",
                Demographics = new ClinicalTrialDemographics()
{
                    AcceptedSex = ClinicalTrialAcceptedSex.All,
                    AcceptedAgeRange = new AcceptedAgeRange()
{
                        MinimumAge = new AcceptedAge(AgeUnit.Years, 3.14f),
                    },
                },
            }
        },
                    RegistryFilters =
{
            new ClinicalTrialRegistryFilter()
{
                Conditions =
{
                    "<null>"
                },
                StudyTypes =
{
                    ClinicalTrialStudyType.Interventional
                },
                RecruitmentStatuses =
{
                    ClinicalTrialRecruitmentStatus.UnknownStatus
                },
                Sponsors =
{
                    "<null>"
                },
                Phases =
{
                    ClinicalTrialPhase.NotApplicable
                },
                Purposes =
{
                    ClinicalTrialPurpose.NotApplicable
                },
                Ids =
{
                    "<null>"
                },
                Sources =
{
                    ClinicalTrialSource.Custom
                },
                FacilityNames =
{
                    "<null>"
                },
                FacilityLocations =
{
                    new GeographicLocation("<countryOrRegion>")
{
                        City = "<City>",
                        State = "<State>",
                    }
                },
                FacilityAreas =
{
                    new GeographicArea(GeoJsonType.Feature, new AreaGeometry(GeoJsonGeometryType.Point, new float[]
{
                        3.14f
                    }), new AreaProperties(GeoJsonPropertiesSubType.Circle, 3.14))
                },
            }
        },
                })
                {
                    Verbose = true,
                    IncludeEvidence = true,
                },
            };
            var operation = await client.MatchTrialsAsync(WaitUntil.Completed, trialMatcherData, "<repeatabilityRequestId>", DateTimeOffset.UtcNow);
        }
    }
}
