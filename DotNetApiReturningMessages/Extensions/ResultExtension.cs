using LanguageExt.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net;

namespace ReturningMessages.Extensions;

public static class ResultExtension
{
    public static IActionResult ToActionResult<T>(this Result<T> result, Func<T, IActionResult> successFunc)
    {
        return result.Match(successFunc, (Exception e) =>
        {
            var code = e switch
            {
                ArgumentNullException => HttpStatusCode.BadRequest,
                NotfoundException => HttpStatusCode.NotFound,
                _ => HttpStatusCode.InternalServerError,
            };
            return new ObjectResult(new { error = e.Message })
            {
                StatusCode = (int)code,
                ContentTypes = new MediaTypeCollection { "application/json" }
            };
        });
    }
}
