﻿namespace GSoft.Dynamite.DI.Unity
{
    using Microsoft.Practices.Unity;

    /// <summary>
    /// Interface for type binding modules
    /// </summary>
    public interface IUnityRegistrationModule
    {
        /// <summary>
        /// Registers the module's type bindings on the container
        /// </summary>
        /// <param name="container">The Unity dependency injection container</param>
        void Register(IUnityContainer container);
    }
}
