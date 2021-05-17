using System;

namespace ProxyPattern
{
    class Proxy
    {
        public void Main()
        {
            Console.WriteLine("GET request without proxy:");
            IRequestMaker request = new RequestMaker();
            request.Get("http://stackoverflow.com/");

            Console.WriteLine("\n");

            Console.WriteLine("GET request WITH proxy:");
            IRequestMaker proxyRequest = new ProxyRequest(new RequestMaker());
            proxyRequest.Get("https://stackoverflow.com/");
        }
    }

    // Subject
    public interface IRequestMaker 
    {
        public void Get(string url);
    }

    // RealSubject
    public class RequestMaker : IRequestMaker
    {
        public void Get(string url)
        {
            Console.WriteLine($"Making a GET request to {url}");
        }
    }

    // Proxy
    public class ProxyRequest : IRequestMaker
    {
        private readonly RequestMaker _requestMaker;

        public ProxyRequest(RequestMaker requestMaker)
        {
            _requestMaker = requestMaker;
        }

        public void Get(string url)
        {
            _requestMaker.Get(url);
            Loger loger = new Loger();
            loger.SaveToFile($"A request was made on {DateTime.Now}.");
        }
    }

    public class Loger
    {
        public void SaveToFile(string data)
        {
            // saving data to log ...
            Console.WriteLine("The request date was saved to the log.");
        }
    }
}
