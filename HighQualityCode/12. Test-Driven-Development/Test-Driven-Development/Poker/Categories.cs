//-----------------------------------------------------------------------
// <copyright file="Categories.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>
// <author>For academic reasons - crypted info</author>
//-----------------------------------------------------------------------
namespace Poker
{
    /// <summary>
    /// Specifies constants that define the hand categories value.
    /// </summary>
    public enum Categories
    {
        /// <summary>
        /// Represent hand "High Card"
        /// </summary>
        HighCard = 1,

        /// <summary>
        /// Represent hand "One Pair"
        /// </summary>
        OnePair = 2,

        /// <summary>
        /// Represent hand "Two Pair"
        /// </summary>
        TwoPair = 3,

        /// <summary>
        /// Represent hand "Three Of A Kind"
        /// </summary>
        ThreeOfAKind = 4,

        /// <summary>
        /// Represent hand "Straight"
        /// </summary>
        Straight = 5,

        /// <summary>
        /// Represent hand "Flush"
        /// </summary>
        Flush = 6,

        /// <summary>
        /// Represent hand "Full House"
        /// </summary>
        FullHouse = 7,

        /// <summary>
        /// Represent hand "Four Of A Kind"
        /// </summary>
        FourOfAKind = 8,

        /// <summary>
        /// Represent hand "Straight Flush"
        /// </summary>
        StraightFlush = 9
    }
}