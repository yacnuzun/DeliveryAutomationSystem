﻿using Castle.DynamicProxy;

namespace Core.Utilities.Interceptors
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priorty { get; set; }
        public virtual void Intercept(IInvocation invocation)
        {

        }
    }
}
