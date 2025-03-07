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

#if !MIGRATION
using Windows.Foundation;
#endif

#if MIGRATION
namespace System.Windows.Controls.Primitives
#else
namespace Windows.UI.Xaml.Controls.Primitives
#endif
{
    /// <summary>
    /// Used within the template of a <see cref="DataGrid" /> to specify the 
    /// location in the control's visual tree where the column headers are to be added.
    /// </summary>
    [OpenSilver.NotImplemented]
    public sealed class DataGridColumnHeadersPresenter : Panel
    {
        protected override Size MeasureOverride(Size availableSize)
        {
            throw new NotImplementedException("The method or operation is not implemented.");
        }
        protected override Size ArrangeOverride(Size finalSize)
        {
            throw new NotImplementedException("The method or operation is not implemented.");
        }
    }
}
