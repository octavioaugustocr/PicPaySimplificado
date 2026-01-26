using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PicPaySimplificado.Communication.Responses.Error;
using PicPaySimplificado.Exceptions;
using PicPaySimplificado.Exceptions.ExceptionsBase;
using System.Net;

namespace PicPaySimplificado.API.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is PicPaySimplificadoException picPaySimplificadoException)
                HandleProjectException(picPaySimplificadoException, context);
            else
                ThrowUnknowException(context);
        }

        private static void HandleProjectException(PicPaySimplificadoException picPaySimplificadoException, ExceptionContext context)
        {
            context.HttpContext.Response.StatusCode = (int)picPaySimplificadoException.GetStatusCode();
            context.Result = new ObjectResult(new ResponseErrorJson(picPaySimplificadoException.GetErrorMessages()));
        }

        private static void ThrowUnknowException(ExceptionContext context)
        {
            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Result = new ObjectResult(new ResponseErrorJson(ResourceMessagesException.UNKNOW_ERROR));
        }
    }
}
