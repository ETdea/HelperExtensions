namespace System.Web.Mvc.Html
{
    public class MvcLink : IDisposable
    {
        private readonly ViewContext _viewContext;
        private bool _disposed;

        public MvcLink(ViewContext viewContext)
        {
            if (viewContext == null)
            {
                throw new ArgumentNullException("viewContext");
            }

            _viewContext = viewContext;
        }

        public void Dispose()
        {
            Dispose(true /* disposing */);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                _disposed = true;
                HtmlHelperExtensions.EndLink(_viewContext);
            }
        }

        public void EndTag()
        {
            Dispose(true);
        }
    }
}