using System;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace TaskService.DTO;
public record CreateTask
(
    string Title, string Description
);
