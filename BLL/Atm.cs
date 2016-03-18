using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Atm
    {
        public string Add(Model.userInfo u, Model.cardinfo c)
        {
            //增加用户
            BLL.userInfo bllu = new BLL.userInfo();
            int id=  bllu.Add(u);
            //增加账号
            c.customerID = id;
            BLL.cardinfo bllc = new BLL.cardinfo();
            string CardID;
            bllc.Add(c,out CardID);

            return CardID;
        }
    }
}
