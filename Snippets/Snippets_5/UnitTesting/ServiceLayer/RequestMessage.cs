﻿namespace Snippets5.UnitTesting.ServiceLayer
{
    using NServiceBus;

    public class RequestMessage : IMessage
    {
        public string String { get; set; }
    }
}