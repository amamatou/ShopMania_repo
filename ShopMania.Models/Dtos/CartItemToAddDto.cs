using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMania.Models.Dtos
{
    public class CartItemToAddDto
    {
        public CartItemToAddDto(int cartId, int productId, int qty)
        {
            CartId = cartId;
            ProductId = productId;
            Qty = qty;
        }

        public int CartId { get; set; }

        public int ProductId { get; set; }

        public int Qty { get; set; }
    }
}
