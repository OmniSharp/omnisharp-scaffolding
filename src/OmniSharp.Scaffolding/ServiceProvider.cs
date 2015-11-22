using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.CodeGeneration
{
    internal class ServiceProvider : IServiceProvider
    {
        private readonly Dictionary<Type, object> _instances = new Dictionary<Type, object>();
        private readonly IServiceProvider _fallbackServiceProvider;

        public ServiceProvider()
        {
            _instances[typeof(IServiceProvider)] = this;
        }

        public ServiceProvider(IServiceProvider fallbackServiceProvider)
            : this()
        {
            _fallbackServiceProvider = fallbackServiceProvider;
        }

        public void Add(Type type, object instance)
        {
            _instances[type] = instance;
        }

        public object GetService(Type serviceType)
        {
            object instance;
            if (_instances.TryGetValue(serviceType, out instance))
            {
                return instance;
            }

            if (_fallbackServiceProvider != null)
            {
                return _fallbackServiceProvider.GetService(serviceType);
            }

            return null;
        }

        internal void AddServiceWithDependencies<TService, TImplementation>()
        {
            Add(typeof(TService), ActivatorUtilities.CreateInstance<TImplementation>(this));
        }
    }
}
