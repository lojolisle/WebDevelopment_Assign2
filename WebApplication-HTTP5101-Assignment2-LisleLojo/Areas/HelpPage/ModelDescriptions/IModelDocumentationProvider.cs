using System;
using System.Reflection;

namespace WebApplication_HTTP5101_Assignment2_LisleLojo.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}