//-----------------------------------------------------------------------
// <copyright file="Card.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>
// <author>For academic reasons - crypted info</author>
//-----------------------------------------------------------------------
namespace Poker
{
    using System;

    /// <summary>
    /// Represents a poker card.
    /// </summary>
    public class Card : ICard
    {
       #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="face">Card face.</param>
        /// <param name="suit">Card suit.</param>
        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the face of the card.
        /// </summary>
        public CardFace Face { get; private set; }

        /// <summary>
        /// Gets the suit of the card.
        /// </summary>
        public CardSuit Suit { get; private set; }

        #endregion

        #region Methods
        /// <summary>
        /// String representation of cards suit
        /// </summary>
        /// <returns>Suit value as string</returns>
        private string SuitToString()
        {
            string suitToString = string.Empty;

            switch (this.Suit)
            {
                case CardSuit.Clubs: { suitToString = "♣"; break; }
                case CardSuit.Diamonds: { suitToString = "♦"; break; }
                case CardSuit.Hearts: { suitToString = "♥"; break; }
                case CardSuit.Spades: { suitToString = "♠"; break; }
                default: { throw new ArgumentException("Not correct card suit"); }
            }

            return suitToString;
        }
        /// <summary>
        /// String representation of a card.
        /// </summary>
        /// <returns>The face and suit of a card represented as a string.</returns>
        public override string ToString()
        {
            string cardToString = string.Empty;
            if ((int)this.Face <= 10)
            {
                cardToString += (int)this.Face;
                cardToString += this.SuitToString();
            }
            else
            {
                cardToString += this.Face.ToString()[0];
                cardToString += this.SuitToString();
            }

            return cardToString;
        }
        //!
        /// <summary>
        /// Compares two <see cref="ICard"/> instances.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>Less than zero if this instance is of lower rank, zero if both cards 
        /// are of the same rank, greater than zero if this instance is of higher rank.</returns>
        public int CompareTo(ICard other)
        {
            int result = this.Face.CompareTo(other.Face);

            return result;
        }

        /// <summary>
        /// Indicates whether the current object is equal to another
        /// <see cref="ICard"/> object.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>True if objects are equal, otherwise - false.</returns>
        public bool Equals(ICard other)
        {
            bool isEqual = this.Face == other.Face && this.Suit == other.Suit;

            return isEqual;
        }

        #endregion
    }
}