﻿namespace Snippets4.UnitTesting.ServiceLayer
{
    using NServiceBus;

    public class RequestMessage : IMessage
    {
        public string String { get; set; }
    }
}