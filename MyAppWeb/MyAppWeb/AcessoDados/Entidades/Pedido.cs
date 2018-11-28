using System;
using System.Collections.Generic;

namespace MyAppWeb.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public  DateTime DataPedido { get; set; }
        public ICollection<ItemPedido> ItensPedidos{ get; set; }
    }
}