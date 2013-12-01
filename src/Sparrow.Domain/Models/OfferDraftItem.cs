﻿using System;

namespace Sparrow.Domain.Models
{
    public class OfferDraftItem : EntityBase
    {
        private Product _product;
        private int _quantity;
        private double _discount;

        /// <summary>
        /// Gets the product on offer.
        /// </summary>
        public virtual Product Product
        {
            get { return _product; }
        }

        /// <summary>
        /// Gets or sets the quantity of products on offer.
        /// </summary>
        public virtual int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("value");
                _quantity = value;
            }
        }

        /// <summary>
        /// Gets or sets a discount for the current product.
        /// </summary>
        public virtual double Discount
        {
            get { return _discount; }
            set
            {
                if ((value < 0) || (value > 100))
                    throw new ArgumentOutOfRangeException("value");
                _discount = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OfferDraftItem"/> class.
        /// </summary>
        protected OfferDraftItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OfferDraftItem"/> class.
        /// </summary>
        /// <param name="product"><see cref="Product"/> on offer.</param>
        /// <param name="quantity">Quantity of products on offer.</param>
        public OfferDraftItem(Product product, int quantity)
        {
            if (product == null)
                throw new ArgumentNullException("product");
            if (quantity < 1)
                throw new ArgumentOutOfRangeException("quantity", quantity, "Quantity should be positive.");

            _product = product;
            _quantity = quantity;
        }
    }
}