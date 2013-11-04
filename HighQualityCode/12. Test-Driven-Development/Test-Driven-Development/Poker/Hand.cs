//-----------------------------------------------------------------------
// <copyright file="Hand.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>
// <author>For academic reasons - crypted info</author>
//---------------------------------------------------------------------
namespace Poker
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a poker hand.
    /// </summary>
    public class Hand : IHand
    {
        /// <summary>
        /// Gets the cards in the hand.
        /// </summary>
        public IList<ICard> Cards { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Hand"/> class.
        /// </summary>
        /// <param name="cards">The cards in the hand.</param>
        /// <exception cref="System.ArgumentNullException">Thrown when <paramref name="cards"/> is null.</exception>
        public Hand(IList<ICard> cards)
        {
            if (cards == null)
            {
                throw new ArgumentNullException("cards", "cards cannot be null.");
            }

            this.Cards = cards;
        }

        /// <summary>
        /// Order cards in hand
        /// </summary>
        /// <returns>Ordered hand</returns>
        public ICard[] OrderHand()
        {
            ICard[] array = new ICard[this.Cards.Count];

            for (int count = 0; count < this.Cards.Count; count++)
            {
                array[count] = this.Cards[count];
            }

            Array.Sort(array, delegate(ICard x, ICard y) { return x.Face.CompareTo(y.Face); });
            return array;
        }

        /// <summary>
        /// String representations of the cards in the hand, space-separated.
        /// </summary>
        /// <returns>A string containing the cards in the hand.</returns>
        public override string ToString()
        {
            string handToString = string.Empty;
            for (int count = 0; count < this.Cards.Count; count++)
            {
                ICard current = this.Cards[count];
                handToString += current.ToString();
            }

            return handToString;
        }
    }
}