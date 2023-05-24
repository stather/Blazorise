﻿#region Using directives
#endregion

namespace Blazorise.DataGrid;

/// <summary>
/// Context for the row overlay.
/// </summary>
/// <typeparam name="TItem"></typeparam>
public class RowOverlayContext<TItem>
{
    #region Constructors

    /// <summary>
    /// Constructor for event handler.
    /// </summary>
    /// <param name="item">The model.</param>
    public RowOverlayContext( TItem item )
    {
        Item = item;
    }


    #endregion

    #region Properties



    /// <summary>
    /// Gets the model.
    /// </summary>
    public TItem Item { get; }

    #endregion
}