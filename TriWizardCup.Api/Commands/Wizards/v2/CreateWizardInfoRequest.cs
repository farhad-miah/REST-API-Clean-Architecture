﻿using MediatR;
using TriWizardCup.Entities.Dtos.Requests;
using TriWizardCup.Entities.Dtos.Responses;

namespace TriWizardCup.Api.Commands.Wizards.v2
{
    public class CreateWizardInfoRequest : IRequest<GetWizardResponse>
    {
        public CreateWizardRequest WizardRequest { get; }
        public CreateWizardInfoRequest(CreateWizardRequest wizardRequest)
        {
            WizardRequest = wizardRequest;
        }
    }
}
