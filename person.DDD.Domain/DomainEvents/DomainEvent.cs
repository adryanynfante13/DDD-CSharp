using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace person.DDD.Domain.DomainEvents
{
    public class DomainEvent<T>
    {
        private List<Action<T>> Actions {  get; } = new List<Action<T>>();
        public void Register(Action<T> callback)
        {
            if (Actions.Exists(o=>o.Method== callback.Method))
            {
                return;
            }
            Actions.Add(callback);
        }
        public void Publish(T args)
        {
            foreach(Action<T> action in Actions) 
            { 
                action.Invoke(args);             
            }
        }
    }
}
