// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System.Threading.Tasks;
using Elastic.Elasticsearch.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework.EndpointTests;
using static Tests.Framework.EndpointTests.UrlTester;

namespace Tests.XPack.MachineLearning.CloseJob
{
	public class CloseJobUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls() => await POST("/_ml/anomaly_detectors/job_id/_close")
			.Fluent(c => c.MachineLearning.CloseJob("job_id"))
			.Request(c => c.MachineLearning.CloseJob(new CloseJobRequest("job_id")))
			.FluentAsync(c => c.MachineLearning.CloseJobAsync("job_id"))
			.RequestAsync(c => c.MachineLearning.CloseJobAsync(new CloseJobRequest("job_id")));
	}
}
