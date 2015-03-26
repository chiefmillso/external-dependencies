using System;

namespace Rebus.AzureServiceBus
{
    public interface IAsbOptions
    {
        IAsbOptions AutomaticallyRenewPeekLockEvery(TimeSpan customTimeSpan);
        IAsbOptions DoNotAutomaticallyRenewPeekLock();
    }
}