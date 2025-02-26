﻿using CqrsMediatrExample.Data_Store;
using MediatR;
using static CqrsMediatrExample.Notifications.Notification;

namespace CqrsMediatrExample.Handlers
{

    public class EmailHandler : INotificationHandler<ProductAddedNotification>
    {
        private readonly FakeDataStore _fakeDataStore;
        public EmailHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;
        public async Task Handle(ProductAddedNotification notification, CancellationToken cancellationToken)
        {
            await _fakeDataStore.EventOccured(notification.Product, "Email sent");
            await Task.CompletedTask;
        }
    }
}
