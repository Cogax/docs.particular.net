﻿namespace Snippets4.Transports.RabbitMQ
{
    using NServiceBus;

    public class Usage
    {
        void Basic()
        {
            #region rabbitmq-config-basic 1

            Configure.With()
                .UseTransport<RabbitMQ>();

            #endregion

        }

        void CustomConnectionString()
        {


            #region rabbitmq-config-connectionstring-in-code 1

            Configure.With()
                .UseTransport<RabbitMQ>(() => "My custom connection string");
            #endregion

        }

        void CustomConnectionStringName()
        {
            #region rabbitmq-config-connectionstringname 1

            Configure.With()
                .UseTransport<RabbitMQ>("MyConnectionStringName");

            #endregion

        }

    }
}