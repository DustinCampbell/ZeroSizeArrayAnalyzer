using System.Collections.Immutable;
using System.Composition;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;

namespace ZeroSizeArrayAnalyzer
{
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(ZeroSizeArrayAnalyzerCodeFixProvider)), Shared]
    public class ZeroSizeArrayAnalyzerCodeFixProvider : CodeFixProvider
    {
        private const string title = "Make uppercase";

        public sealed override ImmutableArray<string> FixableDiagnosticIds => ImmutableArray.Create(ZeroSizeArrayDiagnosticAnalyzer.DiagnosticId);

        // See https://github.com/dotnet/roslyn/blob/master/docs/analyzers/FixAllProvider.md for more information on Fix All Providers
        public sealed override FixAllProvider GetFixAllProvider() => WellKnownFixAllProviders.BatchFixer;

        public sealed override async Task RegisterCodeFixesAsync(CodeFixContext context)
        {
            return null;
        }
    }
}