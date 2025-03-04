// <auto-generated/>
#pragma warning disable
using FluentValidation;
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;
using Wolverine.Http.FluentValidation;

namespace Internal.Generated.WolverineHandlers
{
    // START: POST_validate_user
    public class POST_validate_user : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;
        private readonly FluentValidation.IValidator<WolverineWebApi.Validation.CreateUser> _validator_of_CreateUser_1682536441;
        private readonly FluentValidation.IValidator<WolverineWebApi.Validation.CreateUser> _validator_of_CreateUser898719893;
        private readonly Wolverine.Http.FluentValidation.IProblemDetailSource<WolverineWebApi.Validation.CreateUser> _problemDetailSource;

        public POST_validate_user(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions, [Lamar.Named("passwordValidator")] FluentValidation.IValidator<WolverineWebApi.Validation.CreateUser> validator_of_CreateUser_1682536441, [Lamar.Named("createUserValidator")] FluentValidation.IValidator<WolverineWebApi.Validation.CreateUser> validator_of_CreateUser898719893, Wolverine.Http.FluentValidation.IProblemDetailSource<WolverineWebApi.Validation.CreateUser> problemDetailSource) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
            _validator_of_CreateUser_1682536441 = validator_of_CreateUser_1682536441;
            _validator_of_CreateUser898719893 = validator_of_CreateUser898719893;
            _problemDetailSource = problemDetailSource;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var validatorList = new System.Collections.Generic.List<FluentValidation.IValidator<WolverineWebApi.Validation.CreateUser>>{_validator_of_CreateUser898719893, _validator_of_CreateUser_1682536441};
            // Reading the request body via JSON deserialization
            var (user, jsonContinue) = await ReadJsonAsync<WolverineWebApi.Validation.CreateUser>(httpContext);
            if (jsonContinue == Wolverine.HandlerContinuation.Stop) return;
            var result1 = await Wolverine.Http.FluentValidation.Internals.FluentValidationHttpExecutor.ExecuteMany<WolverineWebApi.Validation.CreateUser>(validatorList, _problemDetailSource, user).ConfigureAwait(false);
            // Evaluate whether or not the execution should be stopped based on the IResult value
            if (!(result1 is Wolverine.Http.WolverineContinue))
            {
                await result1.ExecuteAsync(httpContext).ConfigureAwait(false);
                return;
            }


            
            // The actual HTTP request handler execution
            var result_of_Post = WolverineWebApi.Validation.ValidatedEndpoint.Post(user);

            await WriteString(httpContext, result_of_Post);
        }

    }

    // END: POST_validate_user
    
    
}

