using System.Net;

namespace PicPaySimplificado.Exceptions.ExceptionsBase
{
    public abstract class PicPaySimplificadoException : SystemException
    {
        public PicPaySimplificadoException(string message) : base(message) { }

        public abstract IList<string> GetErrorMessages();
        public abstract HttpStatusCode GetStatusCode();
    }
}
