﻿using AutoMapper;
using MediatR;
using TriWizardCup.Api.Queries.Wizards.v1;
using TriWizardCup.DataService.Repositories.Interfaces;
using TriWizardCup.Entities.Dtos.Responses;

namespace TriWizardCup.Api.Handlers.Wizards.v1
{
    public class GetAllWizardsHandler : BaseHandler, IRequestHandler<GetAllWizardsQuery, IEnumerable<GetWizardResponse>>
    {
        public GetAllWizardsHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IEnumerable<GetWizardResponse>> Handle(GetAllWizardsQuery request, CancellationToken cancellationToken)
        {
            var wizards = await _unitOfWork.Wizards.All();

            return _mapper.Map<IEnumerable<GetWizardResponse>>(wizards);
        }
    }
}
