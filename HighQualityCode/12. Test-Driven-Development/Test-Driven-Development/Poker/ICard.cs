//-----------------------------------------------------------------------
// <copyright file="ICard.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>
// <author>For academic reasons - crypted info</author>
//---------------------------------------------------------------------
namespace Poker
{
    using System;

    /// <summary>
    /// Defines properties and methods that a Card class implements to represent a poker card.
    /// </summary>
    public interface ICard : IComparable<ICard>, IEquatable<ICard>
    {
        /// <summary>
        /// Gets the face (rank) of the card.
        /// </summary>
        CardFace Face { get; }

        /// <summary>
        /// Gets the suit of the card.
        /// </summary>
        CardSuit Suit { get; }

        /// <summary>
        /// String representation of the card.
        /// </summary>
        /// <returns>The string representation of the <see cref="ICard"/> object.</returns>
        string ToString();
    }
}