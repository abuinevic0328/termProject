using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using Utilities;
using System.Text;
using System.Threading.Tasks;

namespace termProjectLibrary
{
    [Serializable]
    public class cartItem
    {
        private int prodNum;
        private string prodDesc;
        
        private double prodPrice;
        private int prodQuantity;
        private string imgURL;
        private double subTotal;
        //private List<cartItem> c = new List<cartItem>();
        
        public cartItem()
        {
            prodNum = 0;
            prodDesc = "";
            prodPrice = 0.0;
            prodQuantity = 0;
            imgURL = "";
            subTotal = 0.0;
        }
        
        public int ProdNum
        {
            get { return prodNum; }
            set { prodNum = value; }
        }

        public string ProdDesc
        {
            get { return prodDesc; }
            set { prodDesc = value; }
        }
        public double ProdPrice
        {
            get { return prodPrice; }
            set { prodPrice = value; }
        }

        public int ProdQuantity
        {
            get { return prodQuantity; }
            set { prodQuantity = value; }
        }
        public string ImgUrl
        {
            get { return imgURL; }
            set { imgURL = value; }
        }
        public double SubTotal
        {
            get { return subTotal; }
            set { subTotal = value; }
        }

        public cartItem(int productNum, string productDesc, double productPrice, int productQuantity, double productSubtotal, string imgUrl)
        {
            this.prodNum = productNum;
            this.prodDesc = productDesc;
            this.prodPrice = productPrice;
            this.prodQuantity = productQuantity;
            this.subTotal = productSubtotal;
            this.imgURL = imgUrl;
        }

        public void addToCart(cartItem cI, List<object> list)
        {
            list.Add(cI);
        }
        

    }
}
