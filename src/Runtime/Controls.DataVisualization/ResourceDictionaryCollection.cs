﻿// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.

using System.Collections.ObjectModel;

#if MIGRATION
namespace System.Windows.Controls.DataVisualization
#else
namespace Windows.UI.Xaml.Controls.DataVisualization
#endif
{
    /// <summary>
    /// Represents a collection of ResourceDictionary objects.
    /// </summary>
    /// <QualityBand>Preview</QualityBand>
    public partial class ResourceDictionaryCollection : Collection<ResourceDictionary>
    {
        /// <summary>
        /// Initializes a new instance of the ResourceDictionaryCollection class.
        /// </summary>
        public ResourceDictionaryCollection()
        {
        }
    }
}