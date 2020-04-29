﻿

/*===================================================================================
* 
*   Copyright (c) Userware/OpenSilver.net
*      
*   This file is part of the OpenSilver Runtime (https://opensilver.net), which is
*   licensed under the MIT license: https://opensource.org/licenses/MIT
*   
*   As stated in the MIT license, "the above copyright notice and this permission
*   notice shall be included in all copies or substantial portions of the Software."
*  
\*====================================================================================*/


using System;

#if MIGRATION
namespace System.Windows
#else
namespace Windows.UI.Xaml
#endif
{
#if WORKINPROGRESS
    public sealed partial class TriggerCollection : PresentationFrameworkCollection<TriggerBase>
    {
        internal override void AddOverride(TriggerBase value)
        {
            this.AddDependencyObjectInternal(value);
        }

        internal override void ClearOverride()
        {
            this.ClearDependencyObjectInternal();
        }

        internal override void InsertOverride(int index, TriggerBase value)
        {
            this.InsertDependencyObjectInternal(index, value);
        }

        internal override void RemoveAtOverride(int index)
        {
            this.RemoveAtDependencyObjectInternal(index);
        }

        internal override bool RemoveOverride(TriggerBase value)
        {
            return this.RemoveDependencyObjectInternal(value);
        }

        internal override void SetItemOverride(int index, TriggerBase value)
        {
            this.SetItemDependencyObjectInternal(index, value);
        }
    }
#endif
}
