﻿using System.Collections.Generic;
using ProEventos.Api.ViewModel;

namespace ProEventos.Api.Utilities
{
    public static class Responses
    {
        public static ResultViewModel ApplicationErrorMessage()
        {
            return new ResultViewModel
            {
                Message = "Ocorreu algum erro interno na aplicação, por favor tente novamente.",
                Success = false,
                Data = null
            };
        }

        public static ResultViewModel DomainErrorMessage(string message)
        {
            return new ResultViewModel
            {
                Message = message,
                Success = false,
                Data = null
            };
        }

        public static ResultViewModel DomainErrorMessage(IReadOnlyCollection<string> errors)
        {
            return new ResultViewModel
            {
                Message = null,
                Success = false,
                Data = errors
            };
        }

        public static ResultViewModel UnauthorizedErrorMessage()
        {
            return new ResultViewModel
            {
                Message = "A combinação de login e senha está incorreta!",
                Success = false,
                Data = null
            };
        }

        public static ResultViewModel InternalServerErrorMessage()
        {
            return new ResultViewModel
            {
                Message = "Ocorreu um erro interno na aplicação, por favor tente novamente.",
                Success = false,
                Data = null
            };
        }

        public static ResultViewModel HttpStatusCodeOK(dynamic obj)
        {
            return new ResultViewModel
            {
                Message = "",
                Success = true,
                Data = obj
            };
        }

        public static ResultViewModel HttpStatusCodeNoContent()
        {
            return new ResultViewModel
            {
                Message = "Não foi encontrado",
                Success = true,
                Data = null
            };
        }

    }
}
