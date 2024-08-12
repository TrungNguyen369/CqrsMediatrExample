using CqrsMediatrExample.Models;
using MediatR;

namespace CqrsMediatrExample.Notifications
{
    public class Notification
    {
        public record ProductAddedNotification(Product Product) : INotification;
    }
}
