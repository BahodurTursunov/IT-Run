// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Minor Code Smell", "S2094:Classes should not be empty", Justification = "<Ожидание>", Scope = "type", Target = "~T:Fabric.Infrastructure.Configurations.TransactionConfiguration")]
[assembly: SuppressMessage("Major Code Smell", "S1118:Utility classes should not have public constructors", Justification = "<Ожидание>", Scope = "type", Target = "~T:Fabric.Auth.AuthOptions")]
[assembly: SuppressMessage("Critical Code Smell", "S4487:Unread \"private\" fields should be removed", Justification = "<Ожидание>", Scope = "member", Target = "~F:Fabric.Controllers.CategoryController._logger")]
[assembly: SuppressMessage("Critical Code Smell", "S4487:Unread \"private\" fields should be removed", Justification = "<Ожидание>", Scope = "member", Target = "~F:Fabric.CQRS.Handlers.DeleteCustomerCommandHandler._mapper")]
[assembly: SuppressMessage("Major Code Smell", "S125:Sections of code should not be commented out", Justification = "<Ожидание>", Scope = "member", Target = "~M:Fabric.Infrastructure.Configurations.CustomerConfiguration.Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder{Fabric.Models.Customer})")]
[assembly: SuppressMessage("Critical Code Smell", "S4487:Unread \"private\" fields should be removed", Justification = "<Ожидание>", Scope = "member", Target = "~F:Fabric.Middlewares.AppicationKeyMiddleware._logger")]
