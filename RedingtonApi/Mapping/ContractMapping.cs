﻿using FluentValidation.Results;
using RedingtonApi.Responses;
using RedingtonApi.Validators;


namespace RedingtonApi.Mapping
{
    public static class ContractMapping
    {
        public static ValidationFailureResponse MapToResponse(this IEnumerable<ValidationFailure> validationFailures)
        {
            return new ValidationFailureResponse
            {
                Errors = validationFailures.Select(x => new ValidationResponse
                {
                    PropertyName = x.PropertyName,
                    Message = x.ErrorMessage
                })
            };
        }

        public static ValidationFailureResponse MapToResponse(this ValidationFailed failed)
        {
            return new ValidationFailureResponse
            {
                Errors = failed.Errors.Select(x => new ValidationResponse
                {
                    PropertyName = x.PropertyName,
                    Message = x.ErrorMessage
                })
            };
        }
    }
}
