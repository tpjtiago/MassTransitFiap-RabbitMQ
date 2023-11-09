﻿using Core;
using MassTransit;

namespace Consumidor.Eventos
{
    public class PedidoCriadoConsumidor : IConsumer<Pedido>
    {
        public Task Consume(ConsumeContext<Pedido> context)
        {
            Console.WriteLine(context.Message);

            return Task.CompletedTask;
        }
    }
}
