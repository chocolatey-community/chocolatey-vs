using Microsoft.VisualStudio.LanguageServer.Client;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace chocolatey_vs
{
    public class NuspecContentDefinition
    {
        [Export]
        [Name("nuspec")]
        [BaseDefinition(CodeRemoteContentDefinition.CodeRemoteContentTypeName)]
        internal static ContentTypeDefinition NuspecContentTypeDefinition;


        [Export]
        [FileExtension(".nuspec")]
        [ContentType("nuspec")]
        internal static FileExtensionToContentTypeDefinition NuspecFileExtensionDefinition;
    }
}
