using System.Net;
using System.Text.Json;
using FluentValidation;
using MWS.Application.Shared.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Net.Http;

namespace MWS.Application.Shared.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ocorreu um erro inesperado.");

                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var statusCode = HttpStatusCode.InternalServerError;
            object response;

            switch (exception)
            {
                case ValidationExceptionCustom validationException:
                    statusCode = HttpStatusCode.BadRequest;
                    response = new
                    {
                        Message = "Erro de validação",
                        Errors = validationException.Errors
                    };
                    break;

                case ValidationException fluentValidationException:
                    statusCode = HttpStatusCode.BadRequest;
                    response = new
                    {
                        Message = "Erro de validação",
                        Errors = fluentValidationException.Errors.Select(e => new { e.PropertyName, e.ErrorMessage })
                    };
                    break;

                default:
                    response = new { Message = "Ocorreu um erro interno no servidor." };
                    break;
            }

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)statusCode;

            return context.Response.WriteAsync(JsonSerializer.Serialize(response));
        }
    }
}
