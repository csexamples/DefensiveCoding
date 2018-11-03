using System;
using Common;

namespace BusinessLayer
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }

        public Decimal? CurrentPrice { get; set; }

        public string ProductDescription { get; set; }

        private string _productName { get; set; }

        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public string Log()
        {
            return $"{ProductId}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";
        }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
