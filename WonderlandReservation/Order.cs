using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WonderlandReservation
{
    class Order
    {
        public string oneDayTicket, twoDayTicket, friendTicket, seasonPass, goldPass, platinumPass;

        public Order(string _oneDayTicket, string _twoDayTicket, string _friendTicket, string _seasonPass, string _goldPass, string _platinumPass)
        {
            oneDayTicket = _oneDayTicket;
            twoDayTicket = _twoDayTicket;
            friendTicket = _friendTicket;
            seasonPass = _seasonPass;
            goldPass = _goldPass;
            platinumPass = _platinumPass;
        }
    }
}
