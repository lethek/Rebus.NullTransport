﻿using Rebus.Subscriptions;


namespace Rebus.Persistence.Fake;

public class FakeSubscriptionStorage : ISubscriptionStorage
{
    public Task<string[]> GetSubscriberAddresses(string topic)
        => NoSubscriberAddresses;


    public Task RegisterSubscriber(string topic, string subscriberAddress)
        => Task.CompletedTask;


    public Task UnregisterSubscriber(string topic, string subscriberAddress)
        => Task.CompletedTask;


    public bool IsCentralized { get; } = true;


    private static readonly Task<string[]> NoSubscriberAddresses = Task.FromResult(Array.Empty<string>());
}
