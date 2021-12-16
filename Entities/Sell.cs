using Microsoft.OData.Edm;
using System;

namespace GameProject.Entities
{
    public class Sell
    {
        public int Id { get; set; }
        public Game Game { get; set; }
        public Date TradeDate { get; set; }

    }
}
   