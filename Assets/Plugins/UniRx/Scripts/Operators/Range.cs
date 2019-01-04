using System;

namespace UniRx.Operators
{
    //internal class RangeObservable : OperatorObservableBase<int>
    public class RangeObservable : OperatorObservableBase<int>
    {
        readonly int start; // 0
        readonly int count; // 1
        readonly IScheduler scheduler; // IterationScheduler

        public RangeObservable(int start, int count, IScheduler scheduler)
            : base(scheduler == Scheduler.CurrentThread)
        {
            if (count < 0) throw new ArgumentOutOfRangeException("count < 0");

            this.start = start;
            this.count = count;
            this.scheduler = scheduler;
        }

        protected override IDisposable SubscribeCore(IObserver<int> subscribedObserver, IDisposable cancel)
        {
            subscribedObserver = new Range(subscribedObserver, cancel);

            if (scheduler == Scheduler.Immediate)
            {
                for (int i = 0; i < count; i++)
                {
                    int v = start + i;
                    subscribedObserver.OnNext(v);
                }
                subscribedObserver.OnCompleted();

                return Disposable.Empty;
            }
            else
            {
                var i = 0;
                return scheduler.Schedule((Action self) =>
                {
                    if (i < count)
                    {
                        int v = start + i;
                        subscribedObserver.OnNext(v);
                        i++;
                        self();
                    }
                    else
                    {
                        subscribedObserver.OnCompleted();
                    }
                });
            }
        }

        class Range : OperatorObserverBase<int, int>
        {
            public Range(IObserver<int> observer, IDisposable cancel)
                : base(observer, cancel)
            {
            }

            public override void OnNext(int value)
            {
                try
                {
                    base.observer.OnNext(value);
                }
                catch
                {
                    Dispose();
                    throw;
                }
            }

            public override void OnError(Exception error)
            {
                try { observer.OnError(error); }
                finally { Dispose(); }
            }

            public override void OnCompleted()
            {
                try { observer.OnCompleted(); }
                finally { Dispose(); }
            }
        }
    }
}