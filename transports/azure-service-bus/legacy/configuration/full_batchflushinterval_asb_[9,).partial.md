 * `BatchFlushInterval(TimeSpan)`: This setting controls the batching behavior for message senders. They will buffer send operations during this time frame and send all messages at once. Defaults to 20 ms. Specify `TimeSpan.Zero` to turn batching off.