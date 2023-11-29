using System;

namespace Libreria2.Exceptions
{
    public class PublisherNameException : Exception
    {
        public string PublisherNamer { get; set; }
        public PublisherNameException()
        {

        }

        public PublisherNameException(string message) : base(message)
        {

        }

        public PublisherNameException(string message, Exception inner) : base(message, inner)
        {

        }

        public PublisherNameException(string message, string publisherName) : this(message)
        {
            PublisherNamer = publisherName;
        }

    }
}