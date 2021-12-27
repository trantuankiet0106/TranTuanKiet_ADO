using Kiet.DAO;
using Kiet.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiet.BLL
{
    class CustomerBAL
    {
        CustomerDAO dal = new CustomerDAO();
        public List<ProductDTO> ReadCustomer()
        {
            List<ProductDTO> lstCus = dal.ReadCustomer();
            return lstCus;
        }
        public void NewCustomer(ProductDTO cus)
        {
            dal.NewCustomer(cus);
        }
        public void DeleteCustomer(ProductDTO cus)
        {
            dal.DeleteCustomer(cus);
        }
        public void EditCustomer(ProductDTO cus)
        {
            dal.EditCustomer(cus);
        }
    }
}
