﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamanerECommerce.Application.Features.Mediator.Commands.FooterAddressCommands;
using YamanerECommerce.Application.Interfaces;
using YamanerECommerce.Domain.Entities;

namespace YamanerECommerce.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class UpdateFooterAddressCommandHandler : IRequestHandler<UpdateFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;

        public UpdateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            var values =await _repository.GetByIdAsync(request.FooterAddressID);
            values.Phone = request.Phone;
            values.Address = request.Address;
            values.Email = request.Email;
            values.Description = request.Description;
            await _repository.UpdateAsync(values);
        }

    }
}
