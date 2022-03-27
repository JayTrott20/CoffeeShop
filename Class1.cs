using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CoffeeShop2
{
    enum CoffeeStatus
    {
        NotStarted,
        InProgress,
        OnHold,
        Completed,
        Deleted

    }

    enum SizeCoff
    {
        Small,
        Medium,
        Large,
        Kids,
        NA
    }

    abstract class Beverage
    {
        public int OrdId { get; set; }
        public OrderType orderType { get; set; }
        public string CustName { get; set; }

    }
    class Coffee : Beverage
    {
        public SizeCoff CoffSize { get; set; }
        public CoffeeStatus Status { get; set; }
    }
    enum OrderType
    {   
        The_Tribal_Chief,
        The_Tribal_Chief_Iced,
        The_Wise_Man_Machiatto_Hot,
        The_Wise_Man_Machiatto_Iced,
        Superman_Punch,
        Penetentiary_Water,
        Day_1_ish_Hot,
        Day_1_ish_Iced,
        The_Bloodline_Latte_Hot,
        The_Bloodline_Latte_Iced   
    }
    //public struct _OrderType
    //    {
    //        public string menus;
    
    //    }
}
