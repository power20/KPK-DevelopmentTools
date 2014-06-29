// <copyright file="LogDemo.cs" company="Telerik Academy">
// Copyright (c) 2014 Telerik Academy. All rights reserved.
// </copyright>
namespace LogDemo
{
    using log4net;
    using log4net.Config;
    using System;

    /// <summary>
    /// Represents a demo of LogManager
    /// </summary>
    public class LogDemo
    {
        /// <summary>
        /// Stores a constant of ILog
        /// </summary>
        private static readonly ILog LOG = LogManager.GetLogger("Logger");

        /// <summary>
        /// The entry point of the program.
        /// </summary>
        private static void Main()
        {
            BasicConfigurator.Configure();
            try
            {
                LOG.Debug("An Error occurred!");
                int.Parse("Test");
            }
            catch (Exception ex)
            {
                LOG.Error(ex.Message);
            }
            
        }
    }
}
