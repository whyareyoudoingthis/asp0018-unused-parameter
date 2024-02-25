using Microsoft.AspNetCore.Mvc;

namespace AnalyzerUnusedParameter;

public class RequestModel
{
	/// <summary>
	/// Test route parameter
	/// </summary>
	[FromRoute(Name = "filter")]
	public string? Filter { get; set; }
}