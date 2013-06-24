//-----------------------------------------------------------------------
// <copyright file="IHand.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>
// <author>For academic reasons - crypted info</author>
//---------------------------------------------------------------------
namespace Poker
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines properties and methods that a Hand class implements to represent a poker hand.
    /// </summary>
    public interface IHand
    {
        /// <summary>
        /// Gets the cards in the hand.
        /// </summary>
        IList<ICard> Cards { get; }

        /// <summary>
        /// String representations of the cards in the hand, space-separated.
        /// </summary>
        /// <returns>A string containing the string representations of the cards in the hand.</returns>
        string ToString();
    }
}