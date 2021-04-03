﻿using Elevator.Api.Dto;
using Elevator.Api.Models;

namespace Elevator.Api.Extensions.Dto
{
    public static class CreateProjectRequestExtensions
    {
        public static Project ToServiceProject(this CreateProjectRequestDto createProjectRequestDto) => new Project
        {
            Name = createProjectRequestDto.Name,
            GitToken = createProjectRequestDto.GitToken,
            ProjectUri = createProjectRequestDto.ProjectUri
        };
    }
}