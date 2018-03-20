﻿namespace InfConstractions.ViewModels
{
    using Catel.Data;
    using Catel.MVVM;
    using System.Threading.Tasks;
    using Catel;
    using Catel.Logging;
    using Catel.Services;
    using Catel.IoC;
    using Catel.ApiCop;
    using Catel.ApiCop.Listeners;
    using System;

    public class ucLoggerViewModel : ViewModelBase
    {
        public ucLoggerViewModel()
        {
            Title = "Журнал";
            Title3 = "3333333333333333333333333333";
            Log = App.Log;
        }


        // TODO: Register models with the vmpropmodel codesnippet
        // TODO: Register view model properties with the vmprop or vmpropviewmodeltomodel codesnippets
        // TODO: Register commands with the vmcommand or vmcommandwithcanexecute codesnippets

        public new string Title
        {
            get { return GetValue<string>(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        /// <summary>
            /// Gets or sets the property value.
            /// </summary>
        public ILog Log
        {
            get { return GetValue<ILog>(LogProperty); }
            set { SetValue(LogProperty, value); }
        }

        /// <summary>
        /// Register the Log property so it is known in the class.
        /// </summary>
        public static readonly PropertyData LogProperty = RegisterProperty("Log", typeof(ILog), null);

        /// <summary>
        /// Register the Title property so it is known in the class.
        /// </summary>
        public static readonly PropertyData TitleProperty = RegisterProperty("Title", typeof(string), null);

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            // TODO: subscribe to events here
        }

        protected override async Task CloseAsync()
        {
            // TODO: unsubscribe from events here

            await base.CloseAsync();
        }

        public string Title3
        {
            get { return GetValue<string>(Title3Property); }
            set { SetValue(Title3Property, value); }
        }

        /// <summary>
        /// Register the Title3 property so it is known in the class.
        /// </summary>
        public static readonly PropertyData Title3Property = RegisterProperty("Title3", typeof(string), null);
    }
}
