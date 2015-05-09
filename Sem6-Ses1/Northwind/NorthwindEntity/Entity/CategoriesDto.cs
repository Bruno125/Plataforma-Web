using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEntity.Entity
{
    public class CategoriesDto
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public List<ProductsDto> Products { get; set; }
        public CategoriesDto()
        {
        }

        public CategoriesDto(int CategoriID)
        {
            this.CategoryID = CategoryID;
        }
    }
}
