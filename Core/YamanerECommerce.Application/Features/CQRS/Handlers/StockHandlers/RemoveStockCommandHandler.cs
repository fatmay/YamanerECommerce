﻿using ECommerceProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamanerECommerce.Application.Features.CQRS.Commands.StockCommands;
using YamanerECommerce.Application.Interfaces;

namespace YamanerECommerce.Application.Features.CQRS.Handlers.StockHandlers
{
    public class RemoveStockCommandHandler
    {
        private readonly IRepository<Stock> _repository;

        public RemoveStockCommandHandler(IRepository<Stock> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveStockCommand command)
        {
            var values =await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(values);
        }

    }
}
